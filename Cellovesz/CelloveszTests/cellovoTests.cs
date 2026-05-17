using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cellovesz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellovesz.Tests
{
    [TestClass()]
    public class cellovoTests
    {
        [TestMethod()]
        public void legnagyobbTest()
        {
            cellovo cellovo = new cellovo("Teszt;22;29;12;23");
            Assert.AreEqual(29, cellovo.legnagyobb());
        }

        [TestMethod()]
        public void legnagyobbTest2()
        {
            cellovo cellovo = new cellovo("Teszt;16;45;87;33");
            Assert.AreEqual(87, cellovo.legnagyobb());
        }

        [TestMethod()]
        public void legnagyobbTest3()
        {
            cellovo cellovo = new cellovo("Teszt;96;46;67;45");
            Assert.AreEqual(96, cellovo.legnagyobb());
        }

        [TestMethod()]
        public void legnagyobbTest4()
        {
            cellovo cellovo = new cellovo("Teszt;44;3;12;77");
            Assert.AreEqual(77, cellovo.legnagyobb());
        }
    }
}