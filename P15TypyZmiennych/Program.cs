using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P15TypyZmiennych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a     = 7;
            char b    = 'x';
            string c  = "napis"; // to klasa, któa wyglada jak struktura 
            double d  = 8.645;
            bool e    = false;

            string f = "21-01-2022";
            
            DateTime dt      = new DateTime(2022, 1, 22); // to przyklad struktury , ktora wyglada jak klasa 
            WebClient wc     = new WebClient();
            StringBuilder sb = new StringBuilder();
            sb.Append("ala");
            sb.Append(" ma");
            sb.Append(" kota");

            int a2 = a; // nastepuje kopia wartosci 7 do a2
            StringBuilder sb2 = sb; // przekazujemy tylko referencje 
            a2 = 8;
            DateTime dt2 = dt;// pomimo tego, ze wyglada jak klasa to przekazuje kopie 

            string c2 = c; // pomimo tego, ze to klasa to tutaj przekaznaa jest kopia 
            // typy referencjyne (ang. reference types) i typy wartościowe (ang. value types)

            // zasady: 
            // zazwyczaj wszystkie klasy sa typami referencyjnymi (wyjatek to string, ktory przekazuje sie przez kopie)
            // a struktury to typy wartosciowe , wszystkie struktury przekazywane sa przez kopie  


            string[] tab = new string[3] {"a","b","c"};
            string[] tab2 = tab;
            tab2[0] = "x";

            //https://github.com/tomasz-trener/12DDzien1
            //https://github.com/tomasz-trener/12DDzien2

            //http://pl.spoj.com/problems/
            //https://www.codewars.com/ 
        }
    }
}
