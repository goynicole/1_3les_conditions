using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*String login = "Nicole";
            String password = "Lexie";
            login = Console.ReadLine();// entrer l'identifiant
            password = Console.ReadLine(); // entrer le mot de passe
            if (login == "Nicole" && password == "Lexie") //si le login est bien "Nicole" et que le mot de passe est bien "Lexie"
            {
                Console.WriteLine("bienvenue à la manu le Havre.");
            }
            else
            {
                Console.WriteLine("Mauvais identifiant");
            }
            else if (passeword = false)
            {
                Console.WriteLine("Mauvais mot de passe");
            }
            Console.ReadKey();*/
            String login = "lbh", login2, mdp = "123", mdp2;

            Console.WriteLine("Login");
            login2 = Console.ReadLine();
            Console.WriteLine("Mdp");
            mdp2 = Console.ReadLine();
            //On compare le login entrer et le mot de passe | login.Equals(login2) est équivalent a '=='
            if (login.Equals(login2) && mdp.Equals(mdp2))
            {
                Console.WriteLine("Bienvenu à la manu, Amiens.");
            }
            else
            {
                Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
            }
            Console.ReadKey();
        }
    }
}
