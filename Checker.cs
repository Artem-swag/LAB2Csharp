using System;

namespace pract
{
    public class Checker
    {
        public int ReadInt(string prompt)
        {
            int x = 0;
            bool isParsed = false;

            while (!isParsed)
            {
                Console.WriteLine(prompt);
                string? s = Console.ReadLine();

                if (int.TryParse(s, out x))
                {
                    isParsed = true;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод! Введите ещё раз.");
                }
            }

            return x;
        }

        public string ReadString(string prompt)
        {
            Console.WriteLine(prompt);
            string? s = Console.ReadLine();

            if (s == null)
            {
                return string.Empty;
            }

            return s.Trim();
        }

        public string ReadName(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string? s = Console.ReadLine();

                if (s == null)
                {
                    return string.Empty;
                }

                s = s.Trim();

                bool hasDigit = false;
                for (int i = 0; i < s.Length; i++)
                {
                    if (!char.IsLetter(s[i]) && s[i] != '-')
                    {
                        hasDigit = true;
                        break;
                    }
                }

                if (!hasDigit)
                {
                    return s;
                }

                Console.WriteLine("Ошибка! Только буквы и дефис.");
            }
        }
    }
}
