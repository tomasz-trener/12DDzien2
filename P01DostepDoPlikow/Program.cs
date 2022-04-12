using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P01DostepDoPlikow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // File.ReadAllText("c:\\dane\\plik.txt");
            string dane= File.ReadAllText(@"c:\dane\plik.txt");

            Console.WriteLine(dane);

            string dane2= new WebClient().DownloadString("http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt");

            string strona = new WebClient().DownloadString("http://www.wp.pl");


            Console.WriteLine(dane2);

            Console.WriteLine(strona);

            Console.ReadKey();

        }
    }
}
