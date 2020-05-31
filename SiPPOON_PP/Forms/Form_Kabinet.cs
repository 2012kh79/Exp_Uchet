using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using SiPPOON_PP.Classes;

namespace SiPPOON_PP
{
    public partial class Form_Kabinet : Form
    {
        DataTable path = new DataTable();
        string location = AppDomain.CurrentDomain.BaseDirectory + "/Сотрудники/";
        public Form_Kabinet()
        {
            InitializeComponent();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            btn_Update.Enabled = false;
            tb_Familiya.Enabled = true;
            tb_Imya.Enabled = true;
            tb_Mail.Enabled = true;
            btn_Save.Enabled = true;
        }

        private void Form_Kabinet_Load(object sender, EventArgs e)
        {
            string mySelectQuery = "select * from [Account] inner join [Employee] on [Account].[Employee_ID] = [Employee].[ID_Employee] where [Login_Account] = '" + Form_Authorize.Login + "'";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery, Registry_Class.sql))
            {
                dataAdapter.Fill(path);
                string datalocation = path.Rows[0]["Photo_Employee"].ToString();
                location += datalocation.Replace("ftp://127.0.0.1/", "");
                if (path.Rows[0]["Photo_Employee"].ToString() == "")
                    pb_Sotrudnik.BackgroundImage = pb_Sotrudnik.ErrorImage;
                else
                {
                    FTPServer_Class ftp = new FTPServer_Class();
                    if (System.IO.File.Exists(location))
                        pb_Sotrudnik.BackgroundImage = new Bitmap(location);
                    else
                    {
                        ftp.Get_Image(path);
                        pb_Sotrudnik.BackgroundImage = new Bitmap(ftp.location);
                    }
                }
                tb_Familiya.Text = path.Rows[0]["Fam_Employee"].ToString();
                tb_Imya.Text = path.Rows[0]["Imya_Employee"].ToString();
                tb_Mail.Text = path.Rows[0]["Mail"].ToString();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            btn_Save.Enabled = false;
            tb_Familiya.Enabled = false;
            tb_Imya.Enabled = false;
            tb_Mail.Enabled = false;
            btn_Update.Enabled = true;
            DB_Procedures procedures = new DB_Procedures();
            if (tb_Familiya.Text != "" & tb_Imya.Text != "" & tb_Mail.Text != "")
            {
                try
                {
                    procedures.spEmployee_Update(Convert.ToInt32(path.Rows[0]["ID_Employee"].ToString()), tb_Familiya.Text, tb_Imya.Text, path.Rows[0]["Photo_Employee"].ToString());
                    procedures.spAccount_Update(path.Rows[0]["Login_Account"].ToString(), path.Rows[0]["Parol_Account"].ToString(), tb_Mail.Text, Convert.ToInt32(path.Rows[0]["Role_ID"].ToString()), Convert.ToInt32(path.Rows[0]["Employee_ID"].ToString()));
                }
                catch
                {
                    MessageBox.Show("Ошибка изменения", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Заполните поля данных", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
