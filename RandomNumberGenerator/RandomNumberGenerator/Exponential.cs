using System;

namespace RandomNumberGenerator
{
    public class Exponential : Uniform
    {
        public double Next(double rate)
        {
            var uniformlyRandomNumber = _random.NextDouble();

            return Math.Log(1 - uniformlyRandomNumber) / -rate;
        }
    }
}
