using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

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

        private bool initializing = true;
        private void frmMain_Load(object sender, EventArgs e)
        {
            Display_ComboBox_Main();
            //Select season = 11, episode = All, status = All
            cmbSeason.SelectedIndex = 1;
            cmbEpisode.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;

            string command = "SELECT ID, Love, Date, Episode, Day, Game, Name, Status FROM [";
            dataGrid.DataSource = StatsDB.GetData(command, "]");

            initializing = false;
        }

        private void Display_ComboBox_Main()
        {
            foreach (string season in StatsDB.Seasons)
            {
                cmbSeason.Items.Add(season);
            }
            foreach (string ep in StatsDB.Episodes)
            {
                cmbEpisode.Items.Add(ep);
            }
            foreach (string s in new List<string>{ "All", "Win"})
            {
                cmbStatus.Items.Add(s);
            }
        }

        private void cmbSeason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initializing) // if initializing, the Load function will retrieve the data. Nothing needs to do here.
            {
                return;
            }

            string command = "SELECT ID, Love, Date, Episode, Day, Game, Name, Status FROM [";
            dataGrid.DataSource = StatsDB.GetData(command, Get_Command2());
        }

        private void cmbEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initializing)
            {
                return;
            }

            string command = "SELECT ID, Love, Date, Episode, Day, Game, Name, Status FROM [";
            dataGrid.DataSource = StatsDB.GetData(command, Get_Command2());
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initializing)
            {
                return;
            }
            
            string command = "SELECT ID, Love, Date, Episode, Day, Game, Name, Status FROM [";
            dataGrid.DataSource = StatsDB.GetData(command, Get_Command2());
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEdit editForm = new frmEdit();
            DialogResult selectedButton = editForm.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
                MessageBox.Show("Game edited successfully!", "Edit Game Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                string command = "SELECT ID, Love, Date, Episode, Day, Game, Name, Status FROM [";
                string command2 = "]";
                dataGrid.DataSource = StatsDB.GetData(command, command2);
            }
        }

        private string Get_Command2()
        {
            string season = cmbSeason.SelectedItem.ToString();
            string ep = cmbEpisode.SelectedItem.ToString();
            string status = cmbStatus.SelectedItem.ToString();

            string command2 = "]";

            // all,all,all- ]                         all,all,win- ] where status=1
            // ?,all,all- ] where season=?            ?,all,win- ] where season=? AND status=1
            // all,?,all- ] where ep=?                all,?,win- ] where ep=? AND status=1
            // ?,?,all- ] where season=? AND ep=?     ?,?,win- ] where season=? AND ep=? AND status=1
            if (season == "All" && ep == "All" && status == "All")
            {
                return command2;
            }

            if (season == "All" && ep == "All" && status == "Win")
            {
                command2 += $" WHERE Status = 1";
            }
            else if (season != "All" && ep == "All")
            {
                if (status == "Win")
                {
                    command2 += $" WHERE Season = {season} AND Status = 1";
                }
                else
                {
                    command2 += $" WHERE Season = {season}";
                }
            }
            else if (season == "All" && ep != "All")
            {
                if (status == "Win")
                {
                    command2 += $" WHERE Episode = {ep} AND Status = 1";
                }
                else
                {
                    command2 += $" WHERE Episode = {ep}";
                }
            }
            else if (season != "All" && ep != "All")
            {
                if (status == "Win")
                {
                    command2 += $" WHERE Season = {season} AND Episode = {ep} AND Status = 1";
                }
                else
                {
                    command2 += $" WHERE Season = {season} AND Episode = {ep}";
                }
            }

            return command2;
        }



        // TODO: Modify stats => DONE
        // TODO: Add new stats. => DONE
        // TODO: Delete game => DONE [ID after the deleted item is not changed]
        // TODO: Edit function: To edit rows => DONE
        // TODO: When the main form is maximized, the content size changes accordingly. => DONE!


        // TODO: Ask if the last match in the week, if so, add an empty row to the formatted cells. 

        // TODO: Reverse order by date
    }
}
