using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PekingMastersGameApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //List<PkMatch> matches = StatsDB.GetMatches();

            //txt1.Text = matches[0].MatchName;
            //txt2.Text = matches[1].MatchName;
            //txt3.Text = matches[2].MatchName;

            //season, episode, date, day, matchNumber, matchName, status, love
            Show_data();
        }

        private void Show_data() 
        { 

            const string dir = @"C:\Users\TestiPC\Documents\Study\CSharp\";
            const string FILE_PATH = dir + "PekingMastersGameStats.xlsx";
            string con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
            con = String.Format(con, FILE_PATH, "yes");

            OleDbConnection excelConnection = new OleDbConnection(con);
            excelConnection.Open();
            DataTable dtexcel = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            string excelsheet = dtexcel.Rows[0]["TABLE_NAME"].ToString();
            OleDbCommand command = new OleDbCommand("SELECT * FROM [" + excelsheet + "]", excelConnection);
            OleDbDataAdapter oda = new OleDbDataAdapter(command);

            DataTable dt = new DataTable();
            oda.Fill(dt);
            excelConnection.Close();
            dataGrid.DataSource = dt;
        }



        // TODO: Modify stats

        // TODO: Add new stats. Ask if the last match in the week, if so, then add an empty row to the formatted cells. 

    }
}
