using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace SiPPOON_PP
{
    public partial class Form_Forget : Form
    {
        string mail;
        string patPassword = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        int Enable;
        public Form_Forget()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            tb_Mail.Text = "ivan.ivanov@mail.ru";
            this.BackgroundImage = Properties.Resources.BackGroungImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (btn_Next.Text)
            {
                case "Проверить":
                    mail = tb_Mail.Text;
                    string mySelectQuery = "SELECT [Mail] FROM [dbo].[Account] WHERE [Mail] = '" + mail + "'";
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery, Registry_Class.sql))
                    {
                        DataTable table = new DataTable();
                        dataAdapter.Fill(table);
                        if (table.Rows.Count == 0)
                        {
                            MessageBox.Show("Данный почтовый ящик не был зарегистрирован", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Forget_Password forget_Password = new Forget_Password(mail);
                            forget_Password.MyForget_Password();
                            btn_Next.Text = "Далее";
                        }
                    }
                    break;
                case "Далее":
                    tb_Mail.Text = "";
                    lbl_Mail.Text = "Введите код подтверждения";
                    btn_Next.Text = "Сбросить пароль";
                    break;
                case "Сбросить пароль":
                    if (tb_Mail.Text == Forget_Password.kod.ToString())
                    {
                        this.Controls.Remove(tb_Mail);
                        Form_Forget_Fill();
                    }
                    else
                        MessageBox.Show("Введите корректный код подтверждения!", "Некорректный код");
                    break;
            }
        }

        private void tb_Mail_Click(object sender, EventArgs e)
        {
            if (tb_Mail.Text != "")
            {
                tb_Mail.ForeColor = Color.Black;
                tb_Mail.Text = "";
            }
        }

        private void tb_Mail_Leave(object sender, EventArgs e)
        {
            if (tb_Mail.Text == "" & btn_Next.Text == "Проверить")
            {
                tb_Mail.ForeColor = Color.Silver;
                tb_Mail.Text = "ivan.ivanov@mail.ru";
            }
        }

        private void Form_Forget_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form_Authorize form_Authorize = new Form_Authorize();
            form_Authorize.Show();
        }

        TextBox tb_Password = new TextBox();
        TextBox tb_Repeat_Password = new TextBox();
        Button btn_Glaz = new Button();
        Button btn_Check = new Button();
        Label lbl_Repeat_Password = new Label();
        PictureBox pb_Check = new PictureBox();
        private void Form_Forget_Fill ()
        {
            tb_Repeat_Password.Font = new Font("Microsoft Sans Serif", 12);
            tb_Repeat_Password.Size = new Size(250, 26);
            tb_Repeat_Password.Location = new Point(170, 70);
            tb_Repeat_Password.UseSystemPasswordChar = true;
            this.Controls.Add(tb_Repeat_Password);

            btn_Glaz.BackgroundImage = Properties.Resources.glaz;
            btn_Glaz.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Glaz.Size = new Size(28,28);
            btn_Glaz.Location = new Point(424, 69);
            this.Controls.Add(btn_Glaz);
            btn_Glaz.MouseUp += new MouseEventHandler(btn_Glaz_MouseUp);
            btn_Glaz.MouseDown += new MouseEventHandler(btn_Glaz_MouseDown);

            btn_Check.Font = new Font("Microsoft Sans Serif", 10);
            btn_Check.Text = "Check";
            btn_Check.Size = new Size(120, 28);
            btn_Check.Location = new Point(170, 110);
            this.Controls.Add(btn_Check);
            btn_Check.Click += new EventHandler(btn_Check_Click);

            lbl_Repeat_Password.Font = new Font("Microsoft Sans Serif", 10);
            lbl_Repeat_Password.BackColor = Color.Transparent;
            lbl_Repeat_Password.Text = "Повторите пароль:";
            lbl_Repeat_Password.Size = new Size(150, 25);
            lbl_Repeat_Password.Location = new Point(20, 72);
            this.Controls.Add(lbl_Repeat_Password);

            tb_Password.Font = new Font("Microsoft Sans Serif", 12);
            tb_Password.Text = "";
            tb_Password.Size = new Size(250, 26);
            tb_Password.Location = new Point(170, 26);
            tb_Password.UseSystemPasswordChar = true;
            this.Controls.Add(tb_Password);

            lbl_Mail.Font = new Font("Microsoft Sans Serif", 10);
            lbl_Mail.BackColor = Color.Transparent;
            lbl_Mail.Text = "Пароль:";
            lbl_Mail.Location = new Point(90, 28);

            btn_Next.Font = new Font("Microsoft Sans Serif", 10);
            btn_Next.Enabled = false;
            btn_Next.Text = "Update";
            btn_Next.Size = new Size(120, 28);
            btn_Next.Location = new Point(300, 110);
            btn_Next.Click += new EventHandler(btn_Next_Click);

            pb_Check.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Check.Size = new Size(28,28);
            pb_Check.Location = new Point(424, 25);
            this.Controls.Add(pb_Check);

            this.Height += 50;
            this.Width += 70;
        }
        protected void btn_Next_Click(object sender, EventArgs e)
        {
            try
            {
                DB_Procedures procedures = new DB_Procedures();
                string mySelectQuery1 = "SELECT * FROM [dbo].[Account] WHERE [Mail] = '" + mail + "'";
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery1, Registry_Class.sql))
                {
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    procedures.spAccount_Update(Convert.ToString(table.Rows[0][0]), Form_Registration.Hash(tb_Password.Text), table.Rows[0][2].ToString(), Convert.ToInt32(table.Rows[0][3].ToString()), Convert.ToInt32(table.Rows[0][4].ToString()));
                }
                DialogResult result = MessageBox.Show("Пароль успешно изменен!", "Изменение пароля");
                if (result == DialogResult.OK)
                {
                    this.Hide();
                    Form_Authorize Form_authoriz = new Form_Authorize();
                    Form_authoriz.Show();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка изменения пароля! Повторите попытку", "Ошибка");
            }
        }

        protected void btn_Check_Click(object sender, EventArgs e)
        {
            Enable = 0;
            if (tb_Password.Text.Equals(tb_Repeat_Password.Text))
            {
                if (Regex.IsMatch(tb_Password.Text, patPassword, RegexOptions.IgnoreCase) & tb_Password.Text.Length >= 4)
                {
                    pb_Check.Image = Properties.Resources.gal;
                    Enable++;
                }
                else
                    pb_Check.Image = Properties.Resources.krest;
            }
            else
            {
                MessageBox.Show("Пароли не совпадают!");
                pb_Check.Image = Properties.Resources.krest;
            }
            if (Enable == 1)
                btn_Next.Enabled = true;
            else
                btn_Next.Enabled = false;
        }

        protected void btn_Glaz_MouseDown(object sender, MouseEventArgs e)
        {
            tb_Password.UseSystemPasswordChar = false;
            tb_Repeat_Password.UseSystemPasswordChar = false;
        }

        protected void btn_Glaz_MouseUp(object sender, MouseEventArgs e)
        {
            tb_Password.UseSystemPasswordChar = true;
            tb_Repeat_Password.UseSystemPasswordChar = true;
        }
    }
}
