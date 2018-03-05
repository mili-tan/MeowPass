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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "DES"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("TripleDES");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("AES");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("RC2");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("BlowFish");
            this.passBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tagBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.listView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.materialRadioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // passBox
            // 
            this.passBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passBox.Depth = 0;
            this.passBox.Hint = " 记忆密码";
            this.passBox.Location = new System.Drawing.Point(42, 45);
            this.passBox.MaxLength = 32767;
            this.passBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.SelectedText = "";
            this.passBox.SelectionLength = 0;
            this.passBox.SelectionStart = 0;
            this.passBox.Size = new System.Drawing.Size(325, 29);
            this.passBox.TabIndex = 1;
            this.passBox.TabStop = false;
            this.passBox.UseSystemPasswordChar = false;
            // 
            // tagBox
            // 
            this.tagBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tagBox.Depth = 0;
            this.tagBox.Hint = " 记忆标签";
            this.tagBox.Location = new System.Drawing.Point(42, 5);
            this.tagBox.MaxLength = 32767;
            this.tagBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.tagBox.Name = "tagBox";
            this.tagBox.PasswordChar = '\0';
            this.tagBox.SelectedText = "";
            this.tagBox.SelectionLength = 0;
            this.tagBox.SelectionStart = 0;
            this.tagBox.Size = new System.Drawing.Size(325, 29);
            this.tagBox.TabIndex = 0;
            this.tagBox.TabStop = false;
            this.tagBox.UseSystemPasswordChar = false;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Depth = 0;
            this.listView1.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(134)));
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listView1.Location = new System.Drawing.Point(3, 142);
            this.listView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listView1.MouseState = MaterialSkin.MouseState.OUT;
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(370, 307);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 430;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.materialRadioButton3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialRadioButton1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialRadioButton2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(46, 97);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(327, 39);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // materialRadioButton3
            // 
            this.materialRadioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRadioButton3.AutoSize = true;
            this.materialRadioButton3.Depth = 0;
            this.materialRadioButton3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.materialRadioButton3.Location = new System.Drawing.Point(218, 4);
            this.materialRadioButton3.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton3.Name = "materialRadioButton3";
            this.materialRadioButton3.Ripple = true;
            this.materialRadioButton3.Size = new System.Drawing.Size(109, 30);
            this.materialRadioButton3.TabIndex = 5;
            this.materialRadioButton3.Text = "CRC";
            this.materialRadioButton3.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Checked = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.materialRadioButton1.Location = new System.Drawing.Point(0, 4);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(109, 30);
            this.materialRadioButton1.TabIndex = 3;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "MD5";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.materialRadioButton2.Location = new System.Drawing.Point(109, 4);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(109, 30);
            this.materialRadioButton2.TabIndex = 4;
            this.materialRadioButton2.Text = "SHA";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.06728F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialDivider1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 313F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(376, 452);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(3, 89);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(370, 1);
            this.materialDivider1.TabIndex = 10;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.81081F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.18919F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tagBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.passBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(370, 80);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MeowPass.Properties.Resources.key;
            this.pictureBox2.Location = new System.Drawing.Point(3, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MeowPass.Properties.Resources.tag;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MeowBeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 620);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MeowBeta";
            this.Text = "MeowBeta";
            this.Load += new System.EventHandler(this.MeowBeta_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField passBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField tagBox;
        private MaterialSkin.Controls.MaterialListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}