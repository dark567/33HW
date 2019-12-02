using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectlyO
{
    class CalcRunDistance : IMovie
    {
        public void CalcDistance(int speed, int time)
        {
            Console.WriteLine($"Run distance {speed* time * 0.1}");
        }
    }
}
