namespace Ele_ShoppingApp;

public class Smartphone: Products
{
    // List Fiels  
    private string cameraMp = string.Empty;
    private double operatingSystem;

    // List Properties
    public string CameraMp1 { get { return cameraMp; } set { cameraMp = value; } }
    public double OperatingSystem1 { get { return operatingSystem; } set { operatingSystem = value; } }

    // List Constructor
    // Updated to pass required parameters to base Products constructor.
    public Smartphone(int id, string name, string description, double price, int quantity, string category, int extra1, int extra2, string cameraMp, double operatingSystem)
        : base(id, name, description, price, quantity, category, extra1, extra2)
    {
        CameraMp1 = cameraMp;
        OperatingSystem1 = operatingSystem;
    }
    
    //Display smartphone information
    public void DisplayProductInfor()
    {   Console.WriteLine($"This smartphone's camera is: {CameraMp1} MP");
        Console.WriteLine($"This smartphone's operating system is: {OperatingSystem1}");
    }   
}
