using System;
using System.Collections.Generic;
using System.Text;

namespace Ele_ShoppingApp;

public class Tablet : Products
{
    //Fields
    private double screenSize;
    private double batteryLife;

    //Properties
    public double ScreenSize { get{ return screenSize; } set{screenSize = value;} }
    public double BatteryLife { get{ return batteryLife; } set{batteryLife = value;} }

        //Constructor
public Tablet(int id, string name, string brand, double price, int inventory, int purchase, int purchase1, double screenSize, double batteryLife)
            : base(id, name, brand, price, inventory, "Tablet", purchase, purchase1)
{
            ScreenSize = screenSize;
            BatteryLife = batteryLife;
        }
        //Method: Display tablet information
    public override void DisplayProductInfor()
    {
            base.DisplayProductInfor();
            Console.WriteLine($"This tablet's screen size is: {ScreenSize}");
            Console.WriteLine($"This table's battery life is: {BatteryLife} years");
    }
}//End of Tablet class

