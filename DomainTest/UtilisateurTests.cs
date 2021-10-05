using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace DomainTest
{
    [TestClass]
    public class UtilisateurTests
    {
        private Utilisateur util;

        [TestInitialize()]
        public void Initialize()
        {
            util = new Utilisateur("Doe", "John", "anonymous", "mdp");
        }


        [TestMethod]
        public void ToStringTest()
        {
            Assert.AreEqual("John Doe", util.ToString());
        }

    }
}
