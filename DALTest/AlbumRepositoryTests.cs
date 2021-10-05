using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DALTests;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DALTest


    // TODO : test pour supprimer album collection/souhait

{
    [TestClass]
    public class AlbumRepositoryTests
    {

        private AlbumRepository albumRepository;
        private GenreRepository genreRepository;
        private AuteurRepository auteurRepository;
        private CategorieRepository categorieRepository;
        private SerieRepository serieRepository;

        [TestInitialize()]
        public void Initialize()
        {
            TestRepository.InitDB();

            albumRepository = new AlbumRepository();
            genreRepository = new GenreRepository();
            auteurRepository = new AuteurRepository();
            categorieRepository = new CategorieRepository();
            serieRepository = new SerieRepository();
        }



        [TestMethod]
        public void Test_GetAll()
        {
            var albums = albumRepository.GetAll();
            // 4 albums dans le jeu de données de test
            Assert.AreEqual(4, albums.Count);
            var actual = albums.Select(album => album.NomAlbum).ToList();
            var expected = new List<string> { "Scott Pilgrim s Precious Little Life", "Scott Pilgrim vs. the World", "Adèle et la Bête", "Tome 1: L attaque des Titans" };
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod]
        public void Test_GetAlbumParId()
        {
            int id = 1;
            var albums = albumRepository.GetAlbumParId(id);
            Assert.AreEqual("Scott Pilgrim s Precious Little Life", albums.NomAlbum);
        }

        //cas l'ID n'existe pas
        [TestMethod]
        public void Test_GetAlbumParId_Erreur()
        {
            int id = 22;
            var albums = albumRepository.GetAlbumParId(id);
            Assert.AreEqual(null, albums);
        }

        [TestMethod]
        public void Test_GetAlbumParNom()
        {
            string nom = "Scott Pilgrim s Precious Little Life";
            var albums = albumRepository.GetAlbumParNom(nom).ToList();
            //1 album avec ce titre
            Assert.AreEqual(1, albums.Count);
            //id du dit album
            var actual = albums[0].Id;
            Assert.AreEqual(1, actual);
        }


        // cas erreur : aucun album n'existe avec ce nom
        [TestMethod]
        public void Test_GetAlbumParNom_Erreur()
        {
            string nom = "N'existe pas";
            var albums = albumRepository.GetAlbumParNom(nom).ToList();
            //0 album avec ce titre
            Assert.AreEqual(0, albums.Count);
        }

        [TestMethod]
        public void Test_GetAlbumParSerie()
        {
            string serie = "Scott Pilgrim";
            var albums = albumRepository.GetAlbumParSérie(serie).ToList();
            //2 albums de cette serie
            Assert.AreEqual(2, albums.Count);
            //nom des albums
            var actual = albums.Select(album => album.NomAlbum).ToList();
            var expected = new List<string> { "Scott Pilgrim s Precious Little Life", "Scott Pilgrim vs. the World"};
            CollectionAssert.AreEquivalent(actual, expected);
        }

        //car erreur : la serie n'existe pas
        [TestMethod]
        public void Test_GetAlbumParSerie_Erreur()
        {
            string serie = "X-Men";
            var albums = albumRepository.GetAlbumParSérie(serie).ToList();
            //aucun album
            Assert.AreEqual(0, albums.Count);

        }

        [TestMethod]
        public void Test_GetAlbumParAuteur()
        {
            string auteur = "Lee O Maley";
            var albums = albumRepository.GetAlbumParAuteur(auteur).ToList();
            //2 albums par cet auteur
            Assert.AreEqual(2, albums.Count);
            //nom des albums
            var actual = albums.Select(album => album.NomAlbum).ToList();
            var expected = new List<string> { "Scott Pilgrim s Precious Little Life", "Scott Pilgrim vs. the World" };
            CollectionAssert.AreEquivalent(actual, expected);
        }

        //Cas erreur, l'auteur n'existe pas
        [TestMethod]
        public void Test_GetAlbumParAuteur_Erreur()
        {
            string auteur = "Penelope";
            var albums = albumRepository.GetAlbumParAuteur(auteur).ToList();
            //Aucun album
            Assert.AreEqual(0, albums.Count);

        }

        [TestMethod]
        public void Test_GetAlbumParGenre()
        {
            string genre = "Action";
            var albums = albumRepository.GetAlbumParGenre(genre).ToList();
            //1 album par ce genre
            Assert.AreEqual(1, albums.Count);
            //nom des albums
            var actual = albums.Select(album => album.NomAlbum).ToList();
            var expected = new List<string> { "Tome 1: L attaque des Titans" };
            CollectionAssert.AreEquivalent(actual, expected);
        }

        //cas d'erreur : le genre n'existe pas


        [TestMethod]
        public void Test_GetAlbumParGenre_Erreur()
        {
            string genre = "Attaque";
            var albums = albumRepository.GetAlbumParGenre(genre).ToList();
            //0 album par ce genre
            Assert.AreEqual(0, albums.Count);
        }



        // test ajout d'un nouvel album en BD
        [TestMethod]
        public void Test_Save()
        {
            //initialise l'album

            string album1 = "Tome 1: L attaque des Titans";
            IList<Genre> genres1 = genreRepository.GetGenresParAlbumNom(album1);
            IList<Auteur> auteurs1 = auteurRepository.GetAuteursParAlbumId(4); //recupère l'auteur du tome 1 de l'attaque des titans
            Categorie cate1 = categorieRepository.GetAll()[0];
            Serie serieTome1 = serieRepository.GetAll()[0];

            string album2 = "Tome 2: L attaque des Titans";
            Album albumTome2 = new Album("https://static.fnac-static.com/multimedia/Images/FR/NR/89/cf/4a/4902793/1540-1/tsp20131021170210/L-attaque-des-Titans.jpg",
                album2, "Pika Editions", auteurs1, serieTome1, cate1, genres1);


            //save le tome 2
            albumRepository.Save(albumTome2);

            //doit désormais y avoir 5 albums en BD
            var albums = albumRepository.GetAll().ToList();
            Assert.AreEqual(5, albums.Count);

            //les associations auteurs/album et genres/album doivent avoir été mises à jour
            // l'album a le genre Action 4 :
            var genresNouvelAlbum = genreRepository.GetGenresParAlbumNom(album2);
            var actualGenres = genresNouvelAlbum.Select(genre => genre.NomGenre).ToList();
            var expectedGenres = new List<string> { "Action" };
            CollectionAssert.AreEquivalent(actualGenres, expectedGenres);


            // L'album a l'auteur : Hajime Hisayama
            var auteursNouvelAlbum = auteurRepository.GetAuteursParAlbumId(albumTome2.Id);
            var actualAuteurs = auteursNouvelAlbum.Select(auteur => auteur.Nom).ToList();
            var expectedAuteurs = new List<string> { "Hajime" };
            CollectionAssert.AreEquivalent(actualGenres, expectedGenres);

        }

    }
}
