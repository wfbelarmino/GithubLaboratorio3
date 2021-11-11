using System;

namespace Lab3Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100] { 10, 20, 30, 40, 50 }; int i;
            for (i = 0; i < 100; i++)
            {
                Console.WriteLine("Indice = " + i + " & Valor = " + array[i]);
            }


        }
    }
}
