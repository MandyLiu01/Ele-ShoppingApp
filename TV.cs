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
    // List Constructor
    public TV(int prodID,
        string name,
        string brand,
        double price,
        int stock,
        string category,
        int purchase,
        int purchase1,
        string screenRes,
        double screenSz
    ) : base(prodID, name, brand, price, stock, category, purchase, purchase1)
    {
        screenResolution = screenRes;
        screenSize = screenSz;
    }

}
