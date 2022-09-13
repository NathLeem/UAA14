using System;

namespace Exercice1Rappel
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodeDuProjet MesOutils = new MethodeDuProjet();
            string Request = "Quel âge as-tu ?";
            double Response;

            MesOutils.VerifDouble(Request,out Response);
            Console.WriteLine($"Résultat: {Response}");
        }
    }
}