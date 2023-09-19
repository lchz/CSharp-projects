using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using System.Runtime.InteropServices;

//Microsoft Excel 16 object in references-> COM tab
//using Excel = Microsoft.Office.Interop.Excel;

namespace PekingMastersGameApp
{
    public partial class frmNewGame : Form
    {
        public frmNewGame()
        {
            InitializeComponent();
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

            cmbNewSeason.SelectedIndex = 0;
            dateTimePicker.Value = DateTime.Today;

        }


        private void frmNewEpisode_Load(object sender, EventArgs e)
        {
            Disply_ComboBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string season = cmbNewSeason.Text.ToString();
            string ep = cmbNewEp.Text.ToString();
            DateTime date = dateTimePicker.Value;
            string day = cmbNewDay.Text.ToString();
            string gameNum = cmbNewGameNum.Text.ToString();
            string gameName = cmbNewName.Text.ToString();
            string status = cmbNewStatus.Text.ToString();

            if (season=="" || ep=="" || day=="" || gameNum == "" || gameName == "" || status == "")
            {
                MessageBox.Show("All the fields are required!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }


            StatsDB.Save_Game(season, ep, date, day, gameNum, gameName, status);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // TODO: Save new game to Excel => DONE
        // TODO: Update display in Main => DONE

    }
}
