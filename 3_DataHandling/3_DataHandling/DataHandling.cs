using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_DataHandling
{
    public partial class DataHandlingForm : Form
    {
        public DataHandlingForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Show current date when opening the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCurrentDate_TextChanged(object sender, EventArgs e)
        {
            strCurrentDate.Text = String.Format($"{DateTime.Now:d}");
        }

        /// <summary>
        /// Calculate days to due when clicked OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            DateTime futureDate = DateTime.Parse(txtFutureDate.Text);
            DateTime today = DateTime.Parse(strCurrentDate.Text);
            TimeSpan daysTillDue = futureDate - today;
            strDaysUntilDue.Text = daysTillDue.Days.ToString();
        }

        /// <summary>
        /// Clear result when input data (Future date) changing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFutureDate_TextChanged(object sender, EventArgs e)
        {
            strDaysUntilDue.Text = "";
        }
    }
}
