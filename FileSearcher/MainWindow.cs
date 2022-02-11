using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
//using System.Data.SQLite;



namespace FileSearcher
{
    public partial class MainWindow : Form
    {
	   // ----- Variables -----

	   private Boolean m_closing = false;


	   // ----- Synchronizing Delegates -----

	   private delegate void FoundInfoSyncHandler(FoundInfoEventArgs e);
	   private FoundInfoSyncHandler FoundInfo;

	   private delegate void ThreadEndedSyncHandler(ThreadEndedEventArgs e);
	   private ThreadEndedSyncHandler ThreadEnded;


	   // ----- Constructor -----

	   public MainWindow()
	   {
		  InitializeComponent();
	   }


	   // ----- Event Handlers -----

	   private void MainWindow_Load(object sender, EventArgs e)
	   {

		  Ch_All_Search_CheckedChanged(null, null);
		  Ch_Sort_CheckedChanged(null, null);


		  // Load config values:
		  UserConfig.Load();

		  //this.Location = new Point(UserConfig.Data.LocationX, UserConfig.Data.LocationY);
		  //this.Size = new Size(UserConfig.Data.Width, UserConfig.Data.Height);
		  //this.WindowState = (FormWindowState)UserConfig.Data.WindowState;

		  searchDirTextBox.Text = UserConfig.Data.SearchDir;
		  includeSubDirsCheckBox.Checked = UserConfig.Data.IncludeSubDirsChecked;
		  //fileNameTextBox.Text = UserConfig.Data.FileName;
		  newerThanCheckBox.Checked = UserConfig.Data.NewerThanChecked;
		  newerThanDateTimePicker.Value = UserConfig.Data.NewerThanDateTime;
		  olderThanCheckBox.Checked = UserConfig.Data.OlderThanChecked;
		  olderThanDateTimePicker.Value = UserConfig.Data.OlderThanDateTime;
		  containingCheckBox.Checked = UserConfig.Data.ContainingChecked;
		  containingTextBox.Text = UserConfig.Data.ContainingText;
		  asciiRadioButton.Checked = UserConfig.Data.AsciiChecked;
		  unicodeRadioButton.Checked = UserConfig.Data.UnicodeChecked;
		  delimeterTextBox.Text = UserConfig.Data.Delimeter;

		  // Subscribe for my own delegates:
		  this.FoundInfo += new FoundInfoSyncHandler(this_FoundInfo);
		  this.ThreadEnded += new ThreadEndedSyncHandler(this_ThreadEnded);

		  // Subscribe for the Searcher's events:
		  Searcher.FoundInfo += new Searcher.FoundInfoEventHandler(Searcher_FoundInfo);
		  Searcher.ThreadEnded += new Searcher.ThreadEndedEventHandler(Searcher_ThreadEnded);
	   }

	   private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
	   {
		  MessageBoxManager.Unregister();
		  MessageBoxManager.Yes = "! بلی";
		  MessageBoxManager.No = "خیر";
		  MessageBoxManager.Register();
		  DialogResult x = MessageBox.Show("آیا از برنامه خارج می شوید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
		  MessageBoxManager.Unregister();
		  if (x == DialogResult.Yes)
		  {
			 // Remember that the window is closing,
			 // so that all events from the Searcher are ignored from now on:
			 m_closing = true;

			 // Stop the search thread if it is running:
			 Searcher.Stop();

			 // Save config values:
			 if (this.WindowState == FormWindowState.Normal)
			 {
				UserConfig.Data.LocationX = this.Location.X;
				UserConfig.Data.LocationY = this.Location.Y;
				UserConfig.Data.Width = this.Size.Width;
				UserConfig.Data.Height = this.Size.Height;
			 }
			 if (this.WindowState != FormWindowState.Minimized)
			 {
				UserConfig.Data.WindowState = (Int32)this.WindowState;
			 }

			 UserConfig.Data.SearchDir = searchDirTextBox.Text;
			 UserConfig.Data.IncludeSubDirsChecked = includeSubDirsCheckBox.Checked;
			 UserConfig.Data.FileName = Txt_Search.Text;
			 UserConfig.Data.NewerThanChecked = newerThanCheckBox.Checked;
			 UserConfig.Data.NewerThanDateTime = newerThanDateTimePicker.Value;
			 UserConfig.Data.OlderThanChecked = olderThanCheckBox.Checked;
			 UserConfig.Data.OlderThanDateTime = olderThanDateTimePicker.Value;
			 UserConfig.Data.ContainingChecked = containingCheckBox.Checked;
			 UserConfig.Data.ContainingText = containingTextBox.Text;
			 UserConfig.Data.AsciiChecked = asciiRadioButton.Checked;
			 UserConfig.Data.UnicodeChecked = unicodeRadioButton.Checked;
			 UserConfig.Data.Delimeter = delimeterTextBox.Text;

			 UserConfig.Save();

			 Environment.Exit(1);
		  }
		  else
		  {
			 e.Cancel = true;
		  }
	   }

	   private void selectSearchDirButton_Click(object sender, EventArgs e)
	   {
		  FolderBrowserDialog dlg = new FolderBrowserDialog();
		  dlg.SelectedPath = searchDirTextBox.Text;
		  if (dlg.ShowDialog(this) == DialogResult.OK)
		  {
			 searchDirTextBox.Text = dlg.SelectedPath;
		  }
	   }

	   private void stopButton_Click(object sender, EventArgs e)
	   {
		  // Stop the search thread if it is running:
		  Searcher.Stop();
	   }

	   private void startButton_Click(object sender, EventArgs e)
	   {
		  {
			 {
				{
				    // Clear the results list:
				    resultsList.Items.Clear();
				    String fileNamesString = null;
				    // Get the parameters for  the search thread:
				    if (Ch_All_Search.Checked == false)
				    {
					   if (Ch_File.Checked)
					   {
						  fileNamesString = Txt_Search.Text;
					   }
					   else if (Ch_F.Checked)
					   {
						  fileNamesString = "*." + Txt_Search.Text;
					   }
				    }
				    else
				    {
					   fileNamesString = "*.*";
				    }
				    String[] fileNames = fileNamesString.Split(new Char[] { '-' });
				    List<String> validFileNames = new List<String>();
				    foreach (String fileName in fileNames)
				    {
					   String trimmedFileName = fileName.Trim();
					   if (trimmedFileName != "")
					   {
						  validFileNames.Add(trimmedFileName);
					   }
				    }

				    Encoding encoding = asciiRadioButton.Checked ? Encoding.ASCII : Encoding.Unicode;

				    SearcherParams pars = new SearcherParams(searchDirTextBox.Text.Trim(),
													   includeSubDirsCheckBox.Checked,
													   validFileNames,
													   newerThanCheckBox.Checked,
													   newerThanDateTimePicker.Value,
													   olderThanCheckBox.Checked,
													   olderThanDateTimePicker.Value,
													   containingCheckBox.Checked,
													   containingTextBox.Text.Trim(),
													   encoding);

				    // Start the search thread if it is not already running:
				    if (Searcher.Start(pars))
				    {
					   // Disable all buttons except stop button:
					   DisableButtons();
				    }
				    else
				    {
					   MessageBoxManager.Unregister();
					   MessageBoxManager.OK = "! باشه";
					   MessageBoxManager.Register();
					   MessageBox.Show("نرم افزار هم اکنون در حال جستجو می باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					   MessageBoxManager.Unregister();
				    }

				}
			 }
		  }
	   }

	   private void writeResultsButton_Click(object sender, EventArgs e)
	   {
		  MessageBoxManager.Unregister();
		  MessageBoxManager.Yes = "ذخیره";
		  MessageBoxManager.OK = "ذخیره";
		  MessageBoxManager.Cancel = "لغو";
		  MessageBoxManager.Register();

		  SaveFileDialog dlg = new SaveFileDialog();
		  dlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
		  dlg.FilterIndex = 1;
		  dlg.Title = "ذخیره فایل";
		  dlg.FileName = UserConfig.Data.ResultsFilePath;
		  if (dlg.ShowDialog(this) == DialogResult.OK)
		  {
			 UserConfig.Data.ResultsFilePath = dlg.FileName;

			 try
			 {
				FileStream fs = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write);
				StreamWriter sw = new StreamWriter(fs);

				String delimeter = delimeterTextBox.Text.Replace("\\r", "\r").Replace("\\n", "\n").Replace("\\t", "\t");

				bool bFirstHdr = true;
				foreach (ColumnHeader hdr in resultsList.Columns)
				{
				    if (bFirstHdr)
				    {
					   bFirstHdr = false;
					   sw.Write(hdr.Text + ":");
				    }
				    else
				    {
					   sw.Write(delimeter + hdr.Text + ":");
				    }
				}
				sw.WriteLine();

				foreach (ListViewItem lvi in resultsList.Items)
				{
				    bool bFirstLvsi = true;
				    foreach (ListViewItem.ListViewSubItem lvsi in lvi.SubItems)
				    {
					   if (bFirstLvsi)
					   {
						  bFirstLvsi = false;
						  sw.Write(lvsi.Text);
					   }
					   else
					   {
						  sw.Write(delimeter + lvsi.Text);
					   }
				    }
				    sw.WriteLine();
				}

				sw.Close();
				fs.Close();
				System.Diagnostics.Process.Start(dlg.FileName);
			 }
			 catch (Exception ex)
			 {
				MessageBoxManager.Unregister();
				MessageBoxManager.OK = "! باشه";
				MessageBoxManager.Register();
				MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBoxManager.Unregister();
			 }
			 MessageBoxManager.Unregister();
		  }
	   }

	   private void newerThanCheckBox_CheckedChanged(object sender, EventArgs e)
	   {
		  if (newerThanCheckBox.Checked)
		  {
			 newerThanDateTimePicker.Enabled = true;
		  }
		  else
		  {
			 newerThanDateTimePicker.Enabled = false;
		  }
	   }

	   private void olderThanCheckBox_CheckedChanged(object sender, EventArgs e)
	   {
		  if (olderThanCheckBox.Checked)
		  {
			 olderThanDateTimePicker.Enabled = true;
		  }
		  else
		  {
			 olderThanDateTimePicker.Enabled = false;
		  }
	   }

	   private void containingCheckBox_CheckedChanged(object sender, EventArgs e)
	   {
		  if (containingCheckBox.Checked)
		  {
			 containingTextBox.Enabled = true;
			 asciiRadioButton.Enabled = true;
			 unicodeRadioButton.Enabled = true;
		  }
		  else
		  {
			 containingTextBox.Enabled = false;
			 asciiRadioButton.Enabled = false;
			 unicodeRadioButton.Enabled = false;
		  }
	   }

	   private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
	   {
		  // Don't open the context menu strip, if there are no items selected:
		  if (resultsList.SelectedItems.Count == 0)
		  {
			 e.Cancel = true;
		  }
	   }

	   private void openContainingFolderContextMenuItem_Click(object sender, EventArgs e)
	   {
		  // Get the path from the selected item:
		  if (resultsList.SelectedItems.Count > 0)
		  {
			 String path = resultsList.SelectedItems[0].Text;

			 // Open its containing folder in Windows Explorer:
			 try
			 {
				ProcessStartInfo startInfo = new ProcessStartInfo();
				startInfo.FileName = "explorer.exe";
				startInfo.Arguments = Path.GetDirectoryName(path);
				Process process = new Process();
				process.StartInfo = startInfo;
				process.Start();
			 }
			 catch (Exception)
			 {
				try
				{
				    System.Diagnostics.Process.Start(path);
				}
				catch (Exception)
				{
				}
			 }
		  }
	   }

	   private void resultsList_DoubleClick(object sender, EventArgs e)
	   {
		  // Get the path from the selected item:
		  if (resultsList.SelectedItems.Count > 0)
		  {
			 String path = resultsList.SelectedItems[0].Text;

			 // Open it, if it's a file:
			 if (File.Exists(path))
			 {
				try
				{
				    ProcessStartInfo startInfo = new ProcessStartInfo();
				    startInfo.FileName = path;
				    startInfo.Arguments = "";
				    Process process = new Process();
				    process.StartInfo = startInfo;
				    process.Start();
				}
				catch (Exception)
				{
				}
			 }
			 else
			 {
				System.Diagnostics.Process.Start(path);
			 }


		  }
	   }

	   private void resultsList_Resize(object sender, EventArgs e)
	   {
		  resultsList.Columns[0].Width = resultsList.Width - 230;
	   }

	   private void Searcher_FoundInfo(FoundInfoEventArgs e)
	   {
		  if (!m_closing)
		  {
			 // Invoke the method "this_FoundInfo" through a delegate,
			 // so it is executed in the same thread as MainWindow:
			 this.Invoke(FoundInfo, new object[] { e });
		  }
	   }

	   private void this_FoundInfo(FoundInfoEventArgs e)
	   {
		  // Create a new item in the results list:
		  CreateResultsListItem(e.Info);
	   }

	   private void Searcher_ThreadEnded(ThreadEndedEventArgs e)
	   {
		  if (!m_closing)
		  {
			 // Invoke the method "this_ThreadEnded" through a delegate,
			 // so it is executed in the same thread as MainWindow:
			 this.Invoke(ThreadEnded, new object[] { e });
		  }
	   }

	   private void this_ThreadEnded(ThreadEndedEventArgs e)
	   {
		  // Enable all buttons except stop button:
		  EnableButtons();

		  // Show an error message if necessary:
		  if (!e.Success)
		  {
			 MessageBoxManager.Unregister();
			 MessageBoxManager.OK = "! باشه";
			 MessageBoxManager.Register();
			 MessageBox.Show(e.ErrorMsg, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			 MessageBoxManager.Unregister();
		  }
	   }


	   // ----- Private Methods -----

	   private void EnableButtons()
	   {
		  searchDirTextBox.Enabled = true;
		  selectSearchDirButton.Enabled = true;
		  includeSubDirsCheckBox.Enabled = true;
		  Txt_Search.Enabled = true;
		  newerThanCheckBox.Enabled = true;
		  if (newerThanCheckBox.Checked)
		  {
			 newerThanDateTimePicker.Enabled = true;
		  }
		  olderThanCheckBox.Enabled = true;
		  if (olderThanCheckBox.Checked)
		  {
			 olderThanDateTimePicker.Enabled = true;
		  }
		  containingCheckBox.Enabled = true;
		  if (containingCheckBox.Checked)
		  {
			 containingTextBox.Enabled = true;
			 asciiRadioButton.Enabled = true;
			 unicodeRadioButton.Enabled = true;
		  }
		  stopButton.Enabled = false;
		  startButton.Enabled = true;
		  delimeterTextBox.Enabled = true;
		  writeResultsButton.Enabled = true;
		  groupBox1.Enabled = true;
		  button1.Enabled = true;
		  button2.Enabled = true;

	   }

	   private void DisableButtons()
	   {
		  button1.Enabled = false;
		  button2.Enabled = false;
		  groupBox1.Enabled = false;
		  searchDirTextBox.Enabled = false;
		  selectSearchDirButton.Enabled = false;
		  includeSubDirsCheckBox.Enabled = false;
		  Txt_Search.Enabled = false;
		  newerThanCheckBox.Enabled = false;
		  newerThanDateTimePicker.Enabled = false;
		  olderThanCheckBox.Enabled = false;
		  olderThanDateTimePicker.Enabled = false;
		  containingCheckBox.Enabled = false;
		  containingTextBox.Enabled = false;
		  asciiRadioButton.Enabled = false;
		  unicodeRadioButton.Enabled = false;
		  stopButton.Enabled = true;
		  startButton.Enabled = false;
		  delimeterTextBox.Enabled = false;
		  writeResultsButton.Enabled = false;

	   }

	   public static String GetBytesStringKB(Int64 bytesCount)
	   {
		  Int64 bytesShow = (bytesCount + 1023) >> 10;
		  String bytesString = GetPointString(bytesShow) + " KB";
		  return bytesString;
	   }

	   public static String GetPointString(Int64 value)
	   {
		  String pointString = value.ToString();

		  Int32 i = 3;
		  while (pointString.Length > i)
		  {
			 pointString = pointString.Substring(0, pointString.Length - i) + "." + pointString.Substring(pointString.Length - i, i);
			 i += 4;
		  }

		  return pointString;
	   }
	   bool x;
	   private void CreateResultsListItem(FileSystemInfo info)
	   {
		  // Create a new item and set its text:
		  ListViewItem lvi = new ListViewItem();
		  lvi.Text = info.FullName;

		  ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
		  if (info is FileInfo)
		  {
			 lvsi.Text = GetBytesStringKB(((FileInfo)info).Length);
			 x = true;
		  }
		  else
		  {
			 lvsi.Text = "";
			 x = false;
		  }
		  lvi.SubItems.Add(lvsi);

		  lvsi = new ListViewItem.ListViewSubItem();
		  lvsi.Text = info.LastWriteTime.ToShortDateString() + " " + info.LastWriteTime.ToShortTimeString();
		  lvi.SubItems.Add(lvsi);

		  // Set the text that is shown when the mouse cursor
		  // rests over the item (The "ShowItemToolTips" property of the ListView
		  // must be true to show the text.):
		  lvi.ToolTipText = info.FullName;

		  // Add the new item to the list:


		  if (x == true)
		  {
			 lvi.SubItems.Add("فایل");
		  }
		  else
		  {
			 lvi.SubItems.Add("پوشه");
		  }
		  



		  resultsList.Items.Add(lvi);
	   }

	   private void Button1_Click(object sender, EventArgs e)
	   {
		  MessageBoxManager.Unregister();
		  MessageBoxManager.OK = "! باشه";
		  MessageBoxManager.Register();
		  MessageBox.Show(resultsList.Columns["Path"].Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
		  MessageBoxManager.Unregister();
	   }

	   private void Ch_All_Search_CheckedChanged(object sender, EventArgs e)
	   {
		  if (Ch_All_Search.Checked == true)
		  {
			 Txt_Search.Enabled = false;
			 Ch_File.Checked = true;
			 Ch_File.Enabled = false;
			 Ch_F.Enabled = false;
		  }
		  else
		  {
			 Txt_Search.Enabled = true;
			 Ch_File.Checked = true;
			 Ch_File.Enabled = true;
			 Ch_F.Enabled = true;
		  }
	   }

	   private void Ch_Sort_CheckedChanged(object sender, EventArgs e)
	   {
		  if (Ch_Sort.Checked == true)
		  {
			 Ch_Sort_As.Enabled = false;
			 Ch_Sort_Des.Enabled = false;
			 Ch_Sort_As.Checked = false;
			 Ch_Sort_Des.Checked = false;
		  }
		  else
		  {
			 Ch_Sort_As.Enabled = true;
			 Ch_Sort_Des.Enabled = true;
			 Ch_Sort_As.Checked = true;
			 Ch_Sort_Des.Checked = false;
		  }
	   }

	   private void Ch_Sort_Des_CheckedChanged(object sender, EventArgs e)
	   {
		  if (Ch_Sort.Checked == false)
		  {
			 if (Ch_Sort_Des.Checked == true)
			 {
				Ch_Sort_As.Checked = false;
				resultsList.Sorting = SortOrder.Descending;
			 }
			 else
			 {
				Ch_Sort_As.Checked = true;
			 }
		  }
		  else
		  {
			 resultsList.Sorting = SortOrder.None;
		  }
	   }

	   private void Ch_Sort_As_CheckedChanged(object sender, EventArgs e)
	   {
		  if (Ch_Sort.Checked == false)
		  {
			 if (Ch_Sort_As.Checked == true)
			 {
				Ch_Sort_Des.Checked = false;
				resultsList.Sorting = SortOrder.Ascending;
			 }
			 else
			 {
				Ch_Sort_Des.Checked = true;
			 }
		  }
		  else
		  {
			 resultsList.Sorting = SortOrder.None;
		  }
	   }

	   private void Ch_F_CheckedChanged(object sender, EventArgs e)
	   {
		  if (Ch_F.Checked == true)
		  {
			 Ch_File.Checked = false;
		  }
		  else
		  {
			 Ch_File.Checked = true;
		  }
	   }

	   private void Ch_File_CheckedChanged(object sender, EventArgs e)
	   {
		  if (Ch_File.Checked == true)
		  {
			 Ch_F.Checked = false;
		  }
		  else
		  {
			 Ch_F.Checked = true;
		  }
	   }

	   private void Button3_Click(object sender, EventArgs e)
	   {
		  Environment.Exit(1);
		  Application.Exit();
	   }

	   private void Button1_Click_1(object sender, EventArgs e)
	   {
		  string Message = @"
              راهنما   
برای جستجو یک مسیر را انتخاب نموده و دکمه شروع جستجو را کلیک کنید
برای توقف جستجو بر روی دکمه توقف کلیک کنید
برای دریافت خروجی بر روی دکمه دریافت خروجی از یافته ها کلیک کنید
شما می توانید کاراکتر میانی ار نوع را خود تایپ کنید
محدودیت ها
مرتب سازی 
مرتب سازی پیشفرض (بر اساس یافته ها به ترتیب) نزولی و صعودی

نوع جستجو
فایل و پوشه نام پوشه و یا فایل را وارد می کنید 
فرمت فرمت فایل را وارد می کنید مانند png و نرم افزار آن را پیدا می کند

جستجو در زیر ساخت
برای اینکه اگر فایلی درون پوشه ای بود پیدا شود

جستجو در همه فایل ها تمامی فایل ها و پوشه های فایل انتخاب شده را پیدا می کند
پرونده جدید تر از بر اساس تاریخ فایل را پیدا می کند
پرونده قدیمی تر از بر اساس تارخ فایل را پیدا می کند
پرونده دارای این متن
یعنی اگر این فایل متنی باشد فایل هایی که دارای این متن می باشند را پیدا می کند
نوع فرمت آن فایل هم می توانید تغیر دهید

نسخه 1.0.1                                                     
";
		  MessageBoxManager.Unregister();
		  MessageBoxManager.Yes = "درباره من";
		  MessageBoxManager.No = "خروج";
		  MessageBoxManager.Register();
		  DialogResult x = MessageBox.Show(Message, "راهنما", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
		  MessageBoxManager.Unregister();
		  if (x == DialogResult.Yes)
		  {
			 Button2_Click(null, null);
		  }

	   }

	   private void Button2_Click(object sender, EventArgs e)
	   {
		  string Message = @"
درباره من
ساخته شده توسط آصف قربانی 
تمامی  حقوق مادی معنوی این نرم اافزار
مربوط به آصف قربانی می باشد
و هرگونه نسخه برداری کپی برداری و فروش غیر قانونی ان 
غیر شرعی بوده و مجاز نمی باشد این نرم افزار کاملا رایکان می باشد 
و هیچ شخصی اجازه فروش این نرم افزار را ندارد

سفارش برنامه نویسی و ویندوز موبایل و طراحی وب سایت
تماس : 1914 - 928 - 0902  --  6626 - 870 - 0911
ثابت : 2823 - 3368 - 011

asefg482@gmail.com  --  asefg69@gmail.com : پست الکترونیکی 
ممنون از حسن انتخاب شما
			    
نسخه 1.0.1                                                      

قوانین کپی رایت و حق نسخه برداری این نرم افزار محفوظ می باشد
This App Copy Right ©	                              
";
		  MessageBoxManager.Unregister();
		  MessageBoxManager.Yes = "راهنما";
		  MessageBoxManager.No = "خروج";
		  MessageBoxManager.Register();
		  DialogResult x = MessageBox.Show(Message, "درباره من", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
		  MessageBoxManager.Unregister();
		  if (x == DialogResult.Yes)
		  {
			 Button1_Click_1(null, null);
		  }

	   }

	   private void SearchDirTextBox_DoubleClick(object sender, EventArgs e)
	   {
		  selectSearchDirButton_Click(null, null);
	   }

	   private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
	   {
		  MainWindow_FormClosing(null,null);
	   }

	   private void راهنماToolStripMenuItem_Click(object sender, EventArgs e)
	   {
		  Button1_Click_1(null,null);
	   }

	   private void دربارهمنToolStripMenuItem_Click(object sender, EventArgs e)
	   {
		  Button2_Click(null,null);
	   }
    }
}
