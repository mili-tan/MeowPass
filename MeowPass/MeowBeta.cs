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
using MeowPass.Tools;
using static MeowPass.MeowTool;
using System.Diagnostics;

namespace MeowPass
{
    public partial class MeowBeta : MaterialForm
    {
        public MeowBeta()
        {
            InitializeComponent();
            MaximizeBox = false;

            Process[] processes = Process.GetProcessesByName(Application.CompanyName);
            if (processes.Length > 1)
            {
                MessageBox.Show("已有一个实例正在运行,请不要重复启动", "MeowPass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(1);
            }

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan500, Primary.Cyan600, Primary.Cyan600, Accent.Cyan700, TextShade.WHITE);
        }

        private void MeowBeta_Load(object sender, EventArgs e)
        {
            //listView1.Items[0].Text = "DES";

            encryptList.Scrollable = false;

            copyButton.Visible = false;
            Bitmap b = new Bitmap(panelCopyButton.Width, panelCopyButton.Height);
            panelCopyButton.DrawToBitmap(b, new Rectangle(0, 0, b.Width, b.Height));
            copyButton.Visible = true;
            panelCopyButton.BackgroundImage = b;
        }

        private void Tips_DoubleClick(object sender, EventArgs e)
        {
            panelPassGen.Visible = !panelPassGen.Visible;
        }

        private void PassCount_MouseDown(object sender, MouseEventArgs e)
        {
            endPassBox.UseSystemPasswordChar = false;
        }

        private void PassCount_MouseUp(object sender, MouseEventArgs e)
        {
            endPassBox.UseSystemPasswordChar = true;
        }

        private string GenMeowPass(string pass, string tag, int passLength)
        {
            string uPassCrypto = "";
            string uTagCrypto = MyMD5Crypto(tag);
            if (SHARButton.Checked)
            {
                uPassCrypto = MyMD5Crypto(MySHACrypto(uPassBox.Text.ToString()) + uPassBox.Text.ToString());
            }
            else if (MD5RButton.Checked)
            {
                uPassCrypto = MyMD5Crypto(MyMD5Crypto(uPassBox.Text.ToString()) + uPassBox.Text.ToString());
            }
            else if (CRCRButton.Checked)
            {
                uPassCrypto = MyMD5Crypto(MyCRSCrypto(uPassBox.Text.ToString()) + uPassBox.Text.ToString());
            }
            switch (encryptList.SelectedIndices[0])
            {
                case 0:
                    pass = MyDESCrypto(uTagCrypto, uPassCrypto);
                    break;
                case 1:
                    pass = MyTripleDESCrypto(uTagCrypto, uPassCrypto);
                    break;
                case 2:
                    pass = MyAESCrypto(uTagCrypto, uPassCrypto);
                    break;
                case 3:
                    pass = MyRC2Crypto(uTagCrypto, uPassCrypto);
                    break;
                case 4:
                    pass = MyBlowFishCrypto(uTagCrypto, uPassCrypto);
                    break;
                default:
                    break;
            }
            if (pass.Length < passLength + 1)
            {
                while (!(pass.Length < passLength + 1))
                {
                    pass += pass;
                }
            }
            return pass.Substring(0, passLength);
        }

        private void GenMeowPass()
        {
            endPassBox.Text = GenMeowPass(uPassBox.Text, tagBox.Text, Convert.ToInt32(passCount));
        }

        private void EncryptList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MeowBeta_Activated(object sender, EventArgs e)
        {
            Opacity = 1;
        }

        private void MeowBeta_Deactivate(object sender, EventArgs e)
        {
            try
            {
                Opacity = 0.5;
            }
            catch
            {
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(endPassBox.Text);
        }
    }
}
