using System;

namespace Lab_02
{
    internal class City
    {
        private string _name;
        private Way[] _ways;
        private int _waysCount;

        public City(string name)
        {
            _name = name;
            _ways = new Way[10]; 
            _waysCount = 0;      
        }

        public City(string name, Way[] initialWays) : this(name)
        {
            if (initialWays != null)
            {
                for (int i = 0; i < initialWays.Length; i++)
                {
                    AddWay(initialWays[i]);
                }
            }
        }

        public string Name
        {
            get { return _name; }
        }

        public Way[] Ways
        {
            get { return _ways; }
        }

        public int WaysCount
        {
            get { return _waysCount; }
        }

        public void AddWay(City destination, int cost)
        {
            if (_waysCount < _ways.Length)
            {
                _ways[_waysCount] = new Way(destination, cost);
                _waysCount++;
            }
            else
            {
                Console.WriteLine("Нет места для новых путей!");
            }
        }

        public void AddWay(Way newWay)
        {
            if (_waysCount < _ways.Length)
            {
                _ways[_waysCount] = newWay;
                _waysCount++;
            }
            else
            {
                Console.WriteLine("Нет места для новых путей!");
            }
        }

        public override string ToString()
        {
            string result = $"{_name}: ";

            for (int i = 0; i < _waysCount; i++)
            {
                result += $"{_ways[i].Destination.Name}:{_ways[i].Cost}; ";
            }

            return result;
        }
    }
}
