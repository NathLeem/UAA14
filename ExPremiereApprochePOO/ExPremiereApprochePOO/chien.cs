using System;
using System.Collections.Generic;
using System.Text;

namespace ExPremiereApprochePOO
{
    class chien
    {
        private string _nom;
        private uint _age;
        private string _race;

        public chien(string _nom, uint _age, string _race)
        { 
            this._nom = _nom;
            this._age = _age;
            this._race = _race;
        }
        public string AfficheCaracteristiques()
        {
            string phrase = "Nom: " + this._nom + " Age: " + this._age + " Race: " + this._race;
            return phrase;
        }
    }
}
