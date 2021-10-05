using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DALTests;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DALTest
{
    [TestClass]
    public class GenreRepositoryTests
    {
        private GenreRepository genreRepository;
        private AlbumRepository albumRepository;

        [TestInitialize()]
        public void Initialize()
        {
            TestRepository.InitDB();

            genreRepository = new GenreRepository();
            albumRepository = new AlbumRepository();
        }


        [TestMethod]
        public void Test_GetAll()
        {
            var genres = genreRepository.GetAll();
            // 4 genres dans le jeu de données de test
            Assert.AreEqual(4, genres.Count);
            var actual = genres.Select(genre => genre.NomGenre).ToList();
            var expected = new List<string> { "Contemporain", "Aventure", "Fantasy historique", "Action" };
            CollectionAssert.AreEquivalent(actual, expected);
        }


        [TestMethod]
        public void Test_GetParAlbumNom()
        {
            string album = "Adèle et la Bête";
            var genres = genreRepository.GetGenresParAlbumNom(album);
            // 2 genres pour l'abum donné dans le jeu de données de test
            Assert.AreEqual(2, genres.Count);
            var actual = genres.Select(genre => genre.NomGenre).ToList();
            var expected = new List<string> { "Aventure", "Fantasy historique" };
            CollectionAssert.AreEquivalent(actual, expected);

        }

        //cas erreur, l'album n'existe pas
        [TestMethod]
        public void Test_GetParAlbumNom_Erreur()
        {
            string album = "Adèle et la Chose";
            var genres = genreRepository.GetGenresParAlbumNom(album);
            // N'existe pas, pas de genres
            Assert.AreEqual(0, genres.Count);
            

        }


        [TestMethod]
        public void Test_Save()
        {
            string nom = "Tranche de vie";
            Genre genre = new Genre(nom);
            genreRepository.Save(genre);

            // doit y avoir 5 genres
            var genres = genreRepository.GetAll();
            Assert.AreEqual(5, genres.Count);

            var actual = genres.Select(g => g.NomGenre).ToList();
            var expected = new List<string> { "Contemporain", "Aventure", "Fantasy historique", "Action", "Tranche de vie" };
            CollectionAssert.AreEquivalent(actual, expected);

        }

        
    }
}
