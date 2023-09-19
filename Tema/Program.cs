// CURS 3 
Ex: Sa se scrie un program citind de la tastatura un numar intreg n si un numar intreg k va afisa aranjamente si combinari 

using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int k = int.Parse(Console.ReadLine());

        Arajamente(n, k);

    }
    static int Factorial(int number)
    {
        int fact = 1;

        for (int i = 1; i <= number; i++)
        {
            fact = fact * i;
        }
        return fact;
    }
    static void Arajamente(int n, int k)
    {
        int dif = n - k;

        int araj = 0;
        if (n >= k)
        {

            int numitor = Factorial(dif);

            araj = Factorial(n) / numitor;
        }
        Console.WriteLine(araj);
    }

}

combinari 

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        Combinatorie(n, k);
    }
    static int Factorial(int num)
    {
        int fact = 1;

        for (int i = 1; i < num; i++)
        {
            fact = fact * i;
        }
        return fact;
    }
    static void Combinatorie(int n, int k)
    {
        int comb = 0;
        int dif = n - k;


        if (n >= k)
        {
            comb = Factorial(n) / Factorial(k) * Factorial(dif);
        }
        Console.WriteLine($"Combinari de {n} luate cate {k} = {comb} ");
    }
}

