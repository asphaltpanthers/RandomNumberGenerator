using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    public class Exponential
    {
        private Random _random;

        public Exponential()
        {
            _random = new Random();
        }

        public Exponential(int seed)
        {
            _random = new Random(seed);
        }

        public Double Next(Double rate)
        {
            var uniformlyRandomNumber = _random.NextDouble();

            return Math.Log(1 - uniformlyRandomNumber) / -rate;
        }
    }
}
