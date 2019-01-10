using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Sort(int[] tablica)
        {
            int n = tablica.Length;
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (tablica[i] > tablica[i + 1])
                    {
                        int tmp = tablica[i];
                        tablica[i] = tablica[i + 1];
                        tablica[i + 1] = tmp;
                    }
                }
                n--;
            }
            while (n > 1);
        }
        static void Main(string[] args)
        {
            int[] x = { 2, 5, 1, 3, 4, };

            Console.WriteLine(" Przed sortowaniem");
            for (int z = 0; z < x.Length; z++)
            {
                Console.Write(x[z] + ", ");
            }
Sort(x);
            Console.WriteLine("\n Po sortowaniu");
            for (int z = 0; z < x.Length; z++)
            {
                Console.Write(x[z] + ", ");
            }

            Console.ReadKey();
        }
    }
}