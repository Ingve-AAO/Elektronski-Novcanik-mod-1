using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTN__Zadatci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Unesite količinu novca koju imate u novčaniku:");
            double novacUNovcaniku = double.Parse(Console.ReadLine());


            if (novacUNovcaniku < 1000)
            {
                double faliNovca = 1000 - novacUNovcaniku;
                Console.WriteLine("Nemate dovoljno novca. Fali vam " + faliNovca + " dinara.");
            }
            else
            {
                double kusur = novacUNovcaniku - 1000;
                Console.WriteLine("Imate dovoljno novca. Kusur koji ćete dobiti je " + kusur + " dinara.");
            }
        }
    }

}
