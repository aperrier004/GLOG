using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using DALTests;
using System.Linq;
using System.Collections.Generic;
using Domain;

namespace DALTest
{

    // SAVE TEST pas fait encore
    //tester les cas d'ajouts de doublons en souhait / collec impossible

    [TestClass]
    public class UtilisateurRepositoryTests
    {
        private UtilisateurRepository utilRepository;
        private AlbumRepository albumRepository;

        [TestInitialize()]
        public void Initialize()
        {
            TestRepository.InitDB();

            utilRepository = new UtilisateurRepository();
            albumRepository = new AlbumRepository();
        }

        [TestMethod]
        public void Test_GetAll()
        {
            var utilisateurs = utilRepository.GetAll();
            // 1 utilisateurs dans le jeu de données de test
            Assert.AreEqual(1, utilisateurs.Count);
            var actual = utilisateurs.Select(util => util.Nom).ToList();
            var expected = new List<string> { "Doe"};
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod]
        public void Test_GetUtilisateurParId()
        {
            int id = 1;
            var util = utilRepository.GetUtilisateurParId(id).ToList()[0];
            Assert.AreEqual("Doe", util.Nom);
        }

        [TestMethod]
        //cas erreur : aucun util n'a cet id
        public void Test_GetUtilisateurParId_Erreur()
        {
            int id = 41;
            var util = utilRepository.GetUtilisateurParId(id).ToList();
            Assert.AreEqual(0, util.Count);
        }

        [TestMethod]
        public void Test_GetUtilisateurParLoginMdp()
        {
            string login = "john002", mdp = "monSuperMDP";
            var util = utilRepository.GetUtilisateurParLoginMdp(login, mdp).ToList()[0];
            Assert.AreEqual(1, util.Id);
        }

        //cas erreur : login/mdp ne coincident pas
        [TestMethod]
        public void Test_GetUtilisateurParLoginMdp_Erreur()
        {
            string login = "john002", mdp = "mdp";
            var util = utilRepository.GetUtilisateurParLoginMdp(login, mdp).ToList();
            Assert.AreEqual(0, util.Count);
        }





        //cas normal
        [TestMethod]
        public void Test_Save()
        {
            string nom = "Pierre", prenom = "Jean", login = "JP", mdp = "mdp";
            Utilisateur user = new Utilisateur(nom, prenom, login, mdp);
            utilRepository.Save(user);
            var utilisateurs = utilRepository.GetAll();
            Assert.AreEqual(2, utilisateurs.Count);

            var actual = utilisateurs.Select(util => util.Nom).ToList();
            var expected = new List<string> { "Doe", "Pierre" };
            CollectionAssert.AreEquivalent(actual, expected);
        }

        //cas login déjà pris
        [TestMethod]
        public void Test_Save_Erreur()
        {
            string nom = "Pierre", prenom = "Jean", login = "john002", mdp = "mdp";
            Utilisateur user = new Utilisateur(nom, prenom, login, mdp);
            utilRepository.Save(user);
            // ne met pas à jour en BD car erreur
            var utilisateurs = utilRepository.GetAll();
            Assert.AreEqual(1, utilisateurs.Count);

            var actual = utilisateurs.Select(util => util.Nom).ToList();
            var expected = new List<string> { "Doe" };
            CollectionAssert.AreEquivalent(actual, expected);
        }

        //cas login admin déjà pris
        [TestMethod]
        public void Test_Save_ErreurAdmin()
        {
            string nom = "Pierre", prenom = "Jean", login = "admin", mdp = "mdp";
            Utilisateur user = new Utilisateur(nom, prenom, login, mdp);
            utilRepository.Save(user);
            // ne met pas à jour en BD car erreur
            var utilisateurs = utilRepository.GetAll();
            Assert.AreEqual(1, utilisateurs.Count);

            var actual = utilisateurs.Select(util => util.Nom).ToList();
            var expected = new List<string> { "Doe" };
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod]
        public void Test_GetCollectionUtilisateur()
        {
            int id = 1;
            var albums = utilRepository.GetCollectionUtilisateur(id);
            // 1 album dans la collection de l'user 1
            Assert.AreEqual(1, albums.Count);
            var actual = albums.Select(album => album.NomAlbum).ToList();
            var expected = new List<string> { "Scott Pilgrim s Precious Little Life" };
            CollectionAssert.AreEquivalent(actual, expected);
        }


