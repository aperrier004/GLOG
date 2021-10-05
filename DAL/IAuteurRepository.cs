using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    /// <summary>
    /// Interface d'accès aux Auteurs
    /// </summary>
    public interface IAuteurRepository
    {
        /// <summary>
        /// Récupère la liste des Auteurs
        /// </summary>
        /// <returns></returns>
        IList<Auteur> GetAll();

        IList<Auteur> GetAuteursParAlbumId(int id);

        void Save(Auteur auteur);
    }
}
