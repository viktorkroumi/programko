// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int x;
x = 2;

int y = 3;



double procento = 0.42;

// Vypiš proměnné

/*
 * Ahoj,
 * jak se máš?
 */

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(procento);







string name = "Viktor";

Console.WriteLine("hello, " + name);

int number1 = 42;
int number2 = 24;

Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);


int result = number1 + number2;
Console.WriteLine($"result = {result}");



double number3 = 42;
double number4 = 24;

Console.WriteLine("{0} / {1} = {2}", number3, number4, number3 / number4);

double result2 = number3 / number4;
int result2Int = (int)result2;
Console.WriteLine(result2Int);
double result2Double = result2Int;


bool bool1 = true;
bool bool2 = false;

Console.WriteLine("{0} && {1} = {2}", bool1, bool2, bool1 && bool2);
Console.WriteLine("{0} || {1} = {2}", bool1, bool2, bool1 || bool2);



int cislo = 7;
Console.WriteLine("{0} == 5 -> {1}", cislo, cislo == 5);
bool isCisloSeven = cislo == 7;
Console.WriteLine(isCisloSeven);


Console.WriteLine("What´s your name?");
string jmeno = Console.ReadLine();
Console.WriteLine($"Hello, {jmeno}");


Console.WriteLine("Číslo uživatele?");
string cislouz = Console.ReadLine();
int cisloproc;
bool succes = int.TryParse(cislouz, out cisloproc);
Console.WriteLine($"succes = {succes}");
Console.WriteLine(cisloproc + 3);


