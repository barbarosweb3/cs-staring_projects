using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Class_NoReturnValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mesaj msj = new Mesaj();
            msj.metin();
            Console.Read();
        }
    }
}
