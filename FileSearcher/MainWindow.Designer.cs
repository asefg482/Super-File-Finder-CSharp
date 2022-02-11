namespace FileSearcher
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
		  this.components = new System.ComponentModel.Container();
		  System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
		  this.label1 = new System.Windows.Forms.Label();
		  this.label2 = new System.Windows.Forms.Label();
		  this.searchDirTextBox = new System.Windows.Forms.TextBox();
		  this.selectSearchDirButton = new System.Windows.Forms.Button();
		  this.includeSubDirsCheckBox = new System.Windows.Forms.CheckBox();
		  this.newerThanCheckBox = new System.Windows.Forms.CheckBox();
		  this.newerThanDateTimePicker = new System.Windows.Forms.DateTimePicker();
		  this.olderThanDateTimePicker = new System.Windows.Forms.DateTimePicker();
		  this.olderThanCheckBox = new System.Windows.Forms.CheckBox();
		  this.groupBox1 = new System.Windows.Forms.GroupBox();
		  this.label4 = new System.Windows.Forms.Label();
		  this.Ch_F = new System.Windows.Forms.CheckBox();
		  this.Ch_File = new System.Windows.Forms.CheckBox();
		  this.Ch_Sort_Des = new System.Windows.Forms.CheckBox();
		  this.Ch_Sort_As = new System.Windows.Forms.CheckBox();
		  this.unicodeRadioButton = new System.Windows.Forms.RadioButton();
		  this.asciiRadioButton = new System.Windows.Forms.RadioButton();
		  this.containingTextBox = new System.Windows.Forms.TextBox();
		  this.containingCheckBox = new System.Windows.Forms.CheckBox();
		  this.Ch_All_Search = new System.Windows.Forms.CheckBox();
		  this.Ch_Sort = new System.Windows.Forms.CheckBox();
		  this.label6 = new System.Windows.Forms.Label();
		  this.label5 = new System.Windows.Forms.Label();
		  this.groupBox2 = new System.Windows.Forms.GroupBox();
		  this.delimeterTextBox = new System.Windows.Forms.TextBox();
		  this.button2 = new System.Windows.Forms.Button();
		  this.label3 = new System.Windows.Forms.Label();
		  this.button1 = new System.Windows.Forms.Button();
		  this.writeResultsButton = new System.Windows.Forms.Button();
		  this.stopButton = new System.Windows.Forms.Button();
		  this.startButton = new System.Windows.Forms.Button();
		  this.resultsList = new System.Windows.Forms.ListView();
		  this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
		  this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
		  this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
		  this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
		  this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
		  this.openContainingFolderContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		  this.Txt_Search = new System.Windows.Forms.TextBox();
		  this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
		  this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
		  this.دربارهمنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		  this.راهنماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		  this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		  this.groupBox1.SuspendLayout();
		  this.groupBox2.SuspendLayout();
		  this.contextMenuStrip.SuspendLayout();
		  this.contextMenuStrip1.SuspendLayout();
		  this.SuspendLayout();
		  // 
		  // label1
		  // 
		  this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
		  this.label1.AutoSize = true;
		  this.label1.Location = new System.Drawing.Point(561, 39);
		  this.label1.Name = "label1";
		  this.label1.Size = new System.Drawing.Size(129, 13);
		  this.label1.TabIndex = 4;
		  this.label1.Text = "نام فایل یا پوشه و یا فرمت";
		  // 
		  // label2
		  // 
		  this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
		  this.label2.AutoSize = true;
		  this.label2.Location = new System.Drawing.Point(561, 9);
		  this.label2.Name = "label2";
		  this.label2.Size = new System.Drawing.Size(61, 13);
		  this.label2.TabIndex = 0;
		  this.label2.Text = ": جستجو در ";
		  // 
		  // searchDirTextBox
		  // 
		  this.searchDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
		  this.searchDirTextBox.Location = new System.Drawing.Point(12, 7);
		  this.searchDirTextBox.Name = "searchDirTextBox";
		  this.searchDirTextBox.Size = new System.Drawing.Size(509, 22);
		  this.searchDirTextBox.TabIndex = 1;
		  this.searchDirTextBox.DoubleClick += new System.EventHandler(this.SearchDirTextBox_DoubleClick);
		  // 
		  // selectSearchDirButton
		  // 
		  this.selectSearchDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
		  this.selectSearchDirButton.Location = new System.Drawing.Point(531, 7);
		  this.selectSearchDirButton.Name = "selectSearchDirButton";
		  this.selectSearchDirButton.Size = new System.Drawing.Size(24, 22);
		  this.selectSearchDirButton.TabIndex = 2;
		  this.selectSearchDirButton.Text = "...";
		  this.selectSearchDirButton.UseVisualStyleBackColor = true;
		  this.selectSearchDirButton.Click += new System.EventHandler(this.selectSearchDirButton_Click);
		  // 
		  // includeSubDirsCheckBox
		  // 
		  this.includeSubDirsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
		  this.includeSubDirsCheckBox.AutoSize = true;
		  this.includeSubDirsCheckBox.Location = new System.Drawing.Point(534, 69);
		  this.includeSubDirsCheckBox.Name = "includeSubDirsCheckBox";
		  this.includeSubDirsCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
		  this.includeSubDirsCheckBox.Size = new System.Drawing.Size(133, 17);
		  this.includeSubDirsCheckBox.TabIndex = 3;
		  this.includeSubDirsCheckBox.Text = "جستجو در زیر ساخت ها";
		  this.includeSubDirsCheckBox.UseVisualStyleBackColor = true;
		  // 
		  // newerThanCheckBox
		  // 
		  this.newerThanCheckBox.AutoSize = true;
		  this.newerThanCheckBox.Location = new System.Drawing.Point(256, 17);
		  this.newerThanCheckBox.Name = "newerThanCheckBox";
		  this.newerThanCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
		  this.newerThanCheckBox.Size = new System.Drawing.Size(104, 17);
		  this.newerThanCheckBox.TabIndex = 0;
		  this.newerThanCheckBox.Text = "پرونده جدید تر از";
		  this.newerThanCheckBox.UseVisualStyleBackColor = true;
		  this.newerThanCheckBox.CheckedChanged += new System.EventHandler(this.newerThanCheckBox_CheckedChanged);
		  // 
		  // newerThanDateTimePicker
		  // 
		  this.newerThanDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
		  this.newerThanDateTimePicker.Enabled = false;
		  this.newerThanDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
		  this.newerThanDateTimePicker.Location = new System.Drawing.Point(6, 17);
		  this.newerThanDateTimePicker.Name = "newerThanDateTimePicker";
		  this.newerThanDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
		  this.newerThanDateTimePicker.Size = new System.Drawing.Size(244, 22);
		  this.newerThanDateTimePicker.TabIndex = 1;
		  // 
		  // olderThanDateTimePicker
		  // 
		  this.olderThanDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
		  this.olderThanDateTimePicker.Enabled = false;
		  this.olderThanDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
		  this.olderThanDateTimePicker.Location = new System.Drawing.Point(6, 44);
		  this.olderThanDateTimePicker.Name = "olderThanDateTimePicker";
		  this.olderThanDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
		  this.olderThanDateTimePicker.Size = new System.Drawing.Size(244, 22);
		  this.olderThanDateTimePicker.TabIndex = 3;
		  // 
		  // olderThanCheckBox
		  // 
		  this.olderThanCheckBox.AutoSize = true;
		  this.olderThanCheckBox.Location = new System.Drawing.Point(256, 44);
		  this.olderThanCheckBox.Name = "olderThanCheckBox";
		  this.olderThanCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
		  this.olderThanCheckBox.Size = new System.Drawing.Size(113, 17);
		  this.olderThanCheckBox.TabIndex = 2;
		  this.olderThanCheckBox.Text = "پرونده قدیمی تر از";
		  this.olderThanCheckBox.UseVisualStyleBackColor = true;
		  this.olderThanCheckBox.CheckedChanged += new System.EventHandler(this.olderThanCheckBox_CheckedChanged);
		  // 
		  // groupBox1
		  // 
		  this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
		  this.groupBox1.Controls.Add(this.label4);
		  this.groupBox1.Controls.Add(this.Ch_F);
		  this.groupBox1.Controls.Add(this.Ch_File);
		  this.groupBox1.Controls.Add(this.Ch_Sort_Des);
		  this.groupBox1.Controls.Add(this.Ch_Sort_As);
		  this.groupBox1.Controls.Add(this.unicodeRadioButton);
		  this.groupBox1.Controls.Add(this.asciiRadioButton);
		  this.groupBox1.Controls.Add(this.containingTextBox);
		  this.groupBox1.Controls.Add(this.includeSubDirsCheckBox);
		  this.groupBox1.Controls.Add(this.containingCheckBox);
		  this.groupBox1.Controls.Add(this.olderThanDateTimePicker);
		  this.groupBox1.Controls.Add(this.newerThanCheckBox);
		  this.groupBox1.Controls.Add(this.Ch_All_Search);
		  this.groupBox1.Controls.Add(this.olderThanCheckBox);
		  this.groupBox1.Controls.Add(this.newerThanDateTimePicker);
		  this.groupBox1.Controls.Add(this.Ch_Sort);
		  this.groupBox1.Controls.Add(this.label6);
		  this.groupBox1.Controls.Add(this.label5);
		  this.groupBox1.Location = new System.Drawing.Point(12, 62);
		  this.groupBox1.Name = "groupBox1";
		  this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		  this.groupBox1.Size = new System.Drawing.Size(680, 138);
		  this.groupBox1.TabIndex = 6;
		  this.groupBox1.TabStop = false;
		  this.groupBox1.Text = "محدودیت ها";
		  // 
		  // label4
		  // 
		  this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
		  this.label4.AutoSize = true;
		  this.label4.Location = new System.Drawing.Point(596, 41);
		  this.label4.Name = "label4";
		  this.label4.Size = new System.Drawing.Size(58, 13);
		  this.label4.TabIndex = 21;
		  this.label4.Text = "نوع جستجو";
		  // 
		  // Ch_F
		  // 
		  this.Ch_F.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
		  this.Ch_F.AutoSize = true;
		  this.Ch_F.Location = new System.Drawing.Point(525, 40);
		  this.Ch_F.Name = "Ch_F";
		  this.Ch_F.RightToLeft = System.Windows.Forms.RightToLeft.No;
		  this.Ch_F.Size = new System.Drawing.Size(65, 17);
		  this.Ch_F.TabIndex = 20;
		  this.Ch_F.Text = "فرمت ها";
		  this.Ch_F.UseVisualStyleBackColor = true;
		  this.Ch_F.CheckedChanged += new System.EventHandler(this.Ch_F_CheckedChanged);
		  // 
		  // Ch_File
		  // 
		  this.Ch_File.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
		  this.Ch_File.AutoSize = true;
		  this.Ch_File.Location = new System.Drawing.Point(436, 40);
		  this.Ch_File.Name = "Ch_File";
		  this.Ch_File.RightToLeft = System.Windows.Forms.RightToLeft.No;
		  this.Ch_File.Size = new System.Drawing.Size(83, 17);
		  this.Ch_File.TabIndex = 19;
		  this.Ch_File.Text = "فایل و پوشه";
		  this.Ch_File.UseVisualStyleBackColor = true;
		  this.Ch_File.CheckedChanged += new System.EventHandler(this.Ch_File_CheckedChanged);
		  // 
		  // Ch_Sort_Des
		  // 
		  this.Ch_Sort_Des.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
		  this.Ch_Sort_Des.AutoSize = true;
		  this.Ch_Sort_Des.Location = new System.Drawing.Point(456, 17);
		  this.Ch_Sort_Des.Name = "Ch_Sort_Des";
		  this.Ch_Sort_Des.RightToLeft = System.Windows.Forms.RightToLeft.No;
		  this.Ch_Sort_Des.Size = new System.Drawing.Size(63, 17);
		  this.Ch_Sort_Des.TabIndex = 18;
		  this.Ch_Sort_Des.Text = "صعودی";
		  this.Ch_Sort_Des.UseVisualStyleBackColor = true;
		  this.Ch_Sort_Des.CheckedChanged += new System.EventHandler(this.Ch_Sort_Des_CheckedChanged);
		  // 
		  // Ch_Sort_As
		  // 
		  this.Ch_Sort_As.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
		  this.Ch_Sort_As.AutoSize = true;
		  this.Ch_Sort_As.Location = new System.Drawing.Point(397, 17);
		  this.Ch_Sort_As.Name = "Ch_Sort_As";
		  this.Ch_Sort_As.RightToLeft = System.Windows.Forms.RightToLeft.No;
		  this.Ch_Sort_As.Size = new System.Drawing.Size(53, 17);
		  this.Ch_Sort_As.TabIndex = 17;
		  this.Ch_Sort_As.Text = "نزولی";
		  this.Ch_Sort_As.UseVisualStyleBackColor = true;
		  this.Ch_Sort_As.CheckedChanged += new System.EventHandler(this.Ch_Sort_As_CheckedChanged);
		  // 
		  // unicodeRadioButton
		  // 
		  this.unicodeRadioButton.AutoSize = true;
		  this.unicodeRadioButton.Enabled = false;
		  this.unicodeRadioButton.Location = new System.Drawing.Point(104, 107);
		  this.unicodeRadioButton.Name = "unicodeRadioButton";
		  this.unicodeRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
		  this.unicodeRadioButton.Size = new System.Drawing.Size(68, 17);
		  this.unicodeRadioButton.TabIndex = 7;
		  this.unicodeRadioButton.TabStop = true;
		  this.unicodeRadioButton.Text = "Unicode";
		  this.unicodeRadioButton.UseVisualStyleBackColor = true;
		  // 
		  // asciiRadioButton
		  // 
		  this.asciiRadioButton.AutoSize = true;
		  this.asciiRadioButton.Enabled = false;
		  this.asciiRadioButton.Location = new System.Drawing.Point(15, 106);
		  this.asciiRadioButton.Name = "asciiRadioButton";
		  this.asciiRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
		  this.asciiRadioButton.Size = new System.Drawing.Size(51, 17);
		  this.asciiRadioButton.TabIndex = 6;
		  this.asciiRadioButton.TabStop = true;
		  this.asciiRadioButton.Text = "ASCII";
		  this.asciiRadioButton.UseVisualStyleBackColor = true;
		  // 
		  // containingTextBox
		  // 
		  this.containingTextBox.Enabled = false;
		  this.containingTextBox.Location = new System.Drawing.Point(6, 72);
		  this.containingTextBox.Name = "containingTextBox";
		  this.containingTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
		  this.containingTextBox.Size = new System.Drawing.Size(244, 22);
		  this.containingTextBox.TabIndex = 5;
		  // 
		  // containingCheckBox
		  // 
		  this.containingCheckBox.AutoSize = true;
		  this.containingCheckBox.Location = new System.Drawing.Point(256, 74);
		  this.containingCheckBox.Name = "containingCheckBox";
		  this.containingCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
		  this.containingCheckBox.Size = new System.Drawing.Size(160, 17);
		  this.containingCheckBox.TabIndex = 4;
		  this.containingCheckBox.Text = "پرونده دارای این متن (حساس)";
		  this.containingCheckBox.UseVisualStyleBackColor = true;
		  this.containingCheckBox.CheckedChanged += new System.EventHandler(this.containingCheckBox_CheckedChanged);
		  // 
		  // Ch_All_Search
		  // 
		  this.Ch_All_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
		  this.Ch_All_Search.AutoSize = true;
		  this.Ch_All_Search.Checked = true;
		  this.Ch_All_Search.CheckState = System.Windows.Forms.CheckState.Checked;
		  this.Ch_All_Search.Location = new System.Drawing.Point(534, 93);
		  this.Ch_All_Search.Name = "Ch_All_Search";
		  this.Ch_All_Search.RightToLeft = System.Windows.Forms.RightToLeft.No;
		  this.Ch_All_Search.Size = new System.Drawing.Size(129, 17);
		  this.Ch_All_Search.TabIndex = 13;
		  this.Ch_All_Search.Text = "جستجو در همه فایل ها";
		  this.Ch_All_Search.UseVisualStyleBackColor = true;
		  this.Ch_All_Search.CheckedChanged += new System.EventHandler(this.Ch_All_Search_CheckedChanged);
		  // 
		  // Ch_Sort
		  // 
		  this.Ch_Sort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
		  this.Ch_Sort.AutoSize = true;
		  this.Ch_Sort.Checked = true;
		  this.Ch_Sort.CheckState = System.Windows.Forms.CheckState.Checked;
		  this.Ch_Sort.Location = new System.Drawing.Point(527, 17);
		  this.Ch_Sort.Name = "Ch_Sort";
		  this.Ch_Sort.RightToLeft = System.Windows.Forms.RightToLeft.No;
		  this.Ch_Sort.Size = new System.Drawing.Size(75, 17);
		  this.Ch_Sort.TabIndex = 14;
		  this.Ch_Sort.Text = "پیش فرض";
		  this.Ch_Sort.UseVisualStyleBackColor = true;
		  this.Ch_Sort.CheckedChanged += new System.EventHandler(this.Ch_Sort_CheckedChanged);
		  // 
		  // label6
		  // 
		  this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
		  this.label6.AutoSize = true;
		  this.label6.Location = new System.Drawing.Point(608, 18);
		  this.label6.Name = "label6";
		  this.label6.Size = new System.Drawing.Size(58, 13);
		  this.label6.TabIndex = 4;
		  this.label6.Text = "مرتب سازی";
		  // 
		  // label5
		  // 
		  this.label5.AutoSize = true;
		  this.label5.Location = new System.Drawing.Point(175, 108);
		  this.label5.Name = "label5";
		  this.label5.Size = new System.Drawing.Size(68, 13);
		  this.label5.TabIndex = 4;
		  this.label5.Text = "نوع فرمت کد";
		  // 
		  // groupBox2
		  // 
		  this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
		  this.groupBox2.Controls.Add(this.delimeterTextBox);
		  this.groupBox2.Controls.Add(this.button2);
		  this.groupBox2.Controls.Add(this.label3);
		  this.groupBox2.Controls.Add(this.button1);
		  this.groupBox2.Controls.Add(this.writeResultsButton);
		  this.groupBox2.Controls.Add(this.stopButton);
		  this.groupBox2.Controls.Add(this.startButton);
		  this.groupBox2.Controls.Add(this.resultsList);
		  this.groupBox2.Location = new System.Drawing.Point(12, 206);
		  this.groupBox2.Name = "groupBox2";
		  this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		  this.groupBox2.Size = new System.Drawing.Size(679, 274);
		  this.groupBox2.TabIndex = 9;
		  this.groupBox2.TabStop = false;
		  this.groupBox2.Text = "نتیجه";
		  // 
		  // delimeterTextBox
		  // 
		  this.delimeterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
		  this.delimeterTextBox.Location = new System.Drawing.Point(6, 245);
		  this.delimeterTextBox.MaxLength = 10;
		  this.delimeterTextBox.Name = "delimeterTextBox";
		  this.delimeterTextBox.Size = new System.Drawing.Size(92, 22);
		  this.delimeterTextBox.TabIndex = 2;
		  this.delimeterTextBox.Text = "------";
		  this.delimeterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		  // 
		  // button2
		  // 
		  this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
		  this.button2.Location = new System.Drawing.Point(351, 244);
		  this.button2.Name = "button2";
		  this.button2.Size = new System.Drawing.Size(158, 23);
		  this.button2.TabIndex = 16;
		  this.button2.Text = "درباره من";
		  this.button2.UseVisualStyleBackColor = true;
		  this.button2.Click += new System.EventHandler(this.Button2_Click);
		  // 
		  // label3
		  // 
		  this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
		  this.label3.AutoSize = true;
		  this.label3.Location = new System.Drawing.Point(104, 245);
		  this.label3.Name = "label3";
		  this.label3.Size = new System.Drawing.Size(67, 13);
		  this.label3.TabIndex = 1;
		  this.label3.Text = "کاراکتر میانی";
		  // 
		  // button1
		  // 
		  this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
		  this.button1.Location = new System.Drawing.Point(351, 215);
		  this.button1.Name = "button1";
		  this.button1.Size = new System.Drawing.Size(158, 23);
		  this.button1.TabIndex = 16;
		  this.button1.Text = "راهنما";
		  this.button1.UseVisualStyleBackColor = true;
		  this.button1.Click += new System.EventHandler(this.Button1_Click_1);
		  // 
		  // writeResultsButton
		  // 
		  this.writeResultsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
		  this.writeResultsButton.Location = new System.Drawing.Point(6, 216);
		  this.writeResultsButton.Name = "writeResultsButton";
		  this.writeResultsButton.Size = new System.Drawing.Size(166, 23);
		  this.writeResultsButton.TabIndex = 3;
		  this.writeResultsButton.Text = "دریافت خروجی از یافته ها";
		  this.writeResultsButton.UseVisualStyleBackColor = true;
		  this.writeResultsButton.Click += new System.EventHandler(this.writeResultsButton_Click);
		  // 
		  // stopButton
		  // 
		  this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
		  this.stopButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		  this.stopButton.Enabled = false;
		  this.stopButton.Location = new System.Drawing.Point(515, 243);
		  this.stopButton.Name = "stopButton";
		  this.stopButton.Size = new System.Drawing.Size(158, 23);
		  this.stopButton.TabIndex = 7;
		  this.stopButton.Text = "ایست";
		  this.stopButton.UseVisualStyleBackColor = true;
		  this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
		  // 
		  // startButton
		  // 
		  this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
		  this.startButton.Location = new System.Drawing.Point(515, 214);
		  this.startButton.Name = "startButton";
		  this.startButton.Size = new System.Drawing.Size(159, 23);
		  this.startButton.TabIndex = 8;
		  this.startButton.Text = "شروع جستجو";
		  this.startButton.UseVisualStyleBackColor = true;
		  this.startButton.Click += new System.EventHandler(this.startButton_Click);
		  // 
		  // resultsList
		  // 
		  this.resultsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
		  this.resultsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
		  this.resultsList.ContextMenuStrip = this.contextMenuStrip;
		  this.resultsList.FullRowSelect = true;
		  this.resultsList.HideSelection = false;
		  this.resultsList.Location = new System.Drawing.Point(6, 20);
		  this.resultsList.MultiSelect = false;
		  this.resultsList.Name = "resultsList";
		  this.resultsList.RightToLeftLayout = true;
		  this.resultsList.ShowItemToolTips = true;
		  this.resultsList.Size = new System.Drawing.Size(667, 190);
		  this.resultsList.TabIndex = 0;
		  this.resultsList.UseCompatibleStateImageBehavior = false;
		  this.resultsList.View = System.Windows.Forms.View.Details;
		  this.resultsList.DoubleClick += new System.EventHandler(this.resultsList_DoubleClick);
		  this.resultsList.Resize += new System.EventHandler(this.resultsList_Resize);
		  // 
		  // columnHeader1
		  // 
		  this.columnHeader1.Text = "مسیر فایل";
		  this.columnHeader1.Width = 212;
		  // 
		  // columnHeader2
		  // 
		  this.columnHeader2.Text = "حجم";
		  this.columnHeader2.Width = 123;
		  // 
		  // columnHeader3
		  // 
		  this.columnHeader3.Text = "آخرین بازدید";
		  this.columnHeader3.Width = 149;
		  // 
		  // columnHeader4
		  // 
		  this.columnHeader4.Text = "نوع";
		  this.columnHeader4.Width = 133;
		  // 
		  // contextMenuStrip
		  // 
		  this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openContainingFolderContextMenuItem});
		  this.contextMenuStrip.Name = "contextMenuStrip";
		  this.contextMenuStrip.Size = new System.Drawing.Size(166, 26);
		  this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
		  // 
		  // openContainingFolderContextMenuItem
		  // 
		  this.openContainingFolderContextMenuItem.Name = "openContainingFolderContextMenuItem";
		  this.openContainingFolderContextMenuItem.Size = new System.Drawing.Size(165, 22);
		  this.openContainingFolderContextMenuItem.Text = "بازکردن پوشه قبلی";
		  this.openContainingFolderContextMenuItem.Click += new System.EventHandler(this.openContainingFolderContextMenuItem_Click);
		  // 
		  // Txt_Search
		  // 
		  this.Txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
		  this.Txt_Search.Location = new System.Drawing.Point(12, 34);
		  this.Txt_Search.Name = "Txt_Search";
		  this.Txt_Search.Size = new System.Drawing.Size(543, 22);
		  this.Txt_Search.TabIndex = 12;
		  // 
		  // notifyIcon1
		  // 
		  this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
		  this.notifyIcon1.BalloonTipTitle = "برنامه در حا اجرا می باشد";
		  this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
		  this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
		  this.notifyIcon1.Text = "جستجوگر هوشمند";
		  this.notifyIcon1.Visible = true;
		  this.notifyIcon1.DoubleClick += new System.EventHandler(this.Button2_Click);
		  // 
		  // contextMenuStrip1
		  // 
		  this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.دربارهمنToolStripMenuItem,
            this.راهنماToolStripMenuItem,
            this.خروجToolStripMenuItem});
		  this.contextMenuStrip1.Name = "contextMenuStrip1";
		  this.contextMenuStrip1.Size = new System.Drawing.Size(121, 70);
		  // 
		  // دربارهمنToolStripMenuItem
		  // 
		  this.دربارهمنToolStripMenuItem.Name = "دربارهمنToolStripMenuItem";
		  this.دربارهمنToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
		  this.دربارهمنToolStripMenuItem.Text = "درباره من";
		  this.دربارهمنToolStripMenuItem.Click += new System.EventHandler(this.دربارهمنToolStripMenuItem_Click);
		  // 
		  // راهنماToolStripMenuItem
		  // 
		  this.راهنماToolStripMenuItem.Name = "راهنماToolStripMenuItem";
		  this.راهنماToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
		  this.راهنماToolStripMenuItem.Text = "راهنما";
		  this.راهنماToolStripMenuItem.Click += new System.EventHandler(this.راهنماToolStripMenuItem_Click);
		  // 
		  // خروجToolStripMenuItem
		  // 
		  this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
		  this.خروجToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
		  this.خروجToolStripMenuItem.Text = "خروج";
		  this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
		  // 
		  // MainWindow
		  // 
		  this.AcceptButton = this.startButton;
		  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		  this.CancelButton = this.stopButton;
		  this.ClientSize = new System.Drawing.Size(703, 492);
		  this.Controls.Add(this.Txt_Search);
		  this.Controls.Add(this.groupBox2);
		  this.Controls.Add(this.groupBox1);
		  this.Controls.Add(this.selectSearchDirButton);
		  this.Controls.Add(this.label2);
		  this.Controls.Add(this.searchDirTextBox);
		  this.Controls.Add(this.label1);
		  this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
		  this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
		  this.MinimumSize = new System.Drawing.Size(719, 531);
		  this.Name = "MainWindow";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "جستجوگر هوشمند";
		  this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
		  this.Load += new System.EventHandler(this.MainWindow_Load);
		  this.groupBox1.ResumeLayout(false);
		  this.groupBox1.PerformLayout();
		  this.groupBox2.ResumeLayout(false);
		  this.groupBox2.PerformLayout();
		  this.contextMenuStrip.ResumeLayout(false);
		  this.contextMenuStrip1.ResumeLayout(false);
		  this.ResumeLayout(false);
		  this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchDirTextBox;
        private System.Windows.Forms.Button selectSearchDirButton;
        private System.Windows.Forms.CheckBox includeSubDirsCheckBox;
        private System.Windows.Forms.CheckBox newerThanCheckBox;
        private System.Windows.Forms.DateTimePicker newerThanDateTimePicker;
        private System.Windows.Forms.DateTimePicker olderThanDateTimePicker;
        private System.Windows.Forms.CheckBox olderThanCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox containingTextBox;
        private System.Windows.Forms.CheckBox containingCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView resultsList;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.RadioButton unicodeRadioButton;
        private System.Windows.Forms.RadioButton asciiRadioButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openContainingFolderContextMenuItem;
        private System.Windows.Forms.TextBox delimeterTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button writeResultsButton;
	   private System.Windows.Forms.ColumnHeader columnHeader2;
	   private System.Windows.Forms.TextBox Txt_Search;
	   private System.Windows.Forms.CheckBox Ch_All_Search;
	   private System.Windows.Forms.CheckBox Ch_Sort;
	   private System.Windows.Forms.Button button1;
	   private System.Windows.Forms.Button button2;
	   private System.Windows.Forms.Label label5;
	   private System.Windows.Forms.Label label6;
	   private System.Windows.Forms.CheckBox Ch_Sort_As;
	   private System.Windows.Forms.CheckBox Ch_Sort_Des;
	   private System.Windows.Forms.Label label4;
	   private System.Windows.Forms.CheckBox Ch_F;
	   private System.Windows.Forms.CheckBox Ch_File;
	   private System.Windows.Forms.ColumnHeader columnHeader4;
	   private System.Windows.Forms.NotifyIcon notifyIcon1;
	   private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
	   private System.Windows.Forms.ToolStripMenuItem دربارهمنToolStripMenuItem;
	   private System.Windows.Forms.ToolStripMenuItem راهنماToolStripMenuItem;
	   private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
    }
}

