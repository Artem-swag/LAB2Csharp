using System;

namespace Lab_02
{
    internal class Fullname
    {
        private string _name;
        private string _surname;
        private string _patronymic;

        public Fullname()
        {
            _name = "Иван";
            _surname = "Иванов";
            _patronymic = "Иванович";
        }

        public Fullname(string name, string surname, string patronymic)
        {
            _name = name;
            _surname = surname;
            _patronymic = patronymic;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string Patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; }
        }

        public override string ToString()
        {
            string s = "";

            if (_surname != "")
            {
                s += _surname;
            }

            if (_name != "")
            {
                if (s != "")
                {
                    s += " ";
                }
                s += _name;
            }

            if (_patronymic != "")
            {
                if (s != "")
                {
                    s += " ";
                }
                s += _patronymic;
            }

            if (s == "")
            {
                s = "Безымянный";
            }

            return s;
        }
    }
}
