using NUnit.Framework;
using RaindropsCalculator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaindropsCalculator.Tests
{
    [TestFixture]
    public class RaindropsCounterTest
    {
        private IRaindropsCounter raindropCounter;

        [SetUp]
        protected void SetUp() => raindropCounter = new RaindropsCounter();

        [Test]
        public void NormalDataTest()
        {
            var expected = 8;
            var result = raindropCounter.Solve(new int[] { 5, 2, 3, 4, 5, 4, 1, 3, 1 });
            Assert.AreEqual(expected, result);

            expected = 10;
            result = raindropCounter.Solve(new int[] { 5, 2, 3, 4, 5, 4, 1, 3, 4 });
            Assert.AreEqual(expected, result);

            expected = 27;
            result = raindropCounter.Solve(new int[] { 7, 2, 3, 4, 5, 4, 1, 3, 7 });
            Assert.AreEqual(expected, result);

            expected = 30;
            result = raindropCounter.Solve(new int[] { 7, 2, 3, 4, 2, 4, 1, 3, 7 });
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void OutOfRangeDataTest()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => { raindropCounter.Solve(new int[] { 3, 2, 3, 34000, 5, 4, 1, 3, 7 }); });
            Assert.That(ex.ParamName, Is.EqualTo(nameof(raindropCounter.MaxHeight)));
        }
        [Test]
        public void NegetiveDataTest()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => { raindropCounter.Solve(new int[] { 3, 2, 3, -1, 5, 4, 1, 3, 7 }); });
            Assert.That(ex.ParamName, Is.EqualTo(nameof(raindropCounter.MinHeight)));
        }
    }
}
