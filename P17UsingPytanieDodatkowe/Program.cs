using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17UsingPytanieDodatkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {

          //  StreamReader sr = new StreamReader(@"c:\dane\plik.txt");
          //  string s= sr.ReadToEnd();




            // duuuzo kodu 
            using(StreamReader sr = new StreamReader(@"c:\dane\plik.txt"))
            {
                string s = sr.ReadToEnd();
            }

            // duuuzo kodu 




        }
    }
}
