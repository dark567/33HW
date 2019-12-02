using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectlyO
{
    public class MoveAction
    {
        public int Speed { get; set; }
        public int Time { get; set; }

        public MoveAction(int speed, int time)
        {
            this.Speed = speed;
            this.Time = time;
        }

        public void CalcDistance(IMovie movie)
        {
            movie.CalcDistance(Speed, Time);
        }
    }
}
