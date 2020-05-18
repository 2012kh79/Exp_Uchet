using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace SiPPOON_PP
{
    public partial class Form_Feedback : Form
    {
        string mySelectQuery1;
        readonly DataTable table = new DataTable();
        public Form_Feedback()
        {
            InitializeComponent();
            tb_Body.Text = "Опишите проблему, которая возникла в ходе эксплуатации программного продукта";
            tb_Body.ForeColor = Color.Gray;
            tb_PassMail.UseSystemPasswordChar = true;
        }

        private void Form_Mail_Load(object sender, EventArgs e)//Выгрузка в DataTable информации об аккаунте Сотрудника
        {
            mySelectQuery1 = "select * from [Account] inner join [Employee] on [Account].[Employee_ID] = [Employee].[ID_Employee] where [Login_Account] = '" + Form_Authorize.Login + "'";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery1, Registry_Class.sql))
            {
                dataAdapter.Fill(table);
                tb_Name.Text = table.Rows[0]["Imya_Employee"].ToString();
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)//Отправка данных по почте, с использованием метода из класса для подключения к SMTP-серверу
        {
            try
            {
                if (tb_PassMail.Text != "")
                {
                    if (tb_Name.Text != "")
                    {
                        Send_Mail sendMail = new Send_Mail(tb_Body.Text, "ГКУ \"Экспертавтодор\"", table.Rows[0]["Imya_Employee"].ToString(), table.Rows[0]["Mail"].ToString(), tb_PassMail.Text);
                        sendMail.MySendMail();
                        if (sendMail.dialogResult == DialogResult.OK)
                            this.Close();
                    }
                    else
                        MessageBox.Show("Заполните поле \"Ваше имя\"", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Заполните поле \"Пароль от почты\"", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_Body_Enter(object sender, EventArgs e)//Если сделать активным элемент управления TextBox
        {
            if (tb_Body.Text == "Опишите проблему, которая возникла в ходе эксплуатации программного продукта")
            {
                tb_Body.Clear();
                tb_Body.ForeColor = Color.Black;
            }
        }

        private void tb_Body_Leave(object sender, EventArgs e)//Если сделать неактивным элемент управления TextBox
        {
            if (tb_Body.Text == "")
            {
                tb_Body.Text = "Опишите проблему, которая возникла в ходе эксплуатации программного продукта";
                tb_Body.ForeColor = Color.Gray;
            }
        }
    }
}
