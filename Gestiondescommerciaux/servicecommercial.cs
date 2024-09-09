using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiondescommerciaux
{
    internal class servicecommercial
    {
        private string nom;
        private List<servicecommercial> lesCommerciaux = new List<servicecommercial>{ };

        public string Nom { get => nom; set => nom = value; }
        internal List<servicecommercial> LesCommerciaux { get => lesCommerciaux; set => lesCommerciaux = value; }

        public servicecommercial(string pnom)
        {
            this.nom = pnom;
        }
    }
}
