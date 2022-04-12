using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadaniePogoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string url = "https://www.google.com/search?q=pogoda";
            const char znak = '°';
            const char znakKoncowy = '>';

            // pobranie zawartosci strony z dynmanicznie generowanym adresem url

            while (true)
            {
                Console.WriteLine("Podaj miasto");
                string miasto = Console.ReadLine();

                string dane =
                     new WebClient().DownloadString($"{url} {miasto}");


                int indx = dane.IndexOf(znak);
                if (indx == -1)
                {
                    Console.WriteLine("Nieznane miasto");
                    continue;
                }

                int aktualnaPozycja = indx - 1;
                while (dane[aktualnaPozycja] != znakKoncowy)
                    aktualnaPozycja--;

                int dlugosc = indx - aktualnaPozycja;
                if (dlugosc > 4)
                {
                    Console.WriteLine("Nieznane miasto");
                    continue;
                }

                string wynik = dane.Substring(aktualnaPozycja + 1, indx - aktualnaPozycja + 1);
                Console.WriteLine(wynik);
            }





            string s = "ala ma kota";
            string s2 = s.Substring(4, 2); // tutaj zraca string 
            char znak2 = s[4]; // tutaj zwraca znak

            //  Console.WriteLine(dane);
            //File.WriteAllText(@"c:\dane\pogoda.html", dane);

            // procesing zawarotsci w poszukiwaniu temperatury 

            // wywsietlenei temperatury 


            Console.ReadKey();
        }
    }
}
