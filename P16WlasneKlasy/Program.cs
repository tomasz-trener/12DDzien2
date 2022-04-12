using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16WlasneKlasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // np. kalkulator 
            // 1 klasa 1 plik 

            StringBuilder sb = new StringBuilder();

            Kalkulator k = new Kalkulator();
            // tworzymy nowa zmienna o nazwie k i od razu 
            // pzrypisuje do tej zmiennej nowo utworzony
            // obiekt (nową instancję klasy) 
            // zmienna k wskazuje na ten obiekt i moge sobie na nim pracowac 


            Kalkulator k2; // deklaracja zmiennej o nazwie k2
            // ktora na nic nie wskazuje 
            // nie moge pracowac na kalkulatorze bo go nie mam 

            // w przyszlosci moge do tej zmiennej przypisac jakis obiekt 
            k2 = new Kalkulator();




            new Kalkulator(); //w pamieci komputera tworzy nowy obiekt 
            // ale nie mam do niego uchwytu 
            // czyli ten obiekt lata sobie w pamieci gdzies 
            // zabaradzo nie ma sie jak do niego odwolac 
            // nie ma mozliowsci pracowac na tym obiekcie 

            // garbage collector 





        }
    }
}