        [TestMethod]
        public void Test_GetSouhaitsUtilisateur()
        {
            int id = 1;
            var albums = utilRepository.GetSouhaitUtilisateur(id);
            // 2 albums souhaités par l'user 1
            Assert.AreEqual(2, albums.Count);
            var actual = albums.Select(album => album.NomAlbum).ToList();
            var expected = new List<string> { "Scott Pilgrim vs. the World", "Adèle et la Bête" };
            CollectionAssert.AreEquivalent(actual, expected);
        }

        //cas normal
        [TestMethod]
        public void Test_AjouterAlbumSouhait()
        {
            int idUser = 1, idAlbum = 4;
            var album = albumRepository.GetAlbumParId(idAlbum);
            utilRepository.AjouterAlbumSouhait(album, idUser);
            // Maintenant, l'util 1 doit avoir 3 albums dans sa liste de souhait
            var albums = utilRepository.GetSouhaitUtilisateur(idUser);
            Assert.AreEqual(3, albums.Count);
            var actual = albums.Select(al => al.NomAlbum).ToList();
            var expected = new List<string> { "Scott Pilgrim vs. the World", "Adèle et la Bête", "Tome 1: L attaque des Titans" };
            CollectionAssert.AreEquivalent(actual, expected);
        }

        //cas erreur : album deja dans la liste de souhaits
        [TestMethod]
        public void Test_AjouterAlbumSouhait_Erreur()
        {
            int idUser = 1, idAlbum = 2;
            var album = albumRepository.GetAlbumParId(idAlbum);
            utilRepository.AjouterAlbumSouhait(album, idUser);
            //l'ajout en BD ne s'effectue pas, l'util 1 doit avoir 2 albums dans sa liste de souhait
            var albums = utilRepository.GetSouhaitUtilisateur(idUser);
            Assert.AreEqual(2, albums.Count);
            var actual = albums.Select(al => al.NomAlbum).ToList();
            var expected = new List<string> { "Scott Pilgrim vs. the World", "Adèle et la Bête"};
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod]
        public void Test_AjouterAlbumSouhaiteCollec()
        {
            int idUser = 1, idAlbum = 2;
            var album = albumRepository.GetAlbumParId(idAlbum);
            utilRepository.AjouterAlbumCollec(album, idUser);
            // Maintenant, l'util 1 doit avoir 2 albums dans sa collection
            var albums = utilRepository.GetCollectionUtilisateur(idUser);
            Assert.AreEqual(2, albums.Count);
            var actual = albums.Select(al => al.NomAlbum).ToList();
            var expected = new List<string> { "Scott Pilgrim s Precious Little Life", "Scott Pilgrim vs. the World"};
            CollectionAssert.AreEquivalent(actual, expected);


            // vérifier que ça a été supprimé de la liste de souhait si ça y était
            var souhaits = utilRepository.GetSouhaitUtilisateur(idUser);
            //Ne doit plus y avoir que 1 souhait
            Assert.AreEqual(1, souhaits.Count);
            var actual2= souhaits.Select(s => s.NomAlbum).ToList();
            var expected2 = new List<string> { "Adèle et la Bête"};
            CollectionAssert.AreEquivalent(actual2, expected2);
        }

        //cas erreur : album déjà dans la collection
        [TestMethod]
        public void Test_AjouterAlbumSouhaiteCollec_Erreur()
        {
            int idUser = 1, idAlbum = 1;
            var album = albumRepository.GetAlbumParId(idAlbum);
            utilRepository.AjouterAlbumCollec(album, idUser);
            // Maintenant, l'util 1 doit avoir 1 album dans sa collection
            var albums = utilRepository.GetCollectionUtilisateur(idUser);
            Assert.AreEqual(1, albums.Count);
            var actual = albums.Select(al => al.NomAlbum).ToList();
            var expected = new List<string> { "Scott Pilgrim s Precious Little Life" };
            CollectionAssert.AreEquivalent(actual, expected);
        }





