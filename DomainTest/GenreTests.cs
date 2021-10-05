using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace DomainTest
{
    [TestClass]
    public class GenreTests
    {
        private Genre genre;

        [TestInitialize()]
        public void Initialize()
        {
            genre = new Genre("Horreur");
        }

        [TestMethod]
        public void ToStringTest()
        {
            Assert.AreEqual("Horreur", genre.ToString());
        }
    }
}
