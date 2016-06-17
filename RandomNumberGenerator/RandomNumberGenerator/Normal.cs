using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    public class Normal : Uniform
    {
        public Double Next(Double mean, Double stdDev)
        {
            var uniformalyRandomNumber0 = _random.NextDouble();
            var uniformalyRandomNumber1 = _random.NextDouble();

            var standardNormal = Math.Sqrt(-2.0 * Math.Log(uniformalyRandomNumber0)) * Math.Sin(2.0 * Math.PI * uniformalyRandomNumber1);

            return mean + stdDev * standardNormal;
        }
    }
}
