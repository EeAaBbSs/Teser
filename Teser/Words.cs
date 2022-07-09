using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using Xceed.Document.NET;
using Xceed.Words.NET;
using System.Collections.Generic;

namespace Teser
{
    public class Words
    {
        public static string ScanPath { get; set; }
        public static string DocName { get; set; }

        public void CreateWord()
        {
            #region DocX doc
            string filePath = $@"C:\Users\EABS\Desktop\Teser\{DocName}.docx";
            var doc = DocX.Create(filePath);

            #region Create Table
            doc.InsertParagraph();
            Table table = doc.AddTable(14, 2);

            table.Alignment = Alignment.left;
            table.Design = TableDesign.TableGrid;

            table.Rows[0].Cells[0].Paragraphs.First().Append("№ п/п");
            table.Rows[1].Cells[0].Paragraphs.First().Append("Объект");
            table.Rows[2].Cells[0].Paragraphs.First().Append("Кадастровый номер");
            table.Rows[3].Cells[0].Paragraphs.First().Append("Действующая КС, руб.");
            table.Rows[4].Cells[0].Paragraphs.First().Append("Дата определения КС");
            table.Rows[5].Cells[0].Paragraphs.First().Append("Ставка налога/аренды %");
            table.Rows[6].Cells[0].Paragraphs.First().Append("Налог на имущество, руб. в год");
            table.Rows[7].Cells[0].Paragraphs.First().Append("Возможное снижение КС, руб.");
            table.Rows[8].Cells[0].Paragraphs.First().Append("Налог на имущество при снижении КС, руб в год");
            table.Rows[9].Cells[0].Paragraphs.First().Append("Экономия, руб. в год");
            table.Rows[10].Cells[0].Paragraphs.First().Append("Экономия ретроспектива, руб. в год(до 3 лет от даты определения КС до 01.01 текущего года)");
            table.Rows[11].Cells[0].Paragraphs.First().Append("Экономия перспектива, руб. (за 3 года от 01.01 текущего года)");
            table.Rows[12].Cells[0].Paragraphs.First().Append("Экономия перспектива, руб. (за 5 лет от 01.01 текущего года)");
            table.Rows[13].Cells[0].Paragraphs.First().Append("Примечания");
            #endregion

            #region table filling
            List<Object> dataCells = new List<Object>();
            dataCells.Add("Данные об объекте");
            dataCells.Add(DataBase.obj);
            dataCells.Add(DataBase.KDNumber);
            dataCells.Add(DataBase.cost);
            dataCells.Add(DataBase.KDDateDetermenation);
            dataCells.Add(DataBase.taxYear);
            dataCells.Add(DataBase.dropTax);
            dataCells.Add(DataBase.dropTaxYear);
            dataCells.Add(DataBase.saving);
            dataCells.Add(DataBase.notes);

            for (int i = 0; i < dataCells.Count; i++)
            {
                if (i == 0)
                {
                    table.Rows[i].Cells[1].Paragraphs.First().Append(dataCells[i].ToString());
                }
                else if (i > 0 && i <= 3)
                {
                    var URL = doc.AddHyperlink(Convert.ToString(dataCells[i]), new Uri(ScanPath));
                    URL.Text = dataCells[i].ToString();
                    table.Rows[i].Cells[1].Paragraphs.First().AppendHyperlink(URL).Bold().Color(Color.Aqua);
                }
                else if (i == 4)
                {
                    string KDNForURL = Convert.ToString(dataCells[i - 2]).Replace(":", "%3A");
                    var URL = doc.AddHyperlink(Convert.ToString(dataCells[i]), new Uri(@$"http://www.udmbti.ru/?kadN={KDNForURL}&btn=Узнать+кадастровую+стоимость+объекта#top-c"));
                    URL.Text = dataCells[i].ToString();
                    table.Rows[i].Cells[1].Paragraphs.First().AppendHyperlink(URL).Bold().Color(Color.Aqua);
                }
                else
                {
                    table.Rows[i].Cells[1].Paragraphs.First().Append(dataCells[i].ToString());
                }
            }
            #endregion

            doc.InsertTable(table);
            doc.Save();
            Process.Start("WINWORD.EXE", filePath);
            #endregion
        }
    }
}