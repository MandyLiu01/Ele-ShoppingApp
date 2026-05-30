namespace Ele_ShoppingApp;

public class TV:Products
{
    // List Fiels  
    private string screenResolution;
    private double screenSize;

    // List Properties
    public string ScreenResolution1 { get { return screenResolution; } set { screenResolution = value; } }
    public double ScreenSize1 { get { return screenSize; } set { screenSize = value; } }

    // List Constructor
    public TV(string screenResolution, double screenSize)
    {        ScreenResolution1 = screenResolution;
        ScreenSize1 = screenSize;}
}
