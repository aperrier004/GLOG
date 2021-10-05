using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    /// <summary>
    /// Interface d'accès aux Categories
    /// </summary>
    public interface ICategorieRepository
    {
        /// <summary>
        /// Récupère la liste des Categories
        /// </summary>
        /// <returns></returns>
        IList<Categorie> GetAll();

        void Save(Categorie cat);
    }
}
