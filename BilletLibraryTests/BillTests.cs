﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary.Tests
{
    [TestClass()]
    public class BillTests
    {
        [TestMethod()]
        public void PrisTest()
        {
            //Arrange
            var Bil = new Bill();
            //Act
            int pris = Bil.Pris(240);
            //Assert
            Assert.AreEqual(240, pris);

            
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            var Bil = new Bill();
            string køretøj = Bil.Køretøj();

            Assert.AreEqual("Bil", køretøj);
        }
    }
}