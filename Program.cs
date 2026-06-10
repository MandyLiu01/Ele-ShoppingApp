using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ele_ShoppingApp
{
    internal class Program
    {
        // Main entry point for the application
        static void Main(string[] args)
        {
            string continueChoice;
            List<UserLogin> customerList = new List<UserLogin>();
            customerList.Add(new UserLogin("customer", "password"));

            // Display welcome banner
            Console.WriteLine("===================================");
            Console.WriteLine(" Welcome to Electronic Shopping App ");
            Console.WriteLine("===================================");
            Console.WriteLine();
            // Main application loop
            do
            {
                //This code is displaying the welcome page and ask
                Console.WriteLine("Please select your option:");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("| 1. | Please Login as Customer |");
                Console.WriteLine("| 2. | Please Login as Staff    |");
                Console.WriteLine("| 3. | Exit                     |");
                Console.WriteLine("---------------------------------");
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                int choice;
                string input = Console.ReadLine() ?? string.Empty;
                while (!int.TryParse(input.Trim(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number:");
                    input = Console.ReadLine() ?? string.Empty;
                }

                // Handle user menu selection
                switch (choice)
                {
                    // Customer Menu
                    case 1:

                        // Customer submenu options
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("| 1. | Login to your account       |");
                        Console.WriteLine("| 2. | Signup to the App           |");
                        Console.WriteLine("| n. | To go back to preview menu  |");
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine();
                        Console.Write("Please enter your choice: ");
                        int customerChoice;
                        string custInput = Console.ReadLine() ?? string.Empty;
                        while (!int.TryParse(custInput.Trim(), out customerChoice))
                        {
                            Console.WriteLine("Invalid input. Please enter a number:");
                            custInput = Console.ReadLine() ?? string.Empty;
                        }

                        switch (customerChoice)
                        {
                            // Customer Login
                            case 1:
                                // Process customer login, here we pass the custmerList in the argument to get the existing customer account and his credential
                                UserLogin.Login(customerList);
                                break;

                            // Customer Signup
                            case 2:
                                // Create new object New User which will hold the new user's account information and then add the new user to the customer list, here we call the Signup method to get the new user's account information and then we add it to the customer list, after that we call the Login method to allow the new user to log in immediately after signing up
                                UserLogin newUser = UserLogin.Signup();
                                customerList.Add(newUser);
                                // Log in with the new user after signup, here we pass the customerList to the Login method to allow the new user to log in immediately after signing up
                                UserLogin.Login(customerList);
                                break;
                            default:
                            //This code displays an error message if the user enters an invalid choice in the customer
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                        break;
                    // =============================================================
                    // >>>>>>>>>>>>>>>>>>>>>>>>> STAFF LOGIN SECTION <<<<<<<<<<<<<<<<<<<<<<<<<
                    // Staff Login section: this branch handles staff access and routes into the admin staff menu
                    // >>>>>>>>>>>>>>>>>>>>>>>>> STAFF LOGIN SECTION <<<<<<<<<<<<<<<<<<<<<<<<<
                    // =============================================================
                    case 2:
                        // Access staff login menu
                        Console.WriteLine();
                        Console.WriteLine("------------------Staff Login-----------------");
                        Console.WriteLine("----------------------------------------------");
                        UserLogin.StaffLogin();

                        break;

                    // =============================================================
                    // >>>>>>>>>>>>>>>>>>>>>>>>> END OF STAFF LOGIN SECTION <<<<<<<<<<<<<<<<<<<<<<
                    // The staff menu branch stops here and returns to the main menu loop.
                    // =============================================================
                    // Exit application
                    case 3:
                        // Close the application
                        Environment.Exit(0);
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                // Ask user if they want to continue using the app
                Console.Write("\nDo you want to continue? (yes/no): ");
                continueChoice = Convert.ToString(Console.ReadLine() ?? "string").ToLower();

                if (continueChoice == "no")
                {
                    Console.WriteLine("GoodBye! You have a good day!");
                    Environment.Exit(0);
                }

            } while (continueChoice == "yes");

            

            // //Create a products list to hold the products information, add some products to the list, this list will be used in the customer menu to display the products and allow the customer to add products to their cart
            // List<Products> products = new List<Products>();
            // // Ask the staff to enter information of the products
            // Console.Write("Please enter the product ID:");
            // int productID = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Please enter the product name:");
            // string productName = Convert.ToString(Console.ReadLine() ?? "string");
            // Console.Write("Please enter the product brand:");
            // string productBrand = Convert.ToString(Console.ReadLine() ?? "string");
            // Console.Write("Please enter the product price:");
            // double productPrice = Convert.ToDouble(Console.ReadLine());
            // Console.Write("Please enter the product inventory:");
            // int productInventory = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Please enter the product type:");
            // string productType = Convert.ToString(Console.ReadLine() ?? "string");

            // // Create a new product object and add it to the list
            // Products newProduct = new Products(productID, productName, productBrand, productPrice, productInventory, productType, 0, 0);
            // products.Add(newProduct);

            // // Display the products information to the user, here we call the DisplayProductInfor method to display the products information to the user
            // foreach (Products product in products)
            // {
            //     product.DisplayProductInfor();
            // }

            // //Search the product from the list, here we call the SearchProduct method to search the product from the list
            // Products found = Products.SearchProduct(products, "laptop");
            // if (found != null)
            // {
            //     Console.WriteLine("Product found:");
            //     found.DisplayProductInfor();
            // }
            // else
            // {
            //     Console.WriteLine("Product not found.");
            // }

            //Create a cart object to hold the products that the customer wants to purchase
            // Cart cart = new Cart();
            // //Add a product to the cart, here we call the AddToCart method to add a product to the cart
            // cart.AddProduct();
            // //Display the cart information to the user, here we call the DisplayCart method to display the cart information to the user
            // cart.DisplayCart();
            // //Remove a product from the cart, here we call the RemoveFromCart method to remove a product from the cart
            // cart.RemoveProduct();
            // //Display the cart information to the user after removing a product
            // cart.DisplayCart();
            // //Checkout the cart, here we call the Checkout method to checkout the cart and display the total price to the user
            // cart.Checkout();
        }//End of Main
    }
}

