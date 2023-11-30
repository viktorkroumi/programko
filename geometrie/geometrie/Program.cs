class program
{
    static void Main()
    {
        string[] moznostiTvaru = { "čtverec", "obdélník", "kruh", "krychle", "kvádr", "koule", "kužel", "obecný trojúhelník" };

        while (true)
        {
            VypisMozneTvary(moznostiTvaru);

            Console.Write("Vyberte tvar ");
            string vybranyTvar = Console.ReadLine().ToLower();

            switch (vybranyTvar)
            {
                case "čtverec":
                case "obdélník":
                case "kruh":
                    ZpracujGeometrickyTvar(vybranyTvar);
                    break;

                case "krychle":
                case "kvádr":
                case "koule":
                case "kužel":
                    ZpracujProstorovyTvar(vybranyTvar);
                    break;

                case "obecný trojúhelník":
                    ZpracujObecnyTrojuhelnik();
                    break;

                default:
                    Console.WriteLine("Neplatný výběr. Zkuste to znovu.");
                    break;
            }

            Console.Write("Chcete pokračovat? (ano/ne): ");
            string pokracovat = Console.ReadLine().ToLower();

            if (pokracovat != "ano")
                break;
        }
    }

    static void VypisMozneTvary(string[] tvary)
    {
        foreach (var tvar in tvary)
        {
            Console.WriteLine(tvar);
        }
        Console.WriteLine();
    }

    static void ZpracujGeometrickyTvar(string tvar)
    {
        double vysledek = 0.0;

        switch (tvar)
        {
            case "čtverec":
                Console.Write("Zadejte délku strany čtverce: ");
                double stranaCtverce = ZiskatKladneCislo();
                vysledek = stranaCtverce * stranaCtverce;
                break;

            case "obdélník":
                Console.Write("Zadejte délku strany obdélníku: ");
                double delkaObdelnika = ZiskatKladneCislo();
                Console.Write("Zadejte šířku obdélníku: ");
                double sirkaObdelnika = ZiskatKladneCislo();
                vysledek = delkaObdelnika * sirkaObdelnika;
                break;

            case "kruh":
                Console.Write("Zadejte poloměr kruhu: ");
                double polomerKruhu = ZiskatKladneCislo();
                vysledek = Math.PI * polomerKruhu * polomerKruhu;
                break;
        }

        double obvod = ZjistitObvod(tvar);
        VypisVysledek(tvar, obvod, vysledek);
    }

    static void ZpracujProstorovyTvar(string tvar)
    {
        double vysledek = 0.0;

        switch (tvar)
        {
            case "krychle":
                Console.Write("Zadejte délku hrany krychle: ");
                double hranaKrychle = ZiskatKladneCislo();
                vysledek = 6 * hranaKrychle * hranaKrychle;
                break;

            case "kvádr":
                Console.Write("Zadejte délku hrany kvádru: ");
                double hranaKvadru = ZiskatKladneCislo();
                Console.Write("Zadejte šířku kvádru: ");
                double sirkaKvadru = ZiskatKladneCislo();
                Console.Write("Zadejte výšku kvádru: ");
                double vyskaKvadru = ZiskatKladneCislo();
                vysledek = 2 * (hranaKvadru * sirkaKvadru + hranaKvadru * vyskaKvadru + sirkaKvadru * vyskaKvadru);
                break;

            case "koule":
                Console.Write("Zadejte poloměr koule: ");
                double polomerKoule = ZiskatKladneCislo();
                vysledek = 4 * Math.PI * polomerKoule * polomerKoule;
                break;

            case "kužel":
                Console.Write("Zadejte poloměr kužele: ");
                double polomerKuzele = ZiskatKladneCislo();
                Console.Write("Zadejte výšku kužele: ");
                double vyskaKuzele = ZiskatKladneCislo();
                vysledek = Math.PI * polomerKuzele * (polomerKuzele + Math.Sqrt(polomerKuzele * polomerKuzele + vyskaKuzele * vyskaKuzele));
                break;
        }

        double objem = ZjistitObjem(tvar);
        VypisVysledek(tvar, vysledek, objem);
    }

    static void ZpracujObecnyTrojuhelnik()
    {
        Console.Write("Zadejte délku první strany trojúhelníku: ");
        double stranaA = ZiskatKladneCislo();
        Console.Write("Zadejte délku druhé strany trojúhelníku: ");
        double stranaB = ZiskatKladneCislo();
        Console.Write("Zadejte délku třetí strany trojúhelníku: ");
        double stranaC = ZiskatKladneCislo();

        if (JeTrojuhelnikPlatny(stranaA, stranaB, stranaC))
        {
            double s = (stranaA + stranaB + stranaC) / 2;
            double obsah = Math.Sqrt(s * (s - stranaA) * (s - stranaB) * (s - stranaC));
            double obvod = stranaA + stranaB + stranaC;

            VypisVysledek("obecný trojúhelník", obvod, obsah);
        }
        else
        {
            Console.WriteLine("Zadané délky stran nevytvářejí platný trojúhelník.");
        }
    }

    static double ZjistitObvod(string tvar)
    {
        switch (tvar)
        {
            case "čtverec":
                Console.Write("Zadejte délku strany čtverce: ");
                double stranaCtverce = ZiskatKladneCislo();
                return 4 * stranaCtverce;

            case "obdélník":
                Console.Write("Zadejte délku strany obdélníku: ");
                double delkaObdelnika = ZiskatKladneCislo();
                Console.Write("Zadejte šířku obdélníku: ");
                double sirkaObdelnika = ZiskatKladneCislo();
                return 2 * (delkaObdelnika + sirkaObdelnika);

            case "kruh":
                Console.Write("Zadejte poloměr kruhu: ");
                double polomerKruhu = ZiskatKladneCislo();
                return 2 * Math.PI * polomerKruhu;

            case "obecný trojúhelník":
                Console.Write("Zadejte délku první strany trojúhelníku: ");
                double stranaA = ZiskatKladneCislo();
                Console.Write("Zadejte délku druhé strany trojúhelníku: ");
                double stranaB = ZiskatKladneCislo();
                Console.Write("Zadejte délku třetí strany trojúhelníku: ");
                double stranaC = ZiskatKladneCislo();
                return stranaA + stranaB + stranaC;

            default:
                return 0.0;
        }
    }

    static double ZjistitObjem(string tvar)
    {
        switch (tvar)
        {
            case "krychle":
                Console.Write("Zadejte délku hrany krychle: ");
                double hranaKrychle = ZiskatKladneCislo();
                return Math.Pow(hranaKrychle, 3);

            case "kvádr":
                Console.Write("Zadejte délku hrany kvádru: ");
                double hranaKvadru = ZiskatKladneCislo();
                Console.Write("Zadejte šířku kvádru: ");
                double sirkaKvadru = ZiskatKladneCislo();
                Console.Write("Zadejte výšku kvádru: ");
                double vyskaKvadru = ZiskatKladneCislo();
                return hranaKvadru * sirkaKvadru * vyskaKvadru;

            case "koule":
                Console.Write("Zadejte poloměr koule: ");
                double polomerKoule = ZiskatKladneCislo();
                return (4.0 / 3.0) * Math.PI * Math.Pow(polomerKoule, 3);

            case "kužel":
                Console.Write("Zadejte poloměr kužele: ");
                double polomerKuzele = ZiskatKladneCislo();
                Console.Write("Zadejte výšku kužele: ");
                double vyskaKuzele = ZiskatKladneCislo();
                return (1.0 / 3.0) * Math.PI * Math.Pow(polomerKuzele, 2) * vyskaKuzele;

            default:
                return 0.0;
        }
    }

    static void VypisVysledek(string tvar, double hodnota1, double hodnota2)
    {
        Console.WriteLine($"\nVýsledky pro {tvar}:\n");

        if (tvar == "obecný trojúhelník")
        {
            Console.WriteLine($"- Obsah: {hodnota1:F2}");
            Console.WriteLine($"- Obvod: {hodnota2:F2}");
        }
        else
        {
            Console.WriteLine($"- Obvod: {hodnota1:F2}");
            Console.WriteLine($"- Obsah/Objem: {hodnota2:F2}");
        }

        Console.WriteLine();
    }

    static double ZiskatKladneCislo()
    {
        double cislo;

        while (true)
        {
            string vstup = Console.ReadLine();

            if (double.TryParse(vstup, out cislo) && cislo > 0)
            {
                return cislo;
            }
            else
            {
                Console.Write("Neplatný vstup. Zadejte kladné číslo: ");
            }
        }
    }

    static bool JeTrojuhelnikPlatny(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}





