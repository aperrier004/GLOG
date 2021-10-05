using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Auteur
    {
        public virtual int Id { get; set; }
        public virtual string Nom { get; set; }
        public virtual string Prenom { get; set; }

        public virtual IList<Album> ListeAlbums { get; set; }

        public Auteur() { }

        public Auteur(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
            ListeAlbums = new List<Album>();
        }


        public override string ToString()
        {
            string txt = Nom + " " + Prenom;
            return txt;
        }
    }
}
