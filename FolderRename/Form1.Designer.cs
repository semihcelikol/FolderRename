namespace FolderRename
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnChange = new System.Windows.Forms.Button();
            this.listBoxFirstFile = new System.Windows.Forms.ListBox();
            this.lblWarningFileSelected = new System.Windows.Forms.Label();
            this.listBoxChangeFile = new System.Windows.Forms.ListBox();
            this.lblChangefile = new System.Windows.Forms.Label();
            this.lblFirstFile = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpBoxContact = new System.Windows.Forms.GroupBox();
            this.linkLabelWebUrl = new System.Windows.Forms.LinkLabel();
            this.outlookLink = new System.Windows.Forms.LinkLabel();
            this.lblCopyhright = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelManuel2 = new System.Windows.Forms.Panel();
            this.lbl2manuel2 = new System.Windows.Forms.Label();
            this.lblManuel2 = new System.Windows.Forms.Label();
            this.txtManuelExtension2 = new System.Windows.Forms.TextBox();
            this.checkBoxManuel2 = new System.Windows.Forms.CheckBox();
            this.txtManuel2 = new System.Windows.Forms.TextBox();
            this.panelAuto3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxAutoChange3 = new System.Windows.Forms.CheckBox();
            this.btnInformatin3 = new System.Windows.Forms.Button();
            this.cbAutoChange3 = new System.Windows.Forms.ComboBox();
            this.panelAuto2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxAutoChange2 = new System.Windows.Forms.CheckBox();
            this.btnInformatin2 = new System.Windows.Forms.Button();
            this.cbAutoChange2 = new System.Windows.Forms.ComboBox();
            this.panelAuto1 = new System.Windows.Forms.Panel();
            this.checkBoxAutoChange1 = new System.Windows.Forms.CheckBox();
            this.btnInformatin1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAutoChange1 = new System.Windows.Forms.ComboBox();
            this.panelManuel = new System.Windows.Forms.Panel();
            this.txtManuelExtension = new System.Windows.Forms.TextBox();
            this.checkBoxManuel = new System.Windows.Forms.CheckBox();
            this.txtManuel = new System.Windows.Forms.TextBox();
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbManuel2Change = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpBoxContact.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelManuel2.SuspendLayout();
            this.panelAuto3.SuspendLayout();
            this.panelAuto2.SuspendLayout();
            this.panelAuto1.SuspendLayout();
            this.panelManuel.SuspendLayout();
            this.menuStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.Location = new System.Drawing.Point(325, 247);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(189, 23);
            this.btnFileSelect.TabIndex = 0;
            this.btnFileSelect.Text = "Seç";
            this.btnFileSelect.UseVisualStyleBackColor = true;
            this.btnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Dosya seçimi";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(377, 496);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(107, 77);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Değiştir";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // listBoxFirstFile
            // 
            this.listBoxFirstFile.FormattingEnabled = true;
            this.listBoxFirstFile.HorizontalScrollbar = true;
            this.listBoxFirstFile.Location = new System.Drawing.Point(15, 32);
            this.listBoxFirstFile.Name = "listBoxFirstFile";
            this.listBoxFirstFile.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxFirstFile.Size = new System.Drawing.Size(499, 199);
            this.listBoxFirstFile.TabIndex = 6;
            this.toolTip1.SetToolTip(this.listBoxFirstFile, "CTRL Tuşuna basılı tutarak 1\'den fazla dosya seçebilirsiniz.");
            this.listBoxFirstFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFirstFile_MouseClick);
            this.listBoxFirstFile.SelectedIndexChanged += new System.EventHandler(this.listBoxFirstFile_SelectedIndexChanged);
            this.listBoxFirstFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBoxFirstFile_KeyPress);
            // 
            // lblWarningFileSelected
            // 
            this.lblWarningFileSelected.AutoSize = true;
            this.lblWarningFileSelected.Location = new System.Drawing.Point(12, 252);
            this.lblWarningFileSelected.Name = "lblWarningFileSelected";
            this.lblWarningFileSelected.Size = new System.Drawing.Size(307, 13);
            this.lblWarningFileSelected.TabIndex = 7;
            this.lblWarningFileSelected.Text = "İSİMLERİNİ DEĞİŞTİRMEK İSTEDİĞİNİZ DOSYALARI SEÇİN";
            // 
            // listBoxChangeFile
            // 
            this.listBoxChangeFile.FormattingEnabled = true;
            this.listBoxChangeFile.Location = new System.Drawing.Point(520, 32);
            this.listBoxChangeFile.Name = "listBoxChangeFile";
            this.listBoxChangeFile.Size = new System.Drawing.Size(472, 199);
            this.listBoxChangeFile.TabIndex = 10;
            // 
            // lblChangefile
            // 
            this.lblChangefile.AutoSize = true;
            this.lblChangefile.Location = new System.Drawing.Point(517, 15);
            this.lblChangefile.Name = "lblChangefile";
            this.lblChangefile.Size = new System.Drawing.Size(67, 13);
            this.lblChangefile.TabIndex = 11;
            this.lblChangefile.Text = "Değişen Hali";
            // 
            // lblFirstFile
            // 
            this.lblFirstFile.AutoSize = true;
            this.lblFirstFile.Location = new System.Drawing.Point(12, 15);
            this.lblFirstFile.Name = "lblFirstFile";
            this.lblFirstFile.Size = new System.Drawing.Size(39, 13);
            this.lblFirstFile.TabIndex = 12;
            this.lblFirstFile.Text = "İlk Hali";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(490, 496);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 77);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "TÜMÜNÜ TEMİZLE";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpBoxContact
            // 
            this.grpBoxContact.Controls.Add(this.linkLabelWebUrl);
            this.grpBoxContact.Controls.Add(this.outlookLink);
            this.grpBoxContact.Location = new System.Drawing.Point(844, 542);
            this.grpBoxContact.Name = "grpBoxContact";
            this.grpBoxContact.Size = new System.Drawing.Size(148, 65);
            this.grpBoxContact.TabIndex = 16;
            this.grpBoxContact.TabStop = false;
            this.grpBoxContact.Text = "İletişim İçin;";
            // 
            // linkLabelWebUrl
            // 
            this.linkLabelWebUrl.AutoSize = true;
            this.linkLabelWebUrl.Location = new System.Drawing.Point(6, 40);
            this.linkLabelWebUrl.Name = "linkLabelWebUrl";
            this.linkLabelWebUrl.Size = new System.Drawing.Size(87, 13);
            this.linkLabelWebUrl.TabIndex = 17;
            this.linkLabelWebUrl.TabStop = true;
            this.linkLabelWebUrl.Text = "semihcelikol.com";
            this.linkLabelWebUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWebUrl_LinkClicked);
            // 
            // outlookLink
            // 
            this.outlookLink.AutoSize = true;
            this.outlookLink.Location = new System.Drawing.Point(6, 18);
            this.outlookLink.Name = "outlookLink";
            this.outlookLink.Size = new System.Drawing.Size(133, 13);
            this.outlookLink.TabIndex = 16;
            this.outlookLink.TabStop = true;
            this.outlookLink.Text = "semihcelikol@outlook.com";
            this.outlookLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.outlookLink_LinkClicked);
            // 
            // lblCopyhright
            // 
            this.lblCopyhright.AutoSize = true;
            this.lblCopyhright.Location = new System.Drawing.Point(446, 588);
            this.lblCopyhright.Name = "lblCopyhright";
            this.lblCopyhright.Size = new System.Drawing.Size(117, 13);
            this.lblCopyhright.TabIndex = 17;
            this.lblCopyhright.Text = "Copyright Semih Çelikol";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(213, 15);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(81, 13);
            this.lblWarning.TabIndex = 18;
            this.lblWarning.Text = "UYARI MESAJI";
            this.lblWarning.Visible = false;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelManuel2);
            this.panelMain.Controls.Add(this.panelAuto3);
            this.panelMain.Controls.Add(this.panelAuto2);
            this.panelMain.Controls.Add(this.panelAuto1);
            this.panelMain.Controls.Add(this.panelManuel);
            this.panelMain.Controls.Add(this.lblFirstFile);
            this.panelMain.Controls.Add(this.lblWarning);
            this.panelMain.Controls.Add(this.lblCopyhright);
            this.panelMain.Controls.Add(this.btnFileSelect);
            this.panelMain.Controls.Add(this.btnChange);
            this.panelMain.Controls.Add(this.grpBoxContact);
            this.panelMain.Controls.Add(this.listBoxFirstFile);
            this.panelMain.Controls.Add(this.btnClear);
            this.panelMain.Controls.Add(this.lblWarningFileSelected);
            this.panelMain.Controls.Add(this.lblChangefile);
            this.panelMain.Controls.Add(this.listBoxChangeFile);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 24);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1006, 619);
            this.panelMain.TabIndex = 19;
            // 
            // panelManuel2
            // 
            this.panelManuel2.Controls.Add(this.button1);
            this.panelManuel2.Controls.Add(this.label3);
            this.panelManuel2.Controls.Add(this.cbManuel2Change);
            this.panelManuel2.Controls.Add(this.lbl2manuel2);
            this.panelManuel2.Controls.Add(this.lblManuel2);
            this.panelManuel2.Controls.Add(this.checkBoxManuel2);
            this.panelManuel2.Controls.Add(this.txtManuelExtension2);
            this.panelManuel2.Controls.Add(this.txtManuel2);
            this.panelManuel2.Location = new System.Drawing.Point(8, 354);
            this.panelManuel2.Name = "panelManuel2";
            this.panelManuel2.Size = new System.Drawing.Size(499, 62);
            this.panelManuel2.TabIndex = 36;
            // 
            // lbl2manuel2
            // 
            this.lbl2manuel2.Location = new System.Drawing.Point(199, 32);
            this.lbl2manuel2.Name = "lbl2manuel2";
            this.lbl2manuel2.Size = new System.Drawing.Size(36, 17);
            this.lbl2manuel2.TabIndex = 37;
            this.lbl2manuel2.Text = "Ayraç";
            // 
            // lblManuel2
            // 
            this.lblManuel2.Location = new System.Drawing.Point(10, 32);
            this.lblManuel2.Name = "lblManuel2";
            this.lblManuel2.Size = new System.Drawing.Size(61, 17);
            this.lblManuel2.TabIndex = 0;
            this.lblManuel2.Text = "Dosya ismi";
            // 
            // txtManuelExtension2
            // 
            this.txtManuelExtension2.Location = new System.Drawing.Point(241, 30);
            this.txtManuelExtension2.Name = "txtManuelExtension2";
            this.txtManuelExtension2.Size = new System.Drawing.Size(52, 20);
            this.txtManuelExtension2.TabIndex = 36;
            // 
            // checkBoxManuel2
            // 
            this.checkBoxManuel2.AutoSize = true;
            this.checkBoxManuel2.Location = new System.Drawing.Point(13, 7);
            this.checkBoxManuel2.Name = "checkBoxManuel2";
            this.checkBoxManuel2.Size = new System.Drawing.Size(108, 17);
            this.checkBoxManuel2.TabIndex = 29;
            this.checkBoxManuel2.Text = "Manuel değişim 2";
            this.toolTip1.SetToolTip(this.checkBoxManuel2, "Dosay ismi \'XX\' ayraç \'-\' yapıldığında XX-1, XX-2.. şeklinde sırasıyla isimleri d" +
        "eğiştirir.");
            this.checkBoxManuel2.UseVisualStyleBackColor = true;
            this.checkBoxManuel2.CheckedChanged += new System.EventHandler(this.checkBoxManuel2_CheckedChanged);
            // 
            // txtManuel2
            // 
            this.txtManuel2.Location = new System.Drawing.Point(77, 30);
            this.txtManuel2.Name = "txtManuel2";
            this.txtManuel2.Size = new System.Drawing.Size(107, 20);
            this.txtManuel2.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtManuel2, "Manuel değişim için, burayı kullanın");
            // 
            // panelAuto3
            // 
            this.panelAuto3.Controls.Add(this.label1);
            this.panelAuto3.Controls.Add(this.label2);
            this.panelAuto3.Controls.Add(this.checkBoxAutoChange3);
            this.panelAuto3.Controls.Add(this.btnInformatin3);
            this.panelAuto3.Controls.Add(this.cbAutoChange3);
            this.panelAuto3.Location = new System.Drawing.Point(513, 419);
            this.panelAuto3.Name = "panelAuto3";
            this.panelAuto3.Size = new System.Drawing.Size(452, 62);
            this.panelAuto3.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Dosya adını";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "\'den başlayarak son dosyaya kadar otomatik değiştirin.";
            // 
            // checkBoxAutoChange3
            // 
            this.checkBoxAutoChange3.AutoSize = true;
            this.checkBoxAutoChange3.Location = new System.Drawing.Point(13, 9);
            this.checkBoxAutoChange3.Name = "checkBoxAutoChange3";
            this.checkBoxAutoChange3.Size = new System.Drawing.Size(142, 17);
            this.checkBoxAutoChange3.TabIndex = 31;
            this.checkBoxAutoChange3.Text = "Otomatik Sıralı Değişim 3";
            this.toolTip1.SetToolTip(this.checkBoxAutoChange3, resources.GetString("checkBoxAutoChange3.ToolTip"));
            this.checkBoxAutoChange3.UseVisualStyleBackColor = true;
            this.checkBoxAutoChange3.CheckedChanged += new System.EventHandler(this.checkBoxAutoChange3_CheckedChanged);
            // 
            // btnInformatin3
            // 
            this.btnInformatin3.Location = new System.Drawing.Point(161, 5);
            this.btnInformatin3.Name = "btnInformatin3";
            this.btnInformatin3.Size = new System.Drawing.Size(27, 23);
            this.btnInformatin3.TabIndex = 28;
            this.btnInformatin3.Text = "?";
            this.toolTip1.SetToolTip(this.btnInformatin3, "Bu nedir, öğrenin");
            this.btnInformatin3.UseVisualStyleBackColor = true;
            this.btnInformatin3.Click += new System.EventHandler(this.btnInformatin3_Click);
            // 
            // cbAutoChange3
            // 
            this.cbAutoChange3.FormattingEnabled = true;
            this.cbAutoChange3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbAutoChange3.Location = new System.Drawing.Point(116, 33);
            this.cbAutoChange3.Name = "cbAutoChange3";
            this.cbAutoChange3.Size = new System.Drawing.Size(39, 21);
            this.cbAutoChange3.TabIndex = 23;
            // 
            // panelAuto2
            // 
            this.panelAuto2.Controls.Add(this.label8);
            this.panelAuto2.Controls.Add(this.label7);
            this.panelAuto2.Controls.Add(this.checkBoxAutoChange2);
            this.panelAuto2.Controls.Add(this.btnInformatin2);
            this.panelAuto2.Controls.Add(this.cbAutoChange2);
            this.panelAuto2.Location = new System.Drawing.Point(513, 354);
            this.panelAuto2.Name = "panelAuto2";
            this.panelAuto2.Size = new System.Drawing.Size(452, 62);
            this.panelAuto2.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Dosya adının sonuna";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "\'den başlayarak son dosyaya kadar otomatik değiştirin.";
            // 
            // checkBoxAutoChange2
            // 
            this.checkBoxAutoChange2.AutoSize = true;
            this.checkBoxAutoChange2.Location = new System.Drawing.Point(13, 9);
            this.checkBoxAutoChange2.Name = "checkBoxAutoChange2";
            this.checkBoxAutoChange2.Size = new System.Drawing.Size(142, 17);
            this.checkBoxAutoChange2.TabIndex = 31;
            this.checkBoxAutoChange2.Text = "Otomatik Sıralı Değişim 2";
            this.toolTip1.SetToolTip(this.checkBoxAutoChange2, resources.GetString("checkBoxAutoChange2.ToolTip"));
            this.checkBoxAutoChange2.UseVisualStyleBackColor = true;
            this.checkBoxAutoChange2.CheckedChanged += new System.EventHandler(this.checkBoxAutoChange2_CheckedChanged);
            // 
            // btnInformatin2
            // 
            this.btnInformatin2.Location = new System.Drawing.Point(161, 5);
            this.btnInformatin2.Name = "btnInformatin2";
            this.btnInformatin2.Size = new System.Drawing.Size(27, 23);
            this.btnInformatin2.TabIndex = 28;
            this.btnInformatin2.Text = "?";
            this.toolTip1.SetToolTip(this.btnInformatin2, "Bu nedir, öğrenin");
            this.btnInformatin2.UseVisualStyleBackColor = true;
            this.btnInformatin2.Click += new System.EventHandler(this.btnInformatin2_Click);
            // 
            // cbAutoChange2
            // 
            this.cbAutoChange2.FormattingEnabled = true;
            this.cbAutoChange2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbAutoChange2.Location = new System.Drawing.Point(116, 33);
            this.cbAutoChange2.Name = "cbAutoChange2";
            this.cbAutoChange2.Size = new System.Drawing.Size(39, 21);
            this.cbAutoChange2.TabIndex = 23;
            // 
            // panelAuto1
            // 
            this.panelAuto1.Controls.Add(this.checkBoxAutoChange1);
            this.panelAuto1.Controls.Add(this.btnInformatin1);
            this.panelAuto1.Controls.Add(this.label5);
            this.panelAuto1.Controls.Add(this.label6);
            this.panelAuto1.Controls.Add(this.cbAutoChange1);
            this.panelAuto1.Location = new System.Drawing.Point(513, 289);
            this.panelAuto1.Name = "panelAuto1";
            this.panelAuto1.Size = new System.Drawing.Size(452, 62);
            this.panelAuto1.TabIndex = 33;
            // 
            // checkBoxAutoChange1
            // 
            this.checkBoxAutoChange1.AutoSize = true;
            this.checkBoxAutoChange1.Location = new System.Drawing.Point(13, 9);
            this.checkBoxAutoChange1.Name = "checkBoxAutoChange1";
            this.checkBoxAutoChange1.Size = new System.Drawing.Size(142, 17);
            this.checkBoxAutoChange1.TabIndex = 30;
            this.checkBoxAutoChange1.Text = "Otomatik Sıralı Değişim 1";
            this.toolTip1.SetToolTip(this.checkBoxAutoChange1, resources.GetString("checkBoxAutoChange1.ToolTip"));
            this.checkBoxAutoChange1.UseVisualStyleBackColor = true;
            this.checkBoxAutoChange1.CheckedChanged += new System.EventHandler(this.checkBoxAutoChange1_CheckedChanged);
            // 
            // btnInformatin1
            // 
            this.btnInformatin1.Location = new System.Drawing.Point(161, 5);
            this.btnInformatin1.Name = "btnInformatin1";
            this.btnInformatin1.Size = new System.Drawing.Size(27, 23);
            this.btnInformatin1.TabIndex = 27;
            this.btnInformatin1.Text = "?";
            this.toolTip1.SetToolTip(this.btnInformatin1, "Bu nedir, öğrenin");
            this.btnInformatin1.UseVisualStyleBackColor = true;
            this.btnInformatin1.Click += new System.EventHandler(this.btnInformatin1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Dosya adının başına";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "\'den başlayarak son dosyaya kadar otomatik değiştirin.";
            // 
            // cbAutoChange1
            // 
            this.cbAutoChange1.FormattingEnabled = true;
            this.cbAutoChange1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbAutoChange1.Location = new System.Drawing.Point(116, 28);
            this.cbAutoChange1.Name = "cbAutoChange1";
            this.cbAutoChange1.Size = new System.Drawing.Size(39, 21);
            this.cbAutoChange1.TabIndex = 20;
            // 
            // panelManuel
            // 
            this.panelManuel.Controls.Add(this.txtManuelExtension);
            this.panelManuel.Controls.Add(this.checkBoxManuel);
            this.panelManuel.Controls.Add(this.txtManuel);
            this.panelManuel.Location = new System.Drawing.Point(8, 289);
            this.panelManuel.Name = "panelManuel";
            this.panelManuel.Size = new System.Drawing.Size(499, 62);
            this.panelManuel.TabIndex = 32;
            // 
            // txtManuelExtension
            // 
            this.txtManuelExtension.Location = new System.Drawing.Point(444, 30);
            this.txtManuelExtension.Name = "txtManuelExtension";
            this.txtManuelExtension.Size = new System.Drawing.Size(52, 20);
            this.txtManuelExtension.TabIndex = 36;
            // 
            // checkBoxManuel
            // 
            this.checkBoxManuel.AutoSize = true;
            this.checkBoxManuel.Location = new System.Drawing.Point(13, 7);
            this.checkBoxManuel.Name = "checkBoxManuel";
            this.checkBoxManuel.Size = new System.Drawing.Size(99, 17);
            this.checkBoxManuel.TabIndex = 29;
            this.checkBoxManuel.Text = "Manuel değişim";
            this.toolTip1.SetToolTip(this.checkBoxManuel, "Dosyanızın adını kendiniz değiştirin.\r\n");
            this.checkBoxManuel.UseVisualStyleBackColor = true;
            this.checkBoxManuel.CheckedChanged += new System.EventHandler(this.checkBoxManuel_CheckedChanged);
            // 
            // txtManuel
            // 
            this.txtManuel.Location = new System.Drawing.Point(13, 30);
            this.txtManuel.Name = "txtManuel";
            this.txtManuel.Size = new System.Drawing.Size(425, 20);
            this.txtManuel.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtManuel, "Manuel değişim için, burayı kullanın");
            // 
            // menuStripTop
            // 
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(1006, 24);
            this.menuStripTop.TabIndex = 20;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // cbManuel2Change
            // 
            this.cbManuel2Change.FormattingEnabled = true;
            this.cbManuel2Change.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbManuel2Change.Location = new System.Drawing.Point(399, 30);
            this.cbManuel2Change.Name = "cbManuel2Change";
            this.cbManuel2Change.Size = new System.Drawing.Size(39, 21);
            this.cbManuel2Change.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(307, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Başlangıç sayısı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "?";
            this.toolTip1.SetToolTip(this.button1, "Bu nedir, öğrenin");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 643);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStripTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripTop;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İSİM DEĞİŞTİRME PROGRAMI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxContact.ResumeLayout(false);
            this.grpBoxContact.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelManuel2.ResumeLayout(false);
            this.panelManuel2.PerformLayout();
            this.panelAuto3.ResumeLayout(false);
            this.panelAuto3.PerformLayout();
            this.panelAuto2.ResumeLayout(false);
            this.panelAuto2.PerformLayout();
            this.panelAuto1.ResumeLayout(false);
            this.panelAuto1.PerformLayout();
            this.panelManuel.ResumeLayout(false);
            this.panelManuel.PerformLayout();
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ListBox listBoxFirstFile;
        private System.Windows.Forms.Label lblWarningFileSelected;
        private System.Windows.Forms.ListBox listBoxChangeFile;
        private System.Windows.Forms.Label lblChangefile;
        private System.Windows.Forms.Label lblFirstFile;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpBoxContact;
        private System.Windows.Forms.LinkLabel outlookLink;
        private System.Windows.Forms.Label lblCopyhright;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAutoChange1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbAutoChange2;
        private System.Windows.Forms.Button btnInformatin2;
        private System.Windows.Forms.Button btnInformatin1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtManuel;
        private System.Windows.Forms.CheckBox checkBoxManuel;
        private System.Windows.Forms.CheckBox checkBoxAutoChange2;
        private System.Windows.Forms.CheckBox checkBoxAutoChange1;
        private System.Windows.Forms.Panel panelManuel;
        private System.Windows.Forms.Panel panelAuto2;
        private System.Windows.Forms.Panel panelAuto1;
        private System.Windows.Forms.LinkLabel linkLabelWebUrl;
        private System.Windows.Forms.Panel panelAuto3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxAutoChange3;
        private System.Windows.Forms.Button btnInformatin3;
        private System.Windows.Forms.ComboBox cbAutoChange3;
        private System.Windows.Forms.TextBox txtManuelExtension;
        private System.Windows.Forms.Panel panelManuel2;
        private System.Windows.Forms.Label lbl2manuel2;
        private System.Windows.Forms.Label lblManuel2;
        private System.Windows.Forms.TextBox txtManuelExtension2;
        private System.Windows.Forms.CheckBox checkBoxManuel2;
        private System.Windows.Forms.TextBox txtManuel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbManuel2Change;
        private System.Windows.Forms.Button button1;
    }
}

