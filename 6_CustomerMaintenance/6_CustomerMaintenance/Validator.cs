using System;
using System.Windows.Forms;

namespace _6_CustomerMaintenance
{
    public static class Validator
    {
        private static string title = "Entry Error";

        public static string Title { get { return title; } set { title = value; } }

        public static bool IsDouble(TextBox txtBox)
        {
            if (Double.TryParse(txtBox.Text, out double o))
            {
                return true;
            }
            else
            {
                MessageBox.Show(txtBox.Tag + " must be a decimal value.", Title);
                txtBox.Focus();
                return false;
            }
        }

        public static bool IsPresent(TextBox txtBox)
        {
            if (txtBox.Text == "")
            {
                MessageBox.Show(txtBox.Tag + " is a required field.", Title);
                txtBox.Focus();
                return false;
            }
            return true;
        }
    }
}