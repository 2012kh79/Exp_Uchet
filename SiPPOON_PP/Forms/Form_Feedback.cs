﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SiPPOON_PP
{
    public partial class Form_Feedback : Form
    {
        bool picture1 = true;
        bool picture2 = true;
        bool picture3 = true;
        bool picture4 = true;
        bool picture5 = true;
        string zvezda;
        public Form_Feedback()
        {
            InitializeComponent();
        }

        private void Form_Mail_Load(object sender, EventArgs e)
        {
            btn_Send.BackgroundImage = Properties.Resources.Mail;
            pb1.BackgroundImage = Properties.Resources.Star_disable;
            pb2.BackgroundImage = Properties.Resources.Star_disable;
            pb3.BackgroundImage = Properties.Resources.Star_disable;
            pb4.BackgroundImage = Properties.Resources.Star_disable;
            pb5.BackgroundImage = Properties.Resources.Star_disable;
        }

        private void btn_Mail_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_Mail.Text != "")
                {
                    if (tb_Password.Text != "")
                    {
                        string mySelectQuery1 = "SELECT * FROM [dbo].[Account] WHERE [Mail] = '" + tb_Mail.Text + "'";
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery1, Registry_Class.sql))
                        {
                            DataTable table = new DataTable();
                            dataAdapter.Fill(table);
                            if (table.Rows.Count == 0)
                                MessageBox.Show("Данный почтовый ящик не был зарегистрирован", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                if (tb_Ot.Text != "")
                                {
                                    Send_Mail sendMail = new Send_Mail(tb_Pole.Text, "Звезды: " + zvezda, tb_Ot.Text, tb_Mail.Text, tb_Password.Text);
                                    sendMail.MySendMail();
                                }
                                else
                                    MessageBox.Show("Заполните поле \"Имя\"", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                        MessageBox.Show("Заполните поле \"Пароль\"", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Заполните поле \"Mail\"", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            zvezda = "★";
            switch (picture1)
            {
                case true:
                    pb1.BackgroundImage = Properties.Resources.Star_enable;
                    picture1 = false;
                    break;
                case false:
                    pb1.BackgroundImage = Properties.Resources.Star_disable;
                    picture1 = true;
                    break;
            }
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            zvezda = "★★";
            switch (picture2)
            {
                case true:
                    pb1.BackgroundImage = Properties.Resources.Star_enable;
                    pb2.BackgroundImage = Properties.Resources.Star_enable;
                    picture2 = false;
                    break;
                case false:
                    pb1.BackgroundImage = Properties.Resources.Star_disable;
                    pb2.BackgroundImage = Properties.Resources.Star_disable;
                    picture2 = true;
                    break;
            }
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            zvezda = "★★★";
            switch (picture3)
            {
                case true:
                    pb1.BackgroundImage = Properties.Resources.Star_enable;
                    pb2.BackgroundImage = Properties.Resources.Star_enable;
                    pb3.BackgroundImage = Properties.Resources.Star_enable;
                    picture3 = false;
                    break;
                case false:
                    pb1.BackgroundImage = Properties.Resources.Star_disable;
                    pb2.BackgroundImage = Properties.Resources.Star_disable;
                    pb3.BackgroundImage = Properties.Resources.Star_disable;
                    picture3 = true;
                    break;
            }
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            zvezda = "★★★★";
            switch (picture4)
            {
                case true:
                    pb1.BackgroundImage = Properties.Resources.Star_enable;
                    pb2.BackgroundImage = Properties.Resources.Star_enable;
                    pb3.BackgroundImage = Properties.Resources.Star_enable;
                    pb4.BackgroundImage = Properties.Resources.Star_enable;
                    picture4 = false;
                    break;
                case false:
                    pb1.BackgroundImage = Properties.Resources.Star_disable;
                    pb2.BackgroundImage = Properties.Resources.Star_disable;
                    pb3.BackgroundImage = Properties.Resources.Star_disable;
                    pb4.BackgroundImage = Properties.Resources.Star_disable;
                    picture4 = true;
                    break;
            }
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            zvezda = "★★★★★";
            switch (picture5)
            {
                case true:
                    pb1.BackgroundImage = Properties.Resources.Star_enable;
                    pb2.BackgroundImage = Properties.Resources.Star_enable;
                    pb3.BackgroundImage = Properties.Resources.Star_enable;
                    pb4.BackgroundImage = Properties.Resources.Star_enable;
                    pb5.BackgroundImage = Properties.Resources.Star_enable;
                    picture5 = false;
                    break;
                case false:
                    pb1.BackgroundImage = Properties.Resources.Star_disable;
                    pb2.BackgroundImage = Properties.Resources.Star_disable;
                    pb3.BackgroundImage = Properties.Resources.Star_disable;
                    pb4.BackgroundImage = Properties.Resources.Star_disable;
                    pb5.BackgroundImage = Properties.Resources.Star_disable;
                    picture5 = true;
                    break;
            }
        }
    }
}