﻿namespace GinClientApp.Dialogs
{
    partial class ServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serverAlias = new System.Windows.Forms.Label();
            this.webGBx = new System.Windows.Forms.GroupBox();
            this.cBxWebPort = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBxWebHostname = new System.Windows.Forms.TextBox();
            this.cBxWebProtocol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBxGitHostname = new System.Windows.Forms.TextBox();
            this.cBxGitUser = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cBxGitPort = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.webGBx.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 31);
            this.textBox1.TabIndex = 0;
            // 
            // serverAlias
            // 
            this.serverAlias.AutoSize = true;
            this.serverAlias.Location = new System.Drawing.Point(34, 42);
            this.serverAlias.Name = "serverAlias";
            this.serverAlias.Size = new System.Drawing.Size(128, 25);
            this.serverAlias.TabIndex = 1;
            this.serverAlias.Text = "Server Alias";
            // 
            // webGBx
            // 
            this.webGBx.Controls.Add(this.cBxWebPort);
            this.webGBx.Controls.Add(this.label4);
            this.webGBx.Controls.Add(this.label3);
            this.webGBx.Controls.Add(this.tBxWebHostname);
            this.webGBx.Controls.Add(this.cBxWebProtocol);
            this.webGBx.Controls.Add(this.label1);
            this.webGBx.Location = new System.Drawing.Point(41, 86);
            this.webGBx.Name = "webGBx";
            this.webGBx.Size = new System.Drawing.Size(747, 162);
            this.webGBx.TabIndex = 2;
            this.webGBx.TabStop = false;
            this.webGBx.Text = "Web";
            // 
            // cBxWebPort
            // 
            this.cBxWebPort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBxWebPort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBxWebPort.FormattingEnabled = true;
            this.cBxWebPort.Items.AddRange(new object[] {
            "80",
            "443"});
            this.cBxWebPort.Location = new System.Drawing.Point(146, 103);
            this.cBxWebPort.Name = "cBxWebPort";
            this.cBxWebPort.Size = new System.Drawing.Size(121, 33);
            this.cBxWebPort.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hostname";
            // 
            // tBxWebHostname
            // 
            this.tBxWebHostname.Location = new System.Drawing.Point(146, 65);
            this.tBxWebHostname.Name = "tBxWebHostname";
            this.tBxWebHostname.Size = new System.Drawing.Size(289, 31);
            this.tBxWebHostname.TabIndex = 5;
            // 
            // cBxWebProtocol
            // 
            this.cBxWebProtocol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBxWebProtocol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBxWebProtocol.FormattingEnabled = true;
            this.cBxWebProtocol.Items.AddRange(new object[] {
            "http",
            "https"});
            this.cBxWebProtocol.Location = new System.Drawing.Point(146, 26);
            this.cBxWebProtocol.Name = "cBxWebProtocol";
            this.cBxWebProtocol.Size = new System.Drawing.Size(147, 33);
            this.cBxWebProtocol.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Protocol";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBxGitPort);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cBxGitUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tBxGitHostname);
            this.groupBox1.Location = new System.Drawing.Point(41, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 205);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Git";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "User name";
            // 
            // tBxGitHostname
            // 
            this.tBxGitHostname.Location = new System.Drawing.Point(146, 78);
            this.tBxGitHostname.Name = "tBxGitHostname";
            this.tBxGitHostname.Size = new System.Drawing.Size(525, 31);
            this.tBxGitHostname.TabIndex = 0;
            // 
            // cBxGitUser
            // 
            this.cBxGitUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBxGitUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBxGitUser.FormattingEnabled = true;
            this.cBxGitUser.Items.AddRange(new object[] {
            "git"});
            this.cBxGitUser.Location = new System.Drawing.Point(146, 30);
            this.cBxGitUser.Name = "cBxGitUser";
            this.cBxGitUser.Size = new System.Drawing.Size(121, 33);
            this.cBxGitUser.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hostname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Port";
            // 
            // cBxGitPort
            // 
            this.cBxGitPort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBxGitPort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBxGitPort.FormattingEnabled = true;
            this.cBxGitPort.Items.AddRange(new object[] {
            "22",
            "2222"});
            this.cBxGitPort.Location = new System.Drawing.Point(146, 118);
            this.cBxGitPort.Name = "cBxGitPort";
            this.cBxGitPort.Size = new System.Drawing.Size(121, 33);
            this.cBxGitPort.TabIndex = 10;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(41, 587);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(148, 62);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(239, 587);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(148, 62);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 688);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webGBx);
            this.Controls.Add(this.serverAlias);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServerForm";
            this.Text = "Add Gin Server ";
            this.TopMost = true;
            this.webGBx.ResumeLayout(false);
            this.webGBx.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label serverAlias;
        private System.Windows.Forms.GroupBox webGBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBxGitHostname;
        private System.Windows.Forms.ComboBox cBxWebProtocol;
        private System.Windows.Forms.ComboBox cBxWebPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBxWebHostname;
        private System.Windows.Forms.ComboBox cBxGitUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBxGitPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}