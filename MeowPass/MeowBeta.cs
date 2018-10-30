using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using static MeowPass.MeowTool;
using WindowsInput;
using MeowPass.Tools;
using System.Threading;

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

            HotKey.RegisterHotKey(Handle, 233, 3, Keys.Enter);

            MessageBox.Show(MyMd5Hash("this is a md5 test."));
        }

        private void MeowBeta_Load(object sender, EventArgs e)
        {
            Fx.EffectsWindows(Handle, 100, Fx.AW_BLEND);
            MaximizeBox = false;
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            encryptList.Scrollable = false;

            copyButton.Visible = false;
            Bitmap bitmap = new Bitmap(panelCopyButton.Width, panelCopyButton.Height);
            panelCopyButton.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            copyButton.Visible = true;
            panelCopyButton.BackgroundImage = bitmap;
        }

        private void Tips_DoubleClick(object sender, EventArgs e)
        {
            panelPassGen.Visible = !panelPassGen.Visible;
            GenMeowPass();
        }

        private void PassCount_MouseDown(object sender, MouseEventArgs e)
        {
            GenMeowPass();
            endPassBox.UseSystemPasswordChar = false;
        }

        private void PassCount_MouseUp(object sender, MouseEventArgs e)
        {
            endPassBox.UseSystemPasswordChar = true;
        }

        private string GenMeowPass(string pass, string tag, int passLength)
        {
            if (pass == null) throw new ArgumentNullException(nameof(pass));
            string uPassCrypto = "";
            string uTagCrypto = MyMd5Hash(tag);
            if (SHARButton.Checked)
            {
                uPassCrypto = MyMd5Hash(MySHAHash(uPassBox.Text) + uPassBox.Text);
            }
            else if (MD5RButton.Checked)
            {
                uPassCrypto = MyMd5Hash(MyMd5Hash(uPassBox.Text) + uPassBox.Text);
            }
            else if (CRCRButton.Checked)
            {
                uPassCrypto = MyMd5Hash(MyCRSHash(uPassBox.Text) + uPassBox.Text);
            }
            if (encryptList.SelectedIndices.Count == 0)
            {
                pass = MyDESCrypto(uTagCrypto, uPassCrypto);
            }
            else
            {
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
                        pass = MyDESCrypto(uTagCrypto, uPassCrypto);
                        break;
                }
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
            endPassBox.Text = GenMeowPass(uPassBox.Text, tagBox.Text, Convert.ToInt32(passCount.Text));
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
                // ignored
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            GenMeowPass();
            Clipboard.SetText(endPassBox.Text);
            new Toast(@"已复制到剪贴板").Show();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0312:
                    if (m.WParam.ToString() == "233")
                    {
                        GenMeowPass();
                        if (!string.IsNullOrEmpty(endPassBox.Text))
                        {
                            new InputSimulator().Keyboard.TextEntry(endPassBox.Text);
                            new Toast(@"已模拟键入").Show();
                        }
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void MeowBeta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Fx.EffectsWindows(Handle, 100, Fx.AW_HIDE + Fx.AW_BLEND);
            HotKey.UnregisterHotKey(Handle, 233);
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                NormalForm();
            }
        }

        public void MinimizedForm()
        {
            WindowState = FormWindowState.Minimized;

            Thread.Sleep(200);
            Visible = false;
            ShowInTaskbar = false;

            menuItemShow.Text = @"显示";

            HotKey.RegisterHotKey(Handle, 233, 3, Keys.Enter);
        }

        public void NormalForm()
        {
            Visible = true;
            WindowState = FormWindowState.Normal;
            Activate();
            ShowInTaskbar = false;

            menuItemShow.Text = @"最小化";

            HotKey.RegisterHotKey(Handle, 233, 3, Keys.Enter);
        }

        private void MeowBeta_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                MinimizedForm();
            }
        }

        private void MenuItemShow_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                NormalForm();
            }
            else
            {
                MinimizedForm();
            }
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
            MinimizedForm();
        }

        private void MenuItemExit_Click(object sender, EventArgs e) => Close();

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(passCount.Text) < 20)
            {
                passCount.Text = (Convert.ToInt32(passCount.Text) + 1).ToString();
                GenMeowPass();
            }

        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(passCount.Text) > 6)
            {
                passCount.Text = (Convert.ToInt32(passCount.Text) - 1).ToString();
                GenMeowPass();
            }

        }

    }
}
