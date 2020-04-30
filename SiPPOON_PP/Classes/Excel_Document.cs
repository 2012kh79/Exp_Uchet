﻿using System;
using System.Data;
using excel = Microsoft.Office.Interop.Excel;

namespace SiPPOON_PP
{
    class Excel_Document
    {
        public DataTable dtShet = new DataTable();
        public void Deffect_Create()
        {
            excel.Application application = new excel.Application();
            excel.Workbook workbook = application.Workbooks.Add();
            excel.Worksheet worksheet = (excel.Worksheet)workbook.ActiveSheet;
            string file_name = Form_Configuration.document_default_path + "\\Деффектные участки (" + DateTime.Now.ToString("dd.MM.yyyy)") + ".xlsx";
            try
            {
                worksheet.Name = "Деффектные участки";
                worksheet.Cells[1, 1] = "№ п/п";
                worksheet.Cells[1, 2] = "ID ОДХ";
                worksheet.Cells[1, 3] = "Наименование объекта";
                worksheet.Cells[1, 4] = "ПЛОЩАДЬ ПРОЕЗЖЕЙ ЧАСТИ С ВЫЯВЛЕННЫМИ НАРУШЕНИЯМИ. по 1 показателю (%)";
                worksheet.Cells[1, 5] = "ПЛОЩАДЬ ПРОЕЗЖЕЙ ЧАСТИ С ВЫЯВЛЕННЫМИ НАРУШЕНИЯМИ. по 2 показателям (%)";
                worksheet.Cells[1, 6] = "ПЛОЩАДЬ ПРОЕЗЖЕЙ ЧАСТИ С ВЫЯВЛЕННЫМИ НАРУШЕНИЯМИ. по 3 показателям (%)";
                worksheet.Cells[1, 7] = "ПЛОЩАДЬ ПРОЕЗЖЕЙ ЧАСТИ С ВЫЯВЛЕННЫМИ НАРУШЕНИЯМИ. по 4 показателям (%)";

                for (int i = 0; i < dtShet.Rows.Count; i++)
                {
                    worksheet.Cells[i + 2, 1] = dtShet.Rows[i][0].ToString();
                    worksheet.Cells[i + 2, 2] = dtShet.Rows[i][1].ToString();
                    worksheet.Cells[i + 2, 3] = dtShet.Rows[i][2].ToString();
                    worksheet.Cells[i + 2, 4] = dtShet.Rows[i][3].ToString().Replace(',', '.');
                    worksheet.Cells[i + 2, 5] = dtShet.Rows[i][4].ToString().Replace(',', '.');
                    worksheet.Cells[i + 2, 6] = dtShet.Rows[i][5].ToString().Replace(',', '.');
                    worksheet.Cells[i + 2, 7] = dtShet.Rows[i][6].ToString().Replace(',', '.');
                    for (int format = 1; format <= 7; format++)
                    {
                        worksheet.Rows[i+1].Columns[format].Font.Name = "Times New Roman";
                        worksheet.Rows[i + 1].Columns[format].Font.Size = 12;
                        worksheet.Rows[i + 1].Columns[format].VerticalAlignment = 3;
                        worksheet.Rows[i + 1].Columns[format].HorizontalAlignment = 3;
                        worksheet.Rows[i + 1].Columns[format].Borders.Linestyle = excel.XlLineStyle.xlContinuous;
                    }
                }

                worksheet.Columns[1].ColumnWidth = 10;
                worksheet.Columns[2].ColumnWidth = 15;
                worksheet.Columns[3].ColumnWidth = 110;
                worksheet.Columns[4].ColumnWidth = 100;
                worksheet.Columns[5].ColumnWidth = 100;
                worksheet.Columns[6].ColumnWidth = 100;
                worksheet.Columns[7].ColumnWidth = 100;


                workbook.Charts.Add();
                workbook.ActiveChart.Name = "Диаграмма выявленных нарушений";
                workbook.ActiveChart.ChartType = excel.XlChartType.xl3DColumn;

                workbook.ActiveChart.HasLegend = true;
                workbook.ActiveChart.HasTitle = true;
                workbook.ActiveChart.ChartTitle.Characters.Text = "Площадь проезжей части с выявленными нарушениями";

                workbook.ActiveChart.Axes(excel.XlAxisType.xlCategory).HasTitle = true;
                workbook.ActiveChart.Axes(excel.XlAxisType.xlCategory).AxisTitle.Characters.Text = "Значения";

                workbook.ActiveChart.Axes(excel.XlAxisType.xlCategory).HasTitle = true;
                workbook.ActiveChart.Axes(excel.XlAxisType.xlCategory).AxisTitle.Characters.Text = "Показатели";
            }
            catch (Exception ex)
            {
                Registry_Class.error_message += "\n"
                + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                workbook.SaveAs(file_name, application.DefaultSaveFormat);
                workbook.Close();
                application.Quit();
            }
        }
    }
}