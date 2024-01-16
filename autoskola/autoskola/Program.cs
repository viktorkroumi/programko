using System.IO;
using System.Text;

//Console.OutputEncoding = Encoding.UTF8;

//while (true)
//{
//    Console.WriteLine("Autoškola test");

//    string[] otazky = File.ReadAllLines("questions.data");

//    foreach (string otazka in otazky)
//    {
//        string[] parts = otazka.Split('|');
//        string Otazka = parts[1];
//        string Odpoved = parts[2];
//        string moznost1 = parts[3];
//        string moznost2 = parts[4];
//        string moznost3 = parts[5];
//    }

//}




while (true)
{
    Console.WriteLine("Vybírej z možností A,B nebo A,B,C");
    Console.WriteLine("Po ukončení se zobrazí výsledek (nejde posoudit, jestli prospěl, protože reálně jsou otázky různě bodově ohodnoceny)");
    Console.WriteLine("pokud kdykoli napíšeš konec, test se ukončí. Pro ukončení programu napiš konec znovu. Pro nový test na konci jen zmáčkni enter a spustí se nový test");
    Console.WriteLine("po zobrazení správné odpovědi stiskni enter a zobrazí se další otázka");


    bool z;
    int cislo1;
    do
    {
        string kterej = Console.ReadLine();
        Console.Clear();
        Console.WriteLine();
        int.TryParse(kterej, out cislo1);
        z = (int.TryParse(kterej, out cislo1));
        if (!z)
        {
            Console.WriteLine("to není číslo");
        }

    } while (!z);

    string[] otazky = File.ReadAllLines("questions.data");

    double successrate = 0;
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
            string abc;
            do
            {
                abc = Console.ReadLine();
                x = abc == "A" || abc == "B" || abc == "C" || abc == "konec";
                if (!x)
                {
                    Console.WriteLine("neplatná odpověď");
                }
            }
            while (!x);
            return abc;
        }

        int answer()
        {

            string tvoje = odpoved();
            if (tvoje == x)
            {

                return 1;
            }
            else if (tvoje == "konec")
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        int correct = answer();

        if (correct == 1)
        {
            successrate += 1;
        }

        if (correct == 2)
        {
            break;
        }
        oprava(correct);
        void oprava(int a)
        {

            if (correct == 1)
            {
                Console.WriteLine("správně");
            }
            else
            {
                Console.WriteLine("špatně, správná odpověď je:");
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
        string b = Console.ReadLine(); //toto slouží k pozastavení po zobrazení odpovědi
        if (b == "konec")
        {

            break;
        }
        Console.Clear();
    }
    Console.Clear();
    Console.WriteLine("konec testu");
    Console.WriteLine("počet správných odpovědí: " + successrate + "/" + cislo1);
    Console.WriteLine("vase uspesnost je:" + (100 * successrate / cislo1) + "%");
    string end = Console.ReadLine();

    if (end == "konec")
    {
        break;
    }
    Console.Clear();
}
