using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int.TryParse(Console.ReadLine(), out age);// pour faire la conversion 
            if (age < 18 && age > 0)//on verifie que l'age renseigner est conpris entre 0 et 17
            {
                Console.WriteLine("Vous êtes mineur");
            }
            else if (age > 18)
            {
                Console.WriteLine("Vous êtes majeur");
            }
            else //on gère le cas ou la saisi est incorrect 
            {
                Console.WriteLine("Vous êtes un robot");
            }
        }
    }
}
