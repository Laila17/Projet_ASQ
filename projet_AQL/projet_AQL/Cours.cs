using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_AQL
{
    public class Cours
    {
        //Prorietes de la classe Cours
        public int NumeroCours { get; set; }
        public int Code { get; set; }
        public string Titre { get; set; }

        //Constructeur 
        public Cours(int numero, int code, string titre)
        {
            this.NumeroCours = numero;
            this.Code = code;
            this.Titre = titre;
        }

    }
}
