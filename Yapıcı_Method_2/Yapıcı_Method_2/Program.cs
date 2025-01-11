using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yapıcı_Method_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kimlik kml = new Kimlik();
            kml.AD = "Murat";
            kml.SOYAD = "Yücedağ";
            kml.MEMLEKET = "Elazığ";
            kml.YAS = 36;
            kml.CİNSİYET = 'E';
            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CİNSİYET);
            Console.Read();
        }
    }
}
