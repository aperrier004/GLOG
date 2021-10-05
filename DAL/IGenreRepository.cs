using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    /// <summary>
    /// Interface d'accès aux Genres
    /// </summary>
    public interface IGenreRepository
    {
        /// <summary>
        /// Récupère la liste des Genres
        /// </summary>
        /// <returns></returns>
        IList<Genre> GetAll();

        IList<Genre> GetGenresParAlbumNom(string album);
        void Save(Genre genre);
    }
}
