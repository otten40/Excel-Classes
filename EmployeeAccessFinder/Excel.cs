using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Excel = Microsoft.Office.Interop.Excel;

namespace EmployeeAccessFinder
{
    class Excel
    {
        string path = "";
        Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        Range rng;

        public Excel(string path, int Sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[Sheet];
        }

        public string ReadCell(int i, int j)
        {
            i++;
            j++;
            if (ws.Cells[i, j].Value2 != null)
                return ws.Cells[i, j].Value2;
            else
                return "";
        }
        public void FindValue(string value)
        {
            
        }

        public long LastRow()
        {
            long lastRow;
            long fullRow;

            fullRow = ws.Rows.Count;
            lastRow = ws.Cells[fullRow, 1].get_End(_Excel.XlDirection.xlUp).Row;
            return lastRow;
        }
    }
}
