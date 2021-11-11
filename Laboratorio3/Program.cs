using System;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 10, 20, 30, 40, 50 }; int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Indice = " + i + " & Valor = " + array[i]);
            }
            string[] str = new string[3]; int iStr;
            str[0] = "Um";
            str[1] = "Dois";
            str[2] = "Tres";
            foreach (iStr = 0; iStr < 3; iStr++)
            {
                Console.WriteLine("Indice = " + iStr + " & Valor = " + str[iStr]);
            }

            DateTime[] dt = new DateTime[2]; int iDate;
            dt[0] = new DateTime(2002, 5, 1);
            dt[1] = new DateTime(2002, 6, 1); for (iDate = 0; iDate < 2; iDate++)
            {
                Console.WriteLine("Indice = " + iDate + " & Data = " + dt[iDate].ToShortDateString());
            }

        }
    }
}
