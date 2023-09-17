using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_CustomerMaintenance
{
    public class ProductList
    {
        private List<Product> products;

        public delegate void ListChangeHandler(ProductList productlist);
        public event ListChangeHandler ListChange;

        public ProductList()
        {
            products = new List<Product>();
        }

        public Product this[int i]
        {
            get
            {
                if (i < 0 || i >= this.products.Count)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                return products[i];
            }
            set
            {
                products[i] = value;
                ListChange(this);
            }
        }
        public Product this[string code]
        {
            get
            {
                foreach (Product p in this.products)
                {
                    if (p.Code == code)
                    {
                        return p;
                    }
                }
                return null;
            }
        }

        public int Count => products.Count;

        public void Add(Product p)
        {
            products.Add(p);
            ListChange(this);
        }
        public void Add(string code, string description, double price)
        {
            Product p = new Product(code, description, price);
            products.Add(p);
            ListChange(this);
        }

        public void Remove(Product p)
        {
            products.Remove(p);
            ListChange(this);
        }

        public void Fill()
        {
            ProductDB db = new ProductDB();
            this.products = db.GetProducts();
        }

        public void Save()
        {

        }

        // Operator ++, --
        public static ProductList operator + (ProductList pl, Product p)
        {
            pl.Add(p);
            return pl;
        } 
        public static ProductList operator - (ProductList pl, Product p)
        {
            pl.Remove(p);
            return pl;
        }

    }
}
