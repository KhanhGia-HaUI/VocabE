
namespace VocabE
{
    partial class VocabE
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconAbout = new FontAwesome.Sharp.IconButton();
            this.iconSettings = new FontAwesome.Sharp.IconButton();
            this.iconHelp = new FontAwesome.Sharp.IconButton();
            this.iconDashboard = new FontAwesome.Sharp.IconButton();
            this.iconSearch = new FontAwesome.Sharp.IconButton();
            this.panelMenubar = new System.Windows.Forms.Panel();
            this.displayBundleText = new System.Windows.Forms.Label();
            this.iconMenuBar = new FontAwesome.Sharp.IconButton();
            this.MenuIcon = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.displayTextTitle = new System.Windows.Forms.Label();
            this.displayIconTitle = new FontAwesome.Sharp.IconPictureBox();
            this.iconMinimize = new FontAwesome.Sharp.IconButton();
            this.iconTab = new FontAwesome.Sharp.IconButton();
            this.iconExit = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.disclaim = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.displayNewWordImage = new FontAwesome.Sharp.IconPictureBox();
            this.displayNewWord = new System.Windows.Forms.Label();
            this.displayAnnouncement = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelMenu.SuspendLayout();
            this.panelMenubar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuIcon)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayIconTitle)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayNewWordImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(133)))), ((int)(((byte)(89)))));
            this.panelMenu.Controls.Add(this.iconAbout);
            this.panelMenu.Controls.Add(this.iconSettings);
            this.panelMenu.Controls.Add(this.iconHelp);
            this.panelMenu.Controls.Add(this.iconDashboard);
            this.panelMenu.Controls.Add(this.iconSearch);
            this.panelMenu.Controls.Add(this.panelMenubar);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 577);
            this.panelMenu.TabIndex = 0;
            // 
            // iconAbout
            // 
            this.iconAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconAbout.FlatAppearance.BorderSize = 0;
            this.iconAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconAbout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconAbout.ForeColor = System.Drawing.Color.White;
            this.iconAbout.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconAbout.IconColor = System.Drawing.Color.White;
            this.iconAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconAbout.Location = new System.Drawing.Point(0, 340);
            this.iconAbout.Name = "iconAbout";
            this.iconAbout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconAbout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconAbout.Size = new System.Drawing.Size(180, 60);
            this.iconAbout.TabIndex = 11;
            this.iconAbout.Tag = "About";
            this.iconAbout.Text = "About";
            this.iconAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconAbout.UseVisualStyleBackColor = true;
            this.iconAbout.Click += new System.EventHandler(this.iconAbout_Click);
            // 
            // iconSettings
            // 
            this.iconSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconSettings.FlatAppearance.BorderSize = 0;
            this.iconSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSettings.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconSettings.ForeColor = System.Drawing.Color.White;
            this.iconSettings.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.iconSettings.IconColor = System.Drawing.Color.White;
            this.iconSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconSettings.Location = new System.Drawing.Point(0, 280);
            this.iconSettings.Name = "iconSettings";
            this.iconSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconSettings.Size = new System.Drawing.Size(180, 60);
            this.iconSettings.TabIndex = 10;
            this.iconSettings.Tag = "Settings";
            this.iconSettings.Text = "Settings";
            this.iconSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconSettings.UseVisualStyleBackColor = true;
            this.iconSettings.Click += new System.EventHandler(this.iconSettings_Click);
            // 
            // iconHelp
            // 
            this.iconHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconHelp.FlatAppearance.BorderSize = 0;
            this.iconHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconHelp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconHelp.ForeColor = System.Drawing.Color.White;
            this.iconHelp.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.iconHelp.IconColor = System.Drawing.Color.White;
            this.iconHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconHelp.Location = new System.Drawing.Point(0, 220);
            this.iconHelp.Name = "iconHelp";
            this.iconHelp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconHelp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconHelp.Size = new System.Drawing.Size(180, 60);
            this.iconHelp.TabIndex = 9;
            this.iconHelp.Tag = "Help";
            this.iconHelp.Text = "Help";
            this.iconHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconHelp.UseVisualStyleBackColor = true;
            this.iconHelp.Click += new System.EventHandler(this.iconHelp_Click);
            // 
            // iconDashboard
            // 
            this.iconDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconDashboard.FlatAppearance.BorderSize = 0;
            this.iconDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconDashboard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconDashboard.ForeColor = System.Drawing.Color.White;
            this.iconDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.iconDashboard.IconColor = System.Drawing.Color.White;
            this.iconDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconDashboard.Location = new System.Drawing.Point(0, 160);
            this.iconDashboard.Name = "iconDashboard";
            this.iconDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconDashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconDashboard.Size = new System.Drawing.Size(180, 60);
            this.iconDashboard.TabIndex = 8;
            this.iconDashboard.Tag = "Dashboard";
            this.iconDashboard.Text = "Dashboard";
            this.iconDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconDashboard.UseVisualStyleBackColor = true;
            this.iconDashboard.Click += new System.EventHandler(this.iconDashboard_Click);
            // 
            // iconSearch
            // 
            this.iconSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconSearch.FlatAppearance.BorderSize = 0;
            this.iconSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconSearch.ForeColor = System.Drawing.Color.White;
            this.iconSearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconSearch.IconColor = System.Drawing.Color.White;
            this.iconSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconSearch.Location = new System.Drawing.Point(0, 100);
            this.iconSearch.Name = "iconSearch";
            this.iconSearch.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconSearch.Size = new System.Drawing.Size(180, 60);
            this.iconSearch.TabIndex = 5;
            this.iconSearch.Tag = "Search";
            this.iconSearch.Text = "Search";
            this.iconSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconSearch.UseVisualStyleBackColor = true;
            this.iconSearch.Click += new System.EventHandler(this.iconSearch_Click);
            // 
            // panelMenubar
            // 
            this.panelMenubar.Controls.Add(this.displayBundleText);
            this.panelMenubar.Controls.Add(this.iconMenuBar);
            this.panelMenubar.Controls.Add(this.MenuIcon);
            this.panelMenubar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenubar.Location = new System.Drawing.Point(0, 0);
            this.panelMenubar.Name = "panelMenubar";
            this.panelMenubar.Size = new System.Drawing.Size(180, 100);
            this.panelMenubar.TabIndex = 0;
            // 
            // displayBundleText
            // 
            this.displayBundleText.AutoSize = true;
            this.displayBundleText.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBundleText.ForeColor = System.Drawing.Color.White;
            this.displayBundleText.Location = new System.Drawing.Point(64, 41);
            this.displayBundleText.Name = "displayBundleText";
            this.displayBundleText.Size = new System.Drawing.Size(63, 19);
            this.displayBundleText.TabIndex = 7;
            this.displayBundleText.Text = "VocabE";
            // 
            // iconMenuBar
            // 
            this.iconMenuBar.FlatAppearance.BorderSize = 0;
            this.iconMenuBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconMenuBar.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconMenuBar.IconColor = System.Drawing.Color.White;
            this.iconMenuBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuBar.IconSize = 36;
            this.iconMenuBar.Location = new System.Drawing.Point(134, 25);
            this.iconMenuBar.Name = "iconMenuBar";
            this.iconMenuBar.Size = new System.Drawing.Size(34, 52);
            this.iconMenuBar.TabIndex = 1;
            this.iconMenuBar.UseVisualStyleBackColor = true;
            this.iconMenuBar.Click += new System.EventHandler(this.iconMenuBar_Click);
            // 
            // MenuIcon
            // 
            this.MenuIcon.Image = global::VocabE.Properties.Resources.menu;
            this.MenuIcon.Location = new System.Drawing.Point(8, 27);
            this.MenuIcon.Name = "MenuIcon";
            this.MenuIcon.Size = new System.Drawing.Size(50, 45);
            this.MenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuIcon.TabIndex = 0;
            this.MenuIcon.TabStop = false;
            this.MenuIcon.Click += new System.EventHandler(this.MenuIcon_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.displayTextTitle);
            this.panelTitleBar.Controls.Add(this.displayIconTitle);
            this.panelTitleBar.Controls.Add(this.iconMinimize);
            this.panelTitleBar.Controls.Add(this.iconTab);
            this.panelTitleBar.Controls.Add(this.iconExit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(180, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1081, 54);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // displayTextTitle
            // 
            this.displayTextTitle.AutoSize = true;
            this.displayTextTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTextTitle.ForeColor = System.Drawing.Color.Black;
            this.displayTextTitle.Location = new System.Drawing.Point(55, 20);
            this.displayTextTitle.Name = "displayTextTitle";
            this.displayTextTitle.Size = new System.Drawing.Size(49, 19);
            this.displayTextTitle.TabIndex = 6;
            this.displayTextTitle.Text = "Home";
            // 
            // displayIconTitle
            // 
            this.displayIconTitle.BackColor = System.Drawing.Color.Transparent;
            this.displayIconTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.displayIconTitle.ForeColor = System.Drawing.Color.Black;
            this.displayIconTitle.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.displayIconTitle.IconColor = System.Drawing.Color.Black;
            this.displayIconTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.displayIconTitle.Location = new System.Drawing.Point(16, 12);
            this.displayIconTitle.Name = "displayIconTitle";
            this.displayIconTitle.Size = new System.Drawing.Size(32, 32);
            this.displayIconTitle.TabIndex = 5;
            this.displayIconTitle.TabStop = false;
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.BackColor = System.Drawing.Color.Transparent;
            this.iconMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconMinimize.FlatAppearance.BorderSize = 0;
            this.iconMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMinimize.IconColor = System.Drawing.Color.Black;
            this.iconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMinimize.IconSize = 25;
            this.iconMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconMinimize.Location = new System.Drawing.Point(930, 2);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.iconMinimize.Size = new System.Drawing.Size(50, 30);
            this.iconMinimize.TabIndex = 4;
            this.iconMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMinimize.UseVisualStyleBackColor = false;
            this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
            // 
            // iconTab
            // 
            this.iconTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconTab.BackColor = System.Drawing.Color.Transparent;
            this.iconTab.FlatAppearance.BorderSize = 0;
            this.iconTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconTab.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.iconTab.IconColor = System.Drawing.Color.Black;
            this.iconTab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTab.IconSize = 25;
            this.iconTab.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconTab.Location = new System.Drawing.Point(980, 1);
            this.iconTab.Name = "iconTab";
            this.iconTab.Size = new System.Drawing.Size(50, 30);
            this.iconTab.TabIndex = 3;
            this.iconTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconTab.UseVisualStyleBackColor = false;
            this.iconTab.Click += new System.EventHandler(this.iconTab_Click);
            // 
            // iconExit
            // 
            this.iconExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExit.BackColor = System.Drawing.Color.Transparent;
            this.iconExit.FlatAppearance.BorderSize = 0;
            this.iconExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.iconExit.IconColor = System.Drawing.Color.Black;
            this.iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExit.IconSize = 25;
            this.iconExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconExit.Location = new System.Drawing.Point(1030, 1);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(50, 30);
            this.iconExit.TabIndex = 2;
            this.iconExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconExit.UseVisualStyleBackColor = false;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelDesktop.Controls.Add(this.disclaim);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.label4);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.displayNewWordImage);
            this.panelDesktop.Controls.Add(this.displayNewWord);
            this.panelDesktop.Controls.Add(this.displayAnnouncement);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.Location = new System.Drawing.Point(180, 54);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1081, 523);
            this.panelDesktop.TabIndex = 2;
            // 
            // disclaim
            // 
            this.disclaim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.disclaim.AutoSize = true;
            this.disclaim.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disclaim.ForeColor = System.Drawing.Color.Black;
            this.disclaim.Location = new System.Drawing.Point(446, 281);
            this.disclaim.Name = "disclaim";
            this.disclaim.Size = new System.Drawing.Size(171, 23);
            this.disclaim.TabIndex = 8;
            this.disclaim.Text = "Missing Image T_T";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::VocabE.Properties.Resources.menu;
            this.pictureBox1.Location = new System.Drawing.Point(472, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(606, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "null";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(421, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vietnamese Meaning:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(553, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "null";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(468, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description:";
            // 
            // displayNewWordImage
            // 
            this.displayNewWordImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.displayNewWordImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.displayNewWordImage.ForeColor = System.Drawing.Color.Cornsilk;
            this.displayNewWordImage.IconChar = FontAwesome.Sharp.IconChar.None;
            this.displayNewWordImage.IconColor = System.Drawing.Color.Cornsilk;
            this.displayNewWordImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.displayNewWordImage.IconSize = 300;
            this.displayNewWordImage.Location = new System.Drawing.Point(369, 65);
            this.displayNewWordImage.Name = "displayNewWordImage";
            this.displayNewWordImage.Size = new System.Drawing.Size(300, 300);
            this.displayNewWordImage.TabIndex = 2;
            this.displayNewWordImage.TabStop = false;
            // 
            // displayNewWord
            // 
            this.displayNewWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.displayNewWord.AutoSize = true;
            this.displayNewWord.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayNewWord.ForeColor = System.Drawing.Color.Black;
            this.displayNewWord.Location = new System.Drawing.Point(634, 20);
            this.displayNewWord.Name = "displayNewWord";
            this.displayNewWord.Size = new System.Drawing.Size(63, 36);
            this.displayNewWord.TabIndex = 1;
            this.displayNewWord.Text = "null";
            // 
            // displayAnnouncement
            // 
            this.displayAnnouncement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.displayAnnouncement.AutoSize = true;
            this.displayAnnouncement.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAnnouncement.ForeColor = System.Drawing.Color.Black;
            this.displayAnnouncement.Location = new System.Drawing.Point(360, 20);
            this.displayAnnouncement.Name = "displayAnnouncement";
            this.displayAnnouncement.Size = new System.Drawing.Size(289, 36);
            this.displayAnnouncement.TabIndex = 0;
            this.displayAnnouncement.Text = "New word for today: ";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // VocabE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 577);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Name = "VocabE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VocabE";
            this.Resize += new System.EventHandler(this.VocabE_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelMenubar.ResumeLayout(false);
            this.panelMenubar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuIcon)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayIconTitle)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayNewWordImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelMenubar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private FontAwesome.Sharp.IconButton iconExit;
        private FontAwesome.Sharp.IconButton iconMinimize;
        private FontAwesome.Sharp.IconButton iconTab;
        private FontAwesome.Sharp.IconButton iconSearch;
        private FontAwesome.Sharp.IconPictureBox displayIconTitle;
        private System.Windows.Forms.Label displayTextTitle;
        private System.Windows.Forms.Label displayAnnouncement;
        private System.Windows.Forms.Label displayNewWord;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox displayNewWordImage;
        private System.Windows.Forms.Label disclaim;
        private System.Windows.Forms.Label displayBundleText;
        private FontAwesome.Sharp.IconButton iconMenuBar;
        private System.Windows.Forms.PictureBox MenuIcon;
        private FontAwesome.Sharp.IconButton iconSettings;
        private FontAwesome.Sharp.IconButton iconHelp;
        private FontAwesome.Sharp.IconButton iconDashboard;
        private FontAwesome.Sharp.IconButton iconAbout;
    }
}

