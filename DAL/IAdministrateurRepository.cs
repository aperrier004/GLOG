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
    public interface IAdministrateurRepository
    {
        /// <summary>
        /// Récupère la liste des administrateurs
        /// </summary>
        /// <returns></returns>
        IList<Administrateur> GetAll();

        IList<Administrateur> GetAdminConnexion(string login, string mdp);
    }
}
