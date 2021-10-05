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
    public class CategorieRepositoryTests
    {
        private CategorieRepository categorieRepository;

        [TestInitialize()]
        public void Initialize()
        {
            TestRepository.InitDB();

            categorieRepository = new CategorieRepository();
        }


        [TestMethod]
        public void Test_GetAll()
        {
            var categories = categorieRepository.GetAll();
            // 3 categories dans le jeu de données de test
            Assert.AreEqual(3, categories.Count);
            var actual = categories.Select(cate => cate.NomCategorie).ToList();
            var expected = new List<string> { "Comics", "Manga", "Bande Dessinée"};
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod]
        public void Test_Save()
        {
            string nom = "WebComics";
            Categorie cate = new Categorie(nom);
            categorieRepository.Save(cate);

            // doit y avoir 4 categories
            var categories = categorieRepository.GetAll();
            Assert.AreEqual(4, categories.Count);

        }
    }
}
