using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieTablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zacznij podawać imiona, zakończ pisząc 'koniec'");

          //  Console.WriteLine("Najpierw podaj ile imion chcesz przechowyhwac");
          //  int ile = Convert.ToInt32(Console.ReadLine());

            string[] imona = new string[50];

            int i = 0;

            do
            {
                string wczytaneImie = Console.ReadLine();
                if (wczytaneImie.ToLower() != "koniec")
                {
                    imona[i] = wczytaneImie;
                    i++;
                }
                else
                    break;
            } while (true);

            // wersja1 
            //for (int j = 0; j < imona.Length; j++)
            //    if (imona[j] != null)
            //        Console.WriteLine(String.Format("{0} ({1})", imona[j], imona[j].Length);
            //    else
            //        break;

            // wersja 2 gdy iterujemy po wzsytkich elemntach 
            foreach (var s in imona)
                if (s != null)
                    Console.WriteLine(String.Format("{0} ({1})", s, s.Length));
                else
                    break;
            

            //var tablica = new string[4];
           // int a = 5;
           // var b = 5;
           // var auotmatycznie znajduje jaki typ jest po prawej stronie od = 
        }
    }
}
