using System;

namespace Lab_02
{
    internal class Way
    {
        private City _destination;
        private int _cost;

        public Way(City destination, int cost)
        {
            _destination = destination;
            _cost = cost;
        }

        public City Destination
        {
            get { return _destination; }
        }

        public int Cost
        {
            get { return _cost; }
        }
    }
}