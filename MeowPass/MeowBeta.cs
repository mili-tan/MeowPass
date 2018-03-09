using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeowPass
{
    public partial class MeowBeta : MaterialForm
    {
        public MeowBeta()
        {
            InitializeComponent();
            MaximizeBox = false;

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan500, Primary.Cyan600, Primary.Cyan600, Accent.Cyan700, TextShade.WHITE);
        }

        private void MeowBeta_Load(object sender, EventArgs e)
        {
            //listView1.Items[0].Text = "DES";

            copyButton.Visible = false;
            Bitmap b = new Bitmap(panelCopyButton.Width, panelCopyButton.Height);
            panelCopyButton.DrawToBitmap(b, new Rectangle(0, 0, b.Width, b.Height));
            copyButton.Visible = true;
            panelCopyButton.BackgroundImage = b;
        }

        private void label5_DoubleClick(object sender, EventArgs e)
        {
            panelPassGen.Visible = !panelPassGen.Visible;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            endPassBox.UseSystemPasswordChar = false;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            endPassBox.UseSystemPasswordChar = true;
        }
    }
}
