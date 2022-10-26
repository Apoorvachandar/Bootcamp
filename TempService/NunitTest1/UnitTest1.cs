using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempService;

namespace UnitTest1
{
    [TestFixture]

    internal class TempServiceTest
    {
        [Test]

        public void TestCF()
        {
            
            double expected = 32;
            double actual = temp.CF(0);
            Assert.AreEqual(expected, actual);

        }

        [Test]

        public void TestFC()
        {
            double expected = 0;
            double actual = temp.FC(32);
            Assert.AreEqual(expected, actual);

        }

    }
}