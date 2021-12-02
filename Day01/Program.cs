using System;
using System.IO;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First puzzle answer is: " + Part1());
            Console.WriteLine("Second puzzle answer is: " + Part2());
        }

        private static int Part1()
        {
            var input = File.ReadAllLines("input.txt");

            var counter = 0;
            var prevValue = int.Parse(input[0]);

            for (var i = 1; i < input.Length; i++)
            {
                var actualValue = int.Parse(input[i]);

                if (actualValue > prevValue)
                {
                    counter++;
                }

                prevValue = actualValue;
            }

            return counter;
        }

        private static int Part2()
        {
            var input = File.ReadAllLines("input.txt");

            var counter = 0;
            var prevValue = int.MaxValue;

            for (var i = 0; i < input.Length - 2; i++)
            {
                var actualValue = 0;

                for (var j = 0; j < 3; j++)
                {
                    actualValue += int.Parse(input[i + j]);
                }

                if (actualValue > prevValue)
                {
                    counter++;
                }

                prevValue = actualValue;
            }

            return counter;
        }
    }
}