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
            Assert.True(RandomNumberTester.LoopUntilLimit(() =>
            {
                return _exponential.Next(1) > 0;
            }, 1000));
        }
    }
}
