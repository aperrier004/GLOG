using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DALTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DALTest
{
    [TestClass]
    public class AdministrateurRepositoryTests
    {
        private AdministrateurRepository adminRepository;

        [TestInitialize()]
        public void Initialize()
        {
            TestRepository.InitDB();
            adminRepository = new AdministrateurRepository();
        }

        [TestMethod]
        public void Test_GetAll()
        {
            var admins = adminRepository.GetAll();
            // 1 admin dans le jeu de données de test
            Assert.AreEqual(1, admins.Count);
            var actual = admins.Select(admin => admin.Login).ToList();
            var expected = new List<string> { "admin" };
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod]
        public void Test_GetAdminConnexion()
        {
            string login = "admin", mdp = "admin";
            var admin = adminRepository.GetAdminConnexion(login, mdp).ToList()[0];
            Assert.AreEqual("admin", admin.Login);
        }

        //cas où l'admin n'existe pas
        [TestMethod]
        public void Test_GetAdminConnexion_Erreur()
        {
            string login = "admin", mdp = "random";
            var admin = adminRepository.GetAdminConnexion(login, mdp);
            Assert.AreEqual(0, admin.Count);
        }



    }
}
