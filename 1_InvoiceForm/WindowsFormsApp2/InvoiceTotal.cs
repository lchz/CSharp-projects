using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class InvoiceTotal : Form
    {
        public InvoiceTotal()
        {
            InitializeComponent();
        }

        int numInvoices = 0;
        double totalInvoices = 0;
        double invoiceAve = 0;
        double largestInvoice = 0;
        double smallestInvoice = Double.MaxValue;
        /// <summary>
        /// Calculate-btn functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Calculate discount and total
            double subtotal = Convert.ToDouble(txtEnterSubtotal.Text);
            string customerType = txtCustomerType.Text;
            double disPercent = 0.1;

            if (customerType == "R")
            {
                if (subtotal >= 250 && subtotal < 500)
                {
                    disPercent = 0.25;
                }
                else if (subtotal >= 500)
                {
                    disPercent = 0.3;
                }
            }
            else if (customerType == "C")
            {
                disPercent = 0.2;
            }
            else if (customerType == "T")
            {
                if (subtotal < 500)
                {
                    disPercent = 0.4;
                }
                else
                {
                    disPercent = 0.5;
                }
            }

            //// Example use of switch
            //switch (customerType)
            //{
            //    case "R":
            //        disPercent = 0.2;
            //        break;
            //    case "C":
            //        disPercent = 0.3;
            //        break;
            //    default:
            //        disPercent = 0.1;
            //        break;
            //}

            double disAmount = subtotal * disPercent;
            double total = subtotal - disAmount;

            txtSubtotal.Text = subtotal.ToString("c");
            txtDisPercent.Text = disPercent.ToString("p1");
            txtDisAmount.Text = disAmount.ToString("c");
            txtTotal.Text = total.ToString("c");

            // Update number, total and ave of invoices
            numInvoices++;
            totalInvoices += total;
            invoiceAve = totalInvoices / numInvoices;

            txtNumInvoices.Text = numInvoices.ToString();
            txtTotalInvoices.Text = totalInvoices.ToString("c");
            txtInvoiceAve.Text = invoiceAve.ToString("c");

            // Update largest, smallest invoice
            largestInvoice = Math.Max(largestInvoice, total);
            smallestInvoice = Math.Min(smallestInvoice, total);
            txtLargestInvoice.Text = largestInvoice.ToString("c");
            txtSmallestInvoice.Text = smallestInvoice.ToString("c");

            txtEnterSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Clear the increament of the invoices.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearTotals_Click(object sender, EventArgs e)
        {
            numInvoices = 0;
            totalInvoices = 0;
            invoiceAve = 0;

            txtNumInvoices.Text = "";
            txtTotalInvoices.Text = "";
            txtInvoiceAve.Text = "";

            txtEnterSubtotal.Focus();

        }
    }
}
