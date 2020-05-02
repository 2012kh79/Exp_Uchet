using System;
using System.Drawing;
using System.Windows.Forms;

namespace SiPPOON_PP
{
    public partial class Form_Main : Form
    {
        Form_Change form_Change = new Form_Change();
        public Form_Main()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.BackgroundImage = new Bitmap(Properties.Resources.Zastavka);
        }

        private void Form_Result_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.ExitThread();
            else if
            (result == DialogResult.No)
                e.Cancel = true;
        }

        private void btn_Result_MouseEnter(object sender, EventArgs e)
        {
            btn_Result.BackgroundImage = null;
            btn_Result.Text = "Результаты";
        }

        private void btn_Result_MouseLeave(object sender, EventArgs e)
        {
            btn_Result.Text = null;
            btn_Result.BackgroundImage = Properties.Resources.Main_Result;
        }

        private void btn_Kabinet_MouseEnter(object sender, EventArgs e)
        {
            btn_Kabinet.BackgroundImage = null;
            btn_Kabinet.Text = "Личный кабинет";
        }

        private void btn_Kabinet_MouseLeave(object sender, EventArgs e)
        {
            btn_Kabinet.Text = null;
            btn_Kabinet.BackgroundImage = Properties.Resources.Main_Kabinet;
        }

        private void btn_Propusk_MouseEnter(object sender, EventArgs e)
        {
            btn_Propusk.BackgroundImage = null;
            btn_Propusk.Text = "Пропуска";
        }

        private void btn_Propusk_MouseLeave(object sender, EventArgs e)
        {
            btn_Propusk.Text = null;
            btn_Propusk.BackgroundImage = Properties.Resources.Main_Propusk;
        }

        private void btn_FeedBack_MouseEnter(object sender, EventArgs e)
        {
            btn_FeedBack.BackgroundImage = null;
            btn_FeedBack.Text = "Обратная связь";
        }

        private void btn_FeedBack_MouseLeave(object sender, EventArgs e)
        {
            btn_FeedBack.Text = null;
            btn_FeedBack.BackgroundImage = Properties.Resources.Main_FeedBack;
        }

        private void btn_About_MouseEnter(object sender, EventArgs e)
        {
            btn_About.BackgroundImage = null;
            btn_About.Text = "Информация о программе";
        }

        private void btn_About_MouseLeave(object sender, EventArgs e)
        {
            btn_About.Text = null;
            btn_About.BackgroundImage = Properties.Resources.Main_About;
        }

        private void btn_Settings_MouseEnter(object sender, EventArgs e)
        {
            btn_Settings.BackgroundImage = null;
            btn_Settings.Text = "Настройки";
        }

        private void btn_Settings_MouseLeave(object sender, EventArgs e)
        {
            btn_Settings.Text = null;
            btn_Settings.BackgroundImage = Properties.Resources.Main_Settings;
        }

        private void btn_Result_Click(object sender, EventArgs e)
        {
            form_Change.ShowDialog();
        }

        private void btn_Propusk_Click(object sender, EventArgs e)
        {

        }

        private void btn_FeedBack_Click(object sender, EventArgs e)
        {
            Form_Feedback form_Feedback = new Form_Feedback();
            form_Feedback.Show();
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            About_Form about_Form = new About_Form();
            about_Form.Show();
        }

        private void btn_Kabinet_Click(object sender, EventArgs e)
        {

        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {

        }
    }
}
