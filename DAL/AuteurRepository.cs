using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class AuteurRepository : Repository, IAuteurRepository
    {
        public IList<Auteur> GetAll()
        {
            return Session.Query<Auteur>().ToList();
        }

        public IList<Auteur> GetAuteursParAlbumId(int id)
        {
            var result = Session.Query<Auteur>()
                               .Where(g => g.ListeAlbums.Any(al => al.Id == id))
                               .ToList();
            return result;
        }
        public void Save(Auteur auteur)
        {
            Session.SaveOrUpdate(auteur);
            Session.Flush();
        }
    }
}
