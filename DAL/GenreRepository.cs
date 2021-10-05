using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class GenreRepository : Repository, IGenreRepository
    {
        public IList<Genre> GetAll()
        {
            return Session.Query<Genre>().ToList();
        }

        public IList<Genre> GetGenresParAlbumNom(string album)
        {
            var result = Session.Query<Genre>()
                               .Where(g => g.ListeAlbums.Any(al => al.NomAlbum == album))
                               .ToList();
            return result;
        }

        public void Save(Genre genre)
        {
            Session.SaveOrUpdate(genre);
            Session.Flush();
        }
    }
}
