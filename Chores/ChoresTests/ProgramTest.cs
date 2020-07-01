using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chores.Tests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void CanItStart()
        {
            Assert.AreEqual("yes", "yes");
        }


    }
}
