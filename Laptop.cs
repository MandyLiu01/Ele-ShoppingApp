namespace Ele_ShoppingApp;

public class Laptop: Products
{
    // List Fiels
    private int laptopRam;
    private int storage;
    private string processor;
    private double size;

    // List Properties
    public int LaptopRAM { get { return laptopRam; } set { laptopRam = value; } }
    public int Storage { get { return storage; } set { storage = value; } }
    public string Processor { get { return processor; } set { processor = value; } }
    public double Size { get { return size; } set { size = value; } }

    // List Constructor
    public Laptop(int laptopRam, int storage, string processor, double size)
    {
        LaptopRAM = laptopRam;
        Storage = storage;
        Processor = processor;
        Size = size;
    }
}
