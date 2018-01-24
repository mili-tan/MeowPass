using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsInput;
using System.Drawing;
using System.Threading;

namespace MeowPass
{
    public partial class MeowDemo : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, Keys vk);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public MeowDemo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            MaximizeBox = false;
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            notifyIcon.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            encryptBox.SelectedIndex = 0;
            RegisterHotKey(Handle, 233, 3, Keys.Enter);

            if (checkBoxHidePass.Checked)
            {
                passBox.PasswordChar = '*';
            }
        }

        private void CheckBoxHidePass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHidePass.Checked)
            {
                passBox.PasswordChar = '*';
            }
            else
            {
                passBox.PasswordChar = new char();
            }
        }

        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passBox.Text);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0312:
                    if (m.WParam.ToString() == "233")
                    {
                        if (!string.IsNullOrEmpty(passBox.Text))
                        {
                            new InputSimulator().Keyboard.TextEntry(passBox.Text);
                        }
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void MeowDemo_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(Handle, 233);
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                NormalForm();
            }
        }

        private void MeowDemo_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                MinimizedForm();
            }
        }

        private void MenuItemExit_Click(object sender, EventArgs e) => Close();

        private void MenuItemShow_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                NormalForm();
                menuItemShow.Text = "最小化";
            }
            else
            {
                MinimizedForm();
                menuItemShow.Text = "显示";
            }
        }

        public void MinimizedForm()
        {
            WindowState = FormWindowState.Minimized;
            Thread.Sleep(200);
            Visible = false;
            ShowInTaskbar = false;
        }

        public void NormalForm()
        {
            Visible = true;
            WindowState = FormWindowState.Normal;
            Activate();
            ShowInTaskbar = false;
        }

        private void GenMeowPass()
        {
            string uPassCrypto = "";
            string pass = "";
            string uTagCrypto = MeowTool.MyMD5Crypto(tagBox.Text);
            if (shaRButton.Checked)
            {
                uPassCrypto = MeowTool.MyMD5Crypto(MeowTool.MySHACrypto(uPassBox.Text.ToString()) + uPassBox.Text.ToString());
            }
            else if (md5RButton.Checked)
            {
                uPassCrypto = MeowTool.MyMD5Crypto(MeowTool.MyMD5Crypto(uPassBox.Text.ToString()) + uPassBox.Text.ToString());
            }
            else if (crcRButton.Checked)
            {
                uPassCrypto = MeowTool.MyMD5Crypto(MeowTool.MyCRSCrypto(uPassBox.Text.ToString()) + uPassBox.Text.ToString());
            }
            switch (encryptBox.SelectedIndex)
            {
                case 0:
                    pass = MeowTool.MyDESCrypto(uTagCrypto, uPassCrypto);
                    break;
                case 1:
                    pass = MeowTool.MyTripleDESCrypto(uTagCrypto, uPassCrypto);
                    break;
                case 2:
                    pass = MeowTool.MyAESCrypto(uTagCrypto, uPassCrypto);
                    break;
                case 3:
                    pass = MeowTool.MyRC2Crypto(uTagCrypto, uPassCrypto);
                    break;
                case 4:
                    pass = MeowTool.MyBlowFishCrypto(uTagCrypto, uPassCrypto);
                    break;
                default:
                    break;
            }
            if (pass.Length < passUpDown.Value + 1)
            {
                while (!(pass.Length < passUpDown.Value + 1))
                {
                    pass += pass;
                }
            }
            passBox.Text = pass.Substring(0, Convert.ToInt32(passUpDown.Value));
        }

        private void EncryptBox_SelectedIndexChanged(object sender, EventArgs e) => GenMeowPass();

        private void TableLayoutPanel2_Click(object sender, EventArgs e) => GenMeowPass();

        private void PassUpDown_ValueChanged(object sender, EventArgs e) => GenMeowPass();

        private void TagBox_TextChanged(object sender, EventArgs e) => GenMeowPass();

        private void UPassBox_TextChanged(object sender, EventArgs e) => GenMeowPass();
    }
}
