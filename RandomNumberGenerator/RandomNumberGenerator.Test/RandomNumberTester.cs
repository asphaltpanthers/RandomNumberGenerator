using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator.Test
{
    public class RandomNumberTester
    {
        public static Boolean LoopUntilLimit(Func<Boolean> test, int limit)
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
    }
}
