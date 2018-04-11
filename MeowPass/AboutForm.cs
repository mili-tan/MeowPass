using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeowPass
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void LinkThanks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://raw.githubusercontent.com/mili-tan/MeowPass/master/LICENSE");
        }

        private void LinkMiliSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/ghost");
        }

        private void LinkLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.mozilla.org/en-US/MPL/2.0/");
        }

        private void PictureBox1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = "MeowPass Rember";
            BackColor = Color.Black;
            label1.ForeColor = Color.LightGray;
            label2.ForeColor = Color.LightGray;
            label3.ForeColor = Color.LightGray;
            label4.ForeColor = Color.LightGray;
            label5.ForeColor = Color.LightGray;
            label6.Hide();
            Opacity = 0.8;
        }
    }
}
