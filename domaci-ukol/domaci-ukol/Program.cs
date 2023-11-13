while (true)
{
    bool success;
    double A;
    double B;
    double C;

    double DoubleParse()
    {
        string ting = Console.ReadLine();

        success = double.TryParse(ting, out double result);

        return result;
    }

    do
    {
        Console.WriteLine("Rovnice: ax²+bx+c=0");
        Console.Write("a = ");
        A = DoubleParse();

        if (A == 0)
        {
            Console.WriteLine("Neni to kvadraticka rovnice, zadej nenulové číslo.");
        }

    } while (success == false);

    do
    {
        Console.Write("b = ");
        B = DoubleParse();

    } while (success == false);

    do
    {
        Console.Write("c = ");
        C = DoubleParse();

    } while (success == false);


    double d = B * B - 4 * A * C;

    double x = (-B + Math.Sqrt(d)) / (2 * A);

    double y = (-B - Math.Sqrt(d)) / (2 * A);


    if (d < 0)
    {
        Console.WriteLine("Rovnice nemá řešení");
    }

    else if (d > 0)
    {
        Console.WriteLine($"Řešením rovnice jsou čísla {x} a {y}");
    }

    else if (d == 0)
    {
        Console.WriteLine($"Řešení rovnice je číslo {x}");
    }

    double w;
    
    Console.WriteLine("Zadejte x pro výpočet");
    w = DoubleParse();

    double q = A * w * w + B * w + C;

    Console.WriteLine(q);
    

}