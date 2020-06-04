using SiPPOON_PP.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace SiPPOON_PP
{
    public partial class Form_Main : Form
    {
        Form_Change form_Change = new Form_Change();
        public static string Location_Result { get; set; }
        public static string Location_Folder { get; set; }
        public Form_Main(bool Settings, bool Result, bool Propusk)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.BackgroundImage = new Bitmap(Properties.Resources.Zastavka);
            btn_Settings.Enabled = Settings;
            btn_Result.Enabled = Result;
            btn_Propusk.Enabled = Propusk;
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
            btn_Result.Text = "Анализ результатов";
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
            btn_Propusk.Text = "Учёт результатов";
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
            Form_Uchet form_Uchet = new Form_Uchet();
            form_Uchet.ShowDialog();
        }

        private void btn_FeedBack_Click(object sender, EventArgs e)
        {
            Form_Feedback form_Feedback = new Form_Feedback();
            form_Feedback.ShowDialog();
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            About_Form about_Form = new About_Form();
            about_Form.ShowDialog();
        }

        private void btn_Kabinet_Click(object sender, EventArgs e)
        {
            Form_Kabinet form_Kabinet = new Form_Kabinet();
            form_Kabinet.ShowDialog();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            Form_Settings form_Settings = new Form_Settings();
            form_Settings.ShowDialog();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            string mySelectQuery = "select [Role_name], [Login_Account] from [Account] inner join [Role] on [Account].[Role_ID] = [Role].[ID_Role] where [Login_Account] = '" + Form_Authorize.Login + "'";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery, Registry_Class.sql))
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                if (table.Rows[0]["Role_name"].ToString() == "Сотрудник отдела контроля качества")
                    if (!File.Exists("Настройки.xml"))
                        MessageBox.Show("Здравствуйте, " + Form_Authorize.Login + ". Не забудьте указать путь к файлу с результатами дорожного исследования в настройках и папку для хранения отчёта!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        XmlDocument doc = new XmlDocument();
                        doc.Load("Настройки.xml");
                        foreach (XmlNode node in doc.DocumentElement)
                        {
                            Location_Result = node["Path_File"].InnerText;
                            Location_Folder = node["Path_Folder"].InnerText;
                        }
                    }
            }
        }
    }
}
