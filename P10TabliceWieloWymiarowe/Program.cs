using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10TabliceWieloWymiarowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tablica = new string[3];

            string[,] tablica2 = new string[3, 2];

            string[,,] tablica3 = new string[3, 2, 4];

            int dlugoscTablicy = tablica2.Length; // (2*3=6)

            int dlugoscWym0 = tablica2.GetLength(0); //3
            int dlugoscWym1 = tablica2.GetLength(1); //2 

            tablica2[0, 0] = "a";
            tablica2[1, 0] = "b";
            tablica2[2, 0] = "c";

            tablica2[0, 1] = "d";
            tablica2[1, 1] = "e";
            tablica2[2, 1] = "f";

            for (int i = 0; i < dlugoscWym0; i++)
            {
                for (int j = 0; j < dlugoscWym1; j++)
                    Console.Write(tablica2[i, j]);
                Console.WriteLine();
            }


            Console.WriteLine("--------");

            for (int i = 0; i < dlugoscWym1; i++)
            {
                for (int j = 0; j < dlugoscWym0; j++)
                    Console.Write(tablica2[j,i]);
                Console.WriteLine();
            }

            Console.ReadKey();
            // 13:15



        }
    }
}
