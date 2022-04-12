using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09ZadanieListy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POdaj zdanie");
            string zdanie = Console.ReadLine();

            string[] tab = zdanie.Split(' ');

            List<string> znalezione = new List<string>();

            for (int i = 0; i < tab.Length; i++)
                if (tab[i].Contains("a"))
                    znalezione.Add(tab[i]);

            string wynik = string.Join(" ", znalezione);
            Console.WriteLine(wynik);

            Console.ReadKey();

            // kiedy korzystać z tablic 
            // 1) tablice są szybsze 
            // 2) keidy chcemy dać do zrozumienia, ze nasza kolekcja ma określoną, niezmienną liczebność 

        }
    }
}
