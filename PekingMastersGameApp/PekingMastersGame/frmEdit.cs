using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DataTable = System.Data.DataTable;

namespace PekingMastersGameApp
{
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Today;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Disply_ComboBox();

            string editID = txtEditID.Text;
            string command = "SELECT ID, Season, Episode, Date, Day, Game, Name, Status FROM [";
            string command2 = $"] WHERE ID = {editID}";
            DataTable editGame = StatsDB.GetData(command, command2);

            txtNewID.Text = editGame.Rows[0][0].ToString();
            cmbNewSeason.SelectedItem = editGame.Rows[0][1].ToString();
            cmbNewEp.SelectedItem = editGame.Rows[0][2].ToString();
            cmbNewDay.SelectedItem = editGame.Rows[0][4].ToString();
            cmbNewGameNum.SelectedItem = editGame.Rows[0][5].ToString();
            cmbNewName.SelectedItem = editGame.Rows[0][6].ToString();
            cmbNewStatus.SelectedItem = editGame.Rows[0][7].ToString();
            dateTimePicker.Value = (DateTime)editGame.Rows[0][3];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string season = cmbNewSeason.SelectedItem.ToString();
            string ep = cmbNewEp.Text.ToString();
            DateTime date = dateTimePicker.Value;
            string day = cmbNewDay.Text.ToString();
            string gameNum = cmbNewGameNum.Text.ToString();
            string gameName = cmbNewName.Text.ToString();
            string status = cmbNewStatus.Text.ToString();

            if (season == "" || ep == "" || day == "" || gameNum == "" || gameName == "" || status == "")
            {
                MessageBox.Show("All the fields are required!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            StatsDB.Update_Game(txtEditID.Text, season, ep, date, day, gameNum, gameName, status);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Disply_ComboBox()
        {
            foreach (string season in StatsDB.Seasons)
            {
                cmbNewSeason.Items.Add(season);
            }
            foreach (string ep in StatsDB.Episodes)
            {
                cmbNewEp.Items.Add(ep);
            }
            foreach (string d in StatsDB.Days)
            {
                cmbNewDay.Items.Add(d);
            }
            foreach (string n in StatsDB.GameNum)
            {
                cmbNewGameNum.Items.Add(n);
            }
            foreach (string n in StatsDB.GameNames)
            {
                cmbNewName.Items.Add(n);
            }
            foreach (string s in StatsDB.Status)
            {
                cmbNewStatus.Items.Add(s);
            }

        }

    }
}
