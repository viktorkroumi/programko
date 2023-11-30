//float[] ScaleVector(float[] vector, float nasobek)
//{
//    float[] newvector = new float[] { vector.Length };

//    for (int i = 0; i < vector.Length; i++)
//    {
//        newvector[i] = vector[i] * nasobek;
//    }

//    return newvector;
//}

//float[] myvector = new float[2];
//myvector[0] = 1;
//myvector[1] = 1;
//float scalar = 2;
//float[] vysledek = ScaleVector(myvector, scalar);

//for (int i = 0; i < vysledek.Length; i++)
//{
//    Console.WriteLine(vysledek[i]);
//}


//float[] AddVector(float[] vector, float nasobek)
//{
//    float[] newvector = new float[] { vector.Length };

//    for (int i = 0; i < vector.Length; i++)
//    {
//        newvector[i] = vector[i] * nasobek;
//    }

//    return newvector;
//}

string text = "ahsadadhhsaaaahdajdaaa";

string replace(string text, string a, string b)
{
    char[] chars = text.ToCharArray();
    char[] A = a.ToCharArray();
    char[] B = b.ToCharArray();
    for ( int i = 0; i < chars.Length; i++ )
    {
        if (chars[i] == A[0])
        {
            chars[i] = B[0];
        }
    } 
    string newt = new string(chars);
    return newt;
}

Console.WriteLine("Co chces nahradit?");
string a = Console.ReadLine();

Console.WriteLine("Cim chces nahradit?");
string b = Console.ReadLine();

string newtext = replace(text,a,b);
Console.WriteLine(newtext);