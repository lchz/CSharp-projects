using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

//Microsoft Excel 16 object in references-> COM tab
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PekingMastersGameApp
{
    public static class StatsDB
    {
        private const string dir = @"C:\Users\TestiPC\Documents\Study\CSharp\";
        public static string FILE_PATH = dir + "PekingMastersGameStats.xlsx";

        public static List<string> Seasons = new List<string> { "11", "9" };
        public static List<string> Episodes = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
        public static List<string> Days = new List<string> { "D1", "D2", "D3", "D4" };
        public static List<string> GameNum = new List<string> { "1", "2", "3", "4" };
        public static List<string> GameNames = new List<string> { "预女猎白混", "预女猎白", "石像鬼", "机械狼通灵师", "假面舞会", "魅使神差", "梦魇魔术师", "狼王野孩子", "乌鸦隐狼", "狼美猎人", "鬼魂新娘" };
        public static List<string> Status = new List<string> { "1", "0" };


        public static DataTable GetData(string sqlCommand1, string sqlCommand2)
        {
            string con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
            con = String.Format(con, StatsDB.FILE_PATH, "yes");

            DataTable dt = new DataTable();

            using (OleDbConnection excelConnection = new OleDbConnection(con))
            {
                excelConnection.Open();

                DataTable dtexcel = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string excelsheet = dtexcel.Rows[0]["TABLE_NAME"].ToString();
                OleDbCommand command = new OleDbCommand(sqlCommand1 + excelsheet + sqlCommand2, excelConnection);
                OleDbDataAdapter oda = new OleDbDataAdapter(command);
                oda.Fill(dt);

            }
            return dt;
        }

        public static void Delete_Game(string deleteID)
        {

            Excel.Application xlApp = new Excel.Application();

            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(StatsDB.FILE_PATH);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            //Excel.Range xlRange = xlWorksheet.UsedRange;

            Excel.Range last = xlWorksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            Excel.Range range = xlWorksheet.get_Range("A1", last);

            
            //int rowIndex = last.Row + 1;
            //int lastUsedColumn = last.Column;

            foreach (Excel.Range r in range.Rows)
            {

                if (xlWorksheet.Cells[r.Row, 1].Value != null && xlWorksheet.Cells[r.Row, 1].Value.ToString() == deleteID)
                {
                    r.EntireRow.Delete(XlDeleteShiftDirection.xlShiftUp);
                }
            }

            xlWorkbook.Save();
            xlWorkbook.Close();
            xlApp.Quit();
        }

        public static void Save_Game(string season, string ep, DateTime date, string day, string gameNum, string gameName, string status)
        {

            Excel.Application xlApp = new Excel.Application();

            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(StatsDB.FILE_PATH);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            //Excel.Range xlRange = xlWorksheet.UsedRange;

            Excel.Range last = xlWorksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            Excel.Range range = xlWorksheet.get_Range("A1", last);

            int rowIndex = last.Row + 1;
            //int lastUsedColumn = last.Column;

            int lastID = -1;
            try
            {
                lastID = Convert.ToInt32(xlWorksheet.Cells[rowIndex - 1, 1].Value);
                if (lastID <= 0)
                {
                    lastID = Convert.ToInt32(xlWorksheet.Cells[rowIndex - 2, 1].Value);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Exception with detecting the last ID.", "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                xlWorkbook.Close();
                xlApp.Quit();
            }

            xlWorksheet.Cells[rowIndex, 1] = lastID + 1; // ID
            xlWorksheet.Cells[rowIndex, 2] = season;
            xlWorksheet.Cells[rowIndex, 3] = ep;
            xlWorksheet.Cells[rowIndex, 4] = date;
            xlWorksheet.Cells[rowIndex, 5] = day;
            xlWorksheet.Cells[rowIndex, 6] = gameNum;
            xlWorksheet.Cells[rowIndex, 7] = gameName;
            xlWorksheet.Cells[rowIndex, 8] = status;

            xlApp.Visible = false;
            //xlApp.UserControl = false;

            xlWorkbook.Save();
            xlWorkbook.Close();
            xlApp.Quit();
        }

        public static void Update_Game(string editID, string season, string ep, DateTime date, string day, string gameNum, string gameName, string status)
        {
            Excel.Application xlApp = new Excel.Application();

            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(StatsDB.FILE_PATH);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            //Excel.Range xlRange = xlWorksheet.UsedRange;

            Excel.Range last = xlWorksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            Excel.Range range = xlWorksheet.get_Range("A1", last);

            foreach (Excel.Range r in range.Rows)
            {
                if (xlWorksheet.Cells[r.Row, 1].Value != null && xlWorksheet.Cells[r.Row, 1].Value.ToString() == editID)
                {
                    xlWorksheet.Cells[r.Row, 1].Value = editID;
                    xlWorksheet.Cells[r.Row, 2].Value = season;
                    xlWorksheet.Cells[r.Row, 3].Value = ep;
                    xlWorksheet.Cells[r.Row, 4].Value = date;
                    xlWorksheet.Cells[r.Row, 5].Value = day;
                    xlWorksheet.Cells[r.Row, 6].Value = gameNum;
                    xlWorksheet.Cells[r.Row, 7].Value = gameName;
                    xlWorksheet.Cells[r.Row, 8].Value = status;
                    break;
                }
            }

            xlApp.Visible = false;
            //xlApp.UserControl = false;

            xlWorkbook.Save();
            xlWorkbook.Close();
            xlApp.Quit();

        }



    }
}
