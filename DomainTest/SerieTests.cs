using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace DomainTest
{
    [TestClass]
    public class SerieTests
    {
        private Serie serie;

        [TestInitialize()]
        public void Initialize()
        {
            serie = new Serie("Adèle Blanc Sec");
        }


        [TestMethod]
        public void ToStringTest()
        {
            Assert.AreEqual("Adèle Blanc Sec", serie.ToString());
        }
    }
}
