using Console_With_NoReturnValue_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_With_NoReturnValue_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisiler ks = new Kisiler();
            string ads, ys, mslk;
            Console.Write("İsim girin: ");
            ads = Console.ReadLine();
            Console.Write("Yaş girin: ");
            ys = Console.ReadLine();
            Console.Write("Meslek girin: ");
            mslk = Console.ReadLine();
            ks.kisilistesi(ads, Convert.ToInt16(ys), mslk);
            Console.Read();
        }
    }
}
