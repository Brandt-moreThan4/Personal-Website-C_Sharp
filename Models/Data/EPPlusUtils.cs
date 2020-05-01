using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunWithBrandt.Models.Data
{
    public class EPPlusUtils
    {
        public static int GetLastRow(ExcelWorksheet worksheet, string column = "A")
        {
            string cellAddress;
            column = column.ToUpper();
            var lastRow = worksheet.Dimension.End.Row;

            while (lastRow >= 1)
            {
                cellAddress = column + Convert.ToString(lastRow);
                if (!string.IsNullOrEmpty(worksheet.Cells[cellAddress].Text))
                {
                    return lastRow;
                }
                lastRow--;
            }

            return 1;
        }


        public static void SetNamedRangeValue(ExcelWorksheet worksheet, string namedRange, string value, bool workbookScope = false)
        {
            if (worksheet == null) return;

            if (workbookScope)
            {
                if (worksheet.Workbook.Names.ContainsKey(namedRange)) worksheet.Workbook.Names[namedRange].Value = value;
            }
            else
            {
                if (worksheet.Names.ContainsKey(namedRange)) worksheet.Names[namedRange].Value = value;
            }
        }

        public static string GetNamedRangeValue(ExcelWorksheet worksheet, string namedRange, bool checkWorkbook = false)
        {
            if (worksheet == null) return string.Empty;

            var value = worksheet.Names.ContainsKey(namedRange) ? worksheet.Names[namedRange].Text : null;

            if (string.IsNullOrEmpty(value) && checkWorkbook)
                return worksheet.Workbook.Names.ContainsKey(namedRange)
                    ? worksheet.Workbook.Names[namedRange].Text
                    : null;

            return value;
        }


    }


}
