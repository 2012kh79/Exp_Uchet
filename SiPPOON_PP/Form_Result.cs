using System;
using System.Drawing;
using System.Windows.Forms;

namespace SiPPOON_PP
{
    public partial class Form_Result : Form
    {
        public Form_Result()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.BackgroundImage = new Bitmap(Properties.Resources.BackGroundImage);
        }

        private void Pb_Kategorii_MouseMove(object sender, MouseEventArgs e)
        {
            pb_Kategorii.BackgroundImage = Properties.Resources.Result_Kategorii;
        }

        private void Pb_Kategorii_MouseLeave(object sender, EventArgs e)
        {
            pb_Kategorii.BackgroundImage = Properties.Resources.Result_Kat;
        }

        private void Pb_Okruga_MouseMove(object sender, MouseEventArgs e)
        {
            pb_Okruga.BackgroundImage = Properties.Resources.Result_Okruga;
        }

        private void Pb_Okruga_MouseLeave(object sender, EventArgs e)
        {
            pb_Okruga.BackgroundImage = Properties.Resources.Result_Okr;
        }

        private void Pb_Kategorii_Click(object sender, EventArgs e)
        {
            Form_Kategorii form_kategorii = new Form_Kategorii();
            form_kategorii.Show();
        }

        private void Pb_Okruga_Click(object sender, EventArgs e)
        {
            Form_Okruga form_okruga = new Form_Okruga();
            form_okruga.Show();
        }

        private void Form_Result_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if
            (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
