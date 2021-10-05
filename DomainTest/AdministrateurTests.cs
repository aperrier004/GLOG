using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace DomainTest
{
    [TestClass]
    public class AdministrateurTests
    {
        private Administrateur admin;

        [TestInitialize()]
        public void Initialize()
        {
            admin = new Administrateur("Admin", "admin");
        }

        [TestMethod]
        public void AjouterAlbumTest()
        {
        }
        [TestMethod]
        public void SupprimerAlbumTest()
        {
        }
    }
}

