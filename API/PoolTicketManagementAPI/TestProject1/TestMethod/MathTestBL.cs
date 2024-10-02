using PoolTicketManagementAPI.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.TestMethod
{
    internal class MathTestBL
    {
        MathBL mathBL;
        [SetUp]
        public void Setup()
        {
            mathBL = new MathBL();
        }

        [Test]
        public void TestSum()
        {
            int result = mathBL.Sum(2, 3);
            Assert.IsTrue(result == 5);
        }

    }
}
