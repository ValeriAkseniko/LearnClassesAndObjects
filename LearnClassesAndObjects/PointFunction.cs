using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects
{
    static class PointFunction
    {
        
        static public Point Plus(Point a, Point b)
        {
            int x = a.GetX() + b.GetX();
            int y = a.GetY() + b.GetY();
            return new Point(x, y);
        }
        static public Point Minuse(Point a, Point b)
        {
            int x = a.GetX() - b.GetX();
            int y = a.GetY() - b.GetY();
            return new Point(x, y);
        }
    }
}
