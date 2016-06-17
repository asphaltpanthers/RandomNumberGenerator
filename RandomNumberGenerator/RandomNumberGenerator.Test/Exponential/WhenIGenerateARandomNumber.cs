using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RandomNumberGenerator.Test
{
    public class WhenIGenerateARandomNumber
    {
        private Exponential _exponential;

        public WhenIGenerateARandomNumber()
        {
            _exponential = new Exponential();
        }

        [Fact]
        public void ItShouldNotReturnAValueLessThanZero()
        {
            if (!RandomNumberTester.LoopUntilLimit(() =>
            {
                return _exponential.Next(1) > 0;
            }, 1000))
            {
                Assert.True(false, "Exponential distribution should never return a negative number.");
            }
        }
    }
}
