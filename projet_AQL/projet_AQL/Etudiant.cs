using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_AQL
{
    public class Etudiant
    {

        //Proprietes de la classe Etudiant

        public int Code {get ;set;}
        public string Nom {get; set;}
        public string Prenom {get; set;}

        //Constructeur 
        public Etudiant (int code , string nom, string prenom) {
            this.Code = code;
            this.Nom = nom;
            this.Prenom = prenom;
        }
        
    }
}
