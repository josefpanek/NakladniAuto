using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakladniAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ukony ukony = new Ukony();

            ukony.Naloz(1000);
            ukony.Naloz(500);
            ukony.Vyloz(300);
            ukony.Vyloz(1000);
            ukony.VypisNalozeni();

            Console.ReadKey();
        }
    }
}
