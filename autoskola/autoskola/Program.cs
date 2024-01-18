using System.IO;
using System.Text;

while (true)
{
    Console.WriteLine("Test autoškola");
    Console.WriteLine("Pro konec testu napiš konec");
    Console.ReadLine();
    Console.Clear();
    
    string[] otazky = File.ReadAllLines("questions.data");

    double uspesnost = 0;
    int pocet = 0;
    for (int i = 0; i < otazky.Length; i++)
    {

        string vyberotazky()
        {
            Random rnd = new Random();
            int otazka = rnd.Next(0, 624);

            return otazky[otazka];
        }

        string[] moznosti()
        {
            string i = vyberotazky();
            string[] deleni = i.Split('|');
            return deleni;
        }

        string[] vypis = moznosti();
        string x = zobrazeni(vypis);
        string zobrazeni(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {


                if (i == 1)
                {
                    Console.WriteLine();
                }
                else
                {
                    switch (i)
                    {
                        case 2:
                            Console.Write("A: ");
                            break;
                        case 3:
                            Console.Write("B: ");
                            break;
                        case 4:
                            Console.Write("C: ");
                            break;

                    }
                    if (i < 1)
                    {
                        Console.WriteLine(a[i]);
                    }
                    else
                    {
                        Console.WriteLine(a[i]);
                    }

                }

            }
            return vypis[1];
        }

        string odpoved()
        {
            bool x;
            string vybrana;
            do
            {
                vybrana = Console.ReadLine();
                x = vybrana == "A" || vybrana == "B" || vybrana == "C" || vybrana == "konec";
                if (!x)
                {
                    Console.WriteLine("Neplatná odpověď");
                }
            }
            while (!x);
            return vybrana;
        }

        oprava();

        void oprava()
        {
            pocet++;

            if (odpoved() == "konec")
            {
                end();
            }
            else
            {
                if (odpoved() == x)
                {
                    uspesnost++;
                    Console.WriteLine("Správně");
                }
                else
                {
                    Console.WriteLine("Špatně, správná odpověď je:");
                    if (vypis[1] == "A")
                    {
                        Console.WriteLine("A: " + vypis[2]);
                    }
                    else if (vypis[1] == "B")
                    {
                        Console.WriteLine("B: " + vypis[3]);
                    }
                    else if (vypis[1] == "C")
                    {
                        Console.WriteLine("C: " + vypis[4]);
                    }
                }
            }
        }

        string konec = Console.ReadLine();
        if (konec == "konec")
        {
            break;
        }
        Console.Clear();
    }

    end();

    void end()
    {
        Console.Clear();
        Console.WriteLine("Konec testu");
        Console.WriteLine("Vaše úspěšnonost:" + (100 * uspesnost / pocet) + "%");
        Console.ReadLine();
    }
    break;
}