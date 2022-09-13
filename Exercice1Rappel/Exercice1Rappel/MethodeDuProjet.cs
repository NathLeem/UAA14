using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice1Rappel
{
    public struct MethodeDuProjet
    {
        public double VerifDouble(string Request,out double Response)
        {
            string Req;
            do
            {
                Console.WriteLine(Request);
                Req = Console.ReadLine();
            } while (!double.TryParse(Req, out Response));
           
            return Response;
        }
    }
}