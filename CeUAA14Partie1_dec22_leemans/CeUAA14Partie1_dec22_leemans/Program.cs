using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeUAA14Partie1_dec22_leemans
{
    class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire compte1 = new CompteBancaire(1, "BE43350006467801", 0, 20000);
            CompteBancaire compte2 = new CompteBancaire(2, "BE43350006467811", 200, 0);
            CompteBancaire compte3 = new CompteBancaire(3, "BE43350006467821", 200, 0);
            CompteBancaire compte4 = new CompteBancaire(4, "BE43350006467831", 200, 0);
            CompteBancaire compte5 = new CompteBancaire(5, "BE43350006467841", 200, 0);
            CompteBancaire compte6 = new CompteBancaire(6, "BE43350006467851", 200, 0);
            CompteBancaire compte7 = new CompteBancaire(7, "BE43350006467861", 200, 0);
            CompteBancaire compte8 = new CompteBancaire(8, "BE43350006467871", 200, 0);
            CompteBancaire compte9 = new CompteBancaire(9, "BE43350006467881", 200, 0);
            CompteBancaire compte10 = new CompteBancaire(10, "BE43350006467891", 200, 0);

            Console.WriteLine("\nBanque");
            Console.WriteLine("\nAffichage de tout les comptes\n");
            Console.WriteLine(compte1.AffichageCompte());
            Console.WriteLine(compte2.AffichageCompte());
            Console.WriteLine(compte3.AffichageCompte());
            Console.WriteLine(compte4.AffichageCompte());
            Console.WriteLine(compte5.AffichageCompte());
            Console.WriteLine(compte6.AffichageCompte());
            Console.WriteLine(compte7.AffichageCompte());
            Console.WriteLine(compte8.AffichageCompte());
            Console.WriteLine(compte9.AffichageCompte());
            Console.WriteLine(compte10.AffichageCompte());

            Console.WriteLine(compte1.VersementCompte1());
            Console.WriteLine(compte2.VersementInitiale());
            Console.WriteLine(compte3.VersementInitiale());
            Console.WriteLine(compte4.VersementInitiale());
            Console.WriteLine(compte5.VersementInitiale());
            Console.WriteLine(compte6.VersementInitiale());
            Console.WriteLine(compte7.VersementInitiale());
            Console.WriteLine(compte8.VersementInitiale());
            Console.WriteLine(compte9.VersementInitiale());
            Console.WriteLine(compte10.VersementInitiale());

            Console.ReadLine();
        }
    }
}
