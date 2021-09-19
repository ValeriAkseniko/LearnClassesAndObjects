using LearnClassesAndObjects.Models.Shapes;

namespace LearnClassesAndObjects.Services
{
    public static class PointFunction
    {

        static public Point Plus(Point a, Point b)
        {
            if (a == null || b == null)
            {
                return null;
            }
            int x = a.x + b.x;
            int y = a.y + b.y;
            return new Point(x, y);
        }
        static public Point Minuse(Point a, Point b)
        {
            if (a == null || b == null)
            {
                return null;
            }
            int x = a.x - b.x;
            int y = a.y - b.y;
            return new Point(x, y);
        }
    }
}
