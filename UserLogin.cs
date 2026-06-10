using System.Collections.Generic;
using static System.Console;

namespace Ele_ShoppingApp;

// Handles user authentication (login/signup) and staff access
public class UserLogin
{
      // Shared inventory list for all products managed by staff.
    static readonly List<Products> productList = new List<Products>();
    public static List<Products> ProductInventory => productList;

    // Private fields to store user credentials
    private string username = "";
    private string password = "";

    // Property for username with validation
    public string Username
    {
        get { return username; }
        set
        { 
            if (!string.IsNullOrEmpty(value))
            {
                username = value;
            }
            else
            {
                Console.WriteLine("Username cannot be empty!");
            }
        }
    }

    // Property for password with validation
    public string Password
    {
        get { return password; }
        set 
        { 
            if (!string.IsNullOrEmpty(value))
            {
                password = value;
            }
            else
            {
                Console.WriteLine("Password cannot be empty!");
            }
        }
    }

    // Constructor to initialize a user with username and password
    public UserLogin(string username, string password)
    {
        Username = username;
        Password = password;
    }

    // Authenticates user by comparing entered credentials against saved users
    public static void Login(List<UserLogin> users)
    {
        bool isAuthenticated = false;

        do
        {
            Console.WriteLine();
            Console.WriteLine("|          Customer Login          |");
            Console.WriteLine("====================================");
            Console.WriteLine();
            Console.Write("Enter your Username: ");
            string user = Convert.ToString(Console.ReadLine() ?? "string");

            Console.Write("Enter your Password: ");
            string pass = Convert.ToString(Console.ReadLine() ?? "string");

            foreach (UserLogin existingUser in users)
            {
                if (existingUser.Username == user && existingUser.Password == pass)
                {
                    Console.WriteLine();
                    Console.WriteLine("Customer login successful!");
                    isAuthenticated = true;
                    break;
                }
            }

            if (!isAuthenticated)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid login, please try again.");
            }
        } while (!isAuthenticated);
    }

    // =============================================================
    // >>>>>>>>>>>>>>>>>>>>>>>>> STAFF LOGIN SECTION <<<<<<<<<<<<<<<<<<<<<<<<<
    // Staff Login: this part handles staff authentication with hardcoded admin credentials and allows retry
    // >>>>>>>>>>>>>>>>>>>>>>>>> STAFF LOGIN SECTION <<<<<<<<<<<<<<<<<<<<<<<<<
    // =============================================================
    public static void StaffLogin()
    {
        bool isAuthenticated = false;

        do
        {
            Console.Write("Enter Staff Username: ");
                string staffUser = Convert.ToString(Console.ReadLine() ?? "string");

                Console.Write("Enter Staff Password: ");
                string staffPass = Convert.ToString(Console.ReadLine() ?? "string");

                if (staffUser == "admin" && staffPass == "admin")
                {
                    StaffMenu();
                    isAuthenticated = true;
                }
                else
                {
                    Console.WriteLine("Invalid login, please try again.");
                }
            } while (!isAuthenticated);
    }

    // Allows new users to create an account and returns the new user object
    public static UserLogin Signup()
    {
        Console.WriteLine();
        Console.WriteLine("|          Create Account          |");
        Console.WriteLine("====================================");
        Console.WriteLine();
        // Get new username from user
        Console.Write("Please create a Username: ");
        string newUser = Convert.ToString(Console.ReadLine() ?? "string");

        // Get new password from user
        Console.Write("Please create a Password: ");
        string newPass = Convert.ToString(Console.ReadLine() ?? "string");
        Console.WriteLine();
        Console.WriteLine("Signup successful!");
        return new UserLogin(newUser, newPass);
    }

    public static void StaffMenu()
    {

        do
        {
            // Inventory menu loop for staff.
            // Allows staff to add, remove, display, or search products.
            Console.WriteLine();
            Console.WriteLine("-----------Admin stock for Inventory Menu-----------");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("| 1. | Add New product                             |");
            Console.WriteLine("| 2. | Remove product                              |");
            Console.WriteLine("| 3. | Display Products                            |");
            Console.WriteLine("| 4. | Search Product                              |");
            Console.WriteLine("| n. | To go back to preview menu                  |");
            Console.WriteLine("|____|_____________________________________________|");
            Console.WriteLine();
            
            Console.Write("Your choice: ");

            string input = Console.ReadLine() ?? string.Empty;
            if (input.Trim().ToLower() == "n")
            {
                Console.WriteLine("Returning to the main menu...");
                return;
            }

            if (!int.TryParse(input, out int adminCh))
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            switch (adminCh)
            {
                case 1:
                    // Add or restock a product.
                    // If the product already exists, update only the quantity.
                    try
                    {
                        Console.WriteLine();
                        Console.WriteLine("---------------Add New Product---------------");
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Select product type by entering the corresponding number:");
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("| 1. | TV                                    |");
                        Console.WriteLine("| 2. | Smartphone                            |");
                        Console.WriteLine("| 3. | Laptop                                |");
                        Console.WriteLine("| 4. | Tablet                                |");
                        Console.WriteLine("| 5. | Headphones                            |");
                        Console.WriteLine("| 6. | Smartwatch                            |");
                        Console.WriteLine("| n. | To go back to previous menu           |");
                        Console.WriteLine("|____|_______________________________________|");
                        Console.WriteLine();
                        Console.Write("Enter your choice: ");
                        string typeInput = Console.ReadLine() ?? string.Empty;

                        if (typeInput.Trim().ToLower() == "n")
                        {
                            Console.WriteLine("Returning to the previous menu...");
                            break;
                        }

                        if (!int.TryParse(typeInput, out int typeChoice))
                        {
                            Console.WriteLine("Invalid type selection.");
                            break;
                        }

                        Console.Write("Enter product ID: ");
                        string productIdInput = Console.ReadLine() ?? string.Empty;
                        if (!int.TryParse(productIdInput, out int productId))
                        {
                            Console.WriteLine("Invalid product ID.");
                            break;
                        }

                        Console.Write("Enter product name: ");
                        string productName = Console.ReadLine() ?? string.Empty;
                        Console.Write("Enter product brand: ");
                        string productBrand = Console.ReadLine() ?? string.Empty;

                        Console.Write("Enter product price: ");
                        if (!double.TryParse(Console.ReadLine(), out double productPrice))
                        {
                            Console.WriteLine("Invalid price.");
                            break;
                        }

                        Console.Write("Enter product quantity: ");
                        if (!int.TryParse(Console.ReadLine(), out int productQuantity))
                        {
                            Console.WriteLine("Invalid quantity.");
                            break;
                        }

                        Products newProduct;

                        switch (typeChoice)
                        {
                            case 1:
                                Console.Write("Enter screen resolution: ");
                                string screenResolution = Console.ReadLine() ?? string.Empty;
                                Console.Write("Enter screen size (in inches): ");
                                if (!double.TryParse(Console.ReadLine(), out double screenSize))
                                {
                                    Console.WriteLine("Invalid screen size.");
                                    break;
                                }
                                Products? existingTv = productList.Find(p => string.Equals(p.ProductName, productName, StringComparison.OrdinalIgnoreCase) && string.Equals(p.ProductType, "TV", StringComparison.OrdinalIgnoreCase));
                                if (existingTv != null)
                                {
                                    existingTv.ChangeQuantity(productQuantity);
                                    Console.WriteLine($"TV product already exists. Updated quantity to {existingTv.ProductQuantity}.");
                                }
                                else
                                {
                                    newProduct = new TV(productId, productName, productBrand, productPrice, productQuantity, "TV", 0, 0, screenResolution, screenSize);
                                    productList.Add(newProduct);
                                    Console.WriteLine();
                                    Console.WriteLine("TV product added successfully!");
                                }
                                break;
                            case 2:
                                Console.Write("Enter camera details: ");
                                string cameraMp = Console.ReadLine() ?? string.Empty;
                                Console.Write("Enter operating system version: ");
                                if (!double.TryParse(Console.ReadLine(), out double operatingSystem))
                                {
                                    Console.WriteLine("Invalid operating system version.");
                                    break;
                                }
                                Products? existingPhone = productList.Find(p => string.Equals(p.ProductName, productName, StringComparison.OrdinalIgnoreCase) && string.Equals(p.ProductType, "Smartphone", StringComparison.OrdinalIgnoreCase));
                                if (existingPhone != null)
                                {
                                    existingPhone.ChangeQuantity(productQuantity);
                                    Console.WriteLine($"Smartphone product already exists. Updated quantity to {existingPhone.ProductQuantity}.");
                                }
                                else
                                {
                                    newProduct = new Products(productId, productName, productBrand, productPrice, productQuantity, "Smartphone", 0, 0);
                                    productList.Add(newProduct);
                                    Console.WriteLine();
                                    Console.WriteLine("Smartphone product added successfully!");
                                }
                                break;
                            case 3:
                                Console.Write("Enter RAM (GB): ");
                                if (!int.TryParse(Console.ReadLine(), out int laptopRam))
                                {
                                    Console.WriteLine("Invalid RAM value.");
                                    break;
                                }
                                Console.Write("Enter storage (GB): ");
                                if (!int.TryParse(Console.ReadLine(), out int storage))
                                {
                                    Console.WriteLine("Invalid storage value.");
                                    break;
                                }
                                Console.Write("Enter stock quantity: ");
                                if (!int.TryParse(Console.ReadLine(), out int stock))
                                {
                                    Console.WriteLine("Invalid stock value.");
                                    break;
                                }
                                Console.Write("Enter processor model: ");
                                string processor = Console.ReadLine() ?? string.Empty;
                                Console.Write("Enter laptop display size (in inches): ");
                                if (!double.TryParse(Console.ReadLine(), out double size))
                                {
                                    Console.WriteLine("Invalid laptop size.");
                                    break;
                                }
                                Products? existingLaptop = productList.Find(p => string.Equals(p.ProductName, productName, StringComparison.OrdinalIgnoreCase) && string.Equals(p.ProductType, "Laptop", StringComparison.OrdinalIgnoreCase));
                                if (existingLaptop != null)
                                {
                                   
                                    existingLaptop.ChangeQuantity(productQuantity);
                                    Console.WriteLine($"Laptop product already exists. Updated quantity to {existingLaptop.ProductQuantity}.");
                                }
                                else
                                {
                                    newProduct = new Laptop(productId, productName, productBrand, productPrice, productQuantity, "Laptop", laptopRam, storage, stock, 0, processor, size);
                                    productList.Add(newProduct);
                                    Console.WriteLine();
                                    Console.WriteLine("Laptop product added successfully!");
                                }
                                break;
                            case 4:
                                Console.Write("Enter tablet display size (in inches): ");
                                if (!double.TryParse(Console.ReadLine(), out double tabletSize))
                                {
                                    Console.WriteLine("Invalid tablet size.");
                                    break;
                                }
                                Products? existingTablet = productList.Find(p => string.Equals(p.ProductName, productName, StringComparison.OrdinalIgnoreCase) && string.Equals(p.ProductType, "Tablet", StringComparison.OrdinalIgnoreCase));
                                if (existingTablet != null)
                                {
                                    existingTablet.ChangeQuantity(productQuantity);
                                    Console.WriteLine($"Tablet product already exists. Updated quantity to {existingTablet.ProductQuantity}.");
                                }
                                else
                                {
                                    newProduct = new Tablet(productId, productName, productBrand, productPrice, productQuantity, 0, 0, 0, tabletSize);
                                    productList.Add(newProduct);
                                    Console.WriteLine();
                                    Console.WriteLine("Tablet product added successfully!");
                                }
                                break;
                            case 5:
                                Console.Write("Enter headphone type (e.g., over-ear, in-ear): ");
                                string headphoneType = Console.ReadLine() ?? string.Empty;
                                Products? existingHeadphones = productList.Find(p => string.Equals(p.ProductName, productName, StringComparison.OrdinalIgnoreCase) && string.Equals(p.ProductType, "Headphones", StringComparison.OrdinalIgnoreCase));
                                if (existingHeadphones != null)
                                {
                                    existingHeadphones.ChangeQuantity(productQuantity);
                                    Console.WriteLine($"Headphones product already exists. Updated quantity to {existingHeadphones.ProductQuantity}.");
                                }
                                else
                                {
                                    newProduct = new Headphone(productId, productName, productBrand, productPrice, productQuantity, 0, 0,
                                        headphoneType.Equals("wireless", StringComparison.OrdinalIgnoreCase),
                                        headphoneType.Equals("noise-cancelling", StringComparison.OrdinalIgnoreCase));
                                    productList.Add(newProduct);
                                    Console.WriteLine();
                                    Console.WriteLine("Headphones product added successfully!");
                                }
                                break;
                            case 6:
                                Console.Write("Enter smartwatch display size (in inches): ");
                                if (!double.TryParse(Console.ReadLine(), out double watchSize))
                                {
                                    Console.WriteLine("Invalid smartwatch size.");
                                    break;
                                }
                                Console.Write("Enter smartwatch type (e.g., waterproof, heart-rate-monitor): ");
                                string smartwatchType = Console.ReadLine() ?? string.Empty;
                                Products? existingWatch = productList.Find(p => string.Equals(p.ProductName, productName, StringComparison.OrdinalIgnoreCase) && string.Equals(p.ProductType, "Smartwatch", StringComparison.OrdinalIgnoreCase));
                                if (existingWatch != null)
                                {
                                    existingWatch.ChangeQuantity(productQuantity);
                                    Console.WriteLine($"Smartwatch product already exists. Updated quantity to {existingWatch.ProductQuantity}.");
                                }
                                else
                                {
                                    newProduct = new Smartwatch(productId, productName, productBrand, productPrice, productQuantity,
                                        "Smartwatch", 0, 0,
                                        smartwatchType.Equals("waterproof", StringComparison.OrdinalIgnoreCase),
                                        smartwatchType.Equals("heart-rate-monitor", StringComparison.OrdinalIgnoreCase));
                                    productList.Add(newProduct);
                                    Console.WriteLine();
                                    Console.WriteLine("Smartwatch product added successfully!");
                                }
                                break;
                            
                            default:
                                Console.WriteLine("Invalid type selection.");
                                break;
                        }
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                        break;
                    }

                case 2:
                    // Remove inventory quantity from an existing product.
                    // If quantity reaches zero, the product is removed entirely.
                    Console.WriteLine();
                    Console.WriteLine("-------------------Remove Product-------------------");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine();
                    Console.Write("Enter the product name to remove: ");
                    try
                    {
                        string productNameToRemove = Console.ReadLine() ?? string.Empty;
                        Products? prodToRemove = productList.Find(p => string.Equals(p.ProductName, productNameToRemove, StringComparison.OrdinalIgnoreCase));

                        if (!string.IsNullOrWhiteSpace(productNameToRemove) && prodToRemove != null)
                        {
                            Console.Write("Enter quantity to remove: ");
                            if (!int.TryParse(Console.ReadLine(), out int removeQuantity) || removeQuantity <= 0)
                            {
                                Console.WriteLine("Invalid quantity.");
                                break;
                            }

                            if (prodToRemove.ChangeQuantity(-removeQuantity))
                            {
                                if (prodToRemove.ProductQuantity == 0)
                                {
                                    productList.Remove(prodToRemove);
                                    Console.WriteLine($"{productNameToRemove} removed from inventory.");
                                }
                                else
                                {
                                    Console.WriteLine($"Removed {removeQuantity} from {productNameToRemove}. Remaining quantity: {prodToRemove.ProductQuantity}.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Not enough quantity to remove.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Product not found.");
                        }
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                        break;
                    }
                case 3:
                    // Display all products currently in inventory.
                    foreach (Products product in productList)
                    {
                        product.DisplayProductInfor();
                    }
                    break;
                case 4:
                    // Search for a product by name in the current inventory.
                    Console.WriteLine();
                    Console.WriteLine("-------------------Search Product-------------------");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine();
                    Products? foundProduct = Products.SearchProduct(productList, "string");
                    if (foundProduct != null)
                    {
                        foundProduct.DisplayProductInfor();
                    }
                    else
                    {
                        Console.WriteLine("Product not found.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        while (true);
    }

    // =============================================================
    // >>>>>>>>>>>>>>>>>>>>>>>>> END OF STAFF SECTION <<<<<<<<<<<<<<<<<<<<<<
    // The staff login and admin inventory menu logic ends here.
    // =============================================================
}
