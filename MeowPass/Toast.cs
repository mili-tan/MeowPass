using System;
using System.Windows.Forms;
using MeowPass.Tools;

namespace MeowPass
{
    public partial class Toast : Form
    {
        private string Mtext;
        public Toast(string text)
        {
            Mtext = text;
            InitializeComponent();
            Opacity = 0.5;
            TopMost = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void Toast_FormClosing(object sender, FormClosingEventArgs e)
        {
            Fx.EffectsWindows(Handle, 1200, Fx.AW_HIDE + Fx.AW_BLEND);
        }

        private void Toast_Load(object sender, EventArgs e)
        {
            Fx.EffectsWindows(Handle, 100, Fx.AW_BLEND);
            label1.Text = Mtext;

        }
    }
}
