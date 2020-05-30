using System;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SiPPOON_PP
{
    public partial class Form_Kategorii : Form
    {
        DataGridView dgv_Excel;
        List<string> List_Kategoriya1 = new List<string>();
        List<string> List_Kategoriya2 = new List<string>();
        List<string> List_Kategoriya3 = new List<string>();
        List<string> List_Kategoriya4 = new List<string>();
        List<string> List_Kategoriya5 = new List<string>();
        List<string> List_Kategoriya6 = new List<string>();
        List<string> List_VKO = new List<string>();

        public Form_Kategorii()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            rb_Clear_Kategoriya1.Checked = true;
            rb_Clear_Kategoriya2.Checked = true;
            rb_Clear_Kategoriya3.Checked = true;
            rb_Clear_Kategoriya4.Checked = true;
            rb_Clear_Kategoriya5.Checked = true;
            rb_Clear_Kategoriya6.Checked = true;
            rb_Clear_VKO.Checked = true;
        }

        public void dgv_Kategoriya_1_Fill()
        {
            Fill_Table table = new Fill_Table();
            Classes.Otchet otchet = new Classes.Otchet();
            Action action = () =>
            {
                try
                {
                    table.dtKategoriya_1Fill();
                    table.Table(dgv_Kategoriya1, table.dtKategoriya_1);
                    otchet.Get_Object(dgv_Kategoriya1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        public void dgv_Kategoriya_2_Fill()
        {
            Fill_Table table = new Fill_Table();
            Classes.Otchet otchet = new Classes.Otchet();
            Action action = () =>
            {
                try
                {
                    table.dtKategoriya_2Fill();
                    table.Table(dgv_Kategoriya2, table.dtKategoriya_2);
                    otchet.Get_Object(dgv_Kategoriya2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        public void dgv_Kategoriya_3_Fill()
        {
            Fill_Table table = new Fill_Table();
            Classes.Otchet otchet = new Classes.Otchet();
            Action action = () =>
            {
                try
                {
                    table.dtKategoriya_3Fill();
                    table.Table(dgv_Kategoriya3, table.dtKategoriya_3);
                    otchet.Get_Object(dgv_Kategoriya3);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        public void dgv_Kategoriya_4_Fill()
        {
            Fill_Table table = new Fill_Table();
            Classes.Otchet otchet = new Classes.Otchet();
            Action action = () =>
            {
                try
                {
                    table.dtKategoriya_4Fill();
                    table.Table(dgv_Kategoriya4, table.dtKategoriya_4);
                    otchet.Get_Object(dgv_Kategoriya4);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        public void dgv_Kategoriya_5_Fill()
        {
            Fill_Table table = new Fill_Table();
            Classes.Otchet otchet = new Classes.Otchet();
            Action action = () =>
            {
                try
                {
                    table.dtKategoriya_5Fill();
                    table.Table(dgv_Kategoriya5, table.dtKategoriya_5);
                    otchet.Get_Object(dgv_Kategoriya5);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        public void dgv_Kategoriya_6_Fill()
        {
            Fill_Table table = new Fill_Table();
            Classes.Otchet otchet = new Classes.Otchet();
            Action action = () =>
            {
                try
                {
                    table.dtKategoriya_6Fill();
                    table.Table(dgv_Kategoriya6, table.dtKategoriya_6);
                    otchet.Get_Object(dgv_Kategoriya6);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        public void dgv_VKO_Fill()
        {
            Fill_Table table = new Fill_Table();
            Classes.Otchet otchet = new Classes.Otchet();
            Action action = () =>
            {
                try
                {
                    table.dtVKOFill();
                    table.Table(dgv_VKO, table.dtVKO);
                    otchet.Get_Object(dgv_VKO);
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

        private void rb_Prev_Kategoriya1_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_Kategoriya1, rb_Prev_Kategoriya1);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Deffect_Kategoriya1_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_Kategoriya1;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_Kategoriya1, rb_Deffect_Kategoriya1);
            деффектныеУчасткиToolStripMenuItem.Enabled = true;
        }
        private void rb_Prev_Kategoriya2_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_Kategoriya2, rb_Prev_Kategoriya2);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Deffect_Kategoriya2_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_Kategoriya2;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_Kategoriya2, rb_Deffect_Kategoriya2);
            деффектныеУчасткиToolStripMenuItem.Enabled = true;
        }

        private void rb_Prev_Kategoriya3_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_Kategoriya3, rb_Prev_Kategoriya3);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Deffect_Kategoriya3_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_Kategoriya3;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_Kategoriya3, rb_Deffect_Kategoriya3);
            деффектныеУчасткиToolStripMenuItem.Enabled = true;
        }

        private void rb_Prev_Kategoriya4_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_Kategoriya4, rb_Prev_Kategoriya4);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Deffect_Kategoriya4_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_Kategoriya4;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_Kategoriya4, rb_Deffect_Kategoriya4);
            деффектныеУчасткиToolStripMenuItem.Enabled = true;
        }

        private void rb_Prev_Kategoriya5_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_Kategoriya5, rb_Prev_Kategoriya5);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Deffect_Kategoriya5_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_Kategoriya5;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_Kategoriya5, rb_Deffect_Kategoriya5);
            деффектныеУчасткиToolStripMenuItem.Enabled = true;
        }

        private void rb_Prev_Kategoriya6_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_Kategoriya6, rb_Prev_Kategoriya6);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Deffect_Kategoriya6_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_Kategoriya6;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_Kategoriya6, rb_Deffect_Kategoriya6);
            деффектныеУчасткиToolStripMenuItem.Enabled = true;
        }

        private void rb_Prev_VKO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_VKO, rb_Prev_VKO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Deffect_VKO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_VKO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_VKO, rb_Deffect_VKO);
            деффектныеУчасткиToolStripMenuItem.Enabled = true;
        }

        private void rb_Clear_Kategoriya1_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_Kategoriya1, rb_Clear_Kategoriya1);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Clear_Kategoriya2_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_Kategoriya2, rb_Clear_Kategoriya2);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Clear_Kategoriya3_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_Kategoriya3, rb_Clear_Kategoriya3);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Clear_Kategoriya4_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_Kategoriya4, rb_Clear_Kategoriya4);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Clear_Kategoriya5_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_Kategoriya5, rb_Clear_Kategoriya5);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Clear_Kategoriya6_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_Kategoriya6, rb_Clear_Kategoriya6);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void rb_Clear_VKO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_VKO, rb_Clear_VKO);
            деффектныеУчасткиToolStripMenuItem.Enabled = false;
        }

        private void clb_Kategoriya1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_Kategoriya1, dgv_Kategoriya1, clb_Kategoriya1, List_Kategoriya1);
        }

        private void clb_Kategoriya2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_Kategoriya2, dgv_Kategoriya2, clb_Kategoriya2, List_Kategoriya2);
        }

        private void clb_Kategoriya3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_Kategoriya3, dgv_Kategoriya3, clb_Kategoriya3, List_Kategoriya3);
        }

        private void clb_Kategoriya4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_Kategoriya4, dgv_Kategoriya4, clb_Kategoriya4, List_Kategoriya4);
        }

        private void checkedListBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_Kategoriya5, dgv_Kategoriya5, clb_Kategoriya5, List_Kategoriya5);
        }

        private void clb_Kategoriya6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_Kategoriya6, dgv_Kategoriya6, clb_Kategoriya6, List_Kategoriya6);
        }

        private void clb_VKO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_VKO, dgv_VKO, clb_VKO, List_VKO);
        }

        private void Form_Kategorii_FormClosing(object sender, FormClosingEventArgs e)
        {
            Classes.CallBack.callbackEventHandler("Enable_Kategorii");
            e.Cancel = true;
            this.Hide();
        }

        private void Form_Kategorii_Load(object sender, EventArgs e)
        {
            try
            {
                Fill_Table.connectionString = Form_Main.Location_Result;
                Thread thread_Kategoriya_1 = new Thread(new ThreadStart(dgv_Kategoriya_1_Fill));
                thread_Kategoriya_1.Start();
                Thread thread_Kategoriya_2 = new Thread(new ThreadStart(dgv_Kategoriya_2_Fill));
                thread_Kategoriya_2.Start();
                Thread thread_Kategoriya_3 = new Thread(new ThreadStart(dgv_Kategoriya_3_Fill));
                thread_Kategoriya_3.Start();
                Thread thread_Kategoriya_4 = new Thread(new ThreadStart(dgv_Kategoriya_4_Fill));
                thread_Kategoriya_4.Start();
                Thread thread_Kategoriya_5 = new Thread(new ThreadStart(dgv_Kategoriya_5_Fill));
                thread_Kategoriya_5.Start();
                Thread thread_Kategoriya_6 = new Thread(new ThreadStart(dgv_Kategoriya_6_Fill));
                thread_Kategoriya_6.Start();
                Thread thread_VKO = new Thread(new ThreadStart(dgv_VKO_Fill));
                thread_VKO.Start();
                Thread thread_Kategorii = new Thread(new ThreadStart(Get_Kategorii));
                thread_Kategorii.Start();
                MessageBox.Show("Результаты были успешно загружены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("При загрузке результатов произошла ошибка, выберите корректный файл. Если ошибка осталась, обратитесь к администратору", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Get_Kategorii()
        {
            DataTable table = new DataTable();
            try
            {
                string mySelectQuery = "select [Naim_Object], [Data_Otchet] from [Otchet_Analisys]";
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery, Registry_Class.sql))
                {
                    dataAdapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        if (Convert.ToString(row["Naim_Object"]) == "1 категория" || Convert.ToString(row["Naim_Object"]) == "2 категория" || Convert.ToString(row["Naim_Object"]) == "3 категория"
                                || Convert.ToString(row["Naim_Object"]) == "4 категория" || Convert.ToString(row["Naim_Object"]) == "5 категория" || Convert.ToString(row["Naim_Object"]) == "6 категория"
                                || Convert.ToString(row["Naim_Object"]) == "ВКО" & Convert.ToString(row["Data_Otchet"]) == DateTime.Now.ToShortDateString())
                            всеОбъектыToolStripMenuItem.Enabled = false;
                        else if (Convert.ToString(row["Naim_Object"]) == "1 категория" || Convert.ToString(row["Naim_Object"]) == "2 категория" || Convert.ToString(row["Naim_Object"]) == "3 категория"
                                || Convert.ToString(row["Naim_Object"]) == "4 категория" || Convert.ToString(row["Naim_Object"]) == "5 категория" || Convert.ToString(row["Naim_Object"]) == "6 категория"
                                || Convert.ToString(row["Naim_Object"]) == "ВКО" & Convert.ToString(row["Data_Otchet"]) != DateTime.Now.ToShortDateString())
                            всеОбъектыToolStripMenuItem.Enabled = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Функция получения категорий не работает. Обратитесь к администратору", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void выбранныеОбъектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classes.Otchet otchet = new Classes.Otchet();
            switch (tc_Kategorii.SelectedIndex)
            {
                case 0:
                    otchet.Set_Object(dgv_Kategoriya1, chart_Kategoriya1, clb_Kategoriya1, List_Kategoriya1, выбранныеОбъектыToolStripMenuItem);
                    break;
                case 1:
                    otchet.Set_Object(dgv_Kategoriya2, chart_Kategoriya2, clb_Kategoriya2, List_Kategoriya2, выбранныеОбъектыToolStripMenuItem);
                    break;
                case 2:
                    otchet.Set_Object(dgv_Kategoriya3, chart_Kategoriya3, clb_Kategoriya3, List_Kategoriya3, выбранныеОбъектыToolStripMenuItem);
                    break;
                case 3:
                    otchet.Set_Object(dgv_Kategoriya4, chart_Kategoriya4, clb_Kategoriya4, List_Kategoriya4, выбранныеОбъектыToolStripMenuItem);
                    break;
                case 4:
                    otchet.Set_Object(dgv_Kategoriya5, chart_Kategoriya5, clb_Kategoriya5, List_Kategoriya5, выбранныеОбъектыToolStripMenuItem);
                    break;
                case 5:
                    otchet.Set_Object(dgv_Kategoriya6, chart_Kategoriya6, clb_Kategoriya6, List_Kategoriya6, выбранныеОбъектыToolStripMenuItem);
                    break;
                case 6:
                    otchet.Set_Object(dgv_VKO, chart_VKO, clb_VKO, List_VKO, выбранныеОбъектыToolStripMenuItem);
                    break;
            }
        }

        private void всеОбъектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classes.Otchet otchet = new Classes.Otchet();
            DataTable table = new DataTable();
            DB_Procedures procedures = new DB_Procedures();
            try
            {
                string mySelectQuery = "select [ID_Employee] from [Account] inner join [Employee] on [Account].[Employee_ID] = [Employee].[ID_Employee] where [Login_Account] = '" + Form_Authorize.Login + "'";
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery, Registry_Class.sql))
                {
                    dataAdapter.Fill(table);
                    otchet.Otchet_Fill_Set(dgv_Kategoriya1);
                    procedures.spOtchet_Analisys_Insert(tc_Kategorii.TabPages[0].Text, dgv_Kategoriya1.RowCount - 2, Classes.Otchet.Ploshad, Classes.Otchet.Percent_One, Classes.Otchet.Metr_One,
                        Classes.Otchet.Percent_Two, Classes.Otchet.Metr_Two, Classes.Otchet.Percent_Three, Classes.Otchet.Metr_Three, Classes.Otchet.Percent_Four, Classes.Otchet.Metr_Four,
                        Classes.Otchet.Percent_PPCBN, Classes.Otchet.Metr_PPCBN, DateTime.Now.ToShortDateString(), Convert.ToInt32(table.Rows[0]["ID_Employee"].ToString()));
                    otchet.Otchet_Fill_Set(dgv_Kategoriya2);
                    procedures.spOtchet_Analisys_Insert(tc_Kategorii.TabPages[1].Text, dgv_Kategoriya2.RowCount - 2, Classes.Otchet.Ploshad, Classes.Otchet.Percent_One, Classes.Otchet.Metr_One,
                         Classes.Otchet.Percent_Two, Classes.Otchet.Metr_Two, Classes.Otchet.Percent_Three, Classes.Otchet.Metr_Three, Classes.Otchet.Percent_Four, Classes.Otchet.Metr_Four,
                         Classes.Otchet.Percent_PPCBN, Classes.Otchet.Metr_PPCBN, DateTime.Now.ToShortDateString(), Convert.ToInt32(table.Rows[0]["ID_Employee"].ToString()));
                    otchet.Otchet_Fill_Set(dgv_Kategoriya3);
                    procedures.spOtchet_Analisys_Insert(tc_Kategorii.TabPages[2].Text, dgv_Kategoriya3.RowCount - 2, Classes.Otchet.Ploshad, Classes.Otchet.Percent_One, Classes.Otchet.Metr_One,
                        Classes.Otchet.Percent_Two, Classes.Otchet.Metr_Two, Classes.Otchet.Percent_Three, Classes.Otchet.Metr_Three, Classes.Otchet.Percent_Four, Classes.Otchet.Metr_Four,
                        Classes.Otchet.Percent_PPCBN, Classes.Otchet.Metr_PPCBN, DateTime.Now.ToShortDateString(), Convert.ToInt32(table.Rows[0]["ID_Employee"].ToString()));
                    otchet.Otchet_Fill_Set(dgv_Kategoriya4);
                    procedures.spOtchet_Analisys_Insert(tc_Kategorii.TabPages[3].Text, dgv_Kategoriya4.RowCount - 2, Classes.Otchet.Ploshad, Classes.Otchet.Percent_One, Classes.Otchet.Metr_One,
                         Classes.Otchet.Percent_Two, Classes.Otchet.Metr_Two, Classes.Otchet.Percent_Three, Classes.Otchet.Metr_Three, Classes.Otchet.Percent_Four, Classes.Otchet.Metr_Four,
                         Classes.Otchet.Percent_PPCBN, Classes.Otchet.Metr_PPCBN, DateTime.Now.ToShortDateString(), Convert.ToInt32(table.Rows[0]["ID_Employee"].ToString()));
                    otchet.Otchet_Fill_Set(dgv_Kategoriya5);
                    procedures.spOtchet_Analisys_Insert(tc_Kategorii.TabPages[4].Text, dgv_Kategoriya5.RowCount - 2, Classes.Otchet.Ploshad, Classes.Otchet.Percent_One, Classes.Otchet.Metr_One,
                         Classes.Otchet.Percent_Two, Classes.Otchet.Metr_Two, Classes.Otchet.Percent_Three, Classes.Otchet.Metr_Three, Classes.Otchet.Percent_Four, Classes.Otchet.Metr_Four,
                         Classes.Otchet.Percent_PPCBN, Classes.Otchet.Metr_PPCBN, DateTime.Now.ToShortDateString(), Convert.ToInt32(table.Rows[0]["ID_Employee"].ToString()));
                    otchet.Otchet_Fill_Set(dgv_Kategoriya6);
                    procedures.spOtchet_Analisys_Insert(tc_Kategorii.TabPages[5].Text, dgv_Kategoriya6.RowCount - 2, Classes.Otchet.Ploshad, Classes.Otchet.Percent_One, Classes.Otchet.Metr_One,
                          Classes.Otchet.Percent_Two, Classes.Otchet.Metr_Two, Classes.Otchet.Percent_Three, Classes.Otchet.Metr_Three, Classes.Otchet.Percent_Four, Classes.Otchet.Metr_Four,
                          Classes.Otchet.Percent_PPCBN, Classes.Otchet.Metr_PPCBN, DateTime.Now.ToShortDateString(), Convert.ToInt32(table.Rows[0]["ID_Employee"].ToString()));
                    otchet.Otchet_Fill_Set(dgv_VKO);
                    procedures.spOtchet_Analisys_Insert(tc_Kategorii.TabPages[6].Text, dgv_VKO.RowCount - 2, Classes.Otchet.Ploshad, Classes.Otchet.Percent_One, Classes.Otchet.Metr_One,
                        Classes.Otchet.Percent_Two, Classes.Otchet.Metr_Two, Classes.Otchet.Percent_Three, Classes.Otchet.Metr_Three, Classes.Otchet.Percent_Four, Classes.Otchet.Metr_Four,
                        Classes.Otchet.Percent_PPCBN, Classes.Otchet.Metr_PPCBN, DateTime.Now.ToShortDateString(), Convert.ToInt32(table.Rows[0]["ID_Employee"].ToString()));
                    MessageBox.Show("Данные по категориям были уcпешно загружены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    всеОбъектыToolStripMenuItem.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Функция добавления категорий в базу не работает. Обратитесь к администратору", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        }

        private void dgv_Kategoriya1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.Otchet otchet = new Classes.Otchet();
            otchet.Check_Object(dgv_Kategoriya1, chart_Kategoriya1, clb_Kategoriya1, List_Kategoriya1, выбранныеОбъектыToolStripMenuItem);
        }

        private void dgv_Kategoriya2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.Otchet otchet = new Classes.Otchet();
            otchet.Check_Object(dgv_Kategoriya2, chart_Kategoriya2, clb_Kategoriya2, List_Kategoriya2, выбранныеОбъектыToolStripMenuItem);
        }

        private void dgv_Kategoriya3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.Otchet otchet = new Classes.Otchet();
            otchet.Check_Object(dgv_Kategoriya3, chart_Kategoriya3, clb_Kategoriya3, List_Kategoriya3, выбранныеОбъектыToolStripMenuItem);
        }

        private void dgv_Kategoriya4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.Otchet otchet = new Classes.Otchet();
            otchet.Check_Object(dgv_Kategoriya4, chart_Kategoriya4, clb_Kategoriya4, List_Kategoriya4, выбранныеОбъектыToolStripMenuItem);
        }

        private void dgv_Kategoriya5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.Otchet otchet = new Classes.Otchet();
            otchet.Check_Object(dgv_Kategoriya5, chart_Kategoriya5, clb_Kategoriya5, List_Kategoriya5, выбранныеОбъектыToolStripMenuItem);
        }

        private void dgv_Kategoriya6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.Otchet otchet = new Classes.Otchet();
            otchet.Check_Object(dgv_Kategoriya6, chart_Kategoriya6, clb_Kategoriya6, List_Kategoriya6, выбранныеОбъектыToolStripMenuItem);
        }

        private void dgv_VKO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Classes.Otchet otchet = new Classes.Otchet();
            otchet.Check_Object(dgv_VKO, chart_VKO, clb_VKO, List_VKO, выбранныеОбъектыToolStripMenuItem);
        }
    }
}
