using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo5
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection fujita = new NameValueCollection();// création du tableau associatif
            fujita.Add("F0", "Dégâts légers");
            fujita.Add("F1", "Dégats modérés");
            fujita.Add("F2", "Dégats importants");
            fujita.Add("F3", "Dégats importans");
            fujita.Add("F4", "Dégats dévastateurs");
            fujita.Add("F5", "Dégats incroyables");

            Console.WriteLine("renseigner le type d'une tornade.");
            String F = Console.ReadLine();
            if (F == "F0")//recherche des dégats d'une tornade
            Console.WriteLine(fujita["F0"]);
            else if (F == "F1")
            {
                Console.WriteLine(fujita["F1"]);
            }
            else if (F == "F2")
            {
                Console.WriteLine(fujita["F2"]);
            }
            else if (F == "F3")
            {
                Console.WriteLine(fujita["F3"]);
            }
            else if (F == "F4")
            {
                Console.WriteLine(fujita["F4"]);
            }
            else if (F == "F5")
            {
                Console.WriteLine(fujita["F5"]);
            }
        }
    }
}
