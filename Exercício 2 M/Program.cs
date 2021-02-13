using System;

namespace Exercício_2_M
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a;

            int n = int.Parse(Console.ReadLine());

            a = new int[n, n];

            int soma = 0;

            for (int l = 0; l < n; l++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                for (int c = 0; c < n; c++)
                {
                    a[l, c] = int.Parse(vetor[c]);
                }
            }

            Console.WriteLine();
            for (int l = 0; l < n; l++)
            {

                for (int c = 0; c < n; c++)
                {
                    soma = soma + a[l, c];
                }

                Console.WriteLine(soma);
                soma = 0;

            }
        }
    }
}
