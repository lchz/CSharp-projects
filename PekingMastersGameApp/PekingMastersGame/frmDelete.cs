using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PekingMastersGameApp
{
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Show the game info to be deleted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string deleteID = txtDeleteID.Text;
            string command = "SELECT ID, Season, Episode, Date, Day, Game, Name, Status FROM [";
            string command2 = $"] WHERE ID = {deleteID}";
            DataTable deleteGame = StatsDB.GetData(command, command2);

            lblGameInfo.Text = $"ID {deleteGame.Rows[0][0]}\n" +
                                $"时间 {deleteGame.Rows[0][3]:yyyy-MM-dd}\n" +
                                $"第{deleteGame.Rows[0][1]}季\n" +
                                $"第{deleteGame.Rows[0][2]}期\n" +
                                $"{deleteGame.Rows[0][4]}天\n" +
                                $"第{deleteGame.Rows[0][5]}局\n" +
                                $"{deleteGame.Rows[0][6]}\n";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteID = txtDeleteID.Text;

            StatsDB.Delete_Game(deleteID);
            this.DialogResult = DialogResult.OK;
        }
    }
}
