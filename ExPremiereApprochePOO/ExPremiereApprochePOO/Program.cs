using System;

namespace ExPremiereApprochePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            chien[] mesChiens = new chien[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Quel est le nom de votre chien ?");
                string nomChien = Console.ReadLine();
                Console.WriteLine("Quel est l'âge de votre chien ?");
                uint ageChien = uint.Parse(Console.ReadLine());
                Console.WriteLine("Quel est la race de votre chien ?");
                string raceChien = Console.ReadLine();

                mesChiens[i] = new chien(nomChien, ageChien, raceChien);
                Console.WriteLine(mesChiens[i].AfficheCaracteristiques());
            }
        }
    }
}
