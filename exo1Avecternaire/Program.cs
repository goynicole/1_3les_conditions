using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo1AvecTerreMer
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Rainy = true;
            String message = Rainy ? "Slt, prend ton parapluie" : "Bonjour, il ne pleut pas aujourd'hui";
                //langague ternaire exemple "=" =if, ":"=else
                Console.WriteLine(message);

            Console.ReadKey();
        }
    }
}
