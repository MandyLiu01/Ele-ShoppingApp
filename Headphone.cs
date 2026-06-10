using System;
using System.Collections.Generic;
using System.Text;

namespace Ele_ShoppingApp;

public class Headphone : Products
{
    // List Properties
    private bool isWireless;
    private bool isNoiseCancelling;
    //Properties
 
    public bool IsWireless { get{ return isWireless; } set{ isWireless = value; } }
    public bool IsNoiseCancelling { get{ return isNoiseCancelling; } set{ isNoiseCancelling = value; } }

    //Constructor

    public Headphone(int id, string name, string brand, double price, int inventory, int purchase, int purchase1, bool isWireless, bool isNoiseCancelling)
        : base(id, name, brand, price, inventory, "Headphone", purchase, purchase1)
    {        
        IsWireless = isWireless;
        IsNoiseCancelling = isNoiseCancelling;
    }

    //Method: Display headphone information
    public override void DisplayProductInfor()
    {
        base.DisplayProductInfor();
        Console.WriteLine($"This headphone is wireless: {IsWireless}");
        Console.WriteLine($"This headphone is noise cancelling: {IsNoiseCancelling}");
    }
}//End of Headphone class
