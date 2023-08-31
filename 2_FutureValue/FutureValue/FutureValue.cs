using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class FutureValueForm : Form
    {
        public FutureValueForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Function of Calculate -btn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double monthlyInvestment = Convert.ToDouble(txtMonInvestment.Text);
            double yearlyInterestRate = Convert.ToDouble(txtYearlyInterestRate.Text);
            int years = Convert.ToInt32(txtNumYears.Text);

            double monInterestRate = yearlyInterestRate / 12 / 100;

            double futureValue = 0;

            for (int i = 0; i < years*12; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monInterestRate);
            }

            txtFutureValue.Text = futureValue.ToString("c");

            txtMonInvestment.Focus();
        }
    }
}
