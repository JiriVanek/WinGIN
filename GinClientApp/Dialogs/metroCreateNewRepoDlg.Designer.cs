﻿namespace GinClientApp.Dialogs
{
    partial class MetroCreateNewRepoDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetroCreateNewRepoDlg));
            this.mBtnPickRepoMountpointDir = new MetroFramework.Controls.MetroButton();
            this.mBtnPickRepoCheckoutDir = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mTxBRepoAddress = new MetroFramework.Controls.MetroTextBox();
            this.mTxBRepoMountpoint = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mTxBRepoCheckoutDir = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mTxBRepoName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mBtnOK = new MetroFramework.Controls.MetroButton();
            this.mBtnCancel = new MetroFramework.Controls.MetroButton();
            this.mBtnRepoBrowser = new MetroFramework.Controls.MetroButton();
            this.createNewRepoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // mBtnPickRepoMountpointDir
            // 
            this.mBtnPickRepoMountpointDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnPickRepoMountpointDir.Location = new System.Drawing.Point(1032, 225);
            this.mBtnPickRepoMountpointDir.Margin = new System.Windows.Forms.Padding(6);
            this.mBtnPickRepoMountpointDir.Name = "mBtnPickRepoMountpointDir";
            this.mBtnPickRepoMountpointDir.Size = new System.Drawing.Size(44, 44);
            this.mBtnPickRepoMountpointDir.TabIndex = 4;
            this.mBtnPickRepoMountpointDir.Text = "...";
            this.mBtnPickRepoMountpointDir.UseSelectable = true;
            this.mBtnPickRepoMountpointDir.Click += new System.EventHandler(this.mBtnPickRepoMountpointDir_Click);
            // 
            // mBtnPickRepoCheckoutDir
            // 
            this.mBtnPickRepoCheckoutDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnPickRepoCheckoutDir.Location = new System.Drawing.Point(1032, 171);
            this.mBtnPickRepoCheckoutDir.Margin = new System.Windows.Forms.Padding(6);
            this.mBtnPickRepoCheckoutDir.Name = "mBtnPickRepoCheckoutDir";
            this.mBtnPickRepoCheckoutDir.Size = new System.Drawing.Size(44, 44);
            this.mBtnPickRepoCheckoutDir.TabIndex = 3;
            this.mBtnPickRepoCheckoutDir.Text = "...";
            this.mBtnPickRepoCheckoutDir.UseSelectable = true;
            this.mBtnPickRepoCheckoutDir.Click += new System.EventHandler(this.mBtnPickRepoCheckoutDir_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(46, 115);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 19);
            this.metroLabel1.TabIndex = 31;
            this.metroLabel1.Text = "Repository Address";
            // 
            // mTxBRepoAddress
            // 
            this.mTxBRepoAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mTxBRepoAddress.CustomButton.Image = null;
            this.mTxBRepoAddress.CustomButton.Location = new System.Drawing.Point(674, 2);
            this.mTxBRepoAddress.CustomButton.Margin = new System.Windows.Forms.Padding(6);
            this.mTxBRepoAddress.CustomButton.Name = "";
            this.mTxBRepoAddress.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.mTxBRepoAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxBRepoAddress.CustomButton.TabIndex = 1;
            this.mTxBRepoAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxBRepoAddress.CustomButton.UseSelectable = true;
            this.mTxBRepoAddress.CustomButton.Visible = false;
            this.mTxBRepoAddress.Lines = new string[] {
        "metroTextBox5"};
            this.mTxBRepoAddress.Location = new System.Drawing.Point(304, 115);
            this.mTxBRepoAddress.Margin = new System.Windows.Forms.Padding(6);
            this.mTxBRepoAddress.MaxLength = 32767;
            this.mTxBRepoAddress.Name = "mTxBRepoAddress";
            this.mTxBRepoAddress.PasswordChar = '\0';
            this.mTxBRepoAddress.WaterMark= "<username>/<repository>";
            this.mTxBRepoAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxBRepoAddress.SelectedText = "";
            this.mTxBRepoAddress.SelectionLength = 0;
            this.mTxBRepoAddress.SelectionStart = 0;
            this.mTxBRepoAddress.ShortcutsEnabled = true;
            this.mTxBRepoAddress.Size = new System.Drawing.Size(716, 44);
            this.mTxBRepoAddress.TabIndex = 1;
            this.mTxBRepoAddress.Text = "metroTextBox5";
            this.mTxBRepoAddress.UseSelectable = true;
            this.mTxBRepoAddress.WaterMark = "<username>/<repository>";
            this.mTxBRepoAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxBRepoAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mTxBRepoAddress.TextChanged += new System.EventHandler(this.mTxBRepoAddress_TextChanged);
            this.mTxBRepoAddress.Leave += new System.EventHandler(this.mTxBRepoAddress_Leave);
            // 
            // mTxBRepoMountpoint
            // 
            this.mTxBRepoMountpoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mTxBRepoMountpoint.CustomButton.Image = null;
            this.mTxBRepoMountpoint.CustomButton.Location = new System.Drawing.Point(674, 2);
            this.mTxBRepoMountpoint.CustomButton.Margin = new System.Windows.Forms.Padding(6);
            this.mTxBRepoMountpoint.CustomButton.Name = "";
            this.mTxBRepoMountpoint.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.mTxBRepoMountpoint.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxBRepoMountpoint.CustomButton.TabIndex = 1;
            this.mTxBRepoMountpoint.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxBRepoMountpoint.CustomButton.UseSelectable = true;
            this.mTxBRepoMountpoint.CustomButton.Visible = false;
            this.mTxBRepoMountpoint.Lines = new string[] {
        "metroTextBox4"};
            this.mTxBRepoMountpoint.Location = new System.Drawing.Point(304, 225);
            this.mTxBRepoMountpoint.Margin = new System.Windows.Forms.Padding(6);
            this.mTxBRepoMountpoint.MaxLength = 32767;
            this.mTxBRepoMountpoint.Name = "mTxBRepoMountpoint";
            this.mTxBRepoMountpoint.PasswordChar = '\0';
            this.mTxBRepoMountpoint.ReadOnly = true;
            this.mTxBRepoMountpoint.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxBRepoMountpoint.SelectedText = "";
            this.mTxBRepoMountpoint.SelectionLength = 0;
            this.mTxBRepoMountpoint.SelectionStart = 0;
            this.mTxBRepoMountpoint.ShortcutsEnabled = true;
            this.mTxBRepoMountpoint.Size = new System.Drawing.Size(716, 44);
            this.mTxBRepoMountpoint.TabIndex = 29;
            this.mTxBRepoMountpoint.TabStop = false;
            this.mTxBRepoMountpoint.Text = "metroTextBox4";
            this.mTxBRepoMountpoint.UseSelectable = true;
            this.mTxBRepoMountpoint.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxBRepoMountpoint.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(46, 225);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "Mountpoint";
            // 
            // mTxBRepoCheckoutDir
            // 
            this.mTxBRepoCheckoutDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mTxBRepoCheckoutDir.CustomButton.Image = null;
            this.mTxBRepoCheckoutDir.CustomButton.Location = new System.Drawing.Point(674, 2);
            this.mTxBRepoCheckoutDir.CustomButton.Margin = new System.Windows.Forms.Padding(6);
            this.mTxBRepoCheckoutDir.CustomButton.Name = "";
            this.mTxBRepoCheckoutDir.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.mTxBRepoCheckoutDir.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxBRepoCheckoutDir.CustomButton.TabIndex = 1;
            this.mTxBRepoCheckoutDir.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxBRepoCheckoutDir.CustomButton.UseSelectable = true;
            this.mTxBRepoCheckoutDir.CustomButton.Visible = false;
            this.mTxBRepoCheckoutDir.Lines = new string[] {
        "metroTextBox3"};
            this.mTxBRepoCheckoutDir.Location = new System.Drawing.Point(304, 171);
            this.mTxBRepoCheckoutDir.Margin = new System.Windows.Forms.Padding(6);
            this.mTxBRepoCheckoutDir.MaxLength = 32767;
            this.mTxBRepoCheckoutDir.Name = "mTxBRepoCheckoutDir";
            this.mTxBRepoCheckoutDir.PasswordChar = '\0';
            this.mTxBRepoCheckoutDir.ReadOnly = true;
            this.mTxBRepoCheckoutDir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxBRepoCheckoutDir.SelectedText = "";
            this.mTxBRepoCheckoutDir.SelectionLength = 0;
            this.mTxBRepoCheckoutDir.SelectionStart = 0;
            this.mTxBRepoCheckoutDir.ShortcutsEnabled = true;
            this.mTxBRepoCheckoutDir.Size = new System.Drawing.Size(716, 44);
            this.mTxBRepoCheckoutDir.TabIndex = 27;
            this.mTxBRepoCheckoutDir.TabStop = false;
            this.mTxBRepoCheckoutDir.Text = "metroTextBox3";
            this.mTxBRepoCheckoutDir.UseSelectable = true;
            this.mTxBRepoCheckoutDir.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxBRepoCheckoutDir.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(46, 171);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(121, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Checkout Directory";
            // 
            // mTxBRepoName
            // 
            this.mTxBRepoName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mTxBRepoName.CustomButton.Image = null;
            this.mTxBRepoName.CustomButton.Location = new System.Drawing.Point(730, 2);
            this.mTxBRepoName.CustomButton.Margin = new System.Windows.Forms.Padding(6);
            this.mTxBRepoName.CustomButton.Name = "";
            this.mTxBRepoName.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.mTxBRepoName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxBRepoName.CustomButton.TabIndex = 1;
            this.mTxBRepoName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxBRepoName.CustomButton.UseSelectable = true;
            this.mTxBRepoName.CustomButton.Visible = false;
            this.mTxBRepoName.Lines = new string[] {
        "metroTextBox2"};
            this.mTxBRepoName.Location = new System.Drawing.Point(304, 281);
            this.mTxBRepoName.Margin = new System.Windows.Forms.Padding(6);
            this.mTxBRepoName.MaxLength = 32767;
            this.mTxBRepoName.Name = "mTxBRepoName";
            this.mTxBRepoName.PasswordChar = '\0';
            this.mTxBRepoName.ReadOnly = true;
            this.mTxBRepoName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxBRepoName.SelectedText = "";
            this.mTxBRepoName.SelectionLength = 0;
            this.mTxBRepoName.SelectionStart = 0;
            this.mTxBRepoName.ShortcutsEnabled = true;
            this.mTxBRepoName.Size = new System.Drawing.Size(772, 44);
            this.mTxBRepoName.TabIndex = 5;
            this.mTxBRepoName.Text = "metroTextBox2";
            this.mTxBRepoName.UseSelectable = true;
            this.mTxBRepoName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxBRepoName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mTxBRepoName.TextChanged += new System.EventHandler(this.mTxBRepoName_TextChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(46, 281);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Name";
            // 
            // mBtnOK
            // 
            this.mBtnOK.Location = new System.Drawing.Point(50, 354);
            this.mBtnOK.Margin = new System.Windows.Forms.Padding(6);
            this.mBtnOK.Name = "mBtnOK";
            this.mBtnOK.Size = new System.Drawing.Size(150, 44);
            this.mBtnOK.TabIndex = 6;
            this.mBtnOK.Text = "OK";
            this.mBtnOK.UseSelectable = true;
            this.mBtnOK.Click += new System.EventHandler(this.mBtnOK_Click);
            // 
            // mBtnCancel
            // 
            this.mBtnCancel.Location = new System.Drawing.Point(212, 354);
            this.mBtnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.mBtnCancel.Name = "mBtnCancel";
            this.mBtnCancel.Size = new System.Drawing.Size(150, 44);
            this.mBtnCancel.TabIndex = 7;
            this.mBtnCancel.Text = "Cancel";
            this.mBtnCancel.UseSelectable = true;
            this.mBtnCancel.Click += new System.EventHandler(this.mBtnCancel_Click);
            // 
            // mBtnRepoBrowser
            // 
            this.mBtnRepoBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnRepoBrowser.Location = new System.Drawing.Point(1032, 115);
            this.mBtnRepoBrowser.Margin = new System.Windows.Forms.Padding(6);
            this.mBtnRepoBrowser.Name = "mBtnRepoBrowser";
            this.mBtnRepoBrowser.Size = new System.Drawing.Size(44, 44);
            this.mBtnRepoBrowser.TabIndex = 2;
            this.mBtnRepoBrowser.Text = "...";
            this.mBtnRepoBrowser.UseSelectable = true;
            this.mBtnRepoBrowser.Click += new System.EventHandler(this.mBtnRepoBrowser_Click);
            // 
            // MetroCreateNewRepoDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 419);
            this.Controls.Add(this.mBtnRepoBrowser);
            this.Controls.Add(this.mBtnCancel);
            this.Controls.Add(this.mBtnOK);
            this.Controls.Add(this.mBtnPickRepoMountpointDir);
            this.Controls.Add(this.mBtnPickRepoCheckoutDir);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mTxBRepoAddress);
            this.Controls.Add(this.mTxBRepoMountpoint);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mTxBRepoCheckoutDir);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mTxBRepoName);
            this.Controls.Add(this.metroLabel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MetroCreateNewRepoDlg";
            this.Padding = new System.Windows.Forms.Padding(40, 115, 40, 38);
            this.Text = "Please enter Repository details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton mBtnPickRepoMountpointDir;
        private MetroFramework.Controls.MetroButton mBtnPickRepoCheckoutDir;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mTxBRepoAddress;
        private MetroFramework.Controls.MetroTextBox mTxBRepoMountpoint;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mTxBRepoCheckoutDir;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mTxBRepoName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton mBtnOK;
        private MetroFramework.Controls.MetroButton mBtnCancel;
        private MetroFramework.Controls.MetroButton mBtnRepoBrowser;
        private System.Windows.Forms.ToolTip createNewRepoToolTip;
    }
}