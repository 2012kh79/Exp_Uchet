using System;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;

namespace SiPPOON_PP
{
    public partial class Form_Kategorii : Form
    {
        public static string constr;
        DataGridView dgv_Excel;
        List<string> List_Kategorii = new List<string>();
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
        }

        public void dgv_Kategorii_Fill()
        {
            Fill_Table table = new Fill_Table();
            Filter_Table filter = new Filter_Table();
            Action action = () =>
            {
                try
                {
                    table.dtKategoriiFill();
                    table.Table(dgv_Kategorii, table.dtKategorii);
                    filter.Sort_Table(dgv_Kategorii);
                    dgv_Kategorii.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        public void dgv_Kategoriya_1_Fill()
        {
            Fill_Table table = new Fill_Table();
            Action action = () =>
            {
                try
                {
                    table.dtKategoriya_1Fill();
                    table.Table(dgv_Kategoriya1, table.dtKategoriya_1);
                    dgv_Kategoriya1.ReadOnly = true;
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
            Action action = () =>
            {
                try
                {
                    table.dtKategoriya_2Fill();
                    table.Table(dgv_Kategoriya2, table.dtKategoriya_2);
                    dgv_Kategoriya2.ReadOnly = true;
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
            Action action = () =>
            {
                try
                {
                    table.dtKategoriya_3Fill();
                    table.Table(dgv_Kategoriya3, table.dtKategoriya_3);
                    dgv_Kategoriya3.ReadOnly = true;
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
            Action action = () =>
            {
                try
                {
                    table.dtKategoriya_4Fill();
                    table.Table(dgv_Kategoriya4, table.dtKategoriya_4);
                    dgv_Kategoriya4.ReadOnly = true;
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
            Action action = () =>
            {
                try
                {
                    table.dtKategoriya_5Fill();
                    table.Table(dgv_Kategoriya5, table.dtKategoriya_5);
                    dgv_Kategoriya5.ReadOnly = true;
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
            Action action = () =>
            {
                try
                {
                    table.dtKategoriya_6Fill();
                    table.Table(dgv_Kategoriya6, table.dtKategoriya_6);
                    dgv_Kategoriya6.ReadOnly = true;
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
            Action action = () =>
            {
                try
                {
                    table.dtVKOFill();
                    table.Table(dgv_VKO, table.dtVKO);
                    dgv_VKO.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg_im = new OpenFileDialog();
                dlg_im.Filter = "Excel File|*.xls;*.xlsx;*.xlsm";
                if (dlg_im.ShowDialog() == DialogResult.OK)
                {
                    constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dlg_im.FileName + ";Extended Properties='Excel 12.0 XML;HDR=YES;';";
                    Fill_Table.connectionString = constr;
                    Thread thread_Kategorii = new Thread(dgv_Kategorii_Fill);
                    thread_Kategorii.Start();
                    Thread thread_Kategoriya_1 = new Thread(dgv_Kategoriya_1_Fill);
                    thread_Kategoriya_1.Start();
                    Thread thread_Kategoriya_2 = new Thread(dgv_Kategoriya_2_Fill);
                    thread_Kategoriya_2.Start();
                    Thread thread_Kategoriya_3 = new Thread(dgv_Kategoriya_3_Fill);
                    thread_Kategoriya_3.Start();
                    Thread thread_Kategoriya_4 = new Thread(dgv_Kategoriya_4_Fill);
                    thread_Kategoriya_4.Start();
                    Thread thread_Kategoriya_5 = new Thread(dgv_Kategoriya_5_Fill);
                    thread_Kategoriya_5.Start();
                    Thread thread_Kategoriya_6 = new Thread(dgv_Kategoriya_6_Fill);
                    thread_Kategoriya_6.Start();
                    Thread thread_VKO = new Thread(dgv_VKO_Fill);
                    thread_VKO.Start();
                    MessageBox.Show("Данные успешно загружены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripMenuItem3.Enabled = false;
                Form_Configuration configForm = new Form_Configuration();
                DataTable dt = new DataTable();
                DataRow dr;
                Excel_Document document = new Excel_Document();
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
                configForm.ShowDialog();
                if (Form_Configuration.document_default_path == "")
                    MessageBox.Show("Форма сохранения отчёта была закрыта, так как не был выбран путь!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    document.dtShet = dt;
                    document.Deffect_Create();
                    toolStripMenuItem3.Enabled = false;
                    MessageBox.Show("Экспорт данных произошел успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rb_Prev_Kategoriya1_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            Fill_Table table = new Fill_Table();
            filter.Check_Prev(dgv_Kategoriya1, rb_Prev_Kategoriya1);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Deffect_Kategoriya1_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_Kategoriya1;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_Kategoriya1, rb_Deffect_Kategoriya1);
            toolStripMenuItem3.Enabled = true;
        }
        private void rb_Prev_Kategoriya2_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_Kategoriya2, rb_Prev_Kategoriya2);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Deffect_Kategoriya2_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_Kategoriya2;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_Kategoriya2, rb_Deffect_Kategoriya2);
            toolStripMenuItem3.Enabled = true;
        }

        private void rb_Prev_Kategoriya3_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_Kategoriya3, rb_Prev_Kategoriya3);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Deffect_Kategoriya3_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_Kategoriya3;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_Kategoriya3, rb_Deffect_Kategoriya3);
            toolStripMenuItem3.Enabled = true;
        }

        private void rb_Prev_Kategoriya4_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_Kategoriya4, rb_Prev_Kategoriya4);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Deffect_Kategoriya4_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_Kategoriya4;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_Kategoriya4, rb_Deffect_Kategoriya4);
            toolStripMenuItem3.Enabled = true;
        }

        private void rb_Prev_Kategoriya5_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_Kategoriya5, rb_Prev_Kategoriya5);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Deffect_Kategoriya5_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_Kategoriya5;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_Kategoriya5, rb_Deffect_Kategoriya5);
            toolStripMenuItem3.Enabled = true;
        }

        private void rb_Prev_Kategoriya6_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_Kategoriya6, rb_Prev_Kategoriya6);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Deffect_Kategoriya6_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_Kategoriya6;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_Kategoriya6, rb_Deffect_Kategoriya6);
            toolStripMenuItem3.Enabled = true;
        }

        private void rb_Prev_VKO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_VKO, rb_Prev_VKO);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Deffect_VKO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_VKO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_VKO, rb_Deffect_VKO);
            toolStripMenuItem3.Enabled = true;
        }

        private void rb_Prev_Kategorii_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_Kategorii, rb_Prev_Kategorii);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Deffect_Kategorii_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_Kategorii;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_Kategorii, rb_Deffect_Kategorii);
            toolStripMenuItem3.Enabled = true;
        }

        private void rb_Clear_Kategorii_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_Kategorii, rb_Clear_Kategorii);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Clear_Kategoriya1_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_Kategoriya1, rb_Clear_Kategoriya1);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Clear_Kategoriya2_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_Kategoriya2, rb_Clear_Kategoriya2);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Clear_Kategoriya3_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_Kategoriya3, rb_Clear_Kategoriya3);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Clear_Kategoriya4_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_Kategoriya4, rb_Clear_Kategoriya4);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Clear_Kategoriya5_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_Kategoriya5, rb_Clear_Kategoriya5);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Clear_Kategoriya6_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_Kategoriya6, rb_Clear_Kategoriya6);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Clear_VKO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_VKO, rb_Clear_VKO);
            toolStripMenuItem3.Enabled = false;
        }

        private void dgv_Kategorii_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Export(chart_Kategorii, dgv_Kategorii, clb_Kategorii, List_Kategorii);
        }

        private void clb_Kategorii_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_Kategorii, dgv_Kategorii, clb_Kategorii, List_Kategorii);
        }

        private void dgv_Kategoriya1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Export(chart_Kategoriya1, dgv_Kategoriya1, clb_Kategoriya1, List_Kategoriya1);
        }

        private void clb_Kategoriya1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_Kategoriya1, dgv_Kategoriya1, clb_Kategoriya1, List_Kategoriya1);
        }

        private void dgv_Kategoriya2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Export(chart_Kategoriya2, dgv_Kategoriya2, clb_Kategoriya2, List_Kategoriya2);
        }

        private void clb_Kategoriya2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_Kategoriya2, dgv_Kategoriya2, clb_Kategoriya2, List_Kategoriya2);
        }

        private void dgv_Kategoriya3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Export(chart_Kategoriya3, dgv_Kategoriya3, clb_Kategoriya3, List_Kategoriya3);
        }

        private void clb_Kategoriya3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_Kategoriya3, dgv_Kategoriya3, clb_Kategoriya3, List_Kategoriya3);
        }

        private void dgv_Kategoriya4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Export(chart_Kategoriya4, dgv_Kategoriya4, clb_Kategoriya4, List_Kategoriya4);
        }

        private void clb_Kategoriya4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_Kategoriya4, dgv_Kategoriya4, clb_Kategoriya4, List_Kategoriya4);
        }

        private void dgv_Kategoriya5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Export(chart_Kategoriya5, dgv_Kategoriya5, clb_Kategoriya5, List_Kategoriya5);
        }

        private void checkedListBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_Kategoriya5, dgv_Kategoriya5, clb_Kategoriya5, List_Kategoriya5);
        }

        private void dgv_Kategoriya6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Export(chart_Kategoriya6, dgv_Kategoriya6, clb_Kategoriya6, List_Kategoriya6);
        }

        private void clb_Kategoriya6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_Kategoriya6, dgv_Kategoriya6, clb_Kategoriya6, List_Kategoriya6);
        }

        private void dgv_VKO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Export(chart_VKO, dgv_VKO, clb_VKO, List_VKO);
        }

        private void clb_VKO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_VKO, dgv_VKO, clb_VKO, List_VKO);
        }

        private void ФормаОбратнойСвязиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Feedback form_Feedback = new Form_Feedback();
            form_Feedback.Show();
        }
    }
}
