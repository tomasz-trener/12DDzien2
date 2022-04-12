using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08Listy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tablica = new string[4]; // to tablica nie pusta, której długosć wynosi 4 

            List<string> lista = new List<string>(); // to jest lista pusta, której długość wynosi 0

            List<string> lista2 ; // to jest lista pusta (null) a tak naprawdę to zmienna, która wskazuje na null

            // na liscie 2 nie moge pracowac bo to tak naprawde nie jset lista tylko zmienna, ktora na nic nie wskazuje
            // nie moge do tej listy dodac zandego elementu 

            string[] tablica2; // na tej tablciy nie moge pracowac (bo to zmienna, która wskazuje na null)

            lista.Add("ala");
            lista.Add("ma");
            lista.Add("kota");

            // w tym momencie lista ma 3 elementy 

            string s = lista[1]; // tak samo jak w tablicach 

            int dlugoscTablicy = tablica.Length; // to właściwości a właściwości mówią nam jakie to jest 
            int dlugoscListy = lista.Count(); // troszke inaczej niz w tablicach . W lista dlugosc jest dynamiczna wiec trzeba prosic o zliczenie tych elementow 

            lista.Insert(0, "mała"); // wstaw na dowolną pozycję 

            lista.Remove("ma");// usuwa pierwsze znalezione ma 
            lista.RemoveAt(0); // usuwa dowolny element na podanej pozycji 


        }
    }
}
