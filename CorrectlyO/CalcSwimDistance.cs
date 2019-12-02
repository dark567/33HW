using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectlyO
{
    class CalcSwimDistance : IMovie
    {
        public void CalcDistance(int speed, int time)
        {
            Console.WriteLine($"Swim distance {speed * time * 2 }");
        }
    }
}
