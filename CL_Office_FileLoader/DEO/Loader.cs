using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

public class Loader
{
    TempFileDB FileDB { get; set; }

    public Loader()
    {
        FileDB = new TempFileDB();
    }

    public bool loadFile(string url)
    {
        Application excelApp = new Application();
        Workbook workbook = excelApp.Workbooks.Open(url);
        //Workbook workbook = excelApp.Workbooks.Open();
        //Worksheet worksheet;
        //Range range;
        //worksheet = (Worksheet)workbook.Sheets["Test Sheet"];
        /*
        int column = 0;
        int row = 0;

        range = worksheet.UsedRange;
        */
        Console.Write("everything's good so far");
        if (workbook != null)
        {
            Console.Write("couldn't find file");
        }
        return FileDB.loadWorkBook(workbook);        
    }
}
