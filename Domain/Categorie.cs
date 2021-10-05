using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Categorie
    {
        public virtual int Id { get; set; }
        public virtual string NomCategorie { get; set; }

        public Categorie() { }

        public Categorie(string label)
        {
            NomCategorie = label;
        }

        public override string ToString()
        {
            return NomCategorie.ToString();
        }
    }
}
