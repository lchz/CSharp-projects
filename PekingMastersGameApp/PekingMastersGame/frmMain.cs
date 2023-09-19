using Microsoft.Office.Interop.Excel;
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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DataTable = System.Data.DataTable;
//using Excel = Microsoft.Office.Interop.Excel;

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
            //season, episode, date, day, match, Name, status, love
            cmbSeason.SelectedIndex = 0;

        }

        /// <summary>
        /// Find the episodes in the selected season.
        /// </summary>
        private void Collect_Episodes()
        {
            cmbEpisode.Items.Clear();
            cmbEpisode.Items.Add("All");

            string season = cmbSeason.SelectedItem.ToString();
            string sqlCommand1 = "SELECT Episode FROM [";
            string sqlCommand2 = "] WHERE Season = " + season;
            DataTable dt = StatsDB.GetData(sqlCommand1, sqlCommand2);
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() != "" && !cmbEpisode.Items.Contains(dt.Rows[i][0]))
                {
                    cmbEpisode.Items.Add(dt.Rows[i][0]);
                }
            }

            cmbEpisode.SelectedIndex = 0;

        }

        private void cmbSeason_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Change season: ");
            string season = cmbSeason.SelectedItem.ToString();

            string command = "SELECT ID, Love, Date, Episode, Day, Game, Name, Status FROM [";
            string command2 = "] WHERE Season = " + season;

            dataGrid.DataSource = StatsDB.GetData(command, command2);

            cmbSeason.SelectedItem = season;

            Collect_Episodes();

        }

        private void cmbEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Change Episode: ");
            string ep = cmbEpisode.SelectedItem.ToString();
            string command = "SELECT ID, Love, Date, Episode, Day, Game, Name, Status FROM [";
            string command2;

            if (ep == "All")
            {
                command2 = "]";
            }
            else
            {
                string season = cmbSeason.SelectedItem.ToString();
                command2 = "] WHERE Season = " + season + " AND Episode = " + ep;
            }

            dataGrid.DataSource = StatsDB.GetData(command, command2);

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = cmbStatus.SelectedItem.ToString();
            string command = "SELECT ID, Love, Date, Episode, Day, Game, Name, Status FROM [";
            string command2 = "]";

            if (status == "Win")
            {
                string season = cmbSeason.SelectedItem.ToString();
                command2 = "] WHERE Season = " + season + " AND Status = 1";
            }

            dataGrid.DataSource = StatsDB.GetData(command, command2);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form newEpForm = new frmNewGame();
            DialogResult selectedButton = newEpForm.ShowDialog();

            if (selectedButton == DialogResult.OK) // New game added
            {
                MessageBox.Show("New game added successfully!", "Congradulations!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            string command = "SELECT ID, Love, Date, Episode, Day, Game, Name, Status FROM [";
            string command2 = "]";
            dataGrid.DataSource = StatsDB.GetData(command, command2);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDelete deleteForm = new frmDelete();
            DialogResult selectedButton = deleteForm.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
                
                MessageBox.Show("Game deleted successfully!", "Delete Game Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                string command = "SELECT ID, Love, Date, Episode, Day, Game, Name, Status FROM [";
                string command2 = "]";
                dataGrid.DataSource = StatsDB.GetData(command, command2);
            }
        }



        // TODO: Modify stats => DONE

        // TODO: Add new stats. => DONE

        // TODO: Delete game => DONE [ID after the deleted item is not changed]

        // TODO: Ask if the last match in the week, if so, then add an empty row to the formatted cells. 

        // TODO: Edit function: To edit rows

        // TODO: When the main form is maximized, the content size changes accordingly.
    }
}
