using System;

namespace Lab_02
{
    internal class Fraction
    {
        private int _nom;
        private int _den;

        public Fraction()
        {
            _nom = 0;
            _den = 1;
        }

        public Fraction(int nom, int den)
        {
            _nom = nom;
            Den = den;
        }

        public int Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public int Den
        {
            get { return _den; }
            set
            {
                if (value != 0)
                {
                    _den = value;
                }
                else
                {
                    Console.WriteLine("На ноль делить нельзя!");
                    _den = 1;
                }
            }
        }

        public Fraction Add(Fraction other)
        {
            int newNom = _nom * other._den + other._nom * _den;
            int newDen = _den * other._den;
            return new Fraction(newNom, newDen);
        }

        public Fraction Add(int number)
        {
            var other = new Fraction(number, 1);
            return Add(other);
        }

        public Fraction Sub(Fraction other)
        {
            int newNom = _nom * other._den - other._nom * _den;
            int newDen = _den * other._den;
            return new Fraction(newNom, newDen);
        }

        public Fraction Sub(int number)
        {
            var other = new Fraction(number, 1);
            return Sub(other);
        }

        public Fraction Mul(Fraction other)
        {
            int newNom = _nom * other._nom;
            int newDen = _den * other._den;
            return new Fraction(newNom, newDen);
        }

        public Fraction Mul(int number)
        {
            var other = new Fraction(number, 1);
            return Mul(other);
        }

        public Fraction Div(Fraction other)
        {
            if (other._nom == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
                return new Fraction(0, 1);
            }

            int newNom = _nom * other._den;
            int newDen = _den * other._nom;
            return new Fraction(newNom, newDen);
        }

        public Fraction Div(int number)
        {
            var other = new Fraction(number, 1);
            return Div(other);
        }

        public override string ToString()
        {
            return $"{_nom}/{_den}";
        }
    }
}
