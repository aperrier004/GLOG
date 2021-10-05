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
    public class SerieRepositoryTests
    {

        private SerieRepository serieRepository;

        [TestInitialize()]
        public void Initialize()
        {
            TestRepository.InitDB();

            serieRepository = new SerieRepository();
        }


        [TestMethod]
        public void Test_GetAll()
        {
            var series = serieRepository.GetAll();
            // 4 series dans le jeu de données de test
            Assert.AreEqual(4, series.Count);
            var actual = series.Select(serie => serie.NomSerie).ToList();
            var expected = new List<string> { "Scott Pilgrim", "Les Aventures extraordinaires d Adèle Blanc-Sec", "L attaque des Titans", "Le château des étoiles" };
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod]
        public void Test_Save()
        {
            string nom = "X-Men";
            Serie serie = new Serie(nom);
            serieRepository.Save(serie);

            // 5 series dans le jeu de données de test
            var series = serieRepository.GetAll();
            Assert.AreEqual(5, series.Count);
            var actual = series.Select(s => s.NomSerie).ToList();
            var expected = new List<string> { "Scott Pilgrim", "Les Aventures extraordinaires d Adèle Blanc-Sec", "L attaque des Titans", "Le château des étoiles", "X-Men" };
            CollectionAssert.AreEquivalent(actual, expected);
        }

    }
}
