using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    public class Exponential : Uniform
    {
        public Double Next(Double rate)
        {
            var uniformlyRandomNumber = _random.NextDouble();

            return Math.Log(1 - uniformlyRandomNumber) / -rate;
        }
    }
}
