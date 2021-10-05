using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    /// <summary>
    /// Interface d'accès aux albums
    /// </summary>
    public interface IAlbumRepository
    {
        /// <summary>
        /// Récupère la liste des albums
        /// </summary>
        /// <returns></returns>
        IList<Album> GetAll();

        Album GetAlbumParId(int id);

        IList<Album> GetAlbumParNom(string nom);
        IList<Album> GetAlbumParSérie(string serie);
        IList<Album> GetAlbumParAuteur(string auteur);
        IList<Album> GetAlbumParGenre(string genre);

        void Save(Album album);

    }
}
