﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace SiPPOON_PP
{
    class Filter_Table
    {
        public void Check_Deffect(DataGridView data, RadioButton radio)
        {
            switch (radio.Checked)
            {
                case true:
                    for (int clmn = 4; clmn <= 24; clmn++)
                    {
                        data.Columns[clmn].Visible = false;
                    }
                    for (int row = data.Rows.Count - 2; row >= 0; row--)
                    {
                        if (Convert.ToDouble(data.Rows[row].Cells[25].Value) < 40)
                            if (Convert.ToDouble(data.Rows[row].Cells[27].Value) < 40)
                                if (Convert.ToDouble(data.Rows[row].Cells[29].Value) < 40)
                                    if (Convert.ToDouble(data.Rows[row].Cells[31].Value) < 40)
                                        data.Rows[row].Visible = false;
                    }
                    break;
                case false:
                    for (int clmn = 4; clmn <= 24; clmn++)
                    {
                        data.Columns[clmn].Visible = true;
                    }
                    for (int row = data.Rows.Count - 2; row >= 0; row--)
                    {
                        data.Rows[row].Visible = true;
                    }
                    break;
            }
        }

        public void Check_Prev(DataGridView data, RadioButton radio)
        {
            Fill_Table table = new Fill_Table();
            table.dataGrid = data;
            switch (radio.Checked)
            {
                case true:
                    foreach (DataGridViewRow row in table.dataGrid.Rows)
                    {
                        for (int i = 5; i <= 7; i++)
                        {
                            if (Convert.ToDouble(row.Cells[i].Value) >= 4.22)
                            {
                                if (row.DefaultCellStyle.BackColor == Color.Empty)
                                    row.Cells[i].Style.BackColor = Color.IndianRed;
                                else
                                    row.Cells[i].Style.BackColor = Color.Yellow;
                            }
                        }
                        for (int i = 10; i <= 12; i++)
                        {
                            if (Convert.ToDouble(row.Cells[i].Value) >= 20)
                            {
                                if (row.DefaultCellStyle.BackColor == Color.Empty)
                                    row.Cells[i].Style.BackColor = Color.IndianRed;
                                else
                                    row.Cells[i].Style.BackColor = Color.Yellow;
                            }
                        }
                        for (int i = 15; i <= 17; i++)
                        {
                            if (Convert.ToDouble(row.Cells[i].Value) >= 3)
                            {
                                if (row.DefaultCellStyle.BackColor == Color.Empty)
                                    row.Cells[i].Style.BackColor = Color.IndianRed;
                                else
                                    row.Cells[i].Style.BackColor = Color.Yellow;
                            }
                        }
                        for (int i = 20; i <= 22; i++)
                        {
                            if (Convert.ToDouble(row.Cells[i].Value) >= 5)
                            {
                                if (row.DefaultCellStyle.BackColor == Color.Empty)
                                    row.Cells[i].Style.BackColor = Color.IndianRed;
                                else
                                    row.Cells[i].Style.BackColor = Color.Yellow;
                            }
                        }
                    }
                    break;
                case false:
                    foreach (DataGridViewRow row in table.dataGrid.Rows)
                    {
                        for (int i = 5; i <= 7; i++)
                        {
                            row.Cells[i].Style.BackColor = Color.Empty;
                        }
                        for (int i = 10; i <= 12; i++)
                        {
                            row.Cells[i].Style.BackColor = Color.Empty;
                        }
                        for (int i = 15; i <= 17; i++)
                        {
                            row.Cells[i].Style.BackColor = Color.Empty;
                        }
                        for (int i = 20; i <= 22; i++)
                        {
                            row.Cells[i].Style.BackColor = Color.Empty;
                        }
                    }
                    break;
            }
        }

        public void Sort_Table(DataGridView dgv)
        {
            int i = 0;
            for (int row = dgv.Rows.Count - 2; row >= i; row--)
            {
                if (dgv.Rows[row].Cells[4].Value.ToString() == "")
                {
                    dgv.Rows.RemoveAt(row);
                    dgv.Rows[row - 1].DefaultCellStyle.BackColor = Color.Yellow;
                }
                if (dgv.Rows[row].DefaultCellStyle.BackColor == Color.Yellow)
                    dgv.Rows[row].Cells[3].Value = "Итог:";
            }
            dgv.Refresh();
        }

        public void Clear_Filter(DataGridView data, RadioButton radio)
        {
            Fill_Table table = new Fill_Table();
            table.dataGrid = data;
            switch (radio.Checked)
            {
                case true:
                    foreach (DataGridViewRow row in table.dataGrid.Rows)
                    {
                        for (int i = 5; i <= 7; i++)
                        {
                            row.Cells[i].Style.BackColor = Color.Empty;
                        }
                        for (int i = 10; i <= 12; i++)
                        {
                            row.Cells[i].Style.BackColor = Color.Empty;
                        }
                        for (int i = 15; i <= 17; i++)
                        {
                            row.Cells[i].Style.BackColor = Color.Empty;
                        }
                        for (int i = 20; i <= 22; i++)
                        {
                            row.Cells[i].Style.BackColor = Color.Empty;
                        }
                    }
                    for (int clmn = 4; clmn <= 24; clmn++)
                    {
                        data.Columns[clmn].Visible = true;
                    }
                    for (int row = data.Rows.Count - 2; row >= 0; row--)
                    {
                        data.Rows[row].Visible = true;
                    }
                    break;
            }
        }

        public void Chart_Import(Chart chart, DataGridView data, CheckedListBox listBox)
        {
            Fill_Table table = new Fill_Table();
            table.dataGrid = data;
            int i = listBox.Items.Count;
            try
            {
                chart.Series.Clear();
                foreach (string s in listBox.CheckedItems)
                    chart.Series.Add(s);
                //for (int j = 0; j < data.Rows.Count; j++)
                //    data.Rows[j].Cells[0].Value = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Chart_Export(Chart chart, DataGridView data, CheckedListBox listBox)
        {
            int k = data.SelectedCells[0].RowIndex;
            try
            {
                if ((Boolean)data.Rows[k].Cells[0].Value == false)
                {
                    data.Rows[k].Cells[0].Value = true;
                    if (listBox.GetItemChecked(0) == true)
                        chart.Series["Продольная ровность"].Points.AddXY(data.Rows[k].Cells[3].Value.ToString(), data.Rows[k].Cells[5].Value);
                    if (listBox.GetItemChecked(1) == true)
                        chart.Series["Поперечная ровность"].Points.AddXY(data.Rows[k].Cells[3].Value.ToString(), data.Rows[k].Cells[10].Value);
                    if (listBox.GetItemChecked(2) == true)
                        chart.Series["Плотность трещин"].Points.AddXY(data.Rows[k].Cells[3].Value.ToString(), data.Rows[k].Cells[15].Value);
                    if (listBox.GetItemChecked(3) == true)
                        chart.Series["Плотность ремонтных карт"].Points.AddXY(data.Rows[k].Cells[3].Value.ToString(), data.Rows[k].Cells[20].Value);
                }
                else if ((Boolean)data.Rows[k].Cells[0].Value == true)
                {
                    data.Rows[k].Cells[0].Value = false;
                    if (listBox.GetItemChecked(0) == true)
                        chart.Series["Продольная ровность"].Points.Clear();
                    if (listBox.GetItemChecked(1) == true)
                        chart.Series["Поперечная ровность"].Points.Clear();
                    if (listBox.GetItemChecked(2) == true)
                        chart.Series["Плотность трещин"].Points.Clear();
                    if (listBox.GetItemChecked(3) == true)
                        chart.Series["Плотность ремонтных карт"].Points.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}