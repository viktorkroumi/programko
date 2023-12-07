string[] moznosti = { "čtverec", "obdélník", "kruh", "krychle", "kvádr", "koule", "kužel", "trojúhelník" };

        while (true)
        {
            vypismoznosti(moznosti);

            Console.Write("Vyberte tvar: ");
            string vybranyTvar = Console.ReadLine().ToLower();

            if (Array.Exists(moznosti, shape => shape.ToLower() == vybranyTvar))
            {
                switch (vybranyTvar)
                {
                    case "čtverec":
                        Čtverec();
                        break;
                    case "obdélník":
                        Obdélník();
                        break;
                    case "kruh":
                        Kruh();
                        break;
                    case "krychle":
                        Krychle();
                        break;
                    case "kvádr":
                        Kvádr();
                        break;
                    case "koule":
                        Koule();
                        break;
                    case "kužel":
                        Kužel();
                        break;
                    case "trojúhelník":
                        Trojúhelník();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Neplatný výběr. Zkuste to znovu.");
            }

            Console.Write("Chcete pokračovat? (ano/ne): ");
            string konec = Console.ReadLine().ToLower();
            if (konec != "ano")
            {
                break;
            }
        }

        Console.WriteLine("Program byl ukončen.");

    static void vypismoznosti(string[] tvary)
    {
        Console.WriteLine("Možné tvary:");
        foreach (var tvar in tvary)
        {
            Console.WriteLine("- " + tvar);
        }
        Console.WriteLine();
    }

    static void Čtverec()
    {
        double strana;

        while (true)
        {
            Console.Write("Zadejte délku strany čtverce: ");
            if (double.TryParse(Console.ReadLine(), out strana) && strana > 0)
            {
                double obsah = strana * strana;
                double obvod = 4 * strana;

                Console.WriteLine("Obsah: " + obsah + " Obvod: " + obvod);
                break;
            }
            else
            {
                Console.WriteLine("Zadejte kladné číslo");
            }
        }
    }

    static void Obdélník()
    {
        double délka, šířka;

        while (true)
        {
            Console.Write("Zadejte délku obdélníku: ");
            if (double.TryParse(Console.ReadLine(), out délka) && délka > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Zadejte kladné číslo");
            }
        }

        while (true)
        {
            Console.Write("Zadejte šířku obdélníku: ");
            if (double.TryParse(Console.ReadLine(), out šířka) && šířka > 0)
            {
                double obsah = délka * šířka;
                double obvod = 2 * (délka + šířka);

                Console.WriteLine("Obsah: " + obsah + " Obvod: " + obvod);
                break;
            }
            else
            {
                Console.WriteLine("Zadejte kladné číslo");
            }
        }
    }

    static void Kruh()
    {
        double polomer;

        while (true)
        {
            Console.Write("Zadejte poloměr kruhu: ");
            if (double.TryParse(Console.ReadLine(), out polomer) && polomer > 0)
            {
                double obsah = Math.PI * polomer * polomer;
                double obvod = 2 * Math.PI * polomer;

                Console.WriteLine("Obsah: " + obsah + " Obvod: " + obvod);
                break;
            }
            else
            {
                Console.WriteLine("Zadejte kladné číslo");
            }
        }
    }
    static void Krychle()
    {
        double délka;

        while (true)
        {
            Console.Write("Zadejte délku strany: ");
            if (double.TryParse(Console.ReadLine(), out délka) && délka > 0)
            {
                double povrch = 6 * (délka * délka);
                double objem = délka * délka * délka;
                Console.WriteLine("Povrch: " + povrch + " Objem: " + objem);
                break;
            }
            else
            {
                Console.WriteLine("Zadejte kladné číslo");
            }
        }


    }

    static void Kvádr()
    {
        double délka, šířka, výška;

        while (true)
        {
            Console.Write("Zadejte délku kvádru: ");
            if (double.TryParse(Console.ReadLine(), out délka) && délka > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Zadejte kladné číslo");
            }
        }

        while (true)
        {
            Console.Write("Zadejte šířku kvádru: ");
            if (double.TryParse(Console.ReadLine(), out šířka) && šířka > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Zadejte kladné číslo");
            }
        }

        while (true)
        {
            Console.Write("Zadejte výšku kvádru: ");
            if (double.TryParse(Console.ReadLine(), out výška) && výška > 0)
            {
                double povrch = 2 * (délka * šířka + délka * výška + šířka * výška);
                double objem = délka * šířka * výška;

                Console.WriteLine("Povrch: " + povrch + " Objem: " + objem);
                break;
            }
            else
            {
                Console.WriteLine("Zadejte kladné číslo");
            }
        }
    }

    static void Koule()
    {
        double polomer;

        while (true)
        {
            Console.Write("Zadejte poloměr koule: ");
            if (double.TryParse(Console.ReadLine(), out polomer) && polomer > 0)
            {
                double povrch = 4 * Math.PI * polomer * polomer;
                double objem = 4 * Math.PI * polomer * polomer * polomer / 3;

                Console.WriteLine("Povrch: " + povrch + " Objem: " + objem);
                break;
            }
            else
            {
                Console.WriteLine("Zadejte kladné číslo");
            }
        }
    }

    static void Kužel()
    {
        double polomer, výška;

        while (true)
        {
            Console.Write("Zadejte výšku kužele: ");
            if (double.TryParse(Console.ReadLine(), out výška) && výška > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Zadejte kladné číslo");
            }
        }

        while (true)
        {
            Console.Write("Zadejte poloměr podstavy kužele: ");
            if (double.TryParse(Console.ReadLine(), out polomer) && polomer > 0)
            {
                double p = polomer * polomer + výška * výška;
                double délka = Math.Sqrt(p);
                double povrch = (Math.PI * polomer * polomer) + (Math.PI * polomer * délka);
                double objem = Math.PI * polomer * polomer * výška / 3;

                Console.WriteLine("Povrch: " + povrch + " Objem: " + objem);
                break;
            }
            else
            {
                Console.WriteLine("Zadejte kladné číslo");
            }
        }
    }

    static void Trojúhelník()
    {
        double stranaA, stranaB, stranaC;

        while (true)
        {
            Console.Write("Zadejte první stranu trojúhelníku: ");
            if (double.TryParse(Console.ReadLine(), out stranaA) && stranaA > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Zadejte kladné číslo");
            }
        }

        while (true)
        {
            Console.Write("Zadejte druhou stranu trojúhelníku: ");
            if (double.TryParse(Console.ReadLine(), out stranaB) && stranaB > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Zadejte kladné číslo");
            }
        }

        while (true)
        {
            Console.Write("Zadejte třetí stranu trojúhelníku: ");
            if (double.TryParse(Console.ReadLine(), out stranaC) && stranaC > 0)
            {
                if (platnostTrojuhelniku(stranaA, stranaB, stranaC))
                {
                    double s = (stranaA + stranaB + stranaC) / 2;
                    double her = s * (s - stranaA) * (s - stranaB) * (s - stranaC);
                    double obsah = Math.Sqrt(her);
                    double obvod = stranaA + stranaB + stranaC;

                    Console.WriteLine("Obsah: " + obsah + " Obvod: " + obvod);
                    break;
                }
                else
                {
                    Console.WriteLine("Zadané délky stran nevytvářejí platný trojúhelník");
                }
            }

            else
            {
                Console.WriteLine("Zadejte kladné číslo");
            }

            static bool platnostTrojuhelniku(double a, double b, double c)
            {
                return (a + b > c) && (a + c > b) && (b + c > a);
            }
        }
    }
