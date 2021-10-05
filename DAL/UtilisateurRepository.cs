using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using NHibernate.Linq;

namespace DAL
{
    public class UtilisateurRepository : Repository, IUtilisateurRepository
    {
        // Récupère tous les utilisateurs
        public IList<Utilisateur> GetAll()
        {
            return Session.Query<Utilisateur>().ToList();
        }


        // Récupère l'utilisateur en BD avec l'id correspondant
        public IList<Utilisateur> GetUtilisateurParId(int id)
        {
            var result = Session.QueryOver<Utilisateur>().Where(u => u.Id == id)
                                      .List();

            return result;
        }

        // Récupère l'utilisateur avec le login et le mdp correspondant
        public IList<Utilisateur> GetUtilisateurParLoginMdp(string login, string mdp)
        {
            var result = Session.QueryOver<Utilisateur>().Where(u => u.Login == login)
                                      .Where(u => u.Mdp == mdp)
                                      .List();

            return result;
            
        }

        // Sauvegarde un utilisateur = inscription 
        public bool Save(Utilisateur utilisateur)
        {
            bool b = false;
            if(GetAll().Where(u => u.Login == utilisateur.Login).ToList().Count == 0 & utilisateur.Login != "admin")
            {
                Session.SaveOrUpdate(utilisateur);
                Session.Flush();
                b = true;
            }
            return b;
            
        }


        public bool AjouterAlbumSouhait(Album albumSouhaite, int idUtilisateur)
        {
            bool b = false;
            Utilisateur util = Session.Get<Utilisateur>(idUtilisateur);
            if (!util.ListeSouhaits.Contains(albumSouhaite))
            {
                util.ListeSouhaits.Add(albumSouhaite);

                Session.SaveOrUpdate(util);

                Album album = Session.Get<Album>(albumSouhaite.Id);
                album.ListeUtilFavoris.Add(util);

                Session.SaveOrUpdate(album);
                Session.Flush();
                b = true;
            }
            return b;
        }
        public bool AjouterAlbumCollec(Album albumAchete, int idUtilisateur)
        {
            bool b = false;
            Utilisateur util = Session.Get<Utilisateur>(idUtilisateur);
            if (!util.ListeAlbums.Contains(albumAchete))
            {
                util.ListeAlbums.Add(albumAchete);

                Session.SaveOrUpdate(util);

                Album album = Session.Get<Album>(albumAchete.Id);
                album.ListeUtilAchetes.Add(util);

                Session.SaveOrUpdate(album);
                Session.Flush();

                if (util.ListeSouhaits.Contains(album))
                {
                    this.SupprimerAlbumSouhaiteUtilisateur(album, idUtilisateur);
                }
                b = true;
            }
            return b;
        }

        public IList<Album> GetSouhaitUtilisateur(int id)
        {
            var result = Session.Query<Album>()
                                .Where(a => a.ListeUtilFavoris.Any(u => u.Id == id))
                                .ToList();
            return result;
        }

        public IList<Album> GetCollectionUtilisateur(int id)
        {
            var result = Session.Query<Album>()
                                .Where(a => a.ListeUtilAchetes.Any(u => u.Id == id))
                                .ToList();
            return result;
        }



        public bool SupprimerAlbumUtilisateur(Album albumCollec, int idUtilisateur)
        {
            bool b = false;
            Utilisateur util = Session.Get<Utilisateur>(idUtilisateur);
            if (util.ListeAlbums.Remove(albumCollec))
            {
                b = true;
                Session.SaveOrUpdate(util);
            }

            Album album = Session.Get<Album>(albumCollec.Id);
            if (album.ListeUtilAchetes.Remove(util) && b)
            {
                b = true;
                Session.SaveOrUpdate(album);
                Session.Flush();
            } else
            {
                b = false;
            }

            return b;
        }


        public bool SupprimerAlbumSouhaiteUtilisateur(Album albumSouhaite, int idUtilisateur)
        {
            bool b = false;
            Utilisateur util = Session.Get<Utilisateur>(idUtilisateur);
            if (util.ListeSouhaits.Remove(albumSouhaite))
            {
                Session.SaveOrUpdate(util);
                b = true;
            }

            

            Album album = Session.Get<Album>(albumSouhaite.Id);
            if(album.ListeUtilFavoris.Remove(util) && b)
            {
                Session.SaveOrUpdate(album);
                Session.Flush();
                b = true;
            }
            else
            {
                b = false;
            }

            return true;
        }
    }
}
