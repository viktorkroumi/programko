// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");
for (int i = 0; i < 21; i++)
{
    if (i % 5 == 0 && i % 3 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
   else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}



for (int d = 0; d < 20; d++)
{
    Console.WriteLine(d % 3);
    
}

Console.WriteLine("Zadej číslo");
string x = Console.ReadLine();
Console.WriteLine("Zadej druhé číslo");
string y = Console.ReadLine();
Console.WriteLine("Zadej operaci +,-");
string z = Console.ReadLine();

int a = int.Parse(x);
int b = int.Parse(y);

if (z == "+") Console.WriteLine(a + b);
if (z == "-") Console.WriteLine(a - b);
if (z == "*") Console.WriteLine(a * b);
if (z == "/") Console.WriteLine(a / b);