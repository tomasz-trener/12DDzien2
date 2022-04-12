using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07ZadanieNapisy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zdanie");
            string zdanie = Console.ReadLine();

            string[] wyrazy = zdanie.Split(' ');

            int indeksNajdluzszego = 0;
            int najdluzszaDlugosc = wyrazy[indeksNajdluzszego].Length;

            for (int i = 0; i < wyrazy.Length; i++)
            {
                if (wyrazy[i].Length > najdluzszaDlugosc)
                {
                    najdluzszaDlugosc = wyrazy[i].Length;
                    indeksNajdluzszego = i;
                }
            }

            // teraz wiemy , że pod indexNAjdlzuszego kryje sie najduższy wyraz 

            string najdluzszyWyraz = wyrazy[indeksNajdluzszego];

            string[] najdlusze = new string[wyrazy.Length];

            int k = 0;
            foreach (var s in wyrazy)
                if (s.Length == najdluzszyWyraz.Length)
                    najdlusze[k++] = s;

            string wynik = "Znalezione najdluzsze wyrazy to: " + string.Join(" ,", najdlusze);
            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
}
