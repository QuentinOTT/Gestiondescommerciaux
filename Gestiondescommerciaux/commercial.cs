using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiondescommerciaux
{
    internal class commercial
    {
        private int id;
        private string nom;
        private string prenom;
        private int categorie;
        private int puissance;
        private List<note> lesNotes = new List<note>();
        private servicecommercial leService;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public int Categorie { get => categorie; set => categorie = value; }
        public int Puissance { get => puissance; set => puissance = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public List<note> LesNotes { get => lesNotes; set => lesNotes = value; }
        internal servicecommercial LeService { get => leService; set => leService = value; }

        public commercial(int pid, string pnom, string pprenom, int pcategorie, int ppuissance)
        {
            this.id = pid;
            this.nom = pnom;
            this.Prenom = pprenom;
            this.puissance = ppuissance;
            this.categorie = pcategorie;
        }

        public void ajouterNoteFrais(note f)
        {
            LesNotes.Add(f);
        }

        public override string ToString()
        {
            string msg = "id" + id + "nom" + nom + "prenom" + prenom + "puissance" + puissance + "categorie" + categorie + "Note de frais: ";
            foreach(note note in LesNotes)
            {
                msg += note.ToString();
            }
            return msg;

        }

        public double CumulNotesRembourseesParAnnee(int annee)
        {
            double somme = 0;
            foreach (note note in LesNotes)
            {
                if (note.Date.Year == annee)
                {

                    if (note.Rembourse == true)
                    {
                        somme += note.Montant;
                    }
                }
            }
            return somme;
        }
    }
}
