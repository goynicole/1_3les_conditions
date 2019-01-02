using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rainy = true;//le bloque de if n'est executer que si l'on a rainy = true
            if (rainy)
            {
                Console.WriteLine("Bonjour, il ne pleut pas aujourd'hui, bonne journée.");
            }
            else//le else est appelé si le if n'est pas executé
            {
                Console.WriteLine("Bonjour, il pleut aujourd'hui, vous devriez prendre votre parapluie.");
            }
            Console.ReadKey();
        }
    }
}
