using System;
using System.Data;

namespace арифметическое_выражение
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            var numbers = new List<string>();
            numbers.Add (Console.ReadLine());
            bool go_on = true;
            AddMore();
            int i = 0;
            Console.Clear();
            Console.Write("Результат выражения: ");
            foreach (var action in numbers)
            {
                Console.Write(action);
            }
            Console.Write(" = ");
            var result = new DataTable().Compute(string.Join("", numbers), null);
            Console.Write(result);

            void AddMore()
            {
                while (go_on)
                {
                    Console.Clear();
                    Console.Write("Полученное выражение: ");
                    List();
                    Console.WriteLine("");
                    Console.WriteLine("выберите действие: ");
                    Console.WriteLine("1) добавить число");
                    Console.WriteLine("2) вычесть число");
                    Console.WriteLine("3) результат");
                    string input = Console.ReadLine();
                    if (input == "1")
                    {   
                        Console.Clear();
                        Console.Write("Полученное выражение: ");
                        List();
                        Console.WriteLine("Введите число, которое хотите сложить с предыдущим: ");
                        numbers.Add("+");
                        numbers.Add(Console.ReadLine());
                    }
                    else if (input == "2")
                    {
                        Console.Clear();
                        Console.Write("Полученное выражение: ");
                        List();
                        Console.WriteLine("Введите число, которое хотите вычесть из предыдущего: ");
                        numbers.Add("-");
                        numbers.Add(Console.ReadLine());
                    }
                    else if (input == "3")
                    {
                        go_on = false;
                    }
                    else
                    {
                        Console.WriteLine("Вы указали несуществующее действие");
                    }
                }
            }

            void List()
            {
                for (i = 0; i < numbers.Count; i++)
                {
                    Console.Write(numbers[i]);
                }
            }
        }
    }
}