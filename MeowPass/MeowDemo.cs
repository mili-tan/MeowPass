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

        private void meowButton_Click(object sender, EventArgs e)
        {
            string uPassCrypto = "";
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
                    passBox.Text = MeowTool.MyDESCrypto(uTagCrypto, uPassCrypto);
                    break;
                case 1:
                    passBox.Text = MeowTool.MyTripleDESCrypto(uTagCrypto, uPassCrypto);
                    break;
                case 2:
                    passBox.Text = MeowTool.MyAESCrypto(uTagCrypto, uPassCrypto);
                    break;
                case 3:
                    passBox.Text = MeowTool.MyRC2Crypto(uTagCrypto, uPassCrypto);
                    break;
                case 4:
                    passBox.Text = MeowTool.MyBlowFishCrypto(uTagCrypto, uPassCrypto);
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            MaximizeBox = false;
            //MinimizeBox = false;
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            notifyIcon.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            encryptBox.SelectedIndex = 0;
            RegisterHotKey(Handle, 233, 3, Keys.Enter);

            if (checkBoxHidePass.Checked)
            {
                passBox.PasswordChar = '*';
            }
        }

        private void checkBoxHidePass_CheckedChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
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

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Visible = true;
                WindowState = FormWindowState.Normal;
                Activate();
                ShowInTaskbar = false;
            }
        }

        private void MeowDemo_SizeChanged(object sender, EventArgs e)
        {
            Thread.Sleep(200);
            if (WindowState == FormWindowState.Minimized)
            {
                Visible = false;
                ShowInTaskbar = false;
            }
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemShow_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Visible = true;
                WindowState = FormWindowState.Normal;
                Activate();
                ShowInTaskbar = false;
            }
            else
            {
                WindowState = FormWindowState.Minimized;
                Thread.Sleep(200);
                Visible = false;
                ShowInTaskbar = false;

            }
        }
    }
}
