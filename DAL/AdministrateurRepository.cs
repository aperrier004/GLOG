using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class AdministrateurRepository : Repository, IAdministrateurRepository
    {
        public IList<Administrateur> GetAll()
        {
            return Session.Query<Administrateur>().ToList();
        }

        public IList<Administrateur> GetAdminConnexion(string login, string mdp)
        {
            var result = Session.QueryOver<Administrateur>().Where(a => a.Login == login)
                                      .Where(a => a.Mdp == mdp)
                                      .List();

            return result;
        }
    }
}
