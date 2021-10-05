using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class CategorieRepository : Repository, ICategorieRepository
    {
        public IList<Categorie> GetAll()
        {
            return Session.Query<Categorie>().ToList();
        }
        public void Save(Categorie cat)
        {
            Session.SaveOrUpdate(cat);
            Session.Flush();
        }
    }
}
