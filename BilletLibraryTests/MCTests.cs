using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PrisTest()
        {
            //Arrange
            var MC = new MC();
            //Act
            int pris = MC.Pris(125);

            //Assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            var MC = new MC();
            string køretøj = MC.Køretøj("MC");
            Assert.AreEqual("MC", køretøj);
        }
    }
}