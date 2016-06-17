using System;

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
