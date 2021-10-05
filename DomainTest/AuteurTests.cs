using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace DomainTest
{
    [TestClass]
    public class AuteurTests
    {
        private Auteur auteur;

        [TestInitialize()]
        public void Initialize()
        {
            auteur = new Auteur("Tardi", "Jacques");
        }


        [TestMethod]
        public void ToStringTest()
        {
            Assert.AreEqual("Tardi Jacques", auteur.ToString());
        }
    }
}
