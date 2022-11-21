using System;
using Office = Microsoft.Office.Interop;
using System.IO;

namespace _06.EXCELlentKnowledge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Office.Excel.Application xlApp = new Office.Excel.Application();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "sample_table.xlsx");
            Office.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
            Office.Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Office.Excel.Range xlRange = xlWorksheet.UsedRange;


            int rowCount = xlRange.Rows.Count;
            int columnCount = xlRange.Columns.Count;
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= columnCount; j++)
                {
                    
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        Console.Write(xlRange.Cells[i, j].Value2.ToString() + "|");
                }
                Console.WriteLine();
            }
        }
    }
}
