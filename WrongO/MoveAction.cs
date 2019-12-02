using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrongO
{
    /// <summary>
    /// изменение класса вместо расширения
    /// </summary>
    public class MoveAction
    {
        public int Speed { get; set; }
        public int Time { get; set; }

        public MoveAction(int speed, int time)
        {
            this.Speed = speed;
            this.Time = time;
        }

        public void CalcDistance(int speed, int time)
        {
            Console.WriteLine($"Calc distance {speed * time}");
        }

        public void CalcSwimDistance(int speed, int time)
        {
            Console.WriteLine($"Swim distance {speed * time * 2 }");
        }

        public void CalcRunDistance(int speed, int time)
        {
            Console.WriteLine($"Run distance {speed * time * 0.1}");
        }
    }
}
