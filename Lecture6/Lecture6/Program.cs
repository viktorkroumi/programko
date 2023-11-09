
//void PrintArray(int[] cisla)
//{
//    for (int i = 0; i < cisla.Length; i++)
//    {
//        Console.WriteLine(cisla[i]);
//    }


//}

//int[] numbers = { 1, 2, 3, 4 };
//PrintArray(numbers);

//int[] numbers2 = numbers;
//PrintArray(numbers);
//PrintArray(numbers2);

//numbers[0] = 6;
//PrintArray(numbers);
//PrintArray(numbers2);



int[] coefficients = new int[] { 6, 4, 48, -4, 4, -1 };

void PrintPolynomial(int[] coefficients)
{
    for (int i = 0; i < coefficients.Length; i++)
    {
        Console.Write(coefficients[i]);
        Console.Write("x^");
        Console.Write(coefficients.Length - i -1);
        Console.Write("+");
       
    }
}
PrintPolynomial(coefficients);