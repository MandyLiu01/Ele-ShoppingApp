using System;
using System.Collections.Generic;
using System.Text;

namespace Ele_ShoppingApp
{
    public class CustomerMenu
    {
        private List<Products> allProducts; //The list should match with the products list from admin
        private Cart cart;

        public CustomerMenu(List<Products> products)
        {
            allProducts = products;
            cart = new Cart();
        }

        public void ShowMenu()
        {
            int choice;
            do
            {
            Console.WriteLine("\n======CUSTOMER MENU======");
            Console.WriteLine("1. View the list of the Products");
            Console.WriteLine("2. Add the product to Cart");
            Console.WriteLine("3. Remove the product from the Cart");
            Console.WriteLine("4. Search the product(s)");
            Console.WriteLine("5. Go the Cart");
            Console.WriteLine("6. Exit");
            Console.Write("Please enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ViewProductsMenu();
                    break;
                case 2:
                    AddProductToCart();
                    break;
                case 3:
                    RemoveProductFromCart();
                    break;
                case 4:
                    //SearchProduct();
                    break;
                case 5:
                    cart.DisplayCart();
                    break;
                case 6:
                        Console.WriteLine("Returning to the previous menu...");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
                }//End of switch
            } while (choice != 6);  
        }
        private void ViewProductsMenu()
        {
            char option;
            do
            {
                Console.WriteLine("\n======PRODUCTS CATEGORIES======");
                Console.WriteLine("A. Laptop");
                Console.WriteLine("B. Headphone");
                Console.WriteLine("C.TV");
                Console.WriteLine("D. Tablet");
                Console.WriteLine("E. Smartphone");
                Console.WriteLine("F. Smartwatch");
                Console.WriteLine("G. Exit");
                Console.Write("Please choose what type of the products you would like to view: ");
                option = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                string category = "";
                switch (option)
                {
                    case 'A':
                        category = "Laptop";
                        break;
                    case 'B':
                        category = "Headphone";
                        break;
                    case 'C':
                        category = "TV";
                        break;
                    case 'D':
                        category = "Tablet";
                        break;
                    case 'E':
                        category = "Smartphone";
                        break;
                    case 'F':
                        category = "Smartwatch";
                        break;
                    case 'G':
                        return;//return to previous menu
                    default:
                        Console.WriteLine("Invalid choice.");
                        continue;
                }//End of switch
                var categoryProducts = allProducts
                .Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                .ToList();

                Console.WriteLine($"\n--- {category} Products ---");

                foreach (var product in categoryProducts)
                {
                    Console.WriteLine($"ID: {product.ProductID}, Name: {product.ProductName}, Price: ${product.Price}");//Need to change the property name to match with the products class
                }

            } while (option != 'G');
        }//End of ViewProductsMenu method
        private void AddProductToCart()
        {
            Console.Write("Enter Product ID to add: ");

            if (int.TryParse(Console.ReadLine(), out int productId))
            {
                Products product = allProducts.FirstOrDefault(p => p.ProductID == productId);

                if (product != null)
                {
                    cart.AddProduct(product);
                    Console.WriteLine("Product added successfully.");
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }
            }
        }//End of AddProductToCart method
        private void RemoveProductFromCart()
        {
            Console.Write("Enter Product ID to remove: ");

            if (int.TryParse(Console.ReadLine(), out int productId))
            {
                Products product = cart.CartItems.FirstOrDefault(p => p.ProductID == productId);

                if (product != null)
                {
                    cart.RemoveProduct(product);
                    Console.WriteLine("Product removed successfully.");
                }
                else
                {
                    Console.WriteLine("Product not found in cart.");
                }
            }
        }//End of RemoveProductFromCart method
        private void SearchProducts()
        {
            Console.Write("Enter keyword: ");
            string keyword = Console.ReadLine();

            List<Products> result = Product.SearchProduct(allProducts, keyword);

            if (result.Count > 0)
            {
                Console.WriteLine("\nSearch Results:");

                foreach (var product in result)
                {
                    Console.WriteLine(
                        $"ID: {product.ProductID}, Name: {product.ProductName}, Price: ${product.Price}");
                }
            }
            else
            {
                Console.WriteLine("No products found.");
            }
        }//End of SearchProducts method


    }//End of class
}//End of namespace
