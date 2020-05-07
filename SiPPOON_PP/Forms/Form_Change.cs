using System;
using System.Windows.Forms;

namespace SiPPOON_PP
{
    public partial class Form_Change : Form
    {
        public Form_Change()
        {
            InitializeComponent();
            Classes.CallBack.callbackEventHandler = new Classes.CallBack.callbackEvent(this.Reload);
        }

        private void btn_Kategorii_Click(object sender, EventArgs e)
        {
            Form_Kategorii form_Kategorii = new Form_Kategorii();
            form_Kategorii.Show();
            btn_Kategorii.Enabled = false;
        }

        private void btn_Okruga_Click(object sender, EventArgs e)
        {
            Form_Okruga form_Okruga = new Form_Okruga();
            form_Okruga.Show();
            btn_Okruga.Enabled = false;

        }

        private void Reload(string param)
        {
            switch (param)
            {
                case "Enable_Kategorii":
                    btn_Kategorii.Enabled = true;
                    break;
                case "Enable_Okruga":
                    btn_Okruga.Enabled = true;
                    break;
            }
        }
    }
}
