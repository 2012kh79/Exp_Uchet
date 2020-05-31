using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using word = Microsoft.Office.Interop.Word;
using System.Data;

namespace SiPPOON_PP.Classes
{
    class PDF_Document
    {
        word.Application application = new word.Application();
        word.Document document;
        public void Shet_Facture(DataTable table)
        {
            //document = application.Documents.Add(Visible: true);
            //word.Range range = document.Range(0, 0);
            //double kol = 0;
            //double Ploshad = 0;
            //double Percent_One = 0;
            //double Percent_Two = 0;
            //double Percent_Three = 0;
            //double Percent_Four = 0;
            //double Percent_PPCBN = 0;
            //double Metr_One = 0;
            //double Metr_Two = 0;
            //double Metr_Three = 0;
            //double Metr_Four = 0;
            //double Metr_PPCBN = 0;
            //string file_name = Form_Configuration.document_default_path + "\\Отчёт по анализу ("
            //    + DateTime.Now.ToString("dd.MM.yyyy)") + ".pdf";
            //try
            //{
            //    document.Sections.PageSetup.Orientation = word.WdOrientation.wdOrientLandscape;
            //    document.Sections.PageSetup.LeftMargin = application.CentimetersToPoints(1);
            //    document.Sections.PageSetup.RightMargin = application.CentimetersToPoints(1);
            //    document.Sections.PageSetup.TopMargin = application.CentimetersToPoints(1);
            //    document.Sections.PageSetup.BottomMargin = application.CentimetersToPoints(1);

            //    range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
            //    range.ParagraphFormat.SpaceAfter = 1;
            //    range.ParagraphFormat.SpaceBefore = 1;
            //    range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpaceSingle;
            //    range.Font.Name = "Times New Roman";
            //    range.Font.Size = 12;

            //    document.Paragraphs.Add();
            //    document.Paragraphs.Add();

            //    word.Paragraph Name_Doc = document.Paragraphs.Add();
            //    Name_Doc.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
            //    Name_Doc.Range.Font.Name = "Times New Roman";
            //    Name_Doc.Range.Font.Size = 16;
            //    Name_Doc.Range.Text = "СЧЁТ-ФАКТУРА";

            //    document.Paragraphs.Add();

            //    word.Paragraph Nomer_shet = document.Paragraphs.Add();
            //    Nomer_shet.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
            //    Nomer_shet.Range.Font.Name = "Times New Roman";
            //    Nomer_shet.Range.Font.Size = 16;
            //    Nomer_shet.Range.Text = "Номер cчёта - " + ID_Shet;

            //    document.Paragraphs.Add();

            //    word.Paragraph Data = document.Paragraphs.Add();
            //    Data.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
            //    Data.Range.Font.Name = "Times New Roman";
            //    Data.Range.Font.Size = 16;
            //    Data.Range.Text = "Дата формирования счёта - " + Data_form;

            //    document.Paragraphs.Add();

            //    word.Paragraph Tsena = document.Paragraphs.Add();
            //    Tsena.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphLeft;
            //    Tsena.Range.Font.Name = "Times New Roman";
            //    Tsena.Range.Font.Size = 16;
            //    Tsena.Range.Text = "Цена за заказанный товар - " + Tsena_tovara;

            //    document.Paragraphs.Add();

            //    word.Paragraph Zakaz_id = document.Paragraphs.Add();
            //    Zakaz_id.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphLeft;
            //    Zakaz_id.Range.Font.Name = "Times New Roman";
            //    Zakaz_id.Range.Font.Size = 16;
            //    Zakaz_id.Range.Text = "Номер заказанного товара - " + Zakaz_ID;

            //    document.Paragraphs.Add();

            //    word.Paragraph TTN_id = document.Paragraphs.Add();
            //    TTN_id.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphLeft;
            //    TTN_id.Range.Font.Name = "Times New Roman";
            //    TTN_id.Range.Font.Size = 16;
            //    TTN_id.Range.Text = "Номер заказанного товара - " + TTN_ID;

            //    document.Paragraphs.Add();

            //    document.Paragraphs.Add();

            //    word.Paragraph Name_Doc = document.Paragraphs.Add();
            //    Name_Doc.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
            //    Name_Doc.Range.Font.Name = "Times New Roman";
            //    Name_Doc.Range.Font.Size = 16;
            //    Name_Doc.Range.Text = "АНАЛИЗ РЕЗУЛЬТАТОВ ОБСЛЕДОВАНИЯ";

            //    document.Paragraphs.Add();
            //    document.Paragraphs.Add();
            //    document.Paragraphs.Add();

            //    word.Paragraph pTable = document.Paragraphs.Add();

            //    word.Table tbShet = document.Tables.Add(pTable.Range, table.Rows.Count + 3, table.Columns.Count);
            //    tbShet.Borders.InsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
            //    tbShet.Borders.OutsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
            //    tbShet.Cell(1, 1).Range.Text = "Наименование объекта";
            //    tbShet.Cell(1, 2).Range.Text = "Количество объектов";
            //    tbShet.Cell(1, 3).Range.Text = "Площадь объекта";
            //    tbShet.Cell(1, 4).Range.Text = "Площадь проезжей части с выявленными нарушениями";
            //    tbShet.Cell(1, 12).Range.Text = "Площадь проезжей части без выявленных нарушений";
            //    tbShet.Cell(2, 4).Range.Text = "по 1-му параметру";
            //    tbShet.Cell(2, 6).Range.Text = "по 2-му параметру";
            //    tbShet.Cell(2, 8).Range.Text = "по 3-му параметру";
            //    tbShet.Cell(2, 10).Range.Text = "по 4-му параметру";
            //    tbShet.Cell(3, 4).Range.Text = "%";
            //    tbShet.Cell(3, 5).Range.Text = "кв.м";
            //    tbShet.Cell(3, 6).Range.Text = "%";
            //    tbShet.Cell(3, 7).Range.Text = "кв.м";
            //    tbShet.Cell(3, 8).Range.Text = "%";
            //    tbShet.Cell(3, 9).Range.Text = "кв.м";
            //    tbShet.Cell(3, 10).Range.Text = "%";
            //    tbShet.Cell(3, 11).Range.Text = "кв.м";
            //    tbShet.Cell(3, 12).Range.Text = "%";
            //    tbShet.Cell(3, 13).Range.Text = "кв.м";

            //    tbShet.Range.Font.Size = 12;
            //    tbShet.Range.Font.Name = "Times New Roman";

            //    tbShet.Cell(1, 1).Merge(tbShet.Cell(3, 1));
            //    tbShet.Cell(1, 2).Merge(tbShet.Cell(3, 2));
            //    tbShet.Cell(1, 3).Merge(tbShet.Cell(3, 3));
            //    tbShet.Cell(1, 4).Merge(tbShet.Cell(1, 11));
            //    tbShet.Cell(1, 5).Merge(tbShet.Cell(2, 13));
            //    tbShet.Cell(2, 4).Merge(tbShet.Cell(2, 5));
            //    tbShet.Cell(2, 5).Merge(tbShet.Cell(2, 6));
            //    tbShet.Cell(2, 6).Merge(tbShet.Cell(2, 7));
            //    tbShet.Cell(2, 7).Merge(tbShet.Cell(2, 8));

            //    for (int i = 4; i <= tbShet.Rows.Count; i++)
            //    {
            //        for (int j = 1; j <= tbShet.Columns.Count; j++)
            //        {
            //            tbShet.Cell(i, j).Range.Text = table.Rows[i - 4][j - 1].ToString();
            //        }
            //    }

            //    for (int i = 0; i < table.Rows.Count; i++)
            //    {
            //        kol += Convert.ToDouble(table.Rows[i][1]);
            //        Ploshad += Convert.ToDouble(table.Rows[i][2]);
            //        Percent_One += Convert.ToDouble(table.Rows[i][3]);
            //        Metr_One += Convert.ToDouble(table.Rows[i][4]);
            //        Percent_Two += Convert.ToDouble(table.Rows[i][5]);
            //        Metr_Two += Convert.ToDouble(table.Rows[i][6]);
            //        Percent_Three += Convert.ToDouble(table.Rows[i][7]);
            //        Metr_Three += Convert.ToDouble(table.Rows[i][8]);
            //        Percent_Four += Convert.ToDouble(table.Rows[i][9]);
            //        Metr_Four += Convert.ToDouble(table.Rows[i][10]);
            //        Percent_PPCBN += Convert.ToDouble(table.Rows[i][11]);
            //        Metr_PPCBN += Convert.ToDouble(table.Rows[i][12]);
            //    }

            //    tbShet.Rows.Add();
            //    tbShet.Cell(tbShet.Rows.Count, 1).Range.Text = "Всего";
            //    tbShet.Cell(tbShet.Rows.Count, 2).Range.Text = kol.ToString();
            //    tbShet.Cell(tbShet.Rows.Count, 3).Range.Text = Ploshad.ToString();
            //    tbShet.Cell(tbShet.Rows.Count, 4).Range.Text = (Percent_One / table.Rows.Count).ToString();
            //    tbShet.Cell(tbShet.Rows.Count, 5).Range.Text = Metr_One.ToString();
            //    tbShet.Cell(tbShet.Rows.Count, 6).Range.Text = (Percent_Two / table.Rows.Count).ToString();
            //    tbShet.Cell(tbShet.Rows.Count, 7).Range.Text = Metr_Two.ToString();
            //    tbShet.Cell(tbShet.Rows.Count, 8).Range.Text = (Percent_Three / table.Rows.Count).ToString();
            //    tbShet.Cell(tbShet.Rows.Count, 9).Range.Text = Metr_Three.ToString();
            //    tbShet.Cell(tbShet.Rows.Count, 10).Range.Text = (Percent_Four / table.Rows.Count).ToString();
            //    tbShet.Cell(tbShet.Rows.Count, 11).Range.Text = Metr_Four.ToString();
            //    tbShet.Cell(tbShet.Rows.Count, 12).Range.Text = (Percent_PPCBN / table.Rows.Count).ToString();
            //    tbShet.Cell(tbShet.Rows.Count, 13).Range.Text = Metr_PPCBN.ToString();
            //}
            //catch (Exception ex)
            //{
            //    Registry_Class.error_message += "\n"
            //        + DateTime.Now.ToLongDateString() + " " + ex.Message;
            //}
            //finally
            //{
            //    document.SaveAs2(file_name, word.WdSaveFormat.wdFormatDocumentDefault);
            //    document.Close();
            //    application.Quit();
            //}
        }
    }
}
