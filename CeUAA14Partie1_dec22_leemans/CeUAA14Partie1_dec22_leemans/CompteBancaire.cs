using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeUAA14Partie1_dec22_leemans
{
    class CompteBancaire
    {
        private double _montant;
        private double _montant1;
        private string _numeroCompte;
        private double _nomProprio;
        string afficheCompte;

        public double AjoutNom()
        {
            return _nomProprio;
        }
        public string AjoutNumCompte()
        {
            return _numeroCompte;
        }
        public double AjoutMontant()
        {
            return _montant;
        }
        public double AjoutMontant1()
        {
            return _montant1;
        }

        public CompteBancaire(double nomPersonne, string numCompte, int montantInitiale, int montantInitCompte1)
        {
            _nomProprio = nomPersonne;
            _numeroCompte = numCompte;
            _montant = montantInitiale;
            _montant1 = montantInitCompte1;
        }

        public string AffichageCompte()
        {
            
            if (_nomProprio == 1)
            {
                afficheCompte = "le compte numéro " + _numeroCompte + " au nom de la personne " + _nomProprio + " a un montant de " + _montant1;
            }
            else
            {
                afficheCompte = "le compte numéro " + _numeroCompte + " au nom de la personne " + _nomProprio + " a un montant de " + _montant;
            }
            return afficheCompte;
        }
        public double VersementCompte1()
        {
            for (int i = 0; i < 9; i++)
            {
                this._montant1 = this._montant1 - this._nomProprio * 100;
            }
            return _montant1;
        }
        public double VersementInitiale()
        {
            for (int i = 1; i < 10; i++)
            {
                this._nomProprio++;
                this._montant = this._montant + this._nomProprio * 100;
            }
            return _montant;
        }
    }
}
