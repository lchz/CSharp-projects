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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Calculate discount and total
            double subtotal = Convert.ToDouble(txtEnterSubtotal.Text);
            double disPercent = Convert.ToDouble(txtDisPercent.Text) * 0.01;

            double disAmount = subtotal * disPercent;
            double total = subtotal - disAmount;

            txtSubtotal.Text = subtotal.ToString("c");
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
