using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_CustomerMaintenance
{
    public partial class frmNewProduct : Form
    {
        public frmNewProduct()
        {
            InitializeComponent();
        }

        private Product product = null;

        public Product GetNewProduct()
        {
            this.ShowDialog();
            return product;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                product = new Product(txtCode.Text, txtDescription.Text, Convert.ToDouble(txtPrice.Text));
                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtCode) &&
                    Validator.IsPresent(txtDescription) &&
                    Validator.IsPresent(txtPrice) &&
                    Validator.IsDouble(txtPrice);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
