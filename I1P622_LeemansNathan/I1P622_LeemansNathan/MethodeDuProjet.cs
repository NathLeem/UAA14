using System;
using System.Collections.Generic;
using System.Text;

namespace I1P622_LeemansNathan
{
    public struct MethodeDuProjet
    {
        public void ChangerCouleur(int couleur, string identifiant, Random rnd, out string ResultCoul)
        {
            ResultCoul = "";
            for (int i = 0; i < 4; i++)
            {
                couleur = rnd.Next(3);
            }
            if (couleur == 0)
            {
                ResultCoul = "Orange";
            }
            else if (couleur == 1)
            {
                ResultCoul = "Rouge";
            }
            else if (couleur == 2)
            {
                ResultCoul = "Vert";
            }
        }

        public void StatutOnOff(bool onOff,out string ResultStatut)
        {
            ResultStatut = "";
            for (int i = 0; i < 10; i++)
            {
                if (onOff == true)
                {
                    ResultStatut = "éteint";
                    onOff = false;
                }
                else
                {
                    ResultStatut = "allumé";
                    onOff = true;
                }
            }
        }
    }
}
