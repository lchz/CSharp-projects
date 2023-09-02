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

        double[] invoicesArray = new double[5];
        int index = 0;

        List<double> invoicesList = new List<double>();

        /// <summary>
        /// Calculate-btn functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!IsSubtotalInputValid())
            {
                return;
            }

            double subtotal = Convert.ToDouble(txtEnterSubtotal.Text);
            string customerType = txtCustomerType.Text;
            double disPercent = GetDiscountPercent(subtotal, customerType);

            double disAmount = subtotal * disPercent;
            double total = subtotal - disAmount;

            txtSubtotal.Text = subtotal.ToString("c");
            txtDisPercent.Text = disPercent.ToString("p1");
            txtDisAmount.Text = disAmount.ToString("c");
            txtTotal.Text = total.ToString("c");

            UpdateInvoiceSummary(total);
            txtEnterSubtotal.Focus();

            // Store up to 5 invoices
            if (index < invoicesArray.Length)
            {
                invoicesArray[index] = total;
                index++;
            }

            // Store invoices in List
            if (invoicesList.Count < 5)
            {
                invoicesList.Add(total);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Show totals in array when closing the app.
            Array.Sort(invoicesArray); // Sort
            string allTotals = "";
            foreach (double total in invoicesArray)
            {
                if (total != 0)
                {
                    allTotals += total.ToString("c") + "\n";
                }
                
            }
            MessageBox.Show(allTotals, "Order Totals in Array");

            // Show totals in list
            invoicesList.Sort();
            allTotals = "";
            foreach (double total in invoicesArray)
            {
                if (total != 0)
                {
                    allTotals += total.ToString("c") + "\n";
                }

            }
            MessageBox.Show(allTotals, "Order Totals in List");

            this.Close();
        }

        private bool IsSubtotalInputValid()
        {
            // Check if Subtotal is empty
            if (txtEnterSubtotal.Text == "")
            {
                MessageBox.Show(
                    "Subtotal is required.",
                    "Entry Error");
                txtEnterSubtotal.Focus();
                return false;
            }
            // Check if Subtotal a number
            if (!Double.TryParse(txtEnterSubtotal.Text, out double subtotal))
            {
                MessageBox.Show(
                    "Please enter a valid number for the Subtotal field.",
                    "Entry Error");

                txtEnterSubtotal.Focus();
                return false;
            }

            // Subtotal range check
            if (subtotal <= 0 || subtotal >= 10000)
            {
                MessageBox.Show(
                    "The subtotal should greater than 0 and less than 10,000.",
                    "Entry Error");
                txtEnterSubtotal.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Clear the count of the invoices.
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

        /*
         * ************ HELP FUNCTIONS **********************
         */

        /// <summary>
        /// Set different discount percents for different customer types.
        /// Initial discount percent is 0.1.
        /// </summary>
        /// <param name="subtotal"></param>
        /// <param name="customerType"></param>
        /// <param name="disPercent">Initial discount percent. Always 0.1</param>
        /// <returns></returns>
        private static double GetDiscountPercent(double subtotal, string customerType, double disPercent=0.1)
        {
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

            return disPercent;

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
        }

        /// <summary>
        /// Update invoice summary: count, total, ave, largest and smallest invoice.
        /// </summary>
        /// <param name="total"></param>
        private void UpdateInvoiceSummary(double total)
        {
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
        }


        
    }
}
