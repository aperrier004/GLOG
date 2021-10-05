using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Administrateur
    {
        public virtual int Id { get; set; }
        public virtual string Login { get; set; }
        public virtual string Mdp { get; set; }

        //constructeur par défaut
        public Administrateur()
        { }

        public Administrateur(string login, string mdp)
        {
            Login = login;
            Mdp = mdp;
        }
    }
}
