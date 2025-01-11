using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_With_ReturnValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            islem isl = new islem();
            isl.topla(7, 6);
          
            Console.WriteLine("\n\n\n");

            isl.kare(9);

            Console.WriteLine("\n\n\n");

            isl.toplam(5,8);
            Console.Read();
        }
    }
}
