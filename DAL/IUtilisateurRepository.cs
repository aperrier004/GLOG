using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    /// <summary>
    /// Interface d'accès aux utilisateurs de la bibliothèque
    /// </summary>
    public interface IUtilisateurRepository
    {
        /// <summary>
        /// Récupère la liste des utilisateurs
        /// </summary>
        /// <returns></returns>
        IList<Utilisateur> GetAll();

        /// <summary>
        /// Sauvegarde un nouvel utilisateur
        /// </summary>
        /// <param name="utilisateur">l'utilisateur</param>
        bool Save(Utilisateur utilisateur);

        IList<Utilisateur> GetUtilisateurParId(int id);

        IList<Utilisateur> GetUtilisateurParLoginMdp(string login, string mdp);

        bool SupprimerAlbumUtilisateur(Album albumCollec, int idUtilisateur);
        bool SupprimerAlbumSouhaiteUtilisateur(Album albumSouhaite, int idUtilisateur);

        bool AjouterAlbumSouhait(Album albumSouhaite, int idUtilisateur);
        bool AjouterAlbumCollec(Album albumSouhaite, int idUtilisateur);

        IList<Album> GetCollectionUtilisateur(int id);

        IList<Album> GetSouhaitUtilisateur(int id);
    }

}
