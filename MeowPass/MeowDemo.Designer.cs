﻿namespace MeowPass
{
    partial class MeowDemo
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tagBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uPassBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.encryptBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.md5RButton = new System.Windows.Forms.RadioButton();
            this.shaRButton = new System.Windows.Forms.RadioButton();
            this.crcRButton = new System.Windows.Forms.RadioButton();
            this.meowButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxHidePass = new System.Windows.Forms.CheckBox();
            this.buttonCopyToClipboard = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tagBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.uPassBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.encryptBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(365, 173);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tagBox
            // 
            this.tagBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tagBox.Location = new System.Drawing.Point(84, 4);
            this.tagBox.Name = "tagBox";
            this.tagBox.Size = new System.Drawing.Size(278, 25);
            this.tagBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "记忆标签";
            // 
            // passBox
            // 
            this.passBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passBox.Location = new System.Drawing.Point(3, 3);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(178, 25);
            this.passBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "最终密码";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "记忆密码";
            // 
            // uPassBox
            // 
            this.uPassBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uPassBox.Location = new System.Drawing.Point(84, 38);
            this.uPassBox.Name = "uPassBox";
            this.uPassBox.PasswordChar = '*';
            this.uPassBox.Size = new System.Drawing.Size(278, 25);
            this.uPassBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "加密算法";
            // 
            // encryptBox
            // 
            this.encryptBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.encryptBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encryptBox.FormattingEnabled = true;
            this.encryptBox.Items.AddRange(new object[] {
            "DES",
            "TripleDES",
            "AES",
            "RC2",
            "BlowFish"});
            this.encryptBox.Location = new System.Drawing.Point(84, 73);
            this.encryptBox.Name = "encryptBox";
            this.encryptBox.Size = new System.Drawing.Size(278, 23);
            this.encryptBox.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.md5RButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.shaRButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.crcRButton, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(84, 105);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(278, 28);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // md5RButton
            // 
            this.md5RButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.md5RButton.AutoSize = true;
            this.md5RButton.Checked = true;
            this.md5RButton.Location = new System.Drawing.Point(3, 4);
            this.md5RButton.Name = "md5RButton";
            this.md5RButton.Size = new System.Drawing.Size(86, 19);
            this.md5RButton.TabIndex = 0;
            this.md5RButton.TabStop = true;
            this.md5RButton.Text = "MD5";
            this.md5RButton.UseVisualStyleBackColor = true;
            // 
            // shaRButton
            // 
            this.shaRButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.shaRButton.AutoSize = true;
            this.shaRButton.Location = new System.Drawing.Point(95, 4);
            this.shaRButton.Name = "shaRButton";
            this.shaRButton.Size = new System.Drawing.Size(86, 19);
            this.shaRButton.TabIndex = 1;
            this.shaRButton.Text = "SHA";
            this.shaRButton.UseVisualStyleBackColor = true;
            // 
            // crcRButton
            // 
            this.crcRButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.crcRButton.AutoSize = true;
            this.crcRButton.Location = new System.Drawing.Point(187, 4);
            this.crcRButton.Name = "crcRButton";
            this.crcRButton.Size = new System.Drawing.Size(88, 19);
            this.crcRButton.TabIndex = 2;
            this.crcRButton.Text = "CRC";
            this.crcRButton.UseVisualStyleBackColor = true;
            // 
            // meowButton
            // 
            this.meowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.meowButton.Location = new System.Drawing.Point(13, 192);
            this.meowButton.Name = "meowButton";
            this.meowButton.Size = new System.Drawing.Size(365, 23);
            this.meowButton.TabIndex = 1;
            this.meowButton.Text = "喵！";
            this.meowButton.UseVisualStyleBackColor = true;
            this.meowButton.Click += new System.EventHandler(this.meowButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.54676F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.45324F));
            this.tableLayoutPanel3.Controls.Add(this.passBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxHidePass, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(84, 139);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(278, 31);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // checkBoxHidePass
            // 
            this.checkBoxHidePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxHidePass.AutoSize = true;
            this.checkBoxHidePass.Checked = true;
            this.checkBoxHidePass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHidePass.Font = new System.Drawing.Font("宋体", 7F);
            this.checkBoxHidePass.Location = new System.Drawing.Point(187, 7);
            this.checkBoxHidePass.Name = "checkBoxHidePass";
            this.checkBoxHidePass.Size = new System.Drawing.Size(88, 17);
            this.checkBoxHidePass.TabIndex = 3;
            this.checkBoxHidePass.Text = "隐藏密码";
            this.checkBoxHidePass.UseVisualStyleBackColor = true;
            this.checkBoxHidePass.CheckedChanged += new System.EventHandler(this.checkBoxHidePass_CheckedChanged);
            // 
            // buttonCopyToClipboard
            // 
            this.buttonCopyToClipboard.Location = new System.Drawing.Point(13, 221);
            this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
            this.buttonCopyToClipboard.Size = new System.Drawing.Size(365, 23);
            this.buttonCopyToClipboard.TabIndex = 2;
            this.buttonCopyToClipboard.Text = "复制到剪贴板";
            this.buttonCopyToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyToClipboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(0, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 35);
            this.label5.TabIndex = 3;
            this.label5.Text = "[或按下Ctrl+Alt+Enter模拟键入]";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MeowDemo
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 274);
            this.Controls.Add(this.buttonCopyToClipboard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.meowButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MeowDemo";
            this.Text = "MeowDemo";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MeowDemo_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tagBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uPassBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox encryptBox;
        private System.Windows.Forms.Button meowButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton md5RButton;
        private System.Windows.Forms.RadioButton shaRButton;
        private System.Windows.Forms.RadioButton crcRButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox checkBoxHidePass;
        private System.Windows.Forms.Button buttonCopyToClipboard;
        private System.Windows.Forms.Label label5;
    }
}

