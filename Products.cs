using System;
using System.Collections.Generic;
using System.Text;

namespace Ele_ShoppingApp
{
    //Parent Class
    public class Products
    {
        // List Properties
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductType { get; set; }
        public int NumberOfProducts { get; set; }
        public int Purchase { get; set; }

        // List Constructor
        public Products(int id, string name, string brand, double price, int prodQuantity, string type, int purchase, int purchase1)
        {
            ProductID = id;
            ProductName = name;
            ProductBrand = brand;
            ProductPrice = price;
            ProductQuantity = prodQuantity;
            ProductType = type;
            NumberOfProducts = purchase;
            Purchase = purchase;
        }
        //Method: Display product information
        public virtual void DisplayProductInfor()
        {
           Console.WriteLine($"\n Product ID: \t{ProductID} \n Product Name: \t{ProductName} \n Product Brand: \t{ProductBrand} \n Product Price: \t{ProductPrice} \n Product Quantity: \t{ProductQuantity} \n Product Type: \t{ProductType} \n Number of Purchases: \t{NumberOfProducts}");
        }
        //Method: Update product information
        public virtual void UpdateProductInfor(int id, string name, string brand, double price, int inventory)
        {
            ProductID = id;
            ProductName = name;
            ProductBrand = brand;
            ProductPrice = price;
            ProductQuantity = inventory;
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
            Console.WriteLine("The product is not found.");
            return null;
        }

        //Adds or removes quantity from inventory.
    //Returns false when the change would make inventory negative.

    public bool ChangeQuantity(int delta)
    {
        if (ProductQuantity + delta < 0)
        {
            return false;
        }

        ProductQuantity += delta;
        return true;
    }
        
    }//End of Parent Class

}//End of namespace
