using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace DomainTest
{
    [TestClass]
    public class CategorieTests
    {
        private Categorie cate;
        [TestInitialize()]
        public void Initialize()
        {
            cate = new Categorie("Bande Dessinée");
        }

        [TestMethod]
        public void ToStringTest()
        {
            Assert.AreEqual("Bande Dessinée", cate.ToString());
        }
    }
}
