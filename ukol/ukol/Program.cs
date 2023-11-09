//while (true)

//{

//  Console.WriteLine("Rovnice: ax+b=0");

//  Console.Write("a = ");

//  string vstupA = Console.ReadLine();

//  Console.Write("b = ");

//  string vstupB = Console.ReadLine();



//  bool success1 = double.TryParse(vstupA, out double intvstupA);

//  bool success2 = double.TryParse(vstupB, out double intvstupB);



//  if (intvstupA != 0)

//  {

//      double vystupNE = -intvstupB/intvstupA;

//      if ( intvstupB == 0 )

//      {

//          vystupNE = 0;

//      }

//      Console.WriteLine($"Resenim rovnice je: {vystupNE}");



//  }

//  else if (intvstupB == 0)

//  {

//      Console.WriteLine("Rovnice ma nekonecne mnoho reseni.");

//  }

//  else

//  {

//      Console.WriteLine("Rovnice nema reseni.");

//  }

//}







while (true)

{

    bool success;

    double vstupA;

    double vstupB;

    double vstupC;



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

        vstupA = DoubleParse();



        if (vstupA == 0)

        {

            Console.WriteLine("Neni to kvadraticka rovnice, zadej nenulové číslo.");

        }

    } while (success == false);



    do

    {

        Console.Write("b = ");

        vstupB = DoubleParse();

    } while (success == false);



    do

    {

        Console.Write("c = ");

        vstupC = DoubleParse();

    } while (success == false);





    Console.WriteLine("Vypočítej Diskriminant D = b² - 4ac");

    double diskriminant = vstupB * vstupB - 4 * vstupC * vstupA;

    double reseni1 = (-vstupB + Math.Sqrt(diskriminant)) / (2 * vstupA);

    double reseni2 = (-vstupB - Math.Sqrt(diskriminant)) / (2 * vstupA);



    if (diskriminant < 0)

    {

        Console.WriteLine("Rovnice nemá řešení");

    }

    else if (diskriminant > 0)

    {

        Console.WriteLine($"Řešením rovnice jsou čísla {reseni1} a {reseni2}");

    }

    else if (diskriminant == 0)

    {

        Console.WriteLine($"Řešení rovnice je číslo {reseni1}");

    }



}

