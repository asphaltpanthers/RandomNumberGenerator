using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RandomNumberGenerator.Test
{
    public class WhenIGenerateABunchOfRandomNumbers
    {
        private Normal _normal;

        public WhenIGenerateABunchOfRandomNumbers()
        {
            _normal = new Normal();
        }

        [Fact]
        public void ItsMeanShouldBeCloseToFour()
        {
            Assert.True(RandomNumberTester.LoopUntilLimit(() =>
            {
                var randomNumbers = new List<double>();
                for (int i = 1; i <= 1000000; i++)
                {
                    randomNumbers.Add(_normal.Next(4, 3));
                }
                var actualAverage = randomNumbers.Average();
                return actualAverage >= 3.991 && actualAverage <= 4.009;
            }, 100, 0.997));
            
        }
    }
}
