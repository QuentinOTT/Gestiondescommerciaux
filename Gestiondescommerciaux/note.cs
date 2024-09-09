using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gestiondescommerciaux
{
    public class note
    {

        private int identifiant;
        private DateTime date;
        private double montant;
        private string type;
        private Boolean rembourse;
        private commercial commercial;
        public int Identifiant { get => identifiant; set => identifiant = value; }
        public DateTime Date { get => date; set => date = value; }
        public double Montant { get => montant; set => montant = value; }
        public string Type { get => type; set => type = value; }
        public bool Rembourse { get => rembourse; set => rembourse = value; }
        internal commercial Commercial { get => commercial; set => commercial = value; }

        public note(int pid, DateTime pdate, double pmontant, string ptype, Boolean prembourse)
        {
            this.identifiant = pid;
            this.date = pdate;   
            this.montant = pmontant;
            this.type = ptype;
            this.rembourse = prembourse;
        }

        public override string ToString()
        {
            return "id"+ Identifiant +"date" +Date +"Montant" + Montant + "Type" + type + "Rembourse" + Rembourse;
        }

    }
}
