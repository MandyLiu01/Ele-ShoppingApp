using System;
using System.Collections.Generic;
using System.Text;

namespace Ele_ShoppingApp
{
    public class Tablet : Products
    {
        //Properties
        public double ScreenSize { get; set; }
        public double BatteryLife { get; set; }
        //Constructor
        public Tablet() { }
        public Tablet(int id, string name, string brand, double price, int inventory, string type, int purchase, double screenSize, double batteryLife)
            : base(id, name, brand, price, inventory, "Tablet", purchase)
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
}//End of namespace
