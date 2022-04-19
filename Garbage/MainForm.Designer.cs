namespace Garbage
{
    partial class MainForm
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
            this.waterMark = new System.Windows.Forms.Label();
            this.templateMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuName = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExt = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuYear = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuHour = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMinute = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSecond = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSetDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSortingHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSymbolsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.openDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lastUseLabel = new System.Windows.Forms.Label();
            this.askChk = new System.Windows.Forms.CheckBox();
            this.skipRadio = new System.Windows.Forms.RadioButton();
            this.overwriteRadio = new System.Windows.Forms.RadioButton();
            this.historyChk = new System.Windows.Forms.CheckBox();
            this.showMoveDialogChk = new System.Windows.Forms.CheckBox();
            this.checkFreeSpaceChk = new System.Windows.Forms.CheckBox();
            this.templateGroup = new System.Windows.Forms.GroupBox();
            this.exampleLabel = new System.Windows.Forms.Label();
            this.templateInfo = new System.Windows.Forms.Label();
            this.templateBox = new System.Windows.Forms.TextBox();
            this.pathGroup = new System.Windows.Forms.GroupBox();
            this.clearTargetHistoryBtn = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.ComboBox();
            this.openDirBtn = new System.Windows.Forms.Button();
            this.separator = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.showResultChk = new System.Windows.Forms.CheckBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.templateMenu.SuspendLayout();
            this.templateGroup.SuspendLayout();
            this.pathGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // waterMark
            // 
            this.waterMark.AutoSize = true;
            this.waterMark.Enabled = false;
            this.waterMark.Location = new System.Drawing.Point(260, 435);
            this.waterMark.Margin = new System.Windows.Forms.Padding(0);
            this.waterMark.Name = "waterMark";
            this.waterMark.Size = new System.Drawing.Size(139, 13);
            this.waterMark.TabIndex = 99;
            this.waterMark.Text = "Daniel Swan © 2020 - 2022";
            // 
            // templateMenu
            // 
            this.templateMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuName,
            this.menuExt,
            this.menuSeparator1,
            this.menuYear,
            this.menuMonth,
            this.menuDay,
            this.menuSeparator2,
            this.menuHour,
            this.menuMinute,
            this.menuSecond,
            this.menuSeparator3,
            this.menuSetDefault,
            this.menuSeparator4,
            this.menuSortingHelp,
            this.menuSymbolsHelp});
            this.templateMenu.Name = "templateMenu";
            this.templateMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.templateMenu.Size = new System.Drawing.Size(216, 270);
            // 
            // menuName
            // 
            this.menuName.Name = "menuName";
            this.menuName.Size = new System.Drawing.Size(215, 22);
            this.menuName.Text = "%N = name";
            this.menuName.Click += new System.EventHandler(this.menuName_Click);
            // 
            // menuExt
            // 
            this.menuExt.Name = "menuExt";
            this.menuExt.Size = new System.Drawing.Size(215, 22);
            this.menuExt.Text = "%X = extension";
            this.menuExt.Click += new System.EventHandler(this.menuExt_Click);
            // 
            // menuSeparator1
            // 
            this.menuSeparator1.Name = "menuSeparator1";
            this.menuSeparator1.Size = new System.Drawing.Size(212, 6);
            // 
            // menuYear
            // 
            this.menuYear.Name = "menuYear";
            this.menuYear.Size = new System.Drawing.Size(215, 22);
            this.menuYear.Text = "%Y = year";
            this.menuYear.Click += new System.EventHandler(this.menuYear_Click);
            // 
            // menuMonth
            // 
            this.menuMonth.Name = "menuMonth";
            this.menuMonth.Size = new System.Drawing.Size(215, 22);
            this.menuMonth.Text = "%M = month";
            this.menuMonth.Click += new System.EventHandler(this.menuMonth_Click);
            // 
            // menuDay
            // 
            this.menuDay.Name = "menuDay";
            this.menuDay.Size = new System.Drawing.Size(215, 22);
            this.menuDay.Text = "%D = day";
            this.menuDay.Click += new System.EventHandler(this.menuDay_Click);
            // 
            // menuSeparator2
            // 
            this.menuSeparator2.Name = "menuSeparator2";
            this.menuSeparator2.Size = new System.Drawing.Size(212, 6);
            // 
            // menuHour
            // 
            this.menuHour.Name = "menuHour";
            this.menuHour.Size = new System.Drawing.Size(215, 22);
            this.menuHour.Text = "%h = hour";
            this.menuHour.Click += new System.EventHandler(this.menuHour_Click);
            // 
            // menuMinute
            // 
            this.menuMinute.Name = "menuMinute";
            this.menuMinute.Size = new System.Drawing.Size(215, 22);
            this.menuMinute.Text = "%m = minutes";
            this.menuMinute.Click += new System.EventHandler(this.menuMinute_Click);
            // 
            // menuSecond
            // 
            this.menuSecond.Name = "menuSecond";
            this.menuSecond.Size = new System.Drawing.Size(215, 22);
            this.menuSecond.Text = "%s = seconds";
            this.menuSecond.Click += new System.EventHandler(this.menuSecond_Click);
            // 
            // menuSeparator3
            // 
            this.menuSeparator3.Name = "menuSeparator3";
            this.menuSeparator3.Size = new System.Drawing.Size(212, 6);
            // 
            // menuSetDefault
            // 
            this.menuSetDefault.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menuSetDefault.Name = "menuSetDefault";
            this.menuSetDefault.Size = new System.Drawing.Size(215, 22);
            this.menuSetDefault.Text = "Set default template";
            this.menuSetDefault.Click += new System.EventHandler(this.menuSetDefault_Click);
            // 
            // menuSeparator4
            // 
            this.menuSeparator4.Name = "menuSeparator4";
            this.menuSeparator4.Size = new System.Drawing.Size(212, 6);
            // 
            // menuSortingHelp
            // 
            this.menuSortingHelp.Enabled = false;
            this.menuSortingHelp.Name = "menuSortingHelp";
            this.menuSortingHelp.ShowShortcutKeys = false;
            this.menuSortingHelp.Size = new System.Drawing.Size(215, 22);
            this.menuSortingHelp.Text = "For sorting by folders, use  \\ ";
            // 
            // menuSymbolsHelp
            // 
            this.menuSymbolsHelp.Enabled = false;
            this.menuSymbolsHelp.Name = "menuSymbolsHelp";
            this.menuSymbolsHelp.ShowShortcutKeys = false;
            this.menuSymbolsHelp.Size = new System.Drawing.Size(215, 22);
            this.menuSymbolsHelp.Text = "Can\'t use  /  :  *  ?  \"  <  >  |";
            // 
            // openDialog
            // 
            this.openDialog.Description = "VIN: Open folder";
            this.openDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // lastUseLabel
            // 
            this.lastUseLabel.AutoSize = true;
            this.lastUseLabel.Enabled = false;
            this.lastUseLabel.Location = new System.Drawing.Point(5, 435);
            this.lastUseLabel.Name = "lastUseLabel";
            this.lastUseLabel.Size = new System.Drawing.Size(53, 13);
            this.lastUseLabel.TabIndex = 99;
            this.lastUseLabel.Text = "Last use: ";
            // 
            // askChk
            // 
            this.askChk.AutoSize = true;
            this.askChk.Location = new System.Drawing.Point(25, 165);
            this.askChk.Name = "askChk";
            this.askChk.Size = new System.Drawing.Size(120, 17);
            this.askChk.TabIndex = 103;
            this.askChk.Text = "Ask before throwing";
            this.askChk.UseVisualStyleBackColor = true;
            // 
            // skipRadio
            // 
            this.skipRadio.AutoSize = true;
            this.skipRadio.Location = new System.Drawing.Point(44, 257);
            this.skipRadio.Name = "skipRadio";
            this.skipRadio.Size = new System.Drawing.Size(46, 17);
            this.skipRadio.TabIndex = 106;
            this.skipRadio.Text = "Skip";
            this.skipRadio.UseVisualStyleBackColor = true;
            // 
            // overwriteRadio
            // 
            this.overwriteRadio.AutoSize = true;
            this.overwriteRadio.Checked = true;
            this.overwriteRadio.Location = new System.Drawing.Point(96, 257);
            this.overwriteRadio.Name = "overwriteRadio";
            this.overwriteRadio.Size = new System.Drawing.Size(70, 17);
            this.overwriteRadio.TabIndex = 107;
            this.overwriteRadio.TabStop = true;
            this.overwriteRadio.Text = "Overwrite";
            this.overwriteRadio.UseVisualStyleBackColor = true;
            // 
            // historyChk
            // 
            this.historyChk.AutoSize = true;
            this.historyChk.Location = new System.Drawing.Point(25, 326);
            this.historyChk.Name = "historyChk";
            this.historyChk.Size = new System.Drawing.Size(101, 17);
            this.historyChk.TabIndex = 108;
            this.historyChk.Text = "Lead the history";
            this.tip.SetToolTip(this.historyChk, "The history file will be stored in each partition folder");
            this.historyChk.UseVisualStyleBackColor = true;
            this.historyChk.CheckStateChanged += new System.EventHandler(this.historyChk_CheckedChanged);
            // 
            // showMoveDialogChk
            // 
            this.showMoveDialogChk.AutoSize = true;
            this.showMoveDialogChk.Location = new System.Drawing.Point(25, 234);
            this.showMoveDialogChk.Name = "showMoveDialogChk";
            this.showMoveDialogChk.Size = new System.Drawing.Size(135, 17);
            this.showMoveDialogChk.TabIndex = 105;
            this.showMoveDialogChk.Text = "Show throwing window";
            this.showMoveDialogChk.UseVisualStyleBackColor = true;
            this.showMoveDialogChk.CheckStateChanged += new System.EventHandler(this.showMoveDialogChk_CheckedChanged);
            // 
            // checkFreeSpaceChk
            // 
            this.checkFreeSpaceChk.AutoSize = true;
            this.checkFreeSpaceChk.Location = new System.Drawing.Point(25, 188);
            this.checkFreeSpaceChk.Name = "checkFreeSpaceChk";
            this.checkFreeSpaceChk.Size = new System.Drawing.Size(149, 17);
            this.checkFreeSpaceChk.TabIndex = 104;
            this.checkFreeSpaceChk.Text = "Check free space (slower)";
            this.checkFreeSpaceChk.UseVisualStyleBackColor = true;
            // 
            // templateGroup
            // 
            this.templateGroup.Controls.Add(this.exampleLabel);
            this.templateGroup.Controls.Add(this.templateInfo);
            this.templateGroup.Controls.Add(this.templateBox);
            this.templateGroup.Location = new System.Drawing.Point(12, 68);
            this.templateGroup.Name = "templateGroup";
            this.templateGroup.Size = new System.Drawing.Size(380, 70);
            this.templateGroup.TabIndex = 102;
            this.templateGroup.TabStop = false;
            this.templateGroup.Text = " Template pattern ";
            // 
            // exampleLabel
            // 
            this.exampleLabel.AutoSize = true;
            this.exampleLabel.Enabled = false;
            this.exampleLabel.Location = new System.Drawing.Point(10, 47);
            this.exampleLabel.Name = "exampleLabel";
            this.exampleLabel.Size = new System.Drawing.Size(0, 13);
            this.exampleLabel.TabIndex = 9;
            // 
            // templateInfo
            // 
            this.templateInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.templateInfo.AutoSize = true;
            this.templateInfo.BackColor = System.Drawing.SystemColors.Window;
            this.templateInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.templateInfo.Location = new System.Drawing.Point(357, 22);
            this.templateInfo.Name = "templateInfo";
            this.templateInfo.Size = new System.Drawing.Size(13, 13);
            this.templateInfo.TabIndex = 6;
            this.templateInfo.Text = "?";
            this.tip.SetToolTip(this.templateInfo, "Template helper");
            this.templateInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.templateInfo_MouseDown);
            // 
            // templateBox
            // 
            this.templateBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.templateBox.Location = new System.Drawing.Point(6, 19);
            this.templateBox.Name = "templateBox";
            this.templateBox.Size = new System.Drawing.Size(368, 20);
            this.templateBox.TabIndex = 5;
            this.templateBox.TextChanged += new System.EventHandler(this.templateBox_TextChanged);
            // 
            // pathGroup
            // 
            this.pathGroup.Controls.Add(this.clearTargetHistoryBtn);
            this.pathGroup.Controls.Add(this.pathBox);
            this.pathGroup.Controls.Add(this.openDirBtn);
            this.pathGroup.Location = new System.Drawing.Point(12, 12);
            this.pathGroup.Name = "pathGroup";
            this.pathGroup.Size = new System.Drawing.Size(380, 50);
            this.pathGroup.TabIndex = 101;
            this.pathGroup.TabStop = false;
            this.pathGroup.Text = " Target path ";
            // 
            // clearTargetHistoryBtn
            // 
            this.clearTargetHistoryBtn.AccessibleDescription = "";
            this.clearTargetHistoryBtn.BackgroundImage = global::Garbage.Properties.Resources.clear;
            this.clearTargetHistoryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clearTargetHistoryBtn.Location = new System.Drawing.Point(6, 19);
            this.clearTargetHistoryBtn.Name = "clearTargetHistoryBtn";
            this.clearTargetHistoryBtn.Size = new System.Drawing.Size(25, 25);
            this.clearTargetHistoryBtn.TabIndex = 4;
            this.tip.SetToolTip(this.clearTargetHistoryBtn, "Clear target history");
            this.clearTargetHistoryBtn.UseVisualStyleBackColor = true;
            this.clearTargetHistoryBtn.Click += new System.EventHandler(this.clearTargetHistoryBtn_Click);
            // 
            // pathBox
            // 
            this.pathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.pathBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.pathBox.BackColor = System.Drawing.SystemColors.Window;
            this.pathBox.Location = new System.Drawing.Point(37, 22);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(303, 21);
            this.pathBox.TabIndex = 2;
            // 
            // openDirBtn
            // 
            this.openDirBtn.AccessibleDescription = "";
            this.openDirBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openDirBtn.Location = new System.Drawing.Point(346, 19);
            this.openDirBtn.Name = "openDirBtn";
            this.openDirBtn.Size = new System.Drawing.Size(30, 25);
            this.openDirBtn.TabIndex = 3;
            this.openDirBtn.Text = "...";
            this.tip.SetToolTip(this.openDirBtn, "Open directory");
            this.openDirBtn.UseVisualStyleBackColor = true;
            this.openDirBtn.Click += new System.EventHandler(this.openDirBtn_Click);
            // 
            // separator
            // 
            this.separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator.Location = new System.Drawing.Point(200, 385);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(195, 2);
            this.separator.TabIndex = 111;
            // 
            // showResultChk
            // 
            this.showResultChk.AutoSize = true;
            this.showResultChk.Location = new System.Drawing.Point(25, 303);
            this.showResultChk.Name = "showResultChk";
            this.showResultChk.Size = new System.Drawing.Size(81, 17);
            this.showResultChk.TabIndex = 0;
            this.showResultChk.Text = "Show result";
            this.tip.SetToolTip(this.showResultChk, "If enabled, the history will be written after clicking OK. ");
            this.showResultChk.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(220, 390);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 16;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(300, 390);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo.ErrorImage = null;
            this.logo.Image = global::Garbage.Properties.Resources.logo;
            this.logo.InitialImage = null;
            this.logo.Location = new System.Drawing.Point(200, 144);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(195, 238);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 112;
            this.logo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 452);
            this.Controls.Add(this.showResultChk);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.askChk);
            this.Controls.Add(this.skipRadio);
            this.Controls.Add(this.overwriteRadio);
            this.Controls.Add(this.historyChk);
            this.Controls.Add(this.showMoveDialogChk);
            this.Controls.Add(this.checkFreeSpaceChk);
            this.Controls.Add(this.templateGroup);
            this.Controls.Add(this.pathGroup);
            this.Controls.Add(this.lastUseLabel);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.waterMark);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.logo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIN: Garbage";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.templateMenu.ResumeLayout(false);
            this.templateGroup.ResumeLayout(false);
            this.templateGroup.PerformLayout();
            this.pathGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label waterMark;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.ContextMenuStrip templateMenu;
        private System.Windows.Forms.ToolStripMenuItem menuName;
        private System.Windows.Forms.ToolStripMenuItem menuExt;
        private System.Windows.Forms.ToolStripMenuItem menuYear;
        private System.Windows.Forms.ToolStripMenuItem menuMonth;
        private System.Windows.Forms.ToolStripSeparator menuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuSymbolsHelp;
        private System.Windows.Forms.ToolStripMenuItem menuSortingHelp;
        private System.Windows.Forms.FolderBrowserDialog openDialog;
        private System.Windows.Forms.Label lastUseLabel;
        private System.Windows.Forms.ToolStripMenuItem menuDay;
        private System.Windows.Forms.ToolStripSeparator menuSeparator2;
        private System.Windows.Forms.ToolStripSeparator menuSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuHour;
        private System.Windows.Forms.ToolStripMenuItem menuMinute;
        private System.Windows.Forms.ToolStripMenuItem menuSecond;
        private System.Windows.Forms.CheckBox askChk;
        private System.Windows.Forms.RadioButton skipRadio;
        private System.Windows.Forms.RadioButton overwriteRadio;
        private System.Windows.Forms.CheckBox historyChk;
        private System.Windows.Forms.CheckBox showMoveDialogChk;
        private System.Windows.Forms.CheckBox checkFreeSpaceChk;
        private System.Windows.Forms.GroupBox templateGroup;
        private System.Windows.Forms.Label exampleLabel;
        private System.Windows.Forms.Label templateInfo;
        private System.Windows.Forms.TextBox templateBox;
        private System.Windows.Forms.GroupBox pathGroup;
        private System.Windows.Forms.ComboBox pathBox;
        private System.Windows.Forms.Button openDirBtn;
        private System.Windows.Forms.Label separator;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.Button clearTargetHistoryBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ToolStripSeparator menuSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuSetDefault;
        private System.Windows.Forms.CheckBox showResultChk;
        private System.Windows.Forms.PictureBox logo;

    }
}

