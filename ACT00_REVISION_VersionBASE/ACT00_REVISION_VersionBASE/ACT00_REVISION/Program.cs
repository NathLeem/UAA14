using System;

namespace ACT00_REVISION
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration des variables.... COMPLETER AVEC CE QUI MANQUE

            string rep;
            string methode = "";
            string infos = "";

            int numeroCote = 1;
            double c1 = 0;
            double c2 = 0;
            double c3 = 0;
            bool ok = false;
            MethodesDuProjet MesOutils = new MethodesDuProjet();
            // ...... COMPLETER

            Console.WriteLine("Testez les polygones !");
            //On recommence tant que désiré
            do
            {
                //lecture des 3 côtés
                c1 = lireDouble(numeroCote);
                c2 = lireDouble(numeroCote);
                c3 = lireDouble(numeroCote);



                // ordonner les côtés => APPEL ORDONNECOTES
                MesOutils.OrdonneCotes(ref c1, ref c2, ref c3);
                // série de test (voir consignes)
                ok = MesOutils.Triangle(c1, c2, c3);
                if (ok == true)
                {
                    // préparation et affichage du résultat du test 'triangle' avec la procédure 'Affiche'
                    
                    methode = "triangle";
                    MesOutils.Affiche(out infos, ok, methode);
                    Console.WriteLine(infos);


                    // vérification équilatéral
                    ok = MesOutils.Equi(c1,c1,c3);
                    if (ok == true)
                    {
                        // préparation et affichage du résultat du test 'equilateral' avec la procédure 'Affiche'
                        methode = "equilateral";
                        MesOutils.Affiche(out infos, ok, methode);
                        Console.WriteLine(infos);
                    }
                    else
                    {
                        // vérification triangle rectangle
                        ok = MesOutils.TriangleRectangle(c1, c1, c3);
                        if (ok == true)
                        {
                            // préparation et affichage du résultat positif du test 'rectangle' avec la procédure 'Affiche'
                            methode = "rectangle";
                            MesOutils.Affiche(out infos, ok, methode);
                            Console.WriteLine(infos);
                        }
                        else
                        {
                            // préparation et affichage du résultat négatif du test 'rectangle' avec la procédure 'Affiche'
                            // ...
                            // ...
                            methode = "rectangle";
                            MesOutils.Affiche(out infos, ok, methode);
                            Console.WriteLine(infos);
                        }
                        // vérification du cas isocèle et affichage dans le cas positif
                        ok = MesOutils.Isocele(c1, c1, c3);
                        if (ok == true)
                        {
                        methode = "isocele";
                        MesOutils.Affiche(out infos, ok, methode);
                        Console.WriteLine(infos);
                        }
                    }
                }
                else // si ce n'est pas un triangle
                {
                    // préparation et affichage du résultat négataif du test 'triangle' avec la procédure 'Affiche'
                    // ...
                    // ...
                    methode = "triangle";
                    MesOutils.Affiche(out infos, ok, methode);
                    Console.WriteLine(infos);
                }
                // reprise ?
                Console.WriteLine("Voulez-vous tester un autre polygône ? (Tapez espace)");
                rep = Console.ReadLine();
            } while (rep == " ");
        }
        //Récupération d'une donnée fournie par l'utilisateur en 'double' : on suppose qu'il ne se trompe pas !
        static double lireDouble(int numeroCote)
        {
            double cote;
            Console.Write("Tapez la valeur du côté " + numeroCote + " : ");
            cote = double.Parse(Console.ReadLine());
            return cote;
        }
    }
}
