using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_CustomerMaintenance
{
    public partial class frmProductMain : Form
    {
        public frmProductMain()
        {
            InitializeComponent();
        }

        private List<Product> products = null;
        private ProductDB productDB = new ProductDB();

        private void frmProductMain_Load(object sender, EventArgs e)
        {
            this.products = this.productDB.GetProducts();
            FillProductListBox();
        }

        private void FillProductListBox()
        {
            lstProducts.Items.Clear();
            foreach (Product p in this.products)
            {
                lstProducts.Items.Add(p.GetDisplayText("\t"));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewProduct newProductForm = new frmNewProduct();
            Product newProduct = newProductForm.GetNewProduct();

            if (newProduct != null)
            {
                this.products.Add(newProduct);
                //this.productDB.SaveProduct(newProduct);
                FillProductListBox();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstProducts.SelectedIndex;
            if (i != -1)
            {
                Product deletingProduct = this.products[i];
                string msg = "Are you sure you want to delte " + deletingProduct.Description + "?";

                DialogResult button = MessageBox.Show(msg, "Confirm Delete", 
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (button == DialogResult.Yes)
                {
                    this.products.Remove(deletingProduct);
                    //this.productDB.SaveProduct(this.products);
                    FillProductListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
