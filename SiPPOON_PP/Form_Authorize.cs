using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using DLLConnectionString;

namespace SiPPOON_PP
{
    public partial class Form_Authorize : Form
    {
        public static SQLCon con = new SQLCon();
        public static byte Role_ID;
        public static SqlCommand command = new SqlCommand("", Registry_Class.sql);
        public enum Role {Failed, Admin, Otdel_Kachestva};
        public static Role role;
        public static string Login;
        public Form_Authorize()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.BackgroundImage = new Bitmap(Properties.Resources.BackGroungImage);
            tbPass.UseSystemPasswordChar = true;
        }

        private void BtVhod_Click(object sender, EventArgs e)
        {
            Get_Authorize();
        }

        private void Form_Authorize_Load(object sender, EventArgs e)
        {
            Registry_Class reg = new Registry_Class();
            reg.Registry_Set(con.DS, con.DSSN, con.IC, con.ID, con.PSWRD);
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }

        public static Role Get_Role(string login, string password)
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
                        case 2: role = Role.Otdel_Kachestva; break;
                    }
                }
            }
            Registry_Class.sql.Close();
            return role;
        }

        private void Get_Authorize()
        {
            role = Get_Role(tbLogin.Text, Form_Registration.Hash(tbPass.Text));
            if (role == Role.Failed)
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации");
            }
            else
            {
                if (role == Role.Otdel_Kachestva)
                {
                    MessageBox.Show("Вы авторизовались, как \"Начальник отдела по управлению качеством\"");
                    this.Hide();
                    Form_Result main = new Form_Result();
                    main.Show();
                }
                else if (role == Role.Admin)
                {
                    MessageBox.Show("Вы авторизовались, как \"Админ\"");
                    this.Hide();
                    Form_Admin admin = new Form_Admin();
                    admin.Show();
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
            forget.Show();
            this.Close();
        }

        private void ll_NoAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_Registration form_Registration = new Form_Registration();
            form_Registration.Show();
        }
    }
}
