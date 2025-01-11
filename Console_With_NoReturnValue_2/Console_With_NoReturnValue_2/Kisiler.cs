using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_With_NoReturnValue_2
{
    internal class Kisiler
    {
        public void kisilistesi(string adsoyad, int yas, string meslek)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(adsoyad);
                Console.WriteLine(yas);
                Console.WriteLine(meslek);
            }
        }
    }
}
