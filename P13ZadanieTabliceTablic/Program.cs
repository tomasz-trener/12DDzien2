using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P13ZadanieTabliceTablic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            string dane = new WebClient().DownloadString(sciezka);

            string[] wiersze =
                dane.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            int liczbaWierszy = wiersze.Length;
            string[][] tab = new string[liczbaWierszy-1][];

            for (int i = 1; i < liczbaWierszy; i++)
                tab[i - 1] = wiersze[i].Split(';');

            // wyswietlenie 

            foreach (var w in tab)
                Console.WriteLine(string.Join(" ",w));


            string[][] tab2 = new string[3][]
            {
                new string[2],
                new string[2],
                new string[2],
            };


            Console.ReadKey();

        }
    }
}
