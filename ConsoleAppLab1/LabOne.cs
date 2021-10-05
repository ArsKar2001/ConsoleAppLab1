using System;
using static System.Console;

// ReSharper disable All

namespace ConsoleAppLab1
{
    /// <summary>
    /// Линейная программа и программа с ветвлениями
    /// </summary>
    public static class LabOne
    {
        /// <summary>
        /// Задание 3.9:
        /// Написать программу вычисления площади параллелограмма. Извне вводятся
        /// стороны a,b и угол между ними x.
        /// </summary>
        public static void ExecutionTask1()
        {
            WriteLine(
                "Написать программу вычисления площади параллелограмма. Извне вводятся стороны a,b и угол между ними x.");

            Write("Введите сторону А: ");
            var a = Convert.ToInt32(ReadLine());
            Write("Введите сторону B: ");
            var b = Convert.ToInt32(ReadLine());

            Write("Введите угол (в градусах): ");
            var axis = Convert.ToInt32(ReadLine());

            var rad = DegreesInRadians(axis);
            var s = a * b * Math.Sin(rad);

            WriteLine($"Площадь параллеограма: {Math.Round(s)}");
        }

        /// <summary>
        /// Задание 3.21(и):
        /// Не используя никакие арифметические действия, кроме умножения, записать
        /// операторы присваивания, которые позволят получить для заданного а:
        /// и) а^25 за 6 операций.
        /// </summary>
        public static void ExecutionTask2()
        {
            WriteLine(
                "Не используя никакие арифметические действия, кроме умножения, записать операторы присваивания, которые позволят получить для заданного а:");

            Write("Введите число А: ");
            var a = Convert.ToInt32(ReadLine());

            var a1 = (long) Math.Pow(a, 5);
            var a2 = (long) Math.Pow(a, 5);
            var a3 = (long) Math.Pow(a, 5);
            var a4 = (long) Math.Pow(a, 5);
            var a5 = (long) Math.Pow(a, 5);

            var a25 = a1 * a2 * a3 * a4 * a5;

            WriteLine($"a^25 = {a25}");
        }

        /// <summary>
        /// Задание 3.22(и):
        /// Не используя никакие арифметические действия, кроме умножения, записать операторы присваивания, которые позволят получить для заданного а:
        /// и) а^8 и а^47 за 6 операций;
        /// </summary>
        public static void ExecutionTask3()
        {
            WriteLine(
                "Не используя никакие арифметические действия, кроме умножения, записать операторы присваивания, которые позволят получить для заданного а:");

            Write("Введите число А: ");
            var a = Convert.ToInt32(ReadLine());

            var a8 = (long) Math.Pow(a, 8);
            var a16 = (long) Math.Pow(a8, 2);
            var a32 = (long) Math.Pow(a16, 2);
            var a40 = a32 * a8;
            var a48 = a40 * a8;
            var a47 = a48 / a;

            WriteLine($"a^8 = {a8}\n" +
                      $"a^47 = {a47}");
        }

        /// <summary>
        /// Задание 4.9:
        /// Даны действительные числа x1, x2, x3, y1, y2, y3. Принадлежит ли начало координат треугольнику с вершинами (x1, y1), (x2, y2), (x3, y3)?
        /// </summary>
        public static void ExecutionTask4()
        {
            WriteLine(
                "Даны действительные числа x1, x2, x3, y1, y2, y3. Принадлежит ли начало координат треугольнику с вершинами (x1, y1), (x2, y2), (x3, y3)?");

            var x1 = Convert.ToInt32(ReadLine());
            var y1 = Convert.ToInt32(ReadLine());

            var x2 = Convert.ToInt32(ReadLine());
            var y2 = Convert.ToInt32(ReadLine());

            var x3 = Convert.ToInt32(ReadLine());
            var y3 = Convert.ToInt32(ReadLine());

            WriteLine(
                (x1 == 0 && y1 == 0) || (x2 == 0 && y2 == 0) || (x3 == 0 && y3 == 0)
                    ? "Одна из вершин в начале координат."
                    : "Ниодна из вершин не в начале координат.");
        }

        private static double DegreesInRadians(double degree)
        {
            return (degree * Math.PI) / 180;
        }
    }
}