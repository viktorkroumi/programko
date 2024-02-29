
class Product
{
    public string Name;
    public double Price;

    public Product(string Name, double Price)
    {
        this.Name = Name;
        this.Price = Price;
    }

    public virtual void ZobrazInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Price: " + Price);
    }
}