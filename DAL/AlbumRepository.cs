using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using NHibernate.Criterion;
using NHibernate.Linq;

namespace DAL
{
    public class AlbumRepository : Repository, IAlbumRepository
    {
        // Récupère tous les albums de la BD
        public IList<Album> GetAll()
        {
            return Session.Query<Album>().ToList();
        }

        public Album GetAlbumParId(int id)
        {
            var result = Session.QueryOver<Album>().Where(a => a.Id == id)
                                      .List();

            return result.FirstOrDefault();
        }

        public IList<Album> GetAlbumParNom(string nom)
        {
            var result = Session.Query<Album>()
                               .Where(a => a.NomAlbum.Contains(nom))
                               .ToList();
            return result;
        }
        public IList<Album> GetAlbumParSérie(string serie)
        {
            var result = Session.Query<Album>()
                               .Where(a => a.Serie.NomSerie.Contains(serie))
                               .ToList();
            return result;
        }
        public IList<Album> GetAlbumParAuteur(string auteur)
        {
            var result = Session.Query<Album>()
                               .Where(a => a.ListeAuteurs.Any(au => au.Nom.Contains(auteur) || au.Prenom.Contains(auteur)))
                               .ToList();
            return result;
        }
        public IList<Album> GetAlbumParGenre(string genre)
        {
            var result = Session.Query<Album>()
                               .Where(g => g.ListeGenres.Any(ge => ge.NomGenre == genre))
                               .ToList();
            return result;
        }

        public void Save(Album album)
        {
            Session.SaveOrUpdate(album);
            Session.Flush();
        }
    }
}
