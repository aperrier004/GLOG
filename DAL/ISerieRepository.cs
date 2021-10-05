using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    /// <summary>
    /// Interface d'accès aux Series
    /// </summary>
    public interface ISerieRepository
    {
        /// <summary>
        /// Récupère la liste des Series
        /// </summary>
        /// <returns></returns>
        IList<Serie> GetAll();

        void Save(Serie serie);
    }
}
