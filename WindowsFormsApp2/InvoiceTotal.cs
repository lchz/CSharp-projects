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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double subtotal = Convert.ToDouble(txtSubtotal.Text);
            double disPercent = Convert.ToDouble(txtDisPercent.Text) * 0.01;

            double disAmount = subtotal * disPercent;
            double total = subtotal - disAmount;

            txtDisAmount.Text = disAmount.ToString();
            txtTotal.Text = total.ToString();

            txtSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
