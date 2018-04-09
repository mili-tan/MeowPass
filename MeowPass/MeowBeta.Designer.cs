namespace MeowPass
{
    partial class MeowBeta
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "DES"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("TripleDES");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("AES");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("RC2");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("BlowFish");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeowBeta));
            this.uPassBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tagBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.encryptList = new MaterialSkin.Controls.MaterialListView();
            this.encryptColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelHashEncrypt = new System.Windows.Forms.TableLayoutPanel();
            this.CRCRButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.MD5RButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.SHARButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.panelMain = new System.Windows.Forms.TableLayoutPanel();
            this.divider1 = new MaterialSkin.Controls.MaterialDivider();
            this.panelPassInput = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxKey = new System.Windows.Forms.PictureBox();
            this.pictureBoxTag = new System.Windows.Forms.PictureBox();
            this.panelCopyButton = new System.Windows.Forms.Panel();
            this.copyButton = new System.Windows.Forms.PictureBox();
            this.labelTips = new System.Windows.Forms.Label();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelPassGen = new System.Windows.Forms.TableLayoutPanel();
            this.passCount = new System.Windows.Forms.Label();
            this.endPassBox = new System.Windows.Forms.TextBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelHashEncrypt.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelPassInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTag)).BeginInit();
            this.panelCopyButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copyButton)).BeginInit();
            this.panelPassGen.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uPassBox
            // 
            this.uPassBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uPassBox.Depth = 0;
            this.uPassBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uPassBox.Hint = " 记忆密码";
            this.uPassBox.Location = new System.Drawing.Point(42, 65);
            this.uPassBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uPassBox.MaxLength = 32767;
            this.uPassBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.uPassBox.Name = "uPassBox";
            this.uPassBox.PasswordChar = '*';
            this.uPassBox.SelectedText = "";
            this.uPassBox.SelectionLength = 0;
            this.uPassBox.SelectionStart = 0;
            this.uPassBox.Size = new System.Drawing.Size(324, 29);
            this.uPassBox.TabIndex = 1;
            this.uPassBox.TabStop = false;
            this.uPassBox.UseSystemPasswordChar = false;
            // 
            // tagBox
            // 
            this.tagBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tagBox.Depth = 0;
            this.tagBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagBox.Hint = " 记忆标签";
            this.tagBox.Location = new System.Drawing.Point(42, 12);
            this.tagBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tagBox.MaxLength = 32767;
            this.tagBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.tagBox.Name = "tagBox";
            this.tagBox.PasswordChar = '\0';
            this.tagBox.SelectedText = "";
            this.tagBox.SelectionLength = 0;
            this.tagBox.SelectionStart = 0;
            this.tagBox.Size = new System.Drawing.Size(324, 29);
            this.tagBox.TabIndex = 0;
            this.tagBox.TabStop = false;
            this.tagBox.UseSystemPasswordChar = false;
            // 
            // encryptList
            // 
            this.encryptList.AutoArrange = false;
            this.encryptList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.encryptList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.encryptColumnHeader});
            this.encryptList.Depth = 0;
            this.encryptList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptList.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(134)));
            this.encryptList.FullRowSelect = true;
            this.encryptList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.encryptList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.encryptList.Location = new System.Drawing.Point(3, 188);
            this.encryptList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.encryptList.MaximumSize = new System.Drawing.Size(371, 354);
            this.encryptList.MinimumSize = new System.Drawing.Size(371, 354);
            this.encryptList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.encryptList.MouseState = MaterialSkin.MouseState.OUT;
            this.encryptList.MultiSelect = false;
            this.encryptList.Name = "encryptList";
            this.encryptList.OwnerDraw = true;
            this.encryptList.Scrollable = false;
            this.encryptList.ShowGroups = false;
            this.encryptList.Size = new System.Drawing.Size(371, 354);
            this.encryptList.TabIndex = 2;
            this.encryptList.UseCompatibleStateImageBehavior = false;
            this.encryptList.View = System.Windows.Forms.View.Details;
            // 
            // encryptColumnHeader
            // 
            this.encryptColumnHeader.Width = 370;
            // 
            // panelHashEncrypt
            // 
            this.panelHashEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHashEncrypt.ColumnCount = 3;
            this.panelHashEncrypt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelHashEncrypt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelHashEncrypt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelHashEncrypt.Controls.Add(this.CRCRButton, 2, 0);
            this.panelHashEncrypt.Controls.Add(this.MD5RButton, 0, 0);
            this.panelHashEncrypt.Controls.Add(this.SHARButton, 1, 0);
            this.panelHashEncrypt.Location = new System.Drawing.Point(46, 125);
            this.panelHashEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHashEncrypt.Name = "panelHashEncrypt";
            this.panelHashEncrypt.RowCount = 1;
            this.panelHashEncrypt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelHashEncrypt.Size = new System.Drawing.Size(327, 59);
            this.panelHashEncrypt.TabIndex = 8;
            // 
            // CRCRButton
            // 
            this.CRCRButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CRCRButton.AutoSize = true;
            this.CRCRButton.Depth = 0;
            this.CRCRButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.CRCRButton.Location = new System.Drawing.Point(218, 14);
            this.CRCRButton.Margin = new System.Windows.Forms.Padding(0);
            this.CRCRButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CRCRButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CRCRButton.Name = "CRCRButton";
            this.CRCRButton.Ripple = true;
            this.CRCRButton.Size = new System.Drawing.Size(109, 30);
            this.CRCRButton.TabIndex = 5;
            this.CRCRButton.Text = "CRC";
            this.CRCRButton.UseVisualStyleBackColor = true;
            // 
            // MD5RButton
            // 
            this.MD5RButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MD5RButton.AutoSize = true;
            this.MD5RButton.Checked = true;
            this.MD5RButton.Depth = 0;
            this.MD5RButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.MD5RButton.Location = new System.Drawing.Point(0, 14);
            this.MD5RButton.Margin = new System.Windows.Forms.Padding(0);
            this.MD5RButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MD5RButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.MD5RButton.Name = "MD5RButton";
            this.MD5RButton.Ripple = true;
            this.MD5RButton.Size = new System.Drawing.Size(109, 30);
            this.MD5RButton.TabIndex = 3;
            this.MD5RButton.TabStop = true;
            this.MD5RButton.Text = "MD5";
            this.MD5RButton.UseVisualStyleBackColor = true;
            // 
            // SHARButton
            // 
            this.SHARButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SHARButton.AutoSize = true;
            this.SHARButton.Depth = 0;
            this.SHARButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.SHARButton.Location = new System.Drawing.Point(109, 14);
            this.SHARButton.Margin = new System.Windows.Forms.Padding(0);
            this.SHARButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SHARButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SHARButton.Name = "SHARButton";
            this.SHARButton.Ripple = true;
            this.SHARButton.Size = new System.Drawing.Size(109, 30);
            this.SHARButton.TabIndex = 4;
            this.SHARButton.Text = "SHA";
            this.SHARButton.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.ColumnCount = 1;
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.06728F));
            this.panelMain.Controls.Add(this.panelHashEncrypt, 0, 2);
            this.panelMain.Controls.Add(this.divider1, 0, 1);
            this.panelMain.Controls.Add(this.panelPassInput, 0, 0);
            this.panelMain.Controls.Add(this.encryptList, 0, 3);
            this.panelMain.Location = new System.Drawing.Point(11, 69);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.RowCount = 4;
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 365F));
            this.panelMain.Size = new System.Drawing.Size(376, 551);
            this.panelMain.TabIndex = 0;
            // 
            // divider1
            // 
            this.divider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.divider1.Depth = 0;
            this.divider1.Location = new System.Drawing.Point(3, 115);
            this.divider1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.divider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(369, 1);
            this.divider1.TabIndex = 10;
            this.divider1.Text = "materialDivider1";
            // 
            // panelPassInput
            // 
            this.panelPassInput.ColumnCount = 2;
            this.panelPassInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.81081F));
            this.panelPassInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.18919F));
            this.panelPassInput.Controls.Add(this.pictureBoxKey, 0, 1);
            this.panelPassInput.Controls.Add(this.tagBox, 1, 0);
            this.panelPassInput.Controls.Add(this.uPassBox, 1, 1);
            this.panelPassInput.Controls.Add(this.pictureBoxTag, 0, 0);
            this.panelPassInput.Location = new System.Drawing.Point(3, 2);
            this.panelPassInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPassInput.Name = "panelPassInput";
            this.panelPassInput.RowCount = 2;
            this.panelPassInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelPassInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelPassInput.Size = new System.Drawing.Size(369, 106);
            this.panelPassInput.TabIndex = 9;
            // 
            // pictureBoxKey
            // 
            this.pictureBoxKey.Image = global::MeowPass.Properties.Resources.key;
            this.pictureBoxKey.Location = new System.Drawing.Point(3, 55);
            this.pictureBoxKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxKey.Name = "pictureBoxKey";
            this.pictureBoxKey.Size = new System.Drawing.Size(32, 44);
            this.pictureBoxKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxKey.TabIndex = 3;
            this.pictureBoxKey.TabStop = false;
            // 
            // pictureBoxTag
            // 
            this.pictureBoxTag.Image = global::MeowPass.Properties.Resources.tag;
            this.pictureBoxTag.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxTag.Name = "pictureBoxTag";
            this.pictureBoxTag.Size = new System.Drawing.Size(32, 44);
            this.pictureBoxTag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxTag.TabIndex = 2;
            this.pictureBoxTag.TabStop = false;
            // 
            // panelCopyButton
            // 
            this.panelCopyButton.BackColor = System.Drawing.Color.Transparent;
            this.panelCopyButton.Controls.Add(this.copyButton);
            this.panelCopyButton.Controls.Add(this.labelTips);
            this.panelCopyButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCopyButton.Location = new System.Drawing.Point(0, 697);
            this.panelCopyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCopyButton.Name = "panelCopyButton";
            this.panelCopyButton.Size = new System.Drawing.Size(400, 83);
            this.panelCopyButton.TabIndex = 5;
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.Color.Transparent;
            this.copyButton.Image = global::MeowPass.Properties.Resources.copy;
            this.copyButton.Location = new System.Drawing.Point(331, 1);
            this.copyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(55, 69);
            this.copyButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.copyButton.TabIndex = 1;
            this.copyButton.TabStop = false;
            this.copyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // labelTips
            // 
            this.labelTips.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelTips.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTips.ForeColor = System.Drawing.Color.Silver;
            this.labelTips.Location = new System.Drawing.Point(0, 36);
            this.labelTips.Name = "labelTips";
            this.labelTips.Size = new System.Drawing.Size(400, 48);
            this.labelTips.TabIndex = 5;
            this.labelTips.Text = "[或按下Ctrl+Alt+Enter模拟键入]";
            this.labelTips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTips.DoubleClick += new System.EventHandler(this.Tips_DoubleClick);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Font = new System.Drawing.Font("宋体", 12F);
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(35, 8);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(35, 33);
            this.materialFlatButton1.TabIndex = 6;
            this.materialFlatButton1.Text = "+";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Font = new System.Drawing.Font("宋体", 12F);
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(305, 8);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(29, 33);
            this.materialFlatButton2.TabIndex = 7;
            this.materialFlatButton2.Text = "-";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // panelPassGen
            // 
            this.panelPassGen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPassGen.ColumnCount = 3;
            this.panelPassGen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelPassGen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.panelPassGen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelPassGen.Controls.Add(this.materialFlatButton1, 0, 0);
            this.panelPassGen.Controls.Add(this.materialFlatButton2, 2, 0);
            this.panelPassGen.Controls.Add(this.passCount, 1, 1);
            this.panelPassGen.Controls.Add(this.endPassBox, 1, 0);
            this.panelPassGen.Location = new System.Drawing.Point(11, 603);
            this.panelPassGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPassGen.Name = "panelPassGen";
            this.panelPassGen.RowCount = 2;
            this.panelPassGen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.71429F));
            this.panelPassGen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.28571F));
            this.panelPassGen.Size = new System.Drawing.Size(376, 88);
            this.panelPassGen.TabIndex = 8;
            this.panelPassGen.Visible = false;
            // 
            // passCount
            // 
            this.passCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passCount.AutoSize = true;
            this.passCount.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 7F);
            this.passCount.ForeColor = System.Drawing.Color.DimGray;
            this.passCount.Location = new System.Drawing.Point(78, 49);
            this.passCount.Name = "passCount";
            this.passCount.Size = new System.Drawing.Size(219, 17);
            this.passCount.TabIndex = 8;
            this.passCount.Text = "16";
            this.passCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passCount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PassCount_MouseDown);
            this.passCount.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PassCount_MouseUp);
            // 
            // endPassBox
            // 
            this.endPassBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.endPassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.endPassBox.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.endPassBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.endPassBox.Location = new System.Drawing.Point(78, 11);
            this.endPassBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endPassBox.Name = "endPassBox";
            this.endPassBox.Size = new System.Drawing.Size(219, 27);
            this.endPassBox.TabIndex = 9;
            this.endPassBox.Text = "yourpassword";
            this.endPassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endPassBox.UseSystemPasswordChar = true;
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
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "MeowPass";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // MeowBeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 780);
            this.Controls.Add(this.panelPassGen);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelCopyButton);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(400, 848);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "MeowBeta";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeowBeta";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.MeowBeta_Activated);
            this.Deactivate += new System.EventHandler(this.MeowBeta_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MeowBeta_FormClosing);
            this.Load += new System.EventHandler(this.MeowBeta_Load);
            this.SizeChanged += new System.EventHandler(this.MeowBeta_SizeChanged);
            this.panelHashEncrypt.ResumeLayout(false);
            this.panelHashEncrypt.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelPassInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTag)).EndInit();
            this.panelCopyButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.copyButton)).EndInit();
            this.panelPassGen.ResumeLayout(false);
            this.panelPassGen.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField uPassBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField tagBox;
        private MaterialSkin.Controls.MaterialListView encryptList;
        private System.Windows.Forms.TableLayoutPanel panelHashEncrypt;
        private MaterialSkin.Controls.MaterialRadioButton CRCRButton;
        private MaterialSkin.Controls.MaterialRadioButton MD5RButton;
        private MaterialSkin.Controls.MaterialRadioButton SHARButton;
        private System.Windows.Forms.TableLayoutPanel panelMain;
        private System.Windows.Forms.TableLayoutPanel panelPassInput;
        private System.Windows.Forms.PictureBox pictureBoxTag;
        private System.Windows.Forms.PictureBox pictureBoxKey;
        private MaterialSkin.Controls.MaterialDivider divider1;
        private System.Windows.Forms.PictureBox copyButton;
        private System.Windows.Forms.Panel panelCopyButton;
        private System.Windows.Forms.Label labelTips;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.TableLayoutPanel panelPassGen;
        private System.Windows.Forms.Label passCount;
        private System.Windows.Forms.TextBox endPassBox;
        private System.Windows.Forms.ColumnHeader encryptColumnHeader;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemShow;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}