using System;
using System.Data;
using excel = Microsoft.Office.Interop.Excel;

namespace SiPPOON_PP
{
    class Excel_Document
    {
        public DataTable dtShet = new DataTable();
        public void Deffect_Create()//Метод для заполнения документа Excel данными из таблицы "Категории" или "Округа"
        {
            excel.Application application = new excel.Application();//Переменная для создания приложения Excel
            excel.Workbook workbook = application.Workbooks.Add();//Переменная для создания книги Excel
            excel.Worksheet worksheet = (excel.Worksheet)workbook.ActiveSheet;//Переменная для создания листа Excel
            string file_name = Form_Main.Location_Folder + "\\Деффектные участки (" + DateTime.Now.ToString("dd.MM.yyyy)") + ".xlsx";//Путь, по котрому будет храниться выходной документ
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

                for (int i = 0; i < dtShet.Rows.Count; i++)//Заполнение таблицы Excel данными из DataGridView
                {
                    worksheet.Cells[i + 2, 1] = dtShet.Rows[i][0].ToString();
                    worksheet.Cells[i + 2, 2] = dtShet.Rows[i][1].ToString();
                    worksheet.Cells[i + 2, 3] = dtShet.Rows[i][2].ToString();
                    worksheet.Cells[i + 2, 4] = dtShet.Rows[i][3].ToString().Replace(',', '.');
                    worksheet.Cells[i + 2, 5] = dtShet.Rows[i][4].ToString().Replace(',', '.');
                    worksheet.Cells[i + 2, 6] = dtShet.Rows[i][5].ToString().Replace(',', '.');
                    worksheet.Cells[i + 2, 7] = dtShet.Rows[i][6].ToString().Replace(',', '.');
                    for (int format = 1; format <= 7; format++)//Форматирование таблицы Excel
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
