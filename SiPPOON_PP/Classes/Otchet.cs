using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace SiPPOON_PP.Classes
{
    class Otchet
    {
        public static double Ploshad { get; set; }
        public static double Percent_One { get; set; }
        public static double Percent_Two { get; set; }
        public static double Percent_Three { get; set; }
        public static double Percent_Four { get; set; }
        public static double Percent_PPCBN { get; set; }
        public static double Metr_One { get; set; }
        public static double Metr_Two { get; set; }
        public static double Metr_Three { get; set; }
        public static double Metr_Four { get; set; }
        public static double Metr_PPCBN { get; set; }
        public void Otchet_Fill_Set(DataGridView data)
        {
            Percent_One = 0;
            Percent_Two = 0;
            Percent_Three = 0;
            Percent_Four = 0;
            Percent_PPCBN = 0;
            Metr_One = 0;
            Metr_Two = 0;
            Metr_Three = 0;
            Metr_Four = 0;
            Metr_PPCBN = 0;
            for (int i = 0; i < data.RowCount - 2; i++)
            {
                Ploshad += Convert.ToDouble(data.Rows[i].Cells[4].Value);
                Percent_One += Convert.ToDouble(data.Rows[i].Cells[25].Value);
                Percent_Two += Convert.ToDouble(data.Rows[i].Cells[27].Value);
                Percent_Three += Convert.ToDouble(data.Rows[i].Cells[29].Value);
                Percent_Four += Convert.ToDouble(data.Rows[i].Cells[31].Value);
                Percent_PPCBN += Convert.ToDouble(data.Rows[i].Cells[33].Value);
                Metr_One += Convert.ToDouble(data.Rows[i].Cells[26].Value);
                Metr_Two += Convert.ToDouble(data.Rows[i].Cells[28].Value);
                Metr_Three += Convert.ToDouble(data.Rows[i].Cells[30].Value);
                Metr_Four += Convert.ToDouble(data.Rows[i].Cells[32].Value);
                Metr_PPCBN += Convert.ToDouble(data.Rows[i].Cells[34].Value);
            }
            Percent_One /= data.RowCount - 2;
            Percent_Two /= data.RowCount - 2;
            Percent_Three /= data.RowCount - 2;
            Percent_Four /= data.RowCount - 2;
            Percent_PPCBN /= data.RowCount - 2;
        }

        public void Check_Object(DataGridView dataGridView, Chart chart, CheckedListBox checkedListBox, List<string> objectList, ToolStripMenuItem toolStripButton)
        {
            int k = dataGridView.SelectedCells[0].RowIndex;
            if (dataGridView.Rows[k].DefaultCellStyle.BackColor == Color.Green)
                MessageBox.Show("Вы уже внесли этот объект в отчёт!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Filter_Table filter_Table = new Filter_Table();
                filter_Table.Chart_Export(chart, dataGridView, checkedListBox, objectList);
                if (objectList.Count > 0)
                    toolStripButton.Enabled = true;
                else
                    toolStripButton.Enabled = false;
            }
        }

        public void Set_Object(DataGridView dataGridView, ToolStripMenuItem toolStripButton)
        {
            DB_Procedures procedures = new DB_Procedures();
            DataTable table = new DataTable();
            try
            {
                string mySelectQuery = "select [ID_Employee] from [Account] inner join [Employee] on [Account].[Employee_ID] = [Employee].[ID_Employee] where [Login_Account] = '" + Form_Authorize.Login + "'";
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery, Registry_Class.sql))
                {
                    dataAdapter.Fill(table);
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        if ((Convert.ToBoolean(dataGridView.Rows[i].Cells[0].Value) == true))
                        {
                            procedures.spOtchet_Analisys_Insert(dataGridView.Rows[i].Cells[3].Value.ToString(), 1, Convert.ToDouble(dataGridView.Rows[i].Cells[4].Value), Convert.ToDouble(dataGridView.Rows[i].Cells[25].Value),
                            Convert.ToDouble(dataGridView.Rows[i].Cells[26].Value), Convert.ToDouble(dataGridView.Rows[i].Cells[27].Value), Convert.ToDouble(dataGridView.Rows[i].Cells[28].Value),
                            Convert.ToDouble(dataGridView.Rows[i].Cells[29].Value), Convert.ToDouble(dataGridView.Rows[i].Cells[30].Value), Convert.ToDouble(dataGridView.Rows[i].Cells[31].Value),
                            Convert.ToDouble(dataGridView.Rows[i].Cells[32].Value), Convert.ToDouble(dataGridView.Rows[i].Cells[33].Value), Convert.ToDouble(dataGridView.Rows[i].Cells[34].Value),
                            DateTime.Now.ToShortDateString(), Convert.ToInt32(table.Rows[0]["ID_Employee"].ToString()));
                            dataGridView.Rows[i].Cells[0].Value = false;
                            toolStripButton.Enabled = false;
                            dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Функция добавления объекта в базу не работает. Обратитесть к администратору!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Get_Object(DataGridView dataGridView)
        {
            DataTable table = new DataTable();
            try
            {
                string mySelectQuery = "select [Naim_Object] from [Otchet_Analisys]";
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery, Registry_Class.sql))
                {
                    dataAdapter.Fill(table);
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            if (Convert.ToString(dataGridView.Rows[i].Cells[3].Value) == Convert.ToString(row["Naim_Object"]))
                                dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Функция получения объектов из базы не работает. Обратитесть к администратору!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
