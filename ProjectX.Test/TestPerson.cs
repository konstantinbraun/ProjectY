using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectX.Test
{
    [TestClass]
    public class TestPerson
    {
        [TestMethod]
        public void TestPerson_TestCunstructor_TheNameShouldBeTheSame()
        {
            Person o = new Person("Konstantin");
            Assert.AreEqual(o.Name, "Konstantin");
        }
    }
}
