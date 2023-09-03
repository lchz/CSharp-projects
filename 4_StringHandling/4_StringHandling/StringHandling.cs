using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_StringHandling
{
    public partial class StringHandlingForm : Form
    {
        public StringHandlingForm()
        {
            InitializeComponent();
        }

        private void btnParseName_Click(object sender, EventArgs e)
        {
            string[] name = txtName.Text.Trim().Split(' ');
            
            if (name.Length < 2)
            {
                MessageBox.Show("Please enter at least first name and last name.", "Name Format Error");
                txtName.Focus();
                return;
            }

            for (int i = 0; i < name.Length; i++)
            {
                name[i] = name[i].Replace(name[i][0], char.ToUpper(name[i][0]));
                for (int j = 1; j < name[i].Length; j++)
                {
                    name[i] = name[i].Replace(name[i][j], char.ToLower(name[i][j]));
                }
            }


            if (name.Length == 2)
            {
                MessageBox.Show(
                    $"{"First name:",-15}{name[0],-5}\n" +
                    $"{"Last name:",-14}{name[1],-5}",
                    "Parse Name");
            }
            else if (name.Length == 3)
            {
                MessageBox.Show(
                    $"{"First name:",-20}{name[0],-5}\n" +
                    $"{"Middle name:",-16}{name[1],-5}\n" +
                    $"{"Last name:",-19}{name[2],-5}",
                    "Parse Name");
            }
        }

        private void btnEditPhoneNumber_Click(object sender, EventArgs e)
        {
            string enteredNum = txtPhoneNumber.Text;
            string onlyDigits = "";
            // Find and remove special characters
            for (int i = 0; i < enteredNum.Length; i++)
            {
                if (int.TryParse(enteredNum[i].ToString(), out int o))
                {
                    onlyDigits += o.ToString();
                }
            }
            // Check if 10 digits after being formatted
            if (onlyDigits.Length < 10)
            {
                MessageBox.Show("Not a valid phone number", "Phone Number Error");
                txtPhoneNumber.Focus();
                return;
            }

            string standardFormat = onlyDigits.Insert(3, "-");
            standardFormat = standardFormat.Insert(7, "-");

            MessageBox.Show(
                $"{"Entered:",-32}{enteredNum}\n" +
                $"{"Digits only:",-30}{onlyDigits}\n" +
                $"{"Standard format:",-25}{standardFormat}",
                "Edit Phone Number");
        }
    }
}
