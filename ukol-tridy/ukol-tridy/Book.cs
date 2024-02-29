
class Book : Product
{
    public Book(string Name, double Price, string Author) : base(Name, Price)
    {
        this.Author = Author;
    }

    public string Author;

    public override void ZobrazInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Author: " + Author);
    }
}