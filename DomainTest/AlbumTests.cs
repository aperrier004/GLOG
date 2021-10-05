using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using System.Collections.Generic;

namespace DomainTest
{
    [TestClass]
    public class AlbumTests
    {
        private Album album;
        private List<Auteur> auteurs;
        private Serie serie;
        private Categorie cate;
        private List<Genre> genres;

        [TestInitialize()]
        public void Initialize()
        {
            auteurs = new List<Auteur>();
            genres = new List<Genre>();
            Auteur jacquesTardi = new Auteur("Tardi", "Jacques");
            auteurs.Add(jacquesTardi);
            serie = new Serie("Les Aventures extraordinaires d Adèle Blanc-Sec");
            cate = new Categorie("Bande Dessinée");
            Genre genreContemporain = new Genre("Contemporain");
            genres.Add(genreContemporain);
            

            album = new Album("https://www.casterman.com/media/cache/couverture_large/casterman_img/Couvertures/9782203148444.jpg",
                "Adèle et la Bête", "casterman", auteurs, serie, cate, genres);
        }

        [TestMethod]
        public void ToStringTest()
        {
            var actual = album.ToString();
            var expected = "Les Aventures extraordinaires d Adèle Blanc-Sec - Adèle et la Bête";
            Assert.AreEqual(expected, actual);
        }
    }
}
