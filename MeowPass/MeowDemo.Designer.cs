namespace MeowPass
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tagBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxHideUPass = new System.Windows.Forms.CheckBox();
            this.uPassBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.encryptBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.md5RButton = new System.Windows.Forms.RadioButton();
            this.shaRButton = new System.Windows.Forms.RadioButton();
            this.crcRButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.passBox = new System.Windows.Forms.TextBox();
            this.checkBoxHidePass = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.passUpDown = new System.Windows.Forms.NumericUpDown();
            this.buttonCopyToClipboard = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passUpDown)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.encryptBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(365, 210);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.tagBox, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(81, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(281, 28);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // tagBox
            // 
            this.tagBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tagBox.Location = new System.Drawing.Point(3, 3);
            this.tagBox.Name = "tagBox";
            this.tagBox.Size = new System.Drawing.Size(275, 25);
            this.tagBox.TabIndex = 0;
            this.tagBox.TextChanged += new System.EventHandler(this.TagBox_TextChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.19217F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.80783F));
            this.tableLayoutPanel5.Controls.Add(this.checkBoxHideUPass, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.uPassBox, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(81, 37);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(281, 28);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // checkBoxHideUPass
            // 
            this.checkBoxHideUPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxHideUPass.AutoSize = true;
            this.checkBoxHideUPass.Checked = true;
            this.checkBoxHideUPass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHideUPass.Font = new System.Drawing.Font("宋体", 7F);
            this.checkBoxHideUPass.Location = new System.Drawing.Point(188, 5);
            this.checkBoxHideUPass.Name = "checkBoxHideUPass";
            this.checkBoxHideUPass.Size = new System.Drawing.Size(90, 17);
            this.checkBoxHideUPass.TabIndex = 4;
            this.checkBoxHideUPass.Text = "隐藏密码";
            this.checkBoxHideUPass.UseVisualStyleBackColor = true;
            this.checkBoxHideUPass.CheckedChanged += new System.EventHandler(this.CheckBoxHideUPass_CheckedChanged);
            // 
            // uPassBox
            // 
            this.uPassBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uPassBox.Location = new System.Drawing.Point(3, 3);
            this.uPassBox.Name = "uPassBox";
            this.uPassBox.PasswordChar = '*';
            this.uPassBox.Size = new System.Drawing.Size(179, 25);
            this.uPassBox.TabIndex = 1;
            this.uPassBox.TextChanged += new System.EventHandler(this.UPassBox_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "密码位数";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "记忆标签";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "最终密码";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "记忆密码";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
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
            this.encryptBox.Location = new System.Drawing.Point(81, 73);
            this.encryptBox.Name = "encryptBox";
            this.encryptBox.Size = new System.Drawing.Size(281, 23);
            this.encryptBox.TabIndex = 6;
            this.encryptBox.SelectedIndexChanged += new System.EventHandler(this.EncryptBox_SelectedIndexChanged);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(81, 105);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(278, 28);
            this.tableLayoutPanel2.TabIndex = 7;
            this.tableLayoutPanel2.Click += new System.EventHandler(this.TableLayoutPanel2_Click);
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
            this.md5RButton.CheckedChanged += new System.EventHandler(this.Md5RButton_CheckedChanged);
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
            this.shaRButton.CheckedChanged += new System.EventHandler(this.ShaRButton_CheckedChanged);
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
            this.crcRButton.CheckedChanged += new System.EventHandler(this.CrcRButton_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.54676F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.45324F));
            this.tableLayoutPanel3.Controls.Add(this.passBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxHidePass, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(81, 139);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(278, 28);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // passBox
            // 
            this.passBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passBox.Location = new System.Drawing.Point(3, 3);
            this.passBox.Name = "passBox";
            this.passBox.ReadOnly = true;
            this.passBox.Size = new System.Drawing.Size(178, 25);
            this.passBox.TabIndex = 2;
            // 
            // checkBoxHidePass
            // 
            this.checkBoxHidePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxHidePass.AutoSize = true;
            this.checkBoxHidePass.Font = new System.Drawing.Font("宋体", 7F);
            this.checkBoxHidePass.Location = new System.Drawing.Point(187, 5);
            this.checkBoxHidePass.Name = "checkBoxHidePass";
            this.checkBoxHidePass.Size = new System.Drawing.Size(88, 17);
            this.checkBoxHidePass.TabIndex = 3;
            this.checkBoxHidePass.Text = "隐藏密码";
            this.checkBoxHidePass.UseVisualStyleBackColor = true;
            this.checkBoxHidePass.CheckedChanged += new System.EventHandler(this.CheckBoxHidePass_CheckedChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.54676F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.45324F));
            this.tableLayoutPanel4.Controls.Add(this.passUpDown, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(81, 173);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(278, 29);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // passUpDown
            // 
            this.passUpDown.Location = new System.Drawing.Point(3, 3);
            this.passUpDown.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.passUpDown.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.passUpDown.Name = "passUpDown";
            this.passUpDown.Size = new System.Drawing.Size(178, 25);
            this.passUpDown.TabIndex = 9;
            this.passUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.passUpDown.ValueChanged += new System.EventHandler(this.PassUpDown_ValueChanged);
            // 
            // buttonCopyToClipboard
            // 
            this.buttonCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyToClipboard.Location = new System.Drawing.Point(13, 232);
            this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
            this.buttonCopyToClipboard.Size = new System.Drawing.Size(365, 23);
            this.buttonCopyToClipboard.TabIndex = 2;
            this.buttonCopyToClipboard.Text = "复制到剪贴板";
            this.buttonCopyToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyToClipboard.Click += new System.EventHandler(this.ButtonCopy_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(0, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 35);
            this.label5.TabIndex = 3;
            this.label5.Text = "[或按下Ctrl+Alt+Enter模拟键入]";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.DoubleClick += new System.EventHandler(this.label5_DoubleClick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Text = "MeowPass";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.BackColor = System.Drawing.Color.Transparent;
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemShow,
            this.menuItemAbout,
            this.toolStripSeparator1,
            this.menuItemExit});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenu.Size = new System.Drawing.Size(124, 82);
            // 
            // menuItemShow
            // 
            this.menuItemShow.Name = "menuItemShow";
            this.menuItemShow.Size = new System.Drawing.Size(123, 24);
            this.menuItemShow.Text = "最小化";
            this.menuItemShow.Click += new System.EventHandler(this.MenuItemShow_Click);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(123, 24);
            this.menuItemAbout.Text = "关于";
            this.menuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(123, 24);
            this.menuItemExit.Text = "退出";
            this.menuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // MeowDemo
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(390, 288);
            this.Controls.Add(this.buttonCopyToClipboard);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MeowDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeowDemo";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.MeowDemo_Activated);
            this.Deactivate += new System.EventHandler(this.MeowDemo_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MeowDemo_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.MeowDemo_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passUpDown)).EndInit();
            this.contextMenu.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton md5RButton;
        private System.Windows.Forms.RadioButton shaRButton;
        private System.Windows.Forms.RadioButton crcRButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox checkBoxHidePass;
        private System.Windows.Forms.Button buttonCopyToClipboard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemShow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown passUpDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckBox checkBoxHideUPass;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
    }
}

