using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Console_With_ReturnValue
{
    internal class islem
    {
        public int topla(int s1, int s2) 
        {
            int s3 = s1 + s2;
            Console.Write("Sonuc: " + s3);
            return s3;
        }

        public int kare(int deger)
        {
            int sonuc = deger * deger;
            Console.WriteLine("Sonuç: " + sonuc);
            return sonuc;
        }

        public int toplam(int num1, int num2)
        {
            Console.Write("Bir sayı giriniz: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = num1 + num2;
            Console.WriteLine("Sonuc: " + num3);
            return num3;
            
        }
    }
}
