using System;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SiPPOON_PP
{
    public partial class Form_Okruga : Form
    {
        DataGridView dgv_Excel;
        List<string> List_VAO = new List<string>();
        List<string> List_ZAO = new List<string>();
        List<string> List_ZelAO = new List<string>();
        List<string> List_SAO = new List<string>();
        List<string> List_SVAO = new List<string>();
        List<string> List_SZAO = new List<string>();
        List<string> List_TiNAO = new List<string>();
        List<string> List_TSAO = new List<string>();
        List<string> List_YAO = new List<string>();
        List<string> List_YZAO = new List<string>();
        List<string> List_YVAO = new List<string>();


        public Form_Okruga()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            rb_Clear_VAO.Checked = true;
            rb_Clear_ZAO.Checked = true;
            rb_ZelAO.Checked = true;
            rb_Clear_SAO.Checked = true;
            rb_Clear_SVAO.Checked = true;
            rb_Clear_SZAO.Checked = true;
            rb_Clear_TiNAO.Checked = true;
            rb_Clear_TSAO.Checked = true;
            rb_Clear_YAO.Checked = true;
            rb_Clear_YVAO.Checked = true;
            rb_Clear_YZAO.Checked = true;
        }

        public void dgv_VAO_Fill()
        {
            Fill_Table table = new Fill_Table();
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            Action action = () =>
            {
                try
                {
                    table.dtVAOFill();
                    table.Table(dgv_VAO, table.dtVAO);
                    otchet.Get_Object(dgv_VAO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        public void dgv_ZAO_Fill()
        {
            Fill_Table table = new Fill_Table();
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            Action action = () =>
            {
                try
                {
                    table.dtZAOFill();
                    table.Table(dgv_ZAO, table.dtZAO);
                    otchet.Get_Object(dgv_ZAO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        public void dgv_ZelAO_Fill()
        {
            Fill_Table table = new Fill_Table();
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            Action action = () =>
            {
                try
                {
                    table.dtZelAoFill();
                    table.Table(dgv_ZelAO, table.dtZelAO);
                    otchet.Get_Object(dgv_ZelAO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        public void dgv_SAO_Fill()
        {
            Fill_Table table = new Fill_Table();
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            Action action = () =>
            {
                try
                {
                    table.dtSAOFill();
                    table.Table(dgv_SAO, table.dtSAO);
                    otchet.Get_Object(dgv_SAO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        public void dgv_SVAO_Fill()
        {
            Fill_Table table = new Fill_Table();
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            Action action = () =>
            {
                try
                {
                    table.dtSVAOFill();
                    table.Table(dgv_SVAO, table.dtSVAO);
                    otchet.Get_Object(dgv_SVAO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        public void dgv_SZAO_Fill()
        {
            Fill_Table table = new Fill_Table();
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            Action action = () =>
            {
                try
                {
                    table.dtSZAOFill();
                    table.Table(dgv_SZAO, table.dtSZAO);
                    otchet.Get_Object(dgv_SZAO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        public void dgv_TiNAO_Fill()
        {
            Fill_Table table = new Fill_Table();
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            Action action = () =>
            {
                try
                {
                    table.dtTiNAOFill();
                    table.Table(dgv_TiNAO, table.dtTiNAO);
                    otchet.Get_Object(dgv_TiNAO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        public void dgv_TSAO_Fill()
        {
            Fill_Table table = new Fill_Table();
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            Action action = () =>
            {
                try
                {
                    table.dtTSAOFill();
                    table.Table(dgv_TSAO, table.dtTSAO);
                    otchet.Get_Object(dgv_TSAO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        public void dgv_YAO_Fill()
        {
            Fill_Table table = new Fill_Table();
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            Action action = () =>
            {
                try
                {
                    table.dtYAOFill();
                    table.Table(dgv_YAO, table.dtYAO);
                    otchet.Get_Object(dgv_YAO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        public void dgv_YVAO_Fill()
        {
            Fill_Table table = new Fill_Table();
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            Action action = () =>
            {
                try
                {
                    table.dtYVAOFill();
                    table.Table(dgv_YVAO, table.dtYVAO);
                    otchet.Get_Object(dgv_YVAO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        public void dgv_YZAO_Fill()
        {
            Fill_Table table = new Fill_Table();
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            Action action = () =>
            {
                try
                {
                    table.dtYZAOFill();
                    table.Table(dgv_YZAO, table.dtYZAO);
                    otchet.Get_Object(dgv_YZAO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void информацияОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Form about = new About_Form();
            about.Show();
        }

        private void rb_Prev_VAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_VAO, rb_Prev_VAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Deffect_VAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_VAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_VAO, rb_Deffect_VAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = true;
        }

        private void rb_Prev_ZAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_ZAO, rb_Prev_ZAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Deffect_ZAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_ZAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_ZAO, rb_Deffect_ZAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = true;
        }

        private void rb_Prev_ZelAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_ZelAO, rb_Prev_ZelAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Deffect_ZelAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_ZelAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_ZelAO, rb_Deffect_ZelAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = true;
        }

        private void rb_Prev_SAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_SAO, rb_Prev_SAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Deffect_SAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_SAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_SAO, rb_Deffect_SAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = true;
        }

        private void rb_Prev_SVAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_SVAO, rb_Prev_SVAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Deffect_SVAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_SVAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_SVAO, rb_Deffect_SVAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = true;
        }

        private void rb_Prev_SZAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_SZAO, rb_Prev_SZAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Deffect_SZAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_SZAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_SZAO, rb_Deffect_SZAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = true;
        }

        private void rb_Prev_TiNAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_TiNAO, rb_Prev_TiNAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Deffect_TiNAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_TiNAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_TiNAO, rb_Deffect_TiNAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = true;
        }

        private void rb_Prev_TSAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_TSAO, rb_Prev_TSAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Deffect_TSAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_TSAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_TSAO, rb_Deffect_TSAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = true;
        }

        private void rb_Prev_YAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_YAO, rb_Prev_YAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Deffect_YAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_YAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_YAO, rb_Deffect_YAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = true;
        }

        private void rb_Prev_YVAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_YVAO, rb_Prev_YVAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Deffect_YVAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_YVAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_YVAO, rb_Deffect_YVAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = true;
        }

        private void rb_Prev_YZAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_YZAO, rb_Prev_YZAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Deffect_YZAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_YZAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_YZAO, rb_Deffect_YZAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = true;
        }

        private void rb_Clear_VAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_VAO, rb_Clear_VAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Clear_ZAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_ZAO, rb_Clear_ZAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_ZelAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_ZelAO, rb_ZelAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Clear_SAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_SAO, rb_Clear_SAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Clear_SVAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_SVAO, rb_Clear_SVAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Clear_SZAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_SZAO, rb_Clear_SZAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Clear_TiNAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_TiNAO, rb_Clear_TiNAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Clear_TSAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_TSAO, rb_Clear_TSAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Clear_YAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_YAO, rb_Clear_YAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Clear_YVAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_YVAO, rb_Clear_YVAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Clear_YZAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_YZAO, rb_Clear_YZAO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void clb_VAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_VAO, dgv_VAO, clb_VAO, List_VAO);
        }

        private void clb_ZAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_ZAO, dgv_ZAO, clb_ZAO, List_ZAO);
        }

        private void clb_ZelAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_ZelAO, dgv_ZelAO, clb_ZelAO, List_ZelAO);
        }

        private void clb_SAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_SAO, dgv_SAO, clb_SAO, List_SAO);
        }

        private void clb_SVAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_SVAO, dgv_SVAO, clb_SVAO, List_SVAO);
        }

        private void clb_SZAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_SZAO, dgv_SZAO, clb_SZAO, List_SZAO);
        }

        private void clb_TiNAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_TiNAO, dgv_TiNAO, clb_TiNAO, List_TiNAO);
        }

        private void clb_TSAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_TSAO, dgv_TSAO, clb_TSAO, List_TSAO);
        }

        private void clb_YAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_YAO, dgv_YAO, clb_YAO, List_YAO);
        }

        private void clb_YVAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_YVAO, dgv_YVAO, clb_YVAO, List_YVAO);
        }

        private void clb_YZAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_YZAO, dgv_YZAO, clb_YZAO, List_YZAO);
        }

        private void Form_Okruga_FormClosing(object sender, FormClosingEventArgs e)
        {
            Classes.CallBack_Class.callbackEventHandler("Enable_Okruga");
            e.Cancel = true;
            this.Hide();
        }

        private void Form_Okruga_Load(object sender, EventArgs e)
        {
            try
            {
                Fill_Table.connectionString = Form_Main.Location_Result;
                Thread thread_VAO = new Thread(new ThreadStart(dgv_VAO_Fill));
                thread_VAO.Start();
                Thread thread_ZAO = new Thread(new ThreadStart(dgv_ZAO_Fill));
                thread_ZAO.Start();
                Thread thread_ZelAO = new Thread(new ThreadStart(dgv_ZelAO_Fill));
                thread_ZelAO.Start();
                Thread thread_SAO = new Thread(new ThreadStart(dgv_SAO_Fill));
                thread_SAO.Start();
                Thread thread_SVAO = new Thread(new ThreadStart(dgv_SVAO_Fill));
                thread_SVAO.Start();
                Thread thread_SZAO = new Thread(new ThreadStart(dgv_SZAO_Fill));
                thread_SZAO.Start();
                Thread thread_TiNAO = new Thread(new ThreadStart(dgv_TiNAO_Fill));
                thread_TiNAO.Start();
                Thread thread_TSAO = new Thread(new ThreadStart(dgv_TSAO_Fill));
                thread_TSAO.Start();
                Thread thread_YAO = new Thread(new ThreadStart(dgv_YAO_Fill));
                thread_YAO.Start();
                Thread thread_YVAO = new Thread(new ThreadStart(dgv_YVAO_Fill));
                thread_YVAO.Start();
                Thread thread_YZAO = new Thread(new ThreadStart(dgv_YZAO_Fill));
                thread_YZAO.Start();
                Thread thread_Okruga = new Thread(new ThreadStart(Get_Okruga));
                thread_Okruga.Start();
                MessageBox.Show("Результаты были успешно загружены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("При загрузке результатов произошла ошибка, выберите корректный файл. Если ошибка осталась, обратитесь к администратору", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Get_Okruga()
        {
            DataTable table = new DataTable();
            Action action = () =>
            {
                try
                {
                    string mySelectQuery = "select [Naim_Object], [Data_Otchet] from [Object_Obsledovaniya]";
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery, Registry_Class.sql))
                    {
                        dataAdapter.Fill(table);
                        foreach (DataRow row in table.Rows)
                        {
                            if (Convert.ToString(row["Naim_Object"]) == "ВАО" & Convert.ToString(row["Data_Otchet"]) == DateTime.Now.ToShortDateString())
                                всеОбъектыToolStripMenuItem.Enabled = false;
                            else if (Convert.ToString(row["Naim_Object"]) != "ВАО" & Convert.ToString(row["Data_Otchet"]) != DateTime.Now.ToShortDateString())
                                всеОбъектыToolStripMenuItem.Enabled = true;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Функция получения категорий не работает. Обратитесь к администратору", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }
        private void Excel_Set()
        {
            Excel_Document document = new Excel_Document();
            DataTable dt = new DataTable();
            DataRow dr;
            try
            {
                dt.Columns.Add("№ п/п");
                dt.Columns.Add("ID ОДХ");
                dt.Columns.Add("Наименование объекта");
                dt.Columns.Add("ПЛОЩАДЬ ПРОЕЗЖЕЙ ЧАСТИ С ВЫЯВЛЕННЫМИ НАРУШЕНИЯМИ. по 1 показателю (%)");
                dt.Columns.Add("ПЛОЩАДЬ ПРОЕЗЖЕЙ ЧАСТИ С ВЫЯВЛЕННЫМИ НАРУШЕНИЯМИ. по 2 показателям (%)");
                dt.Columns.Add("ПЛОЩАДЬ ПРОЕЗЖЕЙ ЧАСТИ С ВЫЯВЛЕННЫМИ НАРУШЕНИЯМИ. по 3 показателям (%)");
                dt.Columns.Add("ПЛОЩАДЬ ПРОЕЗЖЕЙ ЧАСТИ С ВЫЯВЛЕННЫМИ НАРУШЕНИЯМИ. по 4 показателям (%)");
                foreach (DataGridViewRow Row in dgv_Excel.Rows)
                {
                    if (Row.Visible == true)
                    {
                        dr = dt.NewRow();
                        dr["№ п/п"] = Row.Cells[1].Value;
                        dr["ID ОДХ"] = Row.Cells[2].Value;
                        dr["Наименование объекта"] = Row.Cells[3].Value;
                        dr["ПЛОЩАДЬ ПРОЕЗЖЕЙ ЧАСТИ С ВЫЯВЛЕННЫМИ НАРУШЕНИЯМИ. по 1 показателю (%)"] = Row.Cells[25].Value;
                        dr["ПЛОЩАДЬ ПРОЕЗЖЕЙ ЧАСТИ С ВЫЯВЛЕННЫМИ НАРУШЕНИЯМИ. по 2 показателям (%)"] = Row.Cells[27].Value;
                        dr["ПЛОЩАДЬ ПРОЕЗЖЕЙ ЧАСТИ С ВЫЯВЛЕННЫМИ НАРУШЕНИЯМИ. по 3 показателям (%)"] = Row.Cells[29].Value;
                        dr["ПЛОЩАДЬ ПРОЕЗЖЕЙ ЧАСТИ С ВЫЯВЛЕННЫМИ НАРУШЕНИЯМИ. по 4 показателям (%)"] = Row.Cells[31].Value;
                        dt.Rows.Add(dr);
                    }
                }
                if (Form_Main.Location_Folder != "")
                {
                    document.dtShet = dt;
                    document.Deffect_Create();
                    MessageBox.Show("Экспорт данных произошел успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Укажите путь к папке для хранения отчёта в настройках!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Функция экспорта деффектных участков не работает. Обратитесь к администратору", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void деффектныеУчасткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await Task.Run(() => Excel_Set());
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void выбранныеОбъектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            switch (tc_Okruga.SelectedIndex)
            {
                case 0:
                    otchet.Set_Object(dgv_VAO, chart_VAO, clb_VAO, List_VAO, выбранныеОбъектыToolStripMenuItem);
                    break;
                case 1:
                    otchet.Set_Object(dgv_ZAO, chart_ZAO, clb_ZAO, List_ZAO, выбранныеОбъектыToolStripMenuItem);
                    break;
                case 2:
                    otchet.Set_Object(dgv_ZelAO, chart_ZelAO, clb_ZelAO, List_ZelAO, выбранныеОбъектыToolStripMenuItem);
                    break;
                case 3:
                    otchet.Set_Object(dgv_SAO, chart_SAO, clb_SAO, List_SAO, выбранныеОбъектыToolStripMenuItem);
                    break;
                case 4:
                    otchet.Set_Object(dgv_SVAO, chart_SVAO, clb_SVAO, List_SVAO, выбранныеОбъектыToolStripMenuItem);
                    break;
                case 5:
                    otchet.Set_Object(dgv_SZAO, chart_SZAO, clb_SZAO, List_SZAO, выбранныеОбъектыToolStripMenuItem);
                    break;
                case 6:
                    otchet.Set_Object(dgv_TiNAO, chart_TiNAO, clb_TiNAO, List_TiNAO, выбранныеОбъектыToolStripMenuItem);
                    break;
                case 7:
                    otchet.Set_Object(dgv_TSAO, chart_TSAO, clb_TSAO, List_TSAO, выбранныеОбъектыToolStripMenuItem);
                    break;
                case 8:
                    otchet.Set_Object(dgv_YAO, chart_YAO, clb_YAO, List_YAO, выбранныеОбъектыToolStripMenuItem);
                    break;
                case 9:
                    otchet.Set_Object(dgv_YVAO, chart_YVAO, clb_YVAO, List_YVAO, выбранныеОбъектыToolStripMenuItem);
                    break;
                case 10:
                    otchet.Set_Object(dgv_YZAO, chart_YZAO, clb_YZAO, List_YZAO, выбранныеОбъектыToolStripMenuItem);
                    break;
            }
        }

        private void всеОбъектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            DataTable table = new DataTable();
            DB_Procedures procedures = new DB_Procedures();
            try
            {
                string mySelectQuery = "select [ID_Employee] from [Account] inner join [Employee] on [Account].[Employee_ID] = [Employee].[ID_Employee] where [Login_Account] = '" + Form_Authorize.Login + "'";
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery, Registry_Class.sql))
                {
                    dataAdapter.Fill(table);
                    otchet.Otchet_Fill_Set(dgv_VAO);
                    procedures.spOtchet_Analisys_Insert(tc_Okruga.TabPages[0].Text, dgv_VAO.RowCount - 2, Classes.Otchet_Class.Ploshad, Classes.Otchet_Class.Percent_One, Classes.Otchet_Class.Metr_One,
                        Classes.Otchet_Class.Percent_Two, Classes.Otchet_Class.Metr_Two, Classes.Otchet_Class.Percent_Three, Classes.Otchet_Class.Metr_Three, Classes.Otchet_Class.Percent_Four, Classes.Otchet_Class.Metr_Four,
                        Classes.Otchet_Class.Percent_PPCBN, Classes.Otchet_Class.Metr_PPCBN, DateTime.Now.ToShortDateString(), Convert.ToInt32(table.Rows[0]["ID_Employee"].ToString()));
                    otchet.Otchet_Fill_Set(dgv_ZAO);
                    procedures.spOtchet_Analisys_Insert(tc_Okruga.TabPages[1].Text, dgv_ZAO.RowCount - 2, Classes.Otchet_Class.Ploshad, Classes.Otchet_Class.Percent_One, Classes.Otchet_Class.Metr_One,
                         Classes.Otchet_Class.Percent_Two, Classes.Otchet_Class.Metr_Two, Classes.Otchet_Class.Percent_Three, Classes.Otchet_Class.Metr_Three, Classes.Otchet_Class.Percent_Four, Classes.Otchet_Class.Metr_Four,
                         Classes.Otchet_Class.Percent_PPCBN, Classes.Otchet_Class.Metr_PPCBN, DateTime.Now.ToShortDateString(), Convert.ToInt32(table.Rows[0]["ID_Employee"].ToString()));
                    otchet.Otchet_Fill_Set(dgv_ZelAO);
                    procedures.spOtchet_Analisys_Insert(tc_Okruga.TabPages[2].Text, dgv_ZelAO.RowCount - 2, Classes.Otchet_Class.Ploshad, Classes.Otchet_Class.Percent_One, Classes.Otchet_Class.Metr_One,
                        Classes.Otchet_Class.Percent_Two, Classes.Otchet_Class.Metr_Two, Classes.Otchet_Class.Percent_Three, Classes.Otchet_Class.Metr_Three, Classes.Otchet_Class.Percent_Four, Classes.Otchet_Class.Metr_Four,
                        Classes.Otchet_Class.Percent_PPCBN, Classes.Otchet_Class.Metr_PPCBN, DateTime.Now.ToShortDateString(), Convert.ToInt32(table.Rows[0]["ID_Employee"].ToString()));
                    otchet.Otchet_Fill_Set(dgv_SAO);
                    procedures.spOtchet_Analisys_Insert(tc_Okruga.TabPages[3].Text, dgv_SAO.RowCount - 2, Classes.Otchet_Class.Ploshad, Classes.Otchet_Class.Percent_One, Classes.Otchet_Class.Metr_One,
                         Classes.Otchet_Class.Percent_Two, Classes.Otchet_Class.Metr_Two, Classes.Otchet_Class.Percent_Three, Classes.Otchet_Class.Metr_Three, Classes.Otchet_Class.Percent_Four, Classes.Otchet_Class.Metr_Four,
                         Classes.Otchet_Class.Percent_PPCBN, Classes.Otchet_Class.Metr_PPCBN, DateTime.Now.ToShortDateString(), Convert.ToInt32(table.Rows[0]["ID_Employee"].ToString()));
                    otchet.Otchet_Fill_Set(dgv_SVAO);
                    procedures.spOtchet_Analisys_Insert(tc_Okruga.TabPages[4].Text, dgv_SVAO.RowCount - 2, Classes.Otchet_Class.Ploshad, Classes.Otchet_Class.Percent_One, Classes.Otchet_Class.Metr_One,
                         Classes.Otchet_Class.Percent_Two, Classes.Otchet_Class.Metr_Two, Classes.Otchet_Class.Percent_Three, Classes.Otchet_Class.Metr_Three, Classes.Otchet_Class.Percent_Four, Classes.Otchet_Class.Metr_Four,
                         Classes.Otchet_Class.Percent_PPCBN, Classes.Otchet_Class.Metr_PPCBN, DateTime.Now.ToShortDateString(), Convert.ToInt32(table.Rows[0]["ID_Employee"].ToString()));
                    otchet.Otchet_Fill_Set(dgv_SZAO);
                    procedures.spOtchet_Analisys_Insert(tc_Okruga.TabPages[5].Text, dgv_SZAO.RowCount - 2, Classes.Otchet_Class.Ploshad, Classes.Otchet_Class.Percent_One, Classes.Otchet_Class.Metr_One,
                          Classes.Otchet_Class.Percent_Two, Classes.Otchet_Class.Metr_Two, Classes.Otchet_Class.Percent_Three, Classes.Otchet_Class.Metr_Three, Classes.Otchet_Class.Percent_Four, Classes.Otchet_Class.Metr_Four,
                          Classes.Otchet_Class.Percent_PPCBN, Classes.Otchet_Class.Metr_PPCBN, DateTime.Now.ToShortDateString(), Convert.ToInt32(table.Rows[0]["ID_Employee"].ToString()));
                    otchet.Otchet_Fill_Set(dgv_TiNAO);
                    procedures.spOtchet_Analisys_Insert(tc_Okruga.TabPages[6].Text, dgv_TiNAO.RowCount - 2, Classes.Otchet_Class.Ploshad, Classes.Otchet_Class.Percent_One, Classes.Otchet_Class.Metr_One,
                        Classes.Otchet_Class.Percent_Two, Classes.Otchet_Class.Metr_Two, Classes.Otchet_Class.Percent_Three, Classes.Otchet_Class.Metr_Three, Classes.Otchet_Class.Percent_Four, Classes.Otchet_Class.Metr_Four,
                        Classes.Otchet_Class.Percent_PPCBN, Classes.Otchet_Class.Metr_PPCBN, DateTime.Now.ToShortDateString(), Convert.ToInt32(table.Rows[0]["ID_Employee"].ToString()));
                    otchet.Otchet_Fill_Set(dgv_TSAO);
                    procedures.spOtchet_Analisys_Insert(tc_Okruga.TabPages[7].Text, dgv_TSAO.RowCount - 2, Classes.Otchet_Class.Ploshad, Classes.Otchet_Class.Percent_One, Classes.Otchet_Class.Metr_One,
                        Classes.Otchet_Class.Percent_Two, Classes.Otchet_Class.Metr_Two, Classes.Otchet_Class.Percent_Three, Classes.Otchet_Class.Metr_Three, Classes.Otchet_Class.Percent_Four, Classes.Otchet_Class.Metr_Four,
                        Classes.Otchet_Class.Percent_PPCBN, Classes.Otchet_Class.Metr_PPCBN, DateTime.Now.ToShortDateString(), Convert.ToInt32(table.Rows[0]["ID_Employee"].ToString()));
                    otchet.Otchet_Fill_Set(dgv_YAO);
                    procedures.spOtchet_Analisys_Insert(tc_Okruga.TabPages[8].Text, dgv_YAO.RowCount - 2, Classes.Otchet_Class.Ploshad, Classes.Otchet_Class.Percent_One, Classes.Otchet_Class.Metr_One,
                        Classes.Otchet_Class.Percent_Two, Classes.Otchet_Class.Metr_Two, Classes.Otchet_Class.Percent_Three, Classes.Otchet_Class.Metr_Three, Classes.Otchet_Class.Percent_Four, Classes.Otchet_Class.Metr_Four,
                        Classes.Otchet_Class.Percent_PPCBN, Classes.Otchet_Class.Metr_PPCBN, DateTime.Now.ToShortDateString(), Convert.ToInt32(table.Rows[0]["ID_Employee"].ToString()));
                    otchet.Otchet_Fill_Set(dgv_YVAO);
                    procedures.spOtchet_Analisys_Insert(tc_Okruga.TabPages[9].Text, dgv_YVAO.RowCount - 2, Classes.Otchet_Class.Ploshad, Classes.Otchet_Class.Percent_One, Classes.Otchet_Class.Metr_One,
                        Classes.Otchet_Class.Percent_Two, Classes.Otchet_Class.Metr_Two, Classes.Otchet_Class.Percent_Three, Classes.Otchet_Class.Metr_Three, Classes.Otchet_Class.Percent_Four, Classes.Otchet_Class.Metr_Four,
                        Classes.Otchet_Class.Percent_PPCBN, Classes.Otchet_Class.Metr_PPCBN, DateTime.Now.ToShortDateString(), Convert.ToInt32(table.Rows[0]["ID_Employee"].ToString()));
                    otchet.Otchet_Fill_Set(dgv_YZAO);
                    procedures.spOtchet_Analisys_Insert(tc_Okruga.TabPages[10].Text, dgv_YZAO.RowCount - 2, Classes.Otchet_Class.Ploshad, Classes.Otchet_Class.Percent_One, Classes.Otchet_Class.Metr_One,
                        Classes.Otchet_Class.Percent_Two, Classes.Otchet_Class.Metr_Two, Classes.Otchet_Class.Percent_Three, Classes.Otchet_Class.Metr_Three, Classes.Otchet_Class.Percent_Four, Classes.Otchet_Class.Metr_Four,
                        Classes.Otchet_Class.Percent_PPCBN, Classes.Otchet_Class.Metr_PPCBN, DateTime.Now.ToShortDateString(), Convert.ToInt32(table.Rows[0]["ID_Employee"].ToString()));
                    MessageBox.Show("Данные по округам были уcпешно загружены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    всеОбъектыToolStripMenuItem.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Функция добавления округов в базу не работает. Обратитесь к администратору", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_ZelAO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            otchet.Check_Object(dgv_ZelAO, chart_ZelAO, clb_ZelAO, List_ZelAO, выбранныеОбъектыToolStripMenuItem);
        }

        private void dgv_VAO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            otchet.Check_Object(dgv_VAO, chart_VAO, clb_VAO, List_VAO, выбранныеОбъектыToolStripMenuItem);
        }

        private void dgv_ZAO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            otchet.Check_Object(dgv_ZAO, chart_ZAO, clb_ZAO, List_ZAO, выбранныеОбъектыToolStripMenuItem);
        }

        private void dgv_SAO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            otchet.Check_Object(dgv_SAO, chart_SAO, clb_SAO, List_SAO, выбранныеОбъектыToolStripMenuItem);
        }

        private void dgv_SVAO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            otchet.Check_Object(dgv_SVAO, chart_SVAO, clb_SVAO, List_SVAO, выбранныеОбъектыToolStripMenuItem);
        }

        private void dgv_SZAO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            otchet.Check_Object(dgv_SZAO, chart_SZAO, clb_SZAO, List_SZAO, выбранныеОбъектыToolStripMenuItem);
        }

        private void dgv_TiNAO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            otchet.Check_Object(dgv_TiNAO, chart_TiNAO, clb_TiNAO, List_TiNAO, выбранныеОбъектыToolStripMenuItem);
        }

        private void dgv_TSAO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            otchet.Check_Object(dgv_TSAO, chart_TSAO, clb_TSAO, List_TSAO, выбранныеОбъектыToolStripMenuItem);
        }

        private void dgv_YAO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            otchet.Check_Object(dgv_YAO, chart_YAO, clb_YAO, List_YAO, выбранныеОбъектыToolStripMenuItem);
        }

        private void dgv_YVAO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            otchet.Check_Object(dgv_YVAO, chart_YVAO, clb_YVAO, List_YVAO, выбранныеОбъектыToolStripMenuItem);
        }

        private void dgv_YZAO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.Otchet_Class otchet = new Classes.Otchet_Class();
            otchet.Check_Object(dgv_YZAO, chart_YZAO, clb_YZAO, List_YZAO, выбранныеОбъектыToolStripMenuItem);
        }
    }
}
