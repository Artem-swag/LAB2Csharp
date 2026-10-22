using pract;
using System;

namespace Lab_02
{
    internal class Program
    {
        private static Checker _checker = new Checker();

        private static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("    ЛАБОРАТОРНАЯ РАБОТА 2 (Вариант 5)    ");
                Console.WriteLine("1. Задание 1.1 - Точка");
                Console.WriteLine("2. Задание 1.3 - Имена");
                Console.WriteLine("3. Задание 2.1 - Прямая");
                Console.WriteLine("4. Задание 3.3 - Города (граф с картинки)");
                Console.WriteLine("5. Задание 4.8 - Город (с путями)");
                Console.WriteLine("6. Задание 5.5 - Дроби");
                Console.WriteLine("0. Выход");

                int choice = _checker.ReadInt("Выберите пункт меню: ");

                switch (choice)
                {
                    case 1:
                        DemoPoint();
                        break;
                    case 2:
                        DemoName();
                        break;
                    case 3:
                        DemoLine();
                        break;
                    case 4:
                        DemoCityGraph();
                        break;
                    case 5:
                        DemoCityNew();
                        break;
                    case 6:
                        DemoFraction();
                        break;
                    case 0:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Нет такого пункта.");
                        break;
                }
            }
        }

        private static void DemoPoint()
        {
            Console.WriteLine("\n Задание 1.1: Точка ");
            Console.WriteLine("Создадим три точки. Введите их координаты.");

            int x1 = _checker.ReadInt("Введите X для 1-й точки: ");
            int y1 = _checker.ReadInt("Введите Y для 1-й точки: ");
            var p1 = new Coordinate_point(x1, y1);

            int x2 = _checker.ReadInt("Введите X для 2-й точки: ");
            int y2 = _checker.ReadInt("Введите Y для 2-й точки: ");
            var p2 = new Coordinate_point(x2, y2);

            int x3 = _checker.ReadInt("Введите X для 3-й точки: ");
            int y3 = _checker.ReadInt("Введите Y для 3-й точки: ");
            var p3 = new Coordinate_point(x3, y3);

            Console.WriteLine("\nСозданные точки:");
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p3.ToString());
        }

        private static void DemoName()
        {
            Console.WriteLine("\n Задание 1.3: Имена (создание 3 объектов) ");
            Console.WriteLine("Создадим 3 имени. Если параметра нет, просто нажмите Enter.\n");

            Console.WriteLine("Введите данные для 1-го имени:");
            string surname1 = _checker.ReadString("Фамилия (Enter, если нет): ");
            string name1 = _checker.ReadString("Имя (Enter, если нет): ");
            string patronymic1 = _checker.ReadString("Отчество (Enter, если нет): ");
            var fullname1 = new Fullname(name1, surname1, patronymic1);

            Console.WriteLine("\nВведите данные для 2-го имени:");
            string surname2 = _checker.ReadString("Фамилия (Enter, если нет): ");
            string name2 = _checker.ReadString("Имя (Enter, если нет): ");
            string patronymic2 = _checker.ReadString("Отчество (Enter, если нет): ");
            var fullname2 = new Fullname(name2, surname2, patronymic2);

            Console.WriteLine("\nВведите данные для 3-го имени:");
            string surname3 = _checker.ReadString("Фамилия (Enter, если нет): ");
            string name3 = _checker.ReadString("Имя (Enter, если нет): ");
            string patronymic3 = _checker.ReadString("Отчество (Enter, если нет): ");
            var fullname3 = new Fullname(name3, surname3, patronymic3);

            Console.WriteLine("\n Результаты ");
            Console.WriteLine($"Имя 1: {fullname1}");
            Console.WriteLine($"Имя 2: {fullname2}");
            Console.WriteLine($"Имя 3: {fullname3}");
        }

        private static void DemoLine()
        {
            Console.WriteLine("\n Задание 2.1: Прямая ");

            Console.WriteLine("\nВведите координаты для Линии 1:");
            int x1Start = _checker.ReadInt("X начала: ");
            int y1Start = _checker.ReadInt("Y начала: ");
            var start1 = new Coordinate_point(x1Start, y1Start);

            int x1End = _checker.ReadInt("X конца: ");
            int y1End = _checker.ReadInt("Y конца: ");
            var end1 = new Coordinate_point(x1End, y1End);
            var line1 = new Line(start1, end1);

            Console.WriteLine("\nВведите координаты для Линии 2 (по заданию: Y=10, X от 5 до 25):");
            int x2Start = _checker.ReadInt("X начала: ");
            int y2Start = _checker.ReadInt("Y начала: ");
            var start2 = new Coordinate_point(x2Start, y2Start);

            int x2End = _checker.ReadInt("X конца: ");
            int y2End = _checker.ReadInt("Y конца: ");
            var end2 = new Coordinate_point(x2End, y2End);
            var line2 = new Line(start2, end2);

            var line3 = new Line(line1.StartLine, line2.EndLine);

            Console.WriteLine("\nИсходное состояние:");
            Console.WriteLine($"Линия 1: {line1}");
            Console.WriteLine($"Линия 2: {line2}");
            Console.WriteLine($"Линия 3: {line3}");

            Console.WriteLine("\n Пункт 4: Меняем координаты Л1 и Л2 ");
            int newX1 = _checker.ReadInt("Введите новый X начала Линии 1 (Л3 изменится): ");
            line1.StartLine.X = newX1;

            int newY2 = _checker.ReadInt("Введите новый Y конца Линии 2 (Л3 изменится): ");
            line2.EndLine.Y = newY2;

            Console.WriteLine("\nРезультат изменений (Л3 изменилась):");
            Console.WriteLine($"Линия 1: {line1}");
            Console.WriteLine($"Линия 2: {line2}");
            Console.WriteLine($"Линия 3: {line3}");

            Console.WriteLine("\n Пункт 5: Меняем конец Л1 (Л3 НЕ должна измениться) ");
            int newXEnd1 = _checker.ReadInt("Введите новый X конца Линии 1 (Л3 не изменится): ");
            line1.EndLine.X = newXEnd1;

            Console.WriteLine("\nРезультат (Л1 изменилась, Л3 осталась прежней):");
            Console.WriteLine($"Линия 1: {line1}");
            Console.WriteLine($"Линия 3: {line3}");
        }

        private static void DemoCityGraph()
        {
            Console.WriteLine("\n Задание 3.3: Города (граф) ");
            Console.WriteLine("Строим граф с картинки (A, B, C, D, E, F)...");

            var a = new City("A");
            var b = new City("B");
            var c = new City("C");
            var d = new City("D");
            var e = new City("E");
            var f = new City("F");

            a.AddWay(b, 5);
            a.AddWay(f, 1);
            a.AddWay(d, 6);

            b.AddWay(a, 5);
            b.AddWay(c, 3);
            b.AddWay(f, 1);

            f.AddWay(a, 1);
            f.AddWay(b, 1);
            f.AddWay(e, 2);

            e.AddWay(d, 2);
            e.AddWay(f, 2);

            d.AddWay(a, 6);
            d.AddWay(e, 2);
            d.AddWay(c, 4);

            c.AddWay(b, 3);
            c.AddWay(d, 4);

            Console.WriteLine($"Город A: {a}");
            Console.WriteLine($"Город B: {b}");
            Console.WriteLine($"Город C: {c}");
            Console.WriteLine($"Город D: {d}");
            Console.WriteLine($"Город E: {e}");
            Console.WriteLine($"Город F: {f}");
        }

        private static void DemoCityNew()
        {
            Console.WriteLine("\n Задание 4.8: Новый конструктор Города ");

            string name = _checker.ReadString("Введите название главного города: ");
            string neighbor = _checker.ReadString("Введите название города-соседа: ");
            int cost = _checker.ReadInt("Введите стоимость пути до соседа: ");

            var neighborCity = new City(neighbor);

            var paths = new Way[1];
            paths[0] = new Way(neighborCity, cost);

            var newCity = new City(name, paths);

            Console.WriteLine($"\nСоздан город: {newCity}");
        }

        private static void DemoFraction()
        {
            Console.WriteLine("\n Задание 5.5: Дроби ");

            Console.WriteLine("Введите первую дробь:");
            int n1 = _checker.ReadInt("Числитель: ");
            int d1 = _checker.ReadInt("Знаменатель: ");
            var f1 = new Fraction(n1, d1);

            Console.WriteLine("Введите вторую дробь:");
            int n2 = _checker.ReadInt("Числитель: ");
            int d2 = _checker.ReadInt("Знаменатель: ");
            var f2 = new Fraction(n2, d2);

            Console.WriteLine("\nРезультаты операций:");
            Console.WriteLine($"{f1} + {f2} = {f1.Add(f2)}");
            Console.WriteLine($"{f1} - {f2} = {f1.Sub(f2)}");
            Console.WriteLine($"{f1} * {f2} = {f1.Mul(f2)}");
            Console.WriteLine($"{f1} / {f2} = {f1.Div(f2)}");
        }
    }
}