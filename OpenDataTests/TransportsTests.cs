using Microsoft.VisualStudio.TestTools.UnitTesting;
using dll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenData.Tests;

namespace dll.Tests
{
    [TestClass()]
    public class TransportsTests
    {
        [TestMethod()]
        public void ReceiveApi()
        {
            Transports transports = new Transports(new FakeRequest(true));

            List<Root> result = transports.GetStation();

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("Grenoble, Champs-Elysées", result[0].Name);

        }

        [TestMethod()]
        public void ConnectedOrNot()
        {
            Transports transports = new Transports(new FakeRequest(true));

        }

    }
}