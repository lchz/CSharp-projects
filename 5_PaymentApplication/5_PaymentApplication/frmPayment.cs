using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_PaymentApplication
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Generate years for the expiration year
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frmPayment_Load(object sender, EventArgs e)
        {
            LoadCreditCardType();
            LoadExpMonths();
            LoadExpYears();
        }

        private void LoadCreditCardType()
        {
            lstCreditCardType.SelectedIndex = 0;
        }

        /// <summary>
        /// Generate and select initial expiration month.
        /// </summary>
        private void LoadExpMonths()
        {
            cboExpMonth.SelectedIndex = 0;
        }

        /// <summary>
        /// Generate years for the expiration year.
        /// </summary>
        private void LoadExpYears()
        {
            // Check which year is this year
            int thisYear = DateTime.Now.Year;

            // Load 10 exp years to combo box
            cboExpYear.Items.Add("Select a year...");
            for (int i = 0; i < 10; i++)
            {
                cboExpYear.Items.Add(thisYear + i);
            }

            cboExpYear.SelectedIndex = 0; // Choose the first item.
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rdoBillCustomer.Checked)
            {
                this.Tag = new string[] { "Charge to bill customer."};
            }
            else if (rdoCreditCard.Checked)
            {
                string creditCarType = lstCreditCardType.SelectedItem.ToString();
                string cardNumber = txtCardNumber.Text.ToString();
                string expDate = cboExpMonth.SelectedItem.ToString() + "/" + cboExpYear.SelectedItem.ToString();
                string setAsDefault = chkDefault.Checked.ToString();

                this.Tag = new string[] { creditCarType , cardNumber, expDate, setAsDefault };
            }

            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Disable the form when Bill Customer checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoBillCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBillCustomer.Checked)
            {
                ToggleControls(false);
            }
        }

        /// <summary>
        /// Enable the form when Credit Card selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCreditCard.Checked)
            {
                ToggleControls(true);
            }
        }

        /// <summary>
        /// Help function to toggle controls in Payment Form.
        /// </summary>
        /// <param name="status"></param>
        private void ToggleControls(bool status)
        {
            lstCreditCardType.Enabled = status;
            txtCardNumber.Enabled = status;
            cboExpMonth.Enabled = status;
            cboExpYear.Enabled = status;
        }
    }
}
