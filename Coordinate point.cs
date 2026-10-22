using System;

namespace Lab_02
{
    internal class Coordinate_point
    {
        private int _x;
        private int _y;

        public Coordinate_point()
        {
            _x = 0;
            _y = 0;
        }

        public Coordinate_point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Coordinate_point(Coordinate_point point)
        {
            _x = point._x;
            _y = point._y;
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public override string ToString()
        {
            return $"{{{_x};{_y}}}";
        }
    }
}