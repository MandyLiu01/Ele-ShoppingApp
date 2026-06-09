namespace Ele_ShoppingApp;

public class Laptop:Products
{
    // List Fiels
    private int laptopRam;
    private int storage;
    private string processor = string.Empty;
    private double size;

    // List Properties
    public int LaptopRAM { get { return laptopRam; } set { laptopRam = value; } }
    public int Storage { get { return storage; } set { storage = value; } }
    public string Processor { get { return processor; } set { processor = value; } }
    public double Size { get { return size; } set { size = value; } }

    // List Constructor
    public Laptop(int prodID,
        string name,
        string brand,
        double price,
        int stock,
        string category,
        int purchase,
        int purchase1,
        int laptopRam,
        int storage,
        string processor,
        double size
    ) : base(prodID, name, brand, price, stock, category, purchase, purchase1)
    {
        LaptopRAM = laptopRam;
        Storage = storage;
        Processor = processor;
        Size = size;
    }

    //Display laptop information
    public override void DisplayProductInfor()
    {
        base.DisplayProductInfor();
        Console.WriteLine($"This laptop's RAM is: {LaptopRAM} GB");
        Console.WriteLine($"This laptop's storage is: {Storage} GB");
        Console.WriteLine($"This laptop's processor is: {Processor}");
        Console.WriteLine($"This laptop's size is: {Size} inches");
    }
}
