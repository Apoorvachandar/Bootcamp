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

        public void testCelsiusToFarenheit()
        {
            
            double expected = 32;
            double actual = temp.CcelsiusToFarenheit(0);
            Assert.AreEqual(expected, actual);

        }

        [Test]

        public void testFarenheitToCelsius()
        {
            double expected = 0;
            double actual = temp.farenheitToCelsius(32);
            Assert.AreEqual(expected, actual);

        }

    }
}
