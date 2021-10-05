using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Album
    {

        public virtual int Id { get; set; }
        public virtual string ImgCouv { get; set; }
        public virtual string NomAlbum { get; set; }
        public virtual string Editeur { get; set; }
        public virtual IList<Auteur> ListeAuteurs { get; set; }
        public virtual Serie Serie { get; set; }
        public virtual Categorie Categorie { get; set; }
        public virtual IList<Genre> ListeGenres { get; set; }

        public virtual IList<Utilisateur> ListeUtilAchetes { get; set; }
        public virtual IList<Utilisateur> ListeUtilFavoris { get; set; }

        public Album()
        {

        }

        public Album(string imgCouv, string nomAlbum, string editeur, IList<Auteur> auteurs, 
                    Serie serie, Categorie categorie, IList<Genre> genres)
        {
            ImgCouv = imgCouv;
            NomAlbum = nomAlbum;
            Editeur = editeur;
            ListeAuteurs = auteurs;
            Serie = serie;
            Categorie = categorie;
            ListeGenres = genres;
        }

        public override string ToString()
        {
            string txt = this.Serie + " - " +this.NomAlbum;
            
            return txt;
        }
    }
}
