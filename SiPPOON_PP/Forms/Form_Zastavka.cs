using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

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
            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Uchet_Rez");
            if (Opacity != 1)
                Opacity += 0.01;
            else
            {
                timer1.Enabled = false;
                if (registry != null)
                {
                    Form_Authorize form_Authorize = new Form_Authorize();
                    form_Authorize.Show();
                }
                else
                {
                    Forms.Form_Connection form_Connection = new Forms.Form_Connection();
                    form_Connection.Show();
                }
                this.Hide();
            }
        }
    }
}
