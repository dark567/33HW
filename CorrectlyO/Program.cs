using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectlyO
{
    class Program
    {
        static void Main(string[] args)
        {

            MoveAction dist = new MoveAction(15, 30);

            dist.CalcDistance(new CalcSwimDistance());
            dist.CalcDistance(new CalcRunDistance());

            Console.ReadLine();
        }
    }
}
