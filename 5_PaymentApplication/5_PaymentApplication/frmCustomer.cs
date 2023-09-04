using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_PaymentApplication
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        // card type, card number, expDate, default
        SortedList<string, string[]> customerInfo = new SortedList<string, string[]>();
        string[] newPaymentMethod = new string[4];

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            GenerateCustomers();
            LoadCustomerName();
            LoadPaymentMethod();
        }

        private void GenerateCustomers()
        {
            customerInfo.Add("Select customer name...", new string[] {});
            customerInfo.Add("Mike Smith", new string[] { "Visa", "111222", "April/2017", true.ToString() });
        }
        private void LoadCustomerName()
        {
            foreach (var keyValuePair in customerInfo)
            {
                cboCustomerName.Items.Add(keyValuePair.Key);
            }
            cboCustomerName.SelectedItem = "Select customer name...";
        }
        private void LoadPaymentMethod()
        {
            string customerName = cboCustomerName.Text;
            string[] customerPayment = customerInfo[customerName];

            labPayment.Text = OutputPaymentMethod(customerPayment);
        }

        private string OutputPaymentMethod(string[] methodArray)
        {
            string outputString; 
            if (methodArray.Length == 0) // "Select a customer name"
            {
                outputString = "";
            }
            else if (methodArray.Length == 1)
            {
                outputString = methodArray[0]; // "Bill customer"
            }
            else
            {
                outputString = "Charge to credit card.\n\n" +
                                $"Card type: {methodArray[0]}\n" +
                                $"Card number: {methodArray[1]}\n" +
                                $"Expiration date: {methodArray[2]}\n" +
                                $"Default billing: {methodArray[3]}";
            }
            return outputString;
        }

        private void cboCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPaymentMethod();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnSelectPayment_Click(object sender, EventArgs e)
        {
            Form paymentForm = new frmPayment();
            DialogResult selectedButton = paymentForm.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
                labPayment.Text = OutputPaymentMethod((string[])paymentForm.Tag);
                newPaymentMethod = (string[])paymentForm.Tag;
                //isDataSaved = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();

            MessageBox.Show($"New payment method for customer {cboCustomerName.Text} is saved!",
                            "Save",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void SaveData()
        {
            customerInfo.Add(cboCustomerName.Text.ToString(), newPaymentMethod);
            cboCustomerName.Items.Add(cboCustomerName.Text);
            //newPaymentMethod[4] = true.ToString();
        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if all info saved
            bool isDataSaved = customerInfo.ContainsKey(cboCustomerName.Text);
            if (!isDataSaved)
            {
                DialogResult ifSaveData = MessageBox.Show("New payment method is not saved yet.\nDo you want to save it?",
                                                            "Exit",
                                                            MessageBoxButtons.YesNoCancel,
                                                            MessageBoxIcon.Warning);

                if (ifSaveData == DialogResult.Yes)
                {
                    // Should check data validity first, but omitted here.
                    SaveData();
                }
                else if (ifSaveData == DialogResult.Cancel)
                {
                    e.Cancel = true; // Cancel the FormClosing event and return to the form.
                }
            }
        }
    }
}
