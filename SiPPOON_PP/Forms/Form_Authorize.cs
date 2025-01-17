﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SiPPOON_PP
{
    public partial class Form_Authorize : Form
    {
        public enum Role {Failed, Admin, Otdel_Kachestva, Nachalnik_Otdel_Kachestva };//Хранит перечисление ролей
        public static Role role;
        public static string Login;//Хранит логин
        public Form_Authorize()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.BackgroundImage = new Bitmap(Properties.Resources.BackGroundImage);
            tbPass.UseSystemPasswordChar = true;
        }

        private void BtVhod_Click(object sender, EventArgs e)
        {
            Get_Authorize();
        }

        private void Form_Authorize_Load(object sender, EventArgs e)
        {
            Registry_Class reg = new Registry_Class();
            reg.Registry_Get();
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }

        public static Role Get_Role(string login, string password)//Метод для получения роли, исходя из записи в таблице SQL
        {
            Registry_Class reg = new Registry_Class();
            Role role = Role.Failed;
            reg.Registry_Get();
            SqlCommand command = new SqlCommand("Select [Role_ID] From Account WHERE Login_Account=@Login_Account AND Parol_account=@Parol_Account", Registry_Class.sql);
            Registry_Class.sql.Open();
            command.Parameters.AddWithValue("@Login_Account", login);
            command.Parameters.AddWithValue("@Parol_Account", password);
            using (var dataReader = command.ExecuteReader())
            {
                if (dataReader.Read())
                {
                    switch ((int)dataReader["Role_ID"])
                    {
                        case 1: role = Role.Admin; break;
                        case 2: role = Role.Nachalnik_Otdel_Kachestva; break;
                        case 3: role = Role.Otdel_Kachestva; break;
                    }
                }
            }
            Registry_Class.sql.Close();
            return role;
        }

        private void Get_Authorize()//Метод для входа в систему под определенной ролью
        {
            role = Get_Role(tbLogin.Text, Form_Registration.Hash(tbPass.Text));
            if (role == Role.Failed)
                MessageBox.Show("Неверный логин или пароль", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (role == Role.Otdel_Kachestva)
                {
                    Login = tbLogin.Text;
                    MessageBox.Show("Вы авторизовались, как \"Сотрудник отдела по контролю качества\".", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form_Main main = new Form_Main(true, true, false);
                    main.Show();
                    this.Close();
                }
                if (role == Role.Admin)
                {
                    MessageBox.Show("Вы авторизовались, как \"Администратор\".", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form_Admin admin = new Form_Admin();
                    admin.Show();
                    this.Close();
                }
                if (role == Role.Nachalnik_Otdel_Kachestva)
                {
                    Login = tbLogin.Text;
                    MessageBox.Show("Вы авторизовались, как \"Начальник отдела по контролю качества\".", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form_Main main = new Form_Main(false, false, true);
                    main.Show();
                    this.Close();
                }
            }
        }

        private void btGlaz_MouseUp(object sender, MouseEventArgs e)
        {
            tbPass.UseSystemPasswordChar = true;
        }

        private void btGlaz_MouseDown(object sender, MouseEventArgs e)
        {
            tbPass.UseSystemPasswordChar = false;
        }

        private void ll_Password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Forget forget = new Form_Forget();
            forget.ShowDialog();
        }

        private void ll_NoAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Registration form_Registration = new Form_Registration();
            form_Registration.ShowDialog();
        }
    }
}
