using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06TabliceIStringi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zamiana napisów tablice 

            string napis = "ala ma kota";

            string[] tablica=  napis.Split(' ');

            // otrzymamy tablice 3 -elementową

            string napis2 = "ala!*ma!*kota&&i&&ma#psa";
            // string[] tablica2= napis2.Split('!', '*');

            string[] separatory = { "!*", "&&", "#" };

             string[] tablica2 =napis2.Split(separatory, StringSplitOptions.RemoveEmptyEntries);

            // zamiana tablict na napis 
            string s = "";
            foreach (var x in tablica2)
                s+= x + " ";
            //  s = s+ x + " ";

            // zeby tego nie robic przy pomocy petli

            string s2 = string.Join(" ", tablica2);
            Console.WriteLine(s2);

            Console.ReadKey();


        }
    }
}