            [TestMethod]
        public void Test_AjouterAlbumCollec()
        {
            int idUser = 1, idAlbum = 4;
            var album = albumRepository.GetAlbumParId(idAlbum);
            utilRepository.AjouterAlbumCollec(album, idUser);
            // Maintenant, l'util 1 doit avoir 2 albums dans sa collection
            var albums = utilRepository.GetCollectionUtilisateur(idUser);
            Assert.AreEqual(2, albums.Count);
            var actual = albums.Select(al => al.NomAlbum).ToList();
            var expected = new List<string> { "Scott Pilgrim s Precious Little Life", "Tome 1: L attaque des Titans" };
            CollectionAssert.AreEquivalent(actual, expected);


            // vérifier rien a été supprime de la liste de souhait
            var souhaits = utilRepository.GetSouhaitUtilisateur(idUser);
            //Doit toujours y avoir 2 souhaits
            Assert.AreEqual(2, souhaits.Count);
            var actual2 = souhaits.Select(s => s.NomAlbum).ToList();
            var expected2 = new List<string> { "Scott Pilgrim vs. the World", "Adèle et la Bête" };
            CollectionAssert.AreEquivalent(actual2, expected2);
        }

        [TestMethod]
        public void Test_SupprimerAlbumUtilisateur()
        {
            int idUser = 1, idAlbum = 1; 
            var album = albumRepository.GetAlbumParId(idAlbum);
            //user 1 a l'album 1 dans sa collection
            //On supprimer l'album de sa collection
            utilRepository.SupprimerAlbumUtilisateur(album, idUser);
            // Maintenant, l'util 1 doit avoir 0 album dans sa collection
            var albums = utilRepository.GetCollectionUtilisateur(idUser);
            Assert.AreEqual(0, albums.Count);
        }

        //cas d'erreur : il n'a pas l'album dans sa collection
        [TestMethod]
        public void Test_SupprimerAlbumUtilisateur_Erreur()
        {
            int idUser = 1, idAlbum = 2;
            var album = albumRepository.GetAlbumParId(idAlbum);
            //user 1 a l'album 1 dans sa collection
            //On supprimer l'album de sa collection
            utilRepository.SupprimerAlbumUtilisateur(album, idUser);
            // Maintenant, l'util 1 doit avoir 1 album dans sa collection
            var albums = utilRepository.GetCollectionUtilisateur(idUser);
            Assert.AreEqual(1, albums.Count);
        }

        [TestMethod]
        public void Test_SupprimerAlbumSouhaitUtilisateur()
        {
            int idUser = 1, idAlbum = 2;
            var album = albumRepository.GetAlbumParId(idAlbum);
            //user 1 a l'album 2 et 3 en souhaits
            //On supprimer l'album 2 de sa liste
            utilRepository.SupprimerAlbumSouhaiteUtilisateur(album, idUser);
            // Maintenant, l'util 1 doit avoir 1 album dans sa collection
            var albums = utilRepository.GetSouhaitUtilisateur(idUser);
            Assert.AreEqual(1, albums.Count);
            var actual = albums.Select(al => al.NomAlbum).ToList();
            var expected = new List<string> { "Adèle et la Bête" };
            CollectionAssert.AreEquivalent(actual, expected);
        }

        //supprimer album qui est pas dans la liste de souhait
        [TestMethod]
        public void Test_SupprimerAlbumSouhaitUtilisateur_Erreur()
        {
            int idUser = 1, idAlbum = 4;
            var album = albumRepository.GetAlbumParId(idAlbum);
            //user 1 n'a pas l'album 4 de sa liste
            //On essaie de le supprimer
            utilRepository.SupprimerAlbumSouhaiteUtilisateur(album, idUser);
            // Maintenant, l'util 1 doit avoir 2 albums dans sa collection
            var albums = utilRepository.GetSouhaitUtilisateur(idUser);
            Assert.AreEqual(2, albums.Count);

        }


    }
}
