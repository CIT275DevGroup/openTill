//Blaine Simcox 
//CIT 275
//Jeff Straw
//Domain Testing Address

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using openTill.Domain;

namespace DomainAddressTest
{
    [TestClass]
    public class DomainAddressTest
    {
        [TestMethod]
        public void IDIsNull()
        {
            openTill.Domain.Address add = new openTill.Domain.Address();
            Assert.IsNull(add.ID);
        }
    }
}
