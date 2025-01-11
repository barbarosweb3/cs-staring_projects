using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yapıcı_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, yas, meslek;
            Console.Write("Ad: ");
            ad = Console.ReadLine();
            Console.Write("Soyad: ");
            soyad = Console.ReadLine();
            Console.Write("Yaş: ");
            yas = Console.ReadLine();
            Console.Write("Meslek: ");
            meslek = Console.ReadLine();
            //Ogrenci ogr = new Ogrenci(blg);
            Ogrenci ogr = new Ogrenci(ad, soyad, Convert.ToInt16(yas), meslek);
            Console.Read();
        }
    }
}
