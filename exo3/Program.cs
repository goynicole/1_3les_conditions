using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            String sexe;
            Console.WriteLine("Quel est votre age?");
            
            int.TryParse(Console.ReadLine(), out age); // entrer l'age
            Console.WriteLine("Votre sexe: homme ou femme?");
            sexe = Console.ReadLine(); // entrer le sexe
            if (age >= 18 && sexe == "femme")
            {
                Console.WriteLine("Vous êtes majeur et vous êtes une femme");
            }
            else if(age >= 18 && sexe == "homme")
            {
                Console.WriteLine("Vous êtes majeur et vous êtes un homme");
            }
            else if (age > 0 && sexe == "femme")
            {
                Console.WriteLine("Vous êtes une femme et vous êtes mineur");
            }
                
            else if (age > 0 && sexe == "homme")
            {
                Console.WriteLine("Vous êtes un homme et vous êtes mineur");
            }
            else
            {
                Console.WriteLine("Erreur");
            }
             
        }
    }
}
