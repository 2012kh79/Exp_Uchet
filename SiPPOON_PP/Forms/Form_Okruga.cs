using System;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;

namespace SiPPOON_PP
{
    public partial class Form_Okruga : Form
    {
        public static string constr;
        DataGridView dgv_Excel;
        List<string> List_Okruga = new List<string>();
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
        }

        public void dgv_Okruga_Fill()
        {
            Fill_Table table = new Fill_Table();
            Filter_Table filter = new Filter_Table();
            Action action = () =>
            {
                try
                {
                    table.dtOkrugaFill();
                    table.Table(dgv_Okruga, table.dtOkruga);
                    filter.Sort_Table(dgv_Okruga);
                    dgv_Okruga.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        public void dgv_VAO_Fill()
        {
            Fill_Table table = new Fill_Table();
            Action action = () =>
            {
                try
                {
                    table.dtVAOFill();
                    table.Table(dgv_VAO, table.dtVAO);
                    dgv_VAO.ReadOnly = true;
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
            Action action = () =>
            {
                try
                {
                    table.dtZAOFill();
                    table.Table(dgv_ZAO, table.dtZAO);
                    dgv_ZAO.ReadOnly = true;
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
            Action action = () =>
            {
                try
                {
                    table.dtZelAoFill();
                    table.Table(dgv_ZelAO, table.dtZelAO);
                    dgv_ZelAO.ReadOnly = true;
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
            Action action = () =>
            {
                try
                {
                    table.dtSAOFill();
                    table.Table(dgv_SAO, table.dtSAO);
                    dgv_SAO.ReadOnly = true;
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
            Action action = () =>
            {
                try
                {
                    table.dtSVAOFill();
                    table.Table(dgv_SVAO, table.dtSVAO);
                    dgv_SVAO.ReadOnly = true;
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
            Action action = () =>
            {
                try
                {
                    table.dtSZAOFill();
                    table.Table(dgv_SZAO, table.dtSZAO);
                    dgv_SZAO.ReadOnly = true;
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
            Action action = () =>
            {
                try
                {
                    table.dtTiNAOFill();
                    table.Table(dgv_TiNAO, table.dtTiNAO);
                    dgv_TiNAO.ReadOnly = true;
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
            Action action = () =>
            {
                try
                {
                    table.dtTSAOFill();
                    table.Table(dgv_TSAO, table.dtTSAO);
                    dgv_TSAO.ReadOnly = true;
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
            Action action = () =>
            {
                try
                {
                    table.dtYAOFill();
                    table.Table(dgv_YAO, table.dtYAO);
                    dgv_YAO.ReadOnly = true;
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
            Action action = () =>
            {
                try
                {
                    table.dtYVAOFill();
                    table.Table(dgv_YVAO, table.dtYVAO);
                    dgv_YVAO.ReadOnly = true;
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
            Action action = () =>
            {
                try
                {
                    table.dtYZAOFill();
                    table.Table(dgv_YZAO, table.dtYZAO);
                    dgv_YZAO.ReadOnly = true;
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
                    Thread thread_Okruga = new Thread(dgv_Okruga_Fill);
                    thread_Okruga.Start();
                    Thread thread_VAO = new Thread(dgv_VAO_Fill);
                    thread_VAO.Start();
                    Thread thread_ZAO = new Thread(dgv_ZAO_Fill);
                    thread_ZAO.Start();
                    Thread thread_ZelAO = new Thread(dgv_ZelAO_Fill);
                    thread_ZelAO.Start();
                    Thread thread_SAO = new Thread(dgv_SAO_Fill);
                    thread_SAO.Start();
                    Thread thread_SVAO = new Thread(dgv_SVAO_Fill);
                    thread_SVAO.Start();
                    Thread thread_SZAO = new Thread(dgv_SZAO_Fill);
                    thread_SZAO.Start();
                    Thread thread_TiNAO = new Thread(dgv_TiNAO_Fill);
                    thread_TiNAO.Start();
                    Thread thread_TSAO = new Thread(dgv_TSAO_Fill);
                    thread_TSAO.Start();
                    Thread thread_YAO = new Thread(dgv_YAO_Fill);
                    thread_YAO.Start();
                    Thread thread_YVAO = new Thread(dgv_YVAO_Fill);
                    thread_YVAO.Start();
                    Thread thread_YZAO = new Thread(dgv_YZAO_Fill);
                    thread_YZAO.Start();
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

        private void rb_Prev_VAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_VAO, rb_Prev_VAO);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Deffect_VAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_VAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_VAO, rb_Deffect_VAO);
            toolStripMenuItem3.Enabled = true;
        }

        private void rb_Prev_ZAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_ZAO, rb_Prev_ZAO);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Deffect_ZAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_ZAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_ZAO, rb_Deffect_ZAO);
            toolStripMenuItem3.Enabled = true;
        }

        private void rb_Prev_ZelAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_ZelAO, rb_Prev_ZelAO);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Deffect_ZelAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_ZelAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_ZelAO, rb_Deffect_ZelAO);
            toolStripMenuItem3.Enabled = true;
        }

        private void rb_Prev_SAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_SAO, rb_Prev_SAO);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Deffect_SAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_SAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_SAO, rb_Deffect_SAO);
            toolStripMenuItem3.Enabled = true;
        }

        private void rb_Prev_SVAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_SVAO, rb_Prev_SVAO);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Deffect_SVAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_SVAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_SVAO, rb_Deffect_SVAO);
            toolStripMenuItem3.Enabled = true;
        }

        private void rb_Prev_SZAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_SZAO, rb_Prev_SZAO);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Deffect_SZAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_SZAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_SZAO, rb_Deffect_SZAO);
            toolStripMenuItem3.Enabled = true;
        }

        private void rb_Prev_TiNAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_TiNAO, rb_Prev_TiNAO);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Deffect_TiNAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_TiNAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_TiNAO, rb_Deffect_TiNAO);
            toolStripMenuItem3.Enabled = true;
        }

        private void rb_Prev_TSAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_TSAO, rb_Prev_TSAO);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Deffect_TSAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_TSAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_TSAO, rb_Deffect_TSAO);
            toolStripMenuItem3.Enabled = true;
        }

        private void rb_Prev_YAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_YAO, rb_Prev_YAO);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Deffect_YAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_YAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_YAO, rb_Deffect_YAO);
            toolStripMenuItem3.Enabled = true;
        }

        private void rb_Prev_YVAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_YVAO, rb_Prev_YVAO);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Deffect_YVAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_YVAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_YVAO, rb_Deffect_YVAO);
            toolStripMenuItem3.Enabled = true;
        }

        private void rb_Prev_YZAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_YZAO, rb_Prev_YZAO);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Deffect_YZAO_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_YZAO;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_YZAO, rb_Deffect_YZAO);
            toolStripMenuItem3.Enabled = true;
        }

        private void rb_Prev_Okruga_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Check_Prev(dgv_Okruga, rb_Prev_Okruga);
            toolStripMenuItem3.Enabled = false;
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

        private void rb_Deffect_Okruga_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Excel = dgv_Okruga;
            Filter_Table filter = new Filter_Table();
            filter.Check_Deffect(dgv_Okruga, rb_Deffect_Okruga);
            toolStripMenuItem3.Enabled = true;
        }

        private void rb_Clear_Okruga_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_Okruga, rb_Clear_Okruga);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Clear_VAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_Okruga, rb_Clear_Okruga);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Clear_ZAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_ZAO, rb_Clear_ZAO);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_ZelAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_ZelAO, rb_ZelAO);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Clear_SAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_SAO, rb_Clear_SAO);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Clear_SVAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_SVAO, rb_Clear_SVAO);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Clear_SZAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_SZAO, rb_Clear_SZAO);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Clear_TiNAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_TiNAO, rb_Clear_TiNAO);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Clear_TSAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_TSAO, rb_Clear_TSAO);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Clear_YAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_YAO, rb_Clear_YAO);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Clear_YVAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_YVAO, rb_Clear_YVAO);
            toolStripMenuItem3.Enabled = false;
        }

        private void rb_Clear_YZAO_CheckedChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Clear_Filter(dgv_YZAO, rb_Clear_YZAO);
            toolStripMenuItem3.Enabled = false;
        }

        private void dgv_Okruga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Export(chart_Okruga, dgv_Okruga, clb_Okruga, List_Okruga);
        }

        private void clb_Okruga_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_Okruga, dgv_Okruga, clb_Okruga, List_Okruga);
        }

        private void dgv_VAO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Export(chart_VAO, dgv_VAO, clb_VAO, List_VAO);
        }

        private void clb_VAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_VAO, dgv_VAO, clb_VAO, List_VAO);
        }

        private void dgv_ZAO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Export(chart_ZAO, dgv_ZAO, clb_ZAO, List_ZAO);
        }

        private void clb_ZAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_ZAO, dgv_ZAO, clb_ZAO, List_ZAO);
        }

        private void dgv_ZelAO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Export(chart_ZelAO, dgv_ZelAO, clb_ZelAO, List_ZelAO);
        }

        private void clb_ZelAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_ZelAO, dgv_ZelAO, clb_ZelAO, List_ZelAO);
        }

        private void dgv_SAO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Export(chart_SAO, dgv_SAO, clb_SAO, List_SAO);
        }

        private void clb_SAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_SAO, dgv_SAO, clb_SAO, List_SAO);
        }

        private void dgv_SVAO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Export(chart_SVAO, dgv_SVAO, clb_SVAO, List_SVAO);
        }

        private void clb_SVAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_SVAO, dgv_SVAO, clb_SVAO, List_SVAO);
        }

        private void dgv_SZAO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Export(chart_SZAO, dgv_SZAO, clb_SZAO, List_SZAO);
        }

        private void clb_SZAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_SZAO, dgv_SZAO, clb_SZAO, List_SZAO);
        }

        private void dgv_TiNAO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Export(chart_TiNAO, dgv_TiNAO, clb_TiNAO, List_TiNAO);
        }

        private void clb_TiNAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_TiNAO, dgv_TiNAO, clb_TiNAO, List_TiNAO);
        }

        private void dgv_TSAO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Export(chart_TSAO, dgv_TSAO, clb_TSAO, List_TSAO);
        }

        private void clb_TSAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_TSAO, dgv_TSAO, clb_TSAO, List_TSAO);
        }

        private void dgv_YAO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Export(chart_YAO, dgv_YAO, clb_YAO, List_YAO);
        }

        private void clb_YAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_YAO, dgv_YAO, clb_YAO, List_YAO);
        }

        private void dgv_YVAO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Export(chart_YVAO, dgv_YVAO, clb_YVAO, List_YVAO);
        }

        private void clb_YVAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_YVAO, dgv_YVAO, clb_YVAO, List_YVAO);
        }

        private void dgv_YZAO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Export(chart_YZAO, dgv_YZAO, clb_YZAO, List_YZAO);
        }

        private void clb_YZAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter_Table filter = new Filter_Table();
            filter.Chart_Import(chart_YZAO, dgv_YZAO, clb_YZAO, List_YZAO);
        }

        private void Form_Okruga_FormClosing(object sender, FormClosingEventArgs e)
        {
            Classes.CallBack.callbackEventHandler("Enable_Okruga");
        }
    }
}
