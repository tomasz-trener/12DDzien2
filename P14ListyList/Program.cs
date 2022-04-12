using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14ListyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // nie ma list wielowymiarowych 

            List<List<string>> listaList = new List<List<string>>();

            // teraz wszystkie elementy tej listy to null

            listaList.Add(new List<string>());
            listaList[0].Add("ala");
            listaList[0].Add("ma");
            listaList[0].Add("kota");

            List<string> lista = new List<string>();
            lista.Add("xx");
            listaList.Add(lista);



            // mozna np. zrobic liste tablic 

            List<string[]> listaTablic = new List<string[]>();

            listaTablic.Add(new string[2] { "a", "b" });
            listaTablic.Add(new string[2] { "c", "d" });


        }
    }
}
