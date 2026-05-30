using System;
using System.Collections.Generic;
using System.Text;

namespace Ele_ShoppingApp
{
    public class Cart
    {
        //Properties and create a list to hold products in the cart
        public List<Products> CartItems { get; set; }
        public double TotalPrice { get; set; }
        //Constructor
        public Cart()
        {
            CartItems = new List<Products>();
            TotalPrice = 0;
        }
        //Method: Add product to cart
        public void AddProduct(Products product)
        {
            CartItems.Add(product);
            Console.WriteLine($"{product.ProductName} added to cart.");
            CalculateTotal();
        }
        //Method: Remove product from cart
        public void RemoveProduct(Products product)
        {
            if (CartItems.Remove(product))
            {
                Console.WriteLine($"{product.ProductName} removed from cart.");
                CalculateTotal();
            }
            else
            {
                Console.WriteLine($"{product.ProductName} not found in cart.");
            }
        }
        //Method: Calculate total price
        public void CalculateTotal()
        {
            TotalPrice = 0;
            foreach (var product in CartItems)
            {
                TotalPrice += product.ProductPrice * product.Purchase;
            }
        }
        //Method: Display cart items and total price
        public void DisplayCart()
        {
            Console.WriteLine("\n======SHOPPING CART======");
            if(CartItems.Count == 0)
            {
                Console.WriteLine("Your cart is empty.");
                return;
            }
            foreach (var product in CartItems)
            {
                product.DisplayProductInfor();
            }
            Console.WriteLine($"Total Price: ${TotalPrice}");
        }
        //Method: Checkout and clear cart
        public void Checkout()
        {
            if (CartItems.Count == 0)
            {
                Console.WriteLine("Your cart is empty. Add items before checkout.");
                return;
            }
            Console.WriteLine("\n=====Checking out=====");
            DisplayCart();
            
            Console.WriteLine("Thank you for your purchase!");
            CartItems.Clear();
            TotalPrice = 0;
        }

        internal void AddProduct()
        {
            throw new NotImplementedException();
        }

        internal void RemoveProduct()
        {
            throw new NotImplementedException();
        }
    }//End of Cart class
}//End of namespace
