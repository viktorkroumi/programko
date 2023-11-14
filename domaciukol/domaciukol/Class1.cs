while (true)
{
    bool success;
    double A, B, C;

    double DoubleParse()
    {
        string pr = Console.ReadLine();

        success = double.TryParse(pr, out double result);

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
        Console.WriteLine($"Řešením jsou čísla {x} a {y}");
    }

    else if (d == 0)
    {
        Console.WriteLine($"Řešením je číslo {x}");
    }

    Console.WriteLine("Zadejte x (napiš stop pro ukončení)");
    string odpoved = Console.ReadLine();
    double f;
    if (odpoved == "stop")
    {
        break;
    }
    if (double.TryParse(odpoved, out f))
    {
        double vysledek = A * f * f + B * f + C;
        Console.WriteLine(A + f + "^2 + " + B + f + " + " + C + " = " + vysledek);
    }

    Console.WriteLine("Chcete ukončit program? (ano/ne)");
    string z = Console.ReadLine();

    if (z == "ano")
        break;
}