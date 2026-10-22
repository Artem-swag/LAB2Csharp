using System;

namespace Lab_02
{
    internal class Line
    {
        private Coordinate_point _startLine;
        private Coordinate_point _endLine;

        public Line()
        {
            _startLine = new Coordinate_point(0, 0);
            _endLine = new Coordinate_point(0, 0);
        }

        public Line(Coordinate_point start, Coordinate_point end)
        {
            _startLine = start; 
            _endLine = end;
        }

        public Coordinate_point StartLine
        {
            get { return _startLine; }
            set { _startLine = value; } 
        }

        public Coordinate_point EndLine
        {
            get { return _endLine; }
            set { _endLine = value; } 
        }

        public override string ToString()
        {
            return $"Линия от {_startLine} до {_endLine}";
        }
    }
}
