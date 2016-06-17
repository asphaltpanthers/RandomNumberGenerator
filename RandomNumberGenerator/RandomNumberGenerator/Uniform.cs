using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    public class Uniform
    {
        public Random _random;

        public Uniform()
        {
            _random = new Random();
        }

        public Uniform(int seed)
        {
            _random = new Random(seed);
        }
    }
}
