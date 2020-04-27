using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SiPPOON_PP
{
    public partial class Form_Zastavka : Form
    {
        public Form_Zastavka()
        {
            InitializeComponent();
            this.AllowTransparency = true;
            this.TransparencyKey = Color.Black;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity != 1)
                Opacity += 0.01;
            else
            {
                timer1.Enabled = false;
                Form_Authorize form_authorize = new Form_Authorize();
                form_authorize.Show();
                this.Hide();
            }
        }
    }
}
