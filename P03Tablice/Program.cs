using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string miasto1;
            string miasto2;
            string miasto3;
            string miasto4;
            string miasto5;

            string[] tablicaMiast = new string[5];


            tablicaMiast[0] = "warszawa";
            tablicaMiast[1] = "krakow";
            tablicaMiast[2] = "gdańsk";
            // w tablicaMiast[3] w tym momencie siedzi domyślna wartośc dla stringa 
            tablicaMiast[4] = "łódź";

            for (int i = 0; i < tablicaMiast.Length; i++)
                Console.WriteLine(tablicaMiast[i]);


            bool[] tablicaWartosciLogicznych = new bool[3];
            tablicaWartosciLogicznych[0] = false;

            int?[] tabliczLiczb = new int?[2];

            char[] tablicaZnakow = new char[2];
            tablicaZnakow[0] = '\0';

            Console.ReadKey();


        }
    }
}
