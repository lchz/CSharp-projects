﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        /// <summary>
        /// Close app with Exit -btn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            double monthlyInvestment;
            double yearlyInterestRate;
            int years;

            // Check inputs validity
            if (!(IsValidData(txtMonInvestment, "Monthly Investment", 10, 2000)
                && IsValidData(txtYearlyInterestRate, "Yearly Interest Rate", 1, 200)
                && IsValidData(txtNumYears, "Number of Years", 1, 20, false)))
            {
                return;
            }
            

            // Check any other possible exceptions
            try
            {
                monthlyInvestment = Convert.ToDouble(txtMonInvestment.Text);
                yearlyInterestRate = Convert.ToDouble(txtYearlyInterestRate.Text);
                years = Convert.ToInt32(txtNumYears.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Error");
                txtMonInvestment.Focus();
                return;
            }


            double monInterestRate = yearlyInterestRate / 12 / 100;
            double futureValue = CalculateFutureValue(monthlyInvestment, years, monInterestRate);

            txtFutureValue.Text = futureValue.ToString("c");

            txtMonInvestment.Focus();
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

        /// <summary>
        /// Automatically fill in 12 when "Yearly Interest Rate" -box double-clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtYearlyInterestRate_DoubleClick(object sender, EventArgs e)
        {
            txtYearlyInterestRate.Text = Convert.ToString(12);
        }


        /*
         *********** HELP FUNCTIONS ***************
         */

        /// <summary>
        /// Calculate future value
        /// </summary>
        /// <param name="monthlyInvestment"></param>
        /// <param name="years"></param>
        /// <param name="monInterestRate"></param>
        /// <returns></returns>
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
        /// Validate input data
        /// </summary>
        /// <returns></returns>
        private bool IsValidData(TextBox txtbox, string txtName, double minValue, double maxValue, bool isDoubleValue=true)
        {
            if (isDoubleValue)
            {
                if (IsPresent(txtbox, txtName)
                    && IsDouble(txtbox, txtName)
                    && IsWithinRange(txtbox, txtName, minValue, maxValue))
                {
                    return true;
                }
            }
            else
            {
                if (IsPresent(txtbox, txtName)
                    && IsInt32(txtbox, txtName)
                    && IsWithinRange(txtbox, txtName, minValue, maxValue))
                {
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Check empty input
        /// </summary>
        /// <param name="txtBox"></param>
        /// <param name="txtName"></param>
        /// <returns></returns>
        private bool IsPresent(TextBox txtBox, string txtName)
        {
            
            if (txtBox.Text == "")
            {
                MessageBox.Show(txtName + " is a required field.", "Entry Error");
                txtBox.Focus();
                return false;
            }

            return true;
        }
        /// <summary>
        /// Check if input format is Double
        /// </summary>
        /// <param name="txtBox"></param>
        /// <param name="txtName"></param>
        /// <returns></returns>
        private bool IsDouble(TextBox txtBox, string txtName)
        {
            if (!Double.TryParse(txtBox.Text, out double d))
            {
                MessageBox.Show(txtName + " requires a decimal value.", "Format Error");
                txtBox.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// Check if input format is integer
        /// </summary>
        /// <param name="txtBox"></param>
        /// <param name="txtName"></param>
        /// <returns></returns>
        private bool IsInt32(TextBox txtBox, string txtName)
        {
            if (!Int32.TryParse(txtBox.Text, out int i))
            {
                MessageBox.Show(txtName + " requires an integer value.", "Format Error");
                txtBox.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// Check if input within the range
        /// </summary>
        /// <param name="txtBox"></param>
        /// <param name="txtName"></param>
        /// <param name="minValue"></param>
        /// <param name="MaxValue"></param>
        /// <returns></returns>
        private bool IsWithinRange(TextBox txtBox, string txtName, double minValue, double MaxValue)
        {
            double inputValue = Convert.ToDouble(txtBox.Text);
            if (minValue > inputValue || MaxValue < inputValue)
            {
                MessageBox.Show(txtName + " is not in a valid range.", "Range Error");
                txtBox.Focus();
                return false;
            }
            return true;
        }

    }
}
