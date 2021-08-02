using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects
{
    public class Point
    {
        // public int x { get; set; }
        // public int y { get; set; }
        // Тоже самое, автосвойства
        public int x { get { return x; } set { x = value; } }
        public int y { get { return x; } set { x = value; } }

        public Point()
        {

        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public string GetInfo()
        {
            return $" x = {x}, y = {y}";
        }

    }
}
