using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public class Etudiant
    {
        public int NumeroEtudiant { get; set; }
        public string Nom {get; set; }
        public string Prenom { get; set; }
        public List<Cours> listeDeCours { get; set; }
      

        //Constructeur
        public Etudiant(int numeroEtudiant, string nom, string prenom) {
            this.NumeroEtudiant = numeroEtudiant;
            this.Nom = nom;
            this.Prenom = prenom;
            this.listeDeCours = new List<Cours>();
        }

        //Méthode ajouterCours()
        public void ajouterCours(Cours cours) {
            this.listeDeCours.Add(cours);
        }

        public void ajouterCoursAuListView(ListView listView) {
            ListViewItem item;
           
            foreach (Cours cours in listeDeCours) {
                item = new ListViewItem(new String[] { cours.NumeroCours.ToString(), cours.CodeCours.ToString(), cours.TitreCours.ToString() });
                listView.Items.Add(item);
            }
        }


    }
}
