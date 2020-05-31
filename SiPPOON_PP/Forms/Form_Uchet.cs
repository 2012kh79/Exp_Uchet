using SiPPOON_PP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace SiPPOON_PP.Forms
{
    public partial class Form_Uchet : Form
    {
        DataTable dataTable = new DataTable();
        string Object_Select;
        public Form_Uchet()
        {
            InitializeComponent();
            mtb_Data_Uchet.Text = String.Format("{0}-{1}", mc_Uchet.SelectionStart.ToShortDateString(), mc_Uchet.SelectionEnd.ToShortDateString());
        }

        private void Otchet_Kategorii()
        {
            Fill_Table tables = new Fill_Table();
            Object_Select = "Категории";
            Action action = () =>
            {
                try
                {
                    while (dgv_Uchet.Rows.Count != 0)
                        dgv_Uchet.Rows.Remove(dgv_Uchet.Rows[dgv_Uchet.Rows.Count - 1]);
                    tables.dtOtchet_KategoriiFill();
                    dataTable = tables.dtOtchet_Kategorii;
                    dgv_Uchet.DataSource = tables.dtOtchet_Kategorii;
                    Naim_Headers();
                    dgv_Uchet.Columns[1].Visible = true;
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void Otchet_Okruga()
        {
            Fill_Table tables = new Fill_Table();
            Object_Select = "Округа";
            Action action = () =>
            {
                try
                {
                    while (dgv_Uchet.Rows.Count != 0)
                        dgv_Uchet.Rows.Remove(dgv_Uchet.Rows[dgv_Uchet.Rows.Count - 1]);
                    tables.dtOtchet_OkrugaFill();
                    dataTable = tables.dtOtchet_Okruga;
                    dgv_Uchet.DataSource = tables.dtOtchet_Okruga;
                    Naim_Headers();
                    dgv_Uchet.Columns[1].Visible = true;
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void Otchet_Analisys()
        {
            Fill_Table tables = new Fill_Table();
            Object_Select = "Все объекты";
            Action action = () =>
            {
                try
                {
                    while (dgv_Uchet.Rows.Count != 0)
                        dgv_Uchet.Rows.Remove(dgv_Uchet.Rows[dgv_Uchet.Rows.Count - 1]);
                    tables.dtOtchet_Analisys_ProverkaFill();
                    dataTable = tables.dtOtchet_Analisys_Proverka;
                    dgv_Uchet.DataSource = tables.dtOtchet_Analisys_Proverka;
                    Naim_Headers();
                    dgv_Uchet.Columns[1].Visible = false;
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void Naim_Headers ()
        {
            dgv_Uchet.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Uchet.Columns[0].HeaderText = "Наименование объекта";
            dgv_Uchet.Columns[1].HeaderText = "Количество объектов";
            dgv_Uchet.Columns[2].HeaderText = "Площадь объекта";
            dgv_Uchet.Columns[3].HeaderText = "Площадь проезжей части с выявленными нарушениями. по 1 параметру, %";
            dgv_Uchet.Columns[4].HeaderText = "Площадь проезжей части с выявленными нарушениями. по 1 параметру, кв.м";
            dgv_Uchet.Columns[5].HeaderText = "Площадь проезжей части с выявленными нарушениями. по 2 параметру, %";
            dgv_Uchet.Columns[6].HeaderText = "Площадь проезжей части с выявленными нарушениями. по 2 параметру, кв.м";
            dgv_Uchet.Columns[7].HeaderText = "Площадь проезжей части с выявленными нарушениями. по 3 параметру, %";
            dgv_Uchet.Columns[8].HeaderText = "Площадь проезжей части с выявленными нарушениями. по 3 параметру, кв.м";
            dgv_Uchet.Columns[9].HeaderText = "Площадь проезжей части с выявленными нарушениями. по 4 параметру, %";
            dgv_Uchet.Columns[10].HeaderText = "Площадь проезжей части с выявленными нарушениями. по 4 параметру, кв.м";
            dgv_Uchet.Columns[11].HeaderText = "Площадь проезжей части без нарушений, %";
            dgv_Uchet.Columns[12].HeaderText = "Площадь проезжей части без нарушений, кв.м";
            dgv_Uchet.Columns[13].HeaderText = "Дата создания заявки";
            dgv_Uchet.Columns[14].HeaderText = "Фамилия сотрудника";
        }

        private void Form_Uchet_Load(object sender, EventArgs e)
        {
            Thread thread_Otchet = new Thread(new ThreadStart(Otchet_Analisys));
            thread_Otchet.Start();
            Thread thread_Sotrudnik = new Thread(new ThreadStart(cmbID_EmployeeFill));
            thread_Sotrudnik.Start();
            string mySelectQuery = "select [Fam_Employee] from [Account] inner join [Employee] on [Account].[Employee_ID] = [Employee].[ID_Employee] where [Login_Account] = '" + Form_Authorize.Login + "'";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery, Registry_Class.sql))
            {
                DataTable data = new DataTable();
                dataAdapter.Fill(data);
                tb_Proveril.Text = data.Rows[0]["Fam_Employee"].ToString();
            }
        }

        private void категорииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otchet_Kategorii();
            tb_Search.Text = "";
            rb_Clear_Filter.Checked = true;
        }

        private void округаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otchet_Okruga();
            tb_Search.Text = "";
            rb_Clear_Filter.Checked = true;
        }

        private void всеОбъектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otchet_Analisys();
            tb_Search.Text = "";
            rb_Clear_Filter.Checked = true;
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = dataTable.DefaultView;
            if (rb_Clear_Filter.Checked == true)
            {
                dataView.RowFilter = string.Format("[Naim_Object] like '%{0}%'", tb_Search.Text);
                dgv_Uchet.DataSource = dataView.ToTable();
            }
            else if (rb_Filter_Sotrudnik.Checked == true)
            {
                dataView.RowFilter = string.Format("[Fam_Employee] like '%{0}%' AND [Naim_Object] like '%{1}%'", cmb_Filter_Sotrudnik.SelectedValue, tb_Search.Text);
                dgv_Uchet.DataSource = dataView.ToTable();
            }
            else if (rb_Filter_Data.Checked == true)
            {
                dataView.RowFilter = string.Format("[Data_Otchet] >= '{0:dd.MM.yyyy}' AND [Data_Otchet] <= '{1:dd.MM.yyyy}' AND [Naim_Object] like '%{2}%'", mc_Uchet.SelectionStart, mc_Uchet.SelectionEnd, tb_Search.Text);
                dgv_Uchet.DataSource = dataView.ToTable();
            }
        }

        private void mc_Uchet_DateChanged(object sender, DateRangeEventArgs e)
        {
            mtb_Data_Uchet.Text = String.Format("{0}-{1}", e.Start.ToShortDateString(), e.End.ToShortDateString());
        }

        private void cmbID_EmployeeFill()//Метод для заполнения ComboBox "Сотрудники" данными из таблицы SQL 
        {
            Action action = () =>
            {
                try
                {
                    string mySelectQuery = "select [Fam_Employee], [Role_name] from [Account] inner join [Employee] on [Account].[Employee_ID] = [Employee].[ID_Employee] " +
                    "inner join [Role] on [Account].[Role_ID] = [Role].[ID_Role] where [Role_name] = 'Сотрудник отдела контроля качества'";
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery, Registry_Class.sql))
                    {
                        DataTable table = new DataTable();
                        dataAdapter.Fill(table);
                        cmb_Filter_Sotrudnik.DataSource = table;
                        cmb_Filter_Sotrudnik.DisplayMember = "Employee";
                        cmb_Filter_Sotrudnik.ValueMember = "Fam_Employee";
                    }
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void btn_Word_Click(object sender, EventArgs e)
        {
            Form_Configuration configForm = new Form_Configuration();
            DataTable data = new DataTable();
            Word_Document document = new Word_Document();
            DataRow dr;
            if (configForm.ShowDialog() == DialogResult.OK)
            {
                data.Columns.Add("Наименование объекта");
                data.Columns.Add("Количество объектов");
                data.Columns.Add("Площадь объекта");
                data.Columns.Add("Площадь прозжей части с выявленными нарушениями. по 1-му параметру, %");
                data.Columns.Add("Площадь прозжей части с выявленными нарушениями. по 1-му параметру, кв.м");
                data.Columns.Add("Площадь прозжей части с выявленными нарушениями. по 2-му параметру, %");
                data.Columns.Add("Площадь прозжей части с выявленными нарушениями. по 2-му параметру, кв.м");
                data.Columns.Add("Площадь прозжей части с выявленными нарушениями. по 3-му параметру, %");
                data.Columns.Add("Площадь прозжей части с выявленными нарушениями. по 3-му параметру, кв.м");
                data.Columns.Add("Площадь прозжей части с выявленными нарушениями. по 4-му параметру, %");
                data.Columns.Add("Площадь прозжей части с выявленными нарушениями. по 4-му параметру, кв.м");
                data.Columns.Add("Площадь прозжей части без нарушений, %");
                data.Columns.Add("Площадь прозжей части без нарушений, кв.м");
                foreach (DataGridViewRow row in dgv_Uchet.Rows)
                {
                    dr = data.NewRow();
                    dr["Наименование объекта"] = row.Cells[0].Value.ToString();
                    dr["Количество объектов"] = row.Cells[1].Value.ToString();
                    dr["Площадь объекта"] = row.Cells[2].Value.ToString();
                    dr["Площадь прозжей части с выявленными нарушениями. по 1-му параметру, %"] = row.Cells[3].Value.ToString();
                    dr["Площадь прозжей части с выявленными нарушениями. по 1-му параметру, кв.м"] = row.Cells[4].Value.ToString();
                    dr["Площадь прозжей части с выявленными нарушениями. по 2-му параметру, %"] = row.Cells[5].Value.ToString();
                    dr["Площадь прозжей части с выявленными нарушениями. по 2-му параметру, кв.м"] = row.Cells[6].Value.ToString();
                    dr["Площадь прозжей части с выявленными нарушениями. по 3-му параметру, %"] = row.Cells[7].Value.ToString();
                    dr["Площадь прозжей части с выявленными нарушениями. по 3-му параметру, кв.м"] = row.Cells[8].Value.ToString();
                    dr["Площадь прозжей части с выявленными нарушениями. по 4-му параметру, %"] = row.Cells[9].Value.ToString();
                    dr["Площадь прозжей части с выявленными нарушениями. по 4-му параметру, кв.м"] = row.Cells[10].Value.ToString();
                    dr["Площадь прозжей части без нарушений, %"] = row.Cells[11].Value.ToString();
                    dr["Площадь прозжей части без нарушений, кв.м"] = row.Cells[12].Value.ToString();
                    data.Rows.Add(dr);
                }
                document.Shet_Facture(data);
            }
        }

        private void btn_PDF_Click(object sender, EventArgs e)
        {

        }

        private void rb_Filter_Data_CheckedChanged(object sender, EventArgs e)
        {
            switch (rb_Filter_Data.Checked)
            {
                case true:
                    DataView dataView = dataTable.DefaultView;
                    dataView.RowFilter = string.Format("[Data_Otchet] >= '{0:dd.MM.yyyy}' AND [Data_Otchet] <= '{1:dd.MM.yyyy}'", mc_Uchet.SelectionStart, mc_Uchet.SelectionEnd);
                    dgv_Uchet.DataSource = dataView.ToTable();
                    break;
                case false:
                    Get_Selected_Object();
                    tb_Search.Text = "";
                    break;
            }
        }

        private void rb_Filter_Sotrudnik_CheckedChanged(object sender, EventArgs e)
        {
            switch (rb_Filter_Sotrudnik.Checked)
            {
                case true:
                    DataView dataView = dataTable.DefaultView;
                    dataView.RowFilter = string.Format("[Fam_Employee] like '%{0}%'", cmb_Filter_Sotrudnik.SelectedValue);
                    dgv_Uchet.DataSource = dataView.ToTable();
                    break;
                case false:
                    Get_Selected_Object();
                    tb_Search.Text = "";
                    break;
            }
        }

        private void rb_Clear_Filter_CheckedChanged(object sender, EventArgs e)
        {
            Get_Selected_Object();
            tb_Search.Text = "";
        }

        private void Get_Selected_Object()
        {
            switch (Object_Select)
            {
                case "Категории":
                    Otchet_Kategorii();
                    break;
                case "Округа":
                    Otchet_Okruga();
                    break;
                case "Все объекты":
                    Otchet_Analisys();
                    break;
            }
        }
    }
}
