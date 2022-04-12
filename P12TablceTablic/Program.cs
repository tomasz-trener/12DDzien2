using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12TablceTablic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tab = new string[3];
            string[,] tab2 = new string[3, 2];

            string[][] tablicaTablic = new string[3][];

            tablicaTablic[0] = new string[3];
            tablicaTablic[1] = new string[1];
            tablicaTablic[2] = new string[2];

            tablicaTablic[0][0] = "a";
            tablicaTablic[0][1] = "b";
            tablicaTablic[0][2] = "c";

            tablicaTablic[1][0] = "d";

            tablicaTablic[2][0] = "e";
            tablicaTablic[2][1] = "f";

            int dlugosc = tablicaTablic.Length; // 3 
            int szerokosc0 = tablicaTablic[0].Length;










        }
    }
}
