using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace FutureValue
{
    public partial class FutureValueForm : Form
    {
        public FutureValueForm()
        {
            InitializeComponent();
        }

        string[,] valueTable = new string[10, 4];
        int rowIndex = 0;

        private void FutureValueForm_Load(object sender, EventArgs e)
        {
            LoadNumberOfYears();
        }

        private void LoadNumberOfYears()
        {
            for (int i = 1; i < 21; i++)
            {
                cboNumberOfYears.Items.Add(i.ToString());
            }
            cboNumberOfYears.SelectedItem = "3";
        }


        /// <summary>
        /// Close app with Exit -btn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            string output = "Inv/Mo.\tRate\tYears\tFuture Value\n";
            for (int i = 0; i < valueTable.GetLength(0); i++)
            {
                for (int j = 0; j < valueTable.GetLength(1); j++)
                {
                    output += valueTable[i, j] + "\t";
                }
                output += "\n";
            }
            MessageBox.Show(output, "Future Value Calculations");

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
            if (!(IsValidData(txtMonInvestment, "Monthly Investment", 10, 1000000)
                && IsValidData(txtYearlyInterestRate, "Yearly Interest Rate", 1, 200)))
            {
                return;
            }

            // Convert input values and check any other possible exceptions
            try
            {
                monthlyInvestment = Double.Parse(txtMonInvestment.Text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowParentheses,
                                                    CultureInfo.CurrentCulture);

                yearlyInterestRate = Double.Parse(txtYearlyInterestRate.Text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowParentheses,
                                                    CultureInfo.CurrentCulture);

                years = Convert.ToInt32(cboNumberOfYears.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.ToString(), "Exception Error");
                txtMonInvestment.Focus();
                return;
            }

            txtYearlyInterestRate.Text = (yearlyInterestRate / 100).ToString("p2");
            txtMonInvestment.Text = monthlyInvestment.ToString("c");

            // Calculate Future Value
            List<double> futureValues = CalculateFutureValue(monthlyInvestment, years, yearlyInterestRate);
            lstFutureValue.Items.Clear();
            for (int i = 0; i < futureValues.Count; i++)
            {
                lstFutureValue.Items.Add($"Year {i + 1}: {futureValues[i]:c}");
            }


            // Store in table
            StoreData(monthlyInvestment, yearlyInterestRate, years, futureValues);

            txtMonInvestment.Focus();
        }

        private void StoreData(double monthlyInvestment, double yearlyInterestRate, int years, List<double> futureValues)
        {
            if (rowIndex < valueTable.GetLength(0))
            {
                valueTable[rowIndex, 0] = monthlyInvestment.ToString("c");
                valueTable[rowIndex, 1] = (yearlyInterestRate / 100).ToString("p1");
                valueTable[rowIndex, 2] = years.ToString();
                valueTable[rowIndex, 3] = futureValues.Last().ToString("c");

                rowIndex++;
            }
        }


        /// <summary>
        /// Clear content of Future Value when the three boxes change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearFutureValue(object sender, EventArgs e)
        {
            //MessageBox.Show("Clear value");
            //lstFutureValue.Text = "";
            lstFutureValue.Items.Clear();
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
            cboNumberOfYears.SelectedItem = "3";
            lstFutureValue.Text = "";

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
        private List<double> CalculateFutureValue(double monthlyInvestment, int years, double yearlyInterestRate)
        {
            double monInterestRate = yearlyInterestRate / 12 / 100;
            List<double> futureValueArray = new List<double>();
            double futureValue = 0;

            for (int i = 0; i < years * 12; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monInterestRate);
                if ((i+1) % 12 == 0)
                {
                    futureValueArray.Add(futureValue);
                }
            }

            return futureValueArray;
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
                    && IsCurrency(txtbox, txtName)
                    && IsWithinRange(txtbox, txtName, minValue, maxValue))
                {
                    return true;
                }
            }
            //else
            //{
            //    if (IsPresent(txtbox, txtName)
            //        && IsInt32(txtbox, txtName)
            //        && IsWithinRange(txtbox, txtName, minValue, maxValue))
            //    {
            //        return true;
            //    }
            //}

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
        /// Check if input format is Double, allowing numbers and all numeric styles except for $-sign and parentheses.
        /// </summary>
        /// <param name="txtBox"></param>
        /// <param name="txtName"></param>
        /// <returns></returns>
        private bool IsDouble(TextBox txtBox, string txtName)
        {
            if (!Double.TryParse(txtBox.Text, NumberStyles.Number, 
                                 CultureInfo.CurrentCulture, out double d))
            {
                MessageBox.Show(txtName + " requires a decimal value.", "Format Error");
                txtBox.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// Allows numbers and all numeric styles
        /// </summary>
        /// <param name="txtBox"></param>
        /// <param name="txtName"></param>
        /// <returns></returns>
        private bool IsCurrency(TextBox txtBox, string txtName)
        {
            if (!Double.TryParse(txtBox.Text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowParentheses,
                                 CultureInfo.CurrentCulture, out double d))
            {
                MessageBox.Show(txtName + " requires a decimal value.", "Format Error");
                txtBox.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// Check if input format is integer, only digits allowed.
        /// </summary>
        /// <param name="txtBox"></param>
        /// <param name="txtName"></param>
        /// <returns></returns>
        private bool IsInt32(TextBox txtBox, string txtName)
        {
            if (!Int32.TryParse(txtBox.Text, NumberStyles.None,
                                CultureInfo.CurrentCulture, out int i))
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
            double inputValue = Double.Parse(txtBox.Text, 
                                            NumberStyles.Number | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowParentheses,
                                            CultureInfo.CurrentCulture);
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
