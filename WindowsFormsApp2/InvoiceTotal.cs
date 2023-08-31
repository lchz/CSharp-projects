﻿using System;
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Calculate discount and total
            double subtotal = Convert.ToDouble(txtSubtotal.Text);
            double disPercent = Convert.ToDouble(txtDisPercent.Text) * 0.01;

            double disAmount = subtotal * disPercent;
            double total = subtotal - disAmount;

            txtDisAmount.Text = disAmount.ToString();
            txtTotal.Text = total.ToString();

            // Update number, total and ave of invoices
            numInvoices++;
            totalInvoices += total;
            invoiceAve = totalInvoices / numInvoices;

            txtNumInvoices.Text = numInvoices.ToString();
            txtTotalInvoices.Text = totalInvoices.ToString();

            txtSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
