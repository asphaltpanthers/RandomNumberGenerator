using System;

namespace RandomNumberGenerator.Test
{
    public class RandomNumberTester
    {
        public static bool LoopUntilLimit(Func<bool> test, int limit)
        {
            for (int i = 1; i <= limit; i++)
            {
                if (!test())
                {
                    return false;
                }
            }

            return true;
        }

        public static bool LoopUntilLimit(Func<bool> test, int limit, double passPercentage)
        {
            var failThreshold = (1 - passPercentage) * limit;

            for (int i = 1; i <= limit; i++)
            {
                if (!test())
                {
                    failThreshold--;
                    if (failThreshold < 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
