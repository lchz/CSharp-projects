﻿using System;
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
            double futureValue = CalculateFutureValue(monthlyInvestment, years, monInterestRate);

            txtFutureValue.Text = futureValue.ToString("c");

            txtMonInvestment.Focus();
        }

        private static double CalculateFutureValue(double monthlyInvestment, int years, double monInterestRate)
        {
            double futureValue = 0;

            for (int i = 0; i < years * 12; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monInterestRate);
            }

            return futureValue;
        }

        /// <summary>
        /// Clear content of Future Value when the three boxes change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearFutureValue(object sender, EventArgs e)
        {
            txtFutureValue.Text = "";
        }

        /// <summary>
        /// Clear all boxes when the form is double-clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FutureValueForm_DoubleClick(object sender, EventArgs e)
        {
            txtMonInvestment.Text = "";
            txtYearlyInterestRate.Text = "";
            txtNumYears.Text = "";
            txtFutureValue.Text = "";

        }

        private void txtYearlyInterestRate_DoubleClick(object sender, EventArgs e)
        {
            txtYearlyInterestRate.Text = Convert.ToString(12);
        }
    }
}
