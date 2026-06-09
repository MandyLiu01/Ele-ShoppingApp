namespace Ele_ShoppingApp;

public class Smartphone
{
    // List Fiels  
    private string cameraMp = string.Empty;
    private double operatingSystem;

    // List Properties
    public string CameraMp1 { get { return cameraMp; } set { cameraMp = value; } }
    public double OperatingSystem1 { get { return operatingSystem; } set { operatingSystem = value; } }

    // List Constructor
    public Smartphone(string cameraMp, double operatingSystem)
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
