using System;

namespace I1P622_LeemansNathan
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodeDuProjet MesOutils = new MethodeDuProjet();
            string idCoul = "1900";
            string idCligno = "011";
            int couleur = 0;
            bool onOff = true;
            Random rnd = new Random();
            string ResultCoul = "";
            string ResultStatut = "";
            int i = 0;
            int j = 0;

            Console.WriteLine("Etats de tout les feux");
            MesOutils.ChangerCouleur(couleur, idCoul, rnd, out ResultCoul);
            Console.WriteLine($"Le feu de signalisation {idCligno}  est {ResultCoul}");
            MesOutils.ChangerCouleur(couleur, idCoul, rnd, out ResultCoul);
            Console.WriteLine($"Le feu de signalisation {idCoul}  est {ResultCoul}");

            Console.WriteLine("Changement des couleurs");
            Console.WriteLine("-----------------------");
            while (i != 5)
            {
                MesOutils.ChangerCouleur(couleur, idCoul, rnd, out ResultCoul);
                Console.WriteLine($"Le feu de signalisation {idCoul}  est {ResultCoul}");
                i++;
            }

            Console.WriteLine("Feu clignotant");
            Console.WriteLine("--------------");
            while (j != 10)
            {
                MesOutils.StatutOnOff(onOff,out ResultStatut);
                Console.WriteLine($"{idCligno} est {ResultStatut}");
                j++;
            }
        }
    }
}
