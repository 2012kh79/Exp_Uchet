using System;
using System.Windows.Forms;

namespace SiPPOON_PP
{
    public partial class Form_Change : Form
    {
        Form_Kategorii form_Kategorii = new Form_Kategorii();
        Form_Okruga form_Okruga = new Form_Okruga();
        public Form_Change()
        {
            InitializeComponent();
            Classes.CallBack_Class.callbackEventHandler = new Classes.CallBack_Class.callbackEvent(this.Reload);
        }

        private void btn_Kategorii_Click(object sender, EventArgs e)
        {
            if (Form_Main.Location_Result == null)
                MessageBox.Show("Здравствуйте, " + Form_Authorize.Login + ". Укажите в настройках путь для работы с результатами дорожного исследования!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                form_Kategorii.Show();
                btn_Kategorii.Enabled = false;
            }
        }

        private void btn_Okruga_Click(object sender, EventArgs e)
        {
            if (Form_Main.Location_Result == null)
                MessageBox.Show("Здравствуйте, " + Form_Authorize.Login + ". Укажите в настройках путь для работы с результатами дорожного исследования!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                form_Okruga.Show();
                btn_Okruga.Enabled = false;
            }

        }

        private void Reload(string param)//Метод для синхронизации форм
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
