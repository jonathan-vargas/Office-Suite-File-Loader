using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

public class TempFileDB
{
    List<Workbook> WorkBooks { get; set; }
    List<Contest> contest { get; set; }
    public static string PARTICIPANT_WS = "Alumnos";
    public static string WORDS_WS = "Alumnos";

    public TempFileDB()
    {
        this.WorkBooks = new List<Workbook>();
    }

    public bool loadWorkBook(Workbook wb)
    {
        if (wb != null)
        {
            this.WorkBooks.Add(wb);

            Contest c = new Contest();
            c.Name = wb.Name;
            c.Contestants = getParticipants(wb);
            


            return true;
        }
        return false;
    }

    private List<Item> getParticipants(Workbook wb)
    {
        List<Item> lp = new List<Item>();
        Worksheet ws = wb.Worksheets[PARTICIPANT_WS];
        Range header = ws.get_Range("A1").Rows;
        foreach (Range row in header)
        {
            //Do something with the row.

            //Ex. Iterate through the row's data and put in a string array
            String[] col_headers = new String[row.Columns.Count];
            for (int i = 0; i < row.Columns.Count; i++) {
                //Item h = new Item();
                string cell_value= row.Cells[1, i + 1].Value2.ToString();
                //h.addAttribute(new ItemAttribute("header", ItemAttribute.STRING_TYPE, cell_value));
                col_headers[i] = cell_value;
                Console.Write(cell_value);
            }
        }



        /*//Get the used Range
        Excel.Range usedRange = worksheet.UsedRange;

        //Iterate the rows in the used range
        foreach (Excel.Range row in usedRange.Rows)
        {
            //Do something with the row.

            //Ex. Iterate through the row's data and put in a string array
            String[] rowData = new String[row.Columns.Count];
            for (int i = 0; i < row.Columns.Count; i++)
                Data[i] = row.Cells[1, i + 1].Value2.ToString();
        }*/
        return null;
    }
}

