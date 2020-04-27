using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace SiPPOON_PP
{
    public partial class Form_Registration : Form
    {
        string patLogin = @"^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$";
        string patEmail = @"^[-\w.]+@([A-z0-9][-A-z0-9]+\.)+[A-z]{2,4}$";
        string patPassword = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        int Enable;
        public Form_Registration()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.BackgroundImage = new Bitmap(Properties.Resources.BackGroundImage);
            this.btGlaz.BackgroundImage = Properties.Resources.Glaz;
            tbPass.UseSystemPasswordChar = true;
            tbRepeatPass.UseSystemPasswordChar = true;
        }

        public static string Hash(string input)
        {
            using (SHA256Managed sha2 = new SHA256Managed())
            {
                var hash = sha2.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private void btReg_Click(object sender, EventArgs e)
        {
            string mySelectQuery = "SELECT [ID_Employee] FROM [dbo].[Employee] WHERE [Fam_Employee] = '" + tb_Fam.Text + "'";
            Registry_Class reg = new Registry_Class();
            reg.Registry_Get();
            DB_Procedures procedure = new DB_Procedures();
            procedure.spEmployee_Insert(tb_Fam.Text, tbImya.Text);
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery, Registry_Class.sql))
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                procedure.spAccount_Insert(tbLogin.Text, Hash(tbPass.Text), tb_Pochta.Text, 2, Convert.ToInt32(table.Rows[0][0].ToString()));
            }
            DialogResult result = MessageBox.Show("Регистрация прошла успешно", "Регистрация");
            if (result == DialogResult.OK)
            {
                this.Hide();
                Form_Authorize Form_authoriz = new Form_Authorize();
                Form_authoriz.Show();
            }
        }

        private void btProv_Click(object sender, EventArgs e)
        {
            Enable = 0;
            if (tb_Fam.Text.Length >= 4)
            {
                pictureBox4.Image = Properties.Resources.Galochka;
                Enable++;
            }
            else
                pictureBox4.Image = Properties.Resources.Krest;
            if (tbImya.Text.Length >= 4)
            {
                pictureBox5.Image = Properties.Resources.Galochka;
                Enable++;
            }
            else
                pictureBox5.Image = Properties.Resources.Krest;
            if (Regex.IsMatch(tbLogin.Text, patLogin, RegexOptions.IgnoreCase) & tbLogin.Text.Length >= 4)
            {
                pictureBox2.Image = Properties.Resources.Galochka;
                Enable++;
            }
            else
                pictureBox2.Image = Properties.Resources.Krest;
            if (Regex.IsMatch(tb_Pochta.Text, patEmail, RegexOptions.IgnoreCase))
            {
                pictureBox1.Image = Properties.Resources.Galochka;
                Enable++;
            }
            else
                pictureBox1.Image = Properties.Resources.Krest;
            if (tbPass.Text.Equals(tbRepeatPass.Text))
            {
                if (Regex.IsMatch(tbPass.Text, patPassword, RegexOptions.IgnoreCase) & tbPass.Text.Length >= 4)
                {
                    pictureBox3.Image = Properties.Resources.Galochka;
                    Enable++;
                }
                else
                    pictureBox3.Image = Properties.Resources.Krest;
            }
            else
            {
                MessageBox.Show("Пароли не совпадают!");
                pictureBox3.Image = Properties.Resources.Krest;
            }
            if (Enable == 5)
                btReg.Enabled = true;
            else
                btReg.Enabled = false;
        }

        private void btGlaz_MouseDown(object sender, MouseEventArgs e)
        {
            tbPass.UseSystemPasswordChar = false;
            tbRepeatPass.UseSystemPasswordChar = false;
        }

        private void btGlaz_MouseUp(object sender, MouseEventArgs e)
        {
            tbPass.UseSystemPasswordChar = true;
            tbRepeatPass.UseSystemPasswordChar = true;
        }

        private void tb_Fam_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_Authorize Form_authoriz = new Form_Authorize();
            Form_authoriz.Show();
        }
    }
}
