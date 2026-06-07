using System;
using System.Collections.Generic;
using System.Text;

namespace Ele_ShoppingApp;

public class Smartwatch : Products
{
//Properties
public bool Waterproof { get; set; }
public bool HasHeartRateMonitor { get; set; }
//Constructor
        
public Smartwatch(int id, string name, string brand, double price, int inventory, string type, int purchase, int purchase1, bool waterproof, bool hasHeartRateMonitor)
: base(id, name, brand, price, inventory, "Smartwatch", purchase, purchase1)
{
            Waterproof = waterproof;
            HasHeartRateMonitor = hasHeartRateMonitor;
        }
        
        //Method: Display smartwatch information
        public override void DisplayProductInfor()
        {
            base.DisplayProductInfor();
            Console.WriteLine($"This smartwatch is waterproof: {Waterproof}");
            Console.WriteLine($"This smartwatch has a heart rate monitor: {HasHeartRateMonitor}");
        }
    }//End of Smartwatch class
//End of namespace
