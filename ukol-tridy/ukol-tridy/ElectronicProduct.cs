
class ElectronicProduct : Product
{
    public ElectronicProduct(string Name, double Price, string Manufacturer) : base(Name, Price)
    {
        this.Manufacturer = Manufacturer;
    }

    public string Manufacturer;


    public override void ZobrazInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Manufacturer: " + Manufacturer);
    }
}