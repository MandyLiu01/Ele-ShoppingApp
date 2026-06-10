using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ele_ShoppingApp
{
    // Provide an extension method to map Category to ProductType if other code expects Category()
    public static class ProductsExtensions
    {
        public static string Category(this Products p) => p.ProductType;
    }

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
            Console.WriteLine("1. View the list of the Products");//List the products by category, then the user can choose which category of the products they want to view.
            Console.WriteLine("2. Add the product to Cart");//The user can add the product to the cart by entering the product ID, then the system will check if the product ID is valid and if it is, it will add the product to the cart.
            Console.WriteLine("3. Remove the product from the Cart");//The user can remove the product from the cart by entering the product ID, then the system will check if the product ID is valid and if it is, it will remove the product from the cart.
            Console.WriteLine("4. Search the product(s)");//The user can search the product by entering the keyword, then the system will search the product from the list and display the search result to the user.
            Console.WriteLine("5. Go to Cart");//The user can view the items in their cart and manage them.
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
                    SearchProducts();
                    break;
                case 5:
                    cart.DisplayCart();
                    break;
                case 6:
                        Console.WriteLine("Thank you for shopping with us. See you next time!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
                }//End of switch
            } while (choice != 6);  
        }
        //Method: View products by category, the user can choose which category of the products they want to view.
        private void ViewProductsMenu()
        {
            char option;
            do
            {
                Console.WriteLine("\n======PRODUCTS CATEGORIES======");
                Console.WriteLine(" |_______________________________|");
                Console.WriteLine(" | A. | Laptop                   |");
                Console.WriteLine(" | B. | Headphone                |");
                Console.WriteLine(" | C. | TV                       |");
                Console.WriteLine(" | D. | Tablet                   |");
                Console.WriteLine(" | E. | Smartphone               |");
                Console.WriteLine(" | F. | Smartwatch               |");
                Console.WriteLine(" | G. | Exit                     |");
                Console.WriteLine(" |-------------------------------|");
                Console.Write("Please choose what type of the products would you like to view: ");
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
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }//End of switch
                var categoryProducts = allProducts
                .Where(p => p.ProductType.Equals(category, StringComparison.OrdinalIgnoreCase))
                .ToList();

                Console.WriteLine($"\n--- {category} Products ---");

                foreach (var product in categoryProducts)
                {
                    Console.WriteLine($"ID: {product.ProductID}, Name: {product.ProductName}, Price: ${product.ProductPrice}");//May neeed to change the property name to match with the products class
                }

            } while (option != 'G');
        }//End of ViewProductsMenu method
        //Method: Add product to cart, the user can add the product to the cart by entering the product ID, then the system will check if the product ID is valid and if it is, it will add the product to the cart.
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
                    Console.WriteLine("Product not found and not added successfully");
                }
            }
        }//End of AddProductToCart method
        //Method: Remove product from cart, the user can remove the product from the cart by entering the product ID, then the system will check if the product ID is valid and if it is, it will remove the product from the cart.
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
                    Console.WriteLine("Product not found and not removed successfully in cart.");
                }
            }
        }//End of RemoveProductFromCart method
         //Method: Search product, the user can search the product by entering the keyword, then the system will search the product from the list and display the search result to the user.
        private void SearchProducts()
        {
            Console.Write("Enter the keyword of the product that you would like to search: ");
            string keyword = Convert.ToString(Console.ReadLine() ?? "string");

            List<Products> result = allProducts.Where(p => p.ProductName.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();

            if (result.Count > 0)
            {
                Console.WriteLine("\nSearch Results:");

                foreach (var product in result)
                {
                    Console.WriteLine(
                        $"ID: {product.ProductID}, Name: {product.ProductName}, Price: ${product.ProductPrice}");
                }
            }
            else
            {
                Console.WriteLine("No products found.");
            }
        }//End of SearchProducts method

    }//End of class
}//End of namespace
