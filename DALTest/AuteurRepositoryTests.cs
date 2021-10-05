using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using DALTests;
using System.Linq;
using System.Collections.Generic;
using Domain;

namespace DALTest
{
    [TestClass]
    public class AuteurRepositoryTests
    {
        private AuteurRepository auteurRepository;

        [TestInitialize()]
        public void Initialize()
        {
            TestRepository.InitDB();

            auteurRepository = new AuteurRepository();
        }


        [TestMethod]
        public void Test_GetAll()
        {
            var auteurs = auteurRepository.GetAll();
            // 4 auteurs dans le jeu de données de test
            Assert.AreEqual(4, auteurs.Count);
            var actual = auteurs.Select(auteur => auteur.Nom).ToList();
            var expected = new List<string> { "Lee O Maley", "Tardi","Hajime", "Alex" };
            CollectionAssert.AreEquivalent(actual, expected);
        }


        [TestMethod]
        public void Test_GetAuteursParAlbumId()
        {
            int albumId = 3; // album Adele Blanc Sec
            var auteurs = auteurRepository.GetAuteursParAlbumId(albumId);
            // 1 auteur pour l'abum donné dans le jeu de données de test
            Assert.AreEqual(1, auteurs.Count);
            var actual = auteurs.Select(auteur => auteur.Nom).ToList();
            var expected = new List<string> { "Tardi" };
            CollectionAssert.AreEquivalent(actual, expected);
        }

        //cas erreur : aucun auteur existe avec Id specifie
        [TestMethod]
        public void Test_GetAuteursParAlbumId_Erreur()
        {
            int albumId = 22; // album inexistant
            var auteurs = auteurRepository.GetAuteursParAlbumId(albumId);
            // 0 auteur pour l'abum donné dans le jeu de données de test
            Assert.AreEqual(0, auteurs.Count);
        }

        [TestMethod]
        public void Test_Save()
        {
            string nom = "Smith", prenom = "Jeff";
            Auteur auteur = new Auteur(nom, prenom);

            auteurRepository.Save(auteur);

            //doit désormais y avoir 5 auteurs en BD de test : 
            var auteurs = auteurRepository.GetAll();
            Assert.AreEqual(5, auteurs.Count);

        }
    }
}
