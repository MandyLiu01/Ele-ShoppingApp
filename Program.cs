namespace Ele_ShoppingApp
{
    internal class Program
    {
        static void Main(string[] args)
        { 
                string customerUsername = "";
                string customerPassword = "";
                string continueChoice;

           
                Console.WriteLine("==================================");
                Console.WriteLine(" Welcome to Electronic Shopping App ");
                Console.WriteLine("==================================");
            do
            {
                Console.WriteLine("Please select your option:");
                Console.WriteLine("1. Login as Customer");
                Console.WriteLine("2. Login as Staff");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

               switch (choice)
               {
                // Customer Menu
                case 1:

                    Console.WriteLine("\n1. Login to your account");
                    Console.WriteLine("2. Signup to the App");
                    Console.Write("Please enter your choice: ");
                    int customerChoice = Convert.ToInt32(Console.ReadLine());

                    switch (customerChoice)
                    {
                        // Customer Login
                        case 1:

                            Console.Write("Enter your Username: ");
                            string loginUser = Console.ReadLine();

                            Console.Write("Enter your Password: ");
                            string loginPass = Console.ReadLine();

                            if (loginUser == customerUsername &&
                                loginPass == customerPassword &&
                                customerUsername != "")
                            {
                                Console.WriteLine("Customer login successful!");
                            }
                            else
                            {
                                Console.WriteLine("Invalid login. Goodbye!");
                            }

                            break;

                        // Customer Signup
                        case 2:

                            Console.Write("Please create an Username: ");
                            customerUsername = Console.ReadLine();

                            Console.Write("Please create a Password: ");
                            customerPassword = Console.ReadLine();

                            Console.WriteLine("Signup successful!");

                            // Login after signup
                            Console.WriteLine("\nLogin to your account");

                            Console.Write("Enter your Username: ");
                            loginUser = Console.ReadLine();

                            Console.Write("Enter your Password: ");
                            loginPass = Console.ReadLine();

                            if (loginUser == customerUsername &&
                                loginPass == customerPassword)
                            {
                                Console.WriteLine("Customer login successful!");
                            }
                            else
                            {
                                Console.WriteLine("Invalid login");
                            }

                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }

                    break;

                // Staff Login
                case 2:

                    Console.Write("Enter Staff Username: ");
                    string staffUser = Console.ReadLine();

                    Console.Write("Enter Staff Password: ");
                    string staffPass = Console.ReadLine();

                    if (staffUser == "admin" && staffPass == "admin")
                    {
                        Console.WriteLine("Staff login successful!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid login");
                    }

                    break;

                // Exit
                case 3:

                        Console.WriteLine("Thank you for using the App!");
                        return;

                    default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

                Console.Write("\nDo you want to continue? (yes/no): ");
                continueChoice = Console.ReadLine().ToLower();

            } while (continueChoice == "yes");

            Console.WriteLine("GoodBye! You have a good day!");
        }//End of Main
    


    
    }
}
    

