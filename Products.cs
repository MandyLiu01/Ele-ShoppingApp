using System;
using System.Collections.Generic;
using System.Text;

namespace Ele_ShoppingApp
{
    //Parent Class
    public class Products
    {
        // List Fiels 
        private int productID;
        private string productName;
        private string productBrand;
        private double productPrice;
        private int productInventory;
        private string productType;
        private int numberOfProducts;
        internal readonly int Purchase;

        // List Properties
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public double ProductPrice { get; set; }
        public int ProductInventory { get; set; }
        public string ProductType { get; set; }
        public int NumberOfProducts { get; set; }

        // List Constructor
        public Products() { }
        public Products(int id, string name, string brand, double price, int inventory, string type, int purchase)
        {
            ProductID = id;
            ProductName = name;
            ProductBrand = brand;
            ProductPrice = price;
            ProductInventory = inventory;
            ProductType = type;
            NumberOfProducts = purchase;    
        }
        //Method: Display product information
        public virtual void DisplayProductInfor()
        {
            Console.WriteLine($"Product ID is: {ProductID}");
            Console.WriteLine($"Product Name is: {ProductName}");
            Console.WriteLine($"Product Brand is: {ProductBrand}");
            Console.WriteLine($"Product Type is: {ProductType}");
            Console.WriteLine($"Product Price is: ${ProductPrice}");
            Console.WriteLine($"Product Inventory is: {ProductInventory}");
            
        }
        //Method: Update product information
        public virtual void UpdateProductInfor(int id, string name, string brand, double price, int inventory)
        {
            ProductID = id;
            ProductName = name;
            ProductBrand = brand;
            ProductPrice = price;
            ProductInventory = inventory;
        }
        //Method: Search the product by name
        public static Products SearchProduct(List<Products> products, string keyword)
        {
            foreach (Products product in products)
            {
                if (product.ProductName.Equals(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }
            return null; // Return null if no matching product is found
            Console.WriteLine("The product is not found.");
        }
        
    }//End of Parent Class

}//End of namespace
