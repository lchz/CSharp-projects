using System.Collections.Generic;

namespace _6_CustomerMaintenance
{
    public class ProductDB
    {


        private List<Product> productsFile = new List<Product>();

        public ProductDB()
        {
            Product p1 = new Product("C1", "First product.", 12.5);
            Product p2 = new Product("C2", "Second product.", 21);
            Product p3 = new Product("C3", "Third product.", 61.2);
            this.productsFile.Add(p1);
            this.productsFile.Add(p2);
            this.productsFile.Add(p3);
        }

        public List<Product> GetProducts()
        {
            return this.productsFile;
        }

        public void SaveProduct(Product newProduct)
        {
            this.productsFile.Add(newProduct);
        }

        //public void SaveProducts(List<Product> newProducts)
        //{
        //    this.productsFile.Clear();
        //    foreach (Product p in newProducts)
        //    {
        //        productsFile.Add(p);
        //    }
        //}
    }
}