using System;
using static System.Console;

// ReSharper disable All

namespace ConsoleAppLab1
{
    internal static class LabOneProgram
    {
        public static void Main(string[] args)
        {
            ExecutionLabOne();
        }

        private static void ExecutionLabOne()
        {
            while (true)
            {
                WriteLine("Введите номер задания:\n" +
                          "\t1. 3.9\n" +
                          "\t2. 3.21(k)\n" +
                          "\t3. 3.22(и)\n" +
                          "\t4. 4.9");
                var task = ReadLine();
                switch (task)
                {
                    case "1":
                        LabOne.ExecutionTask1();
                        break;
                    case "2":
                        LabOne.ExecutionTask2();
                        break;
                    case "3":
                        LabOne.ExecutionTask3();
                        break;
                    case "4":
                        LabOne.ExecutionTask4();
                        break;
                    default:
                        WriteLine($"Ошибка: неизвестная команда: {task}");
                        break;
                }
            }
        }
    }
}