using System;
using System.IO;

namespace Day02
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

            var horizontalPosition = 0;
            var depth = 0;

            foreach (var instruction in input)
            {
                var command = instruction.Split(" ")[0];
                var value = int.Parse(instruction.Split(" ")[1]);

                switch (command)
                {
                    case "up":
                        depth -= value;
                        break;
                    case "down":
                        depth += value;
                        break;
                    case "forward":
                        horizontalPosition += value;
                        break;
                }
            }

            return horizontalPosition * depth;
        }

        private static int Part2()
        {
            var input = File.ReadAllLines("input.txt");

            var aim = 0;
            var horizontalPosition = 0;
            var depth = 0;

            foreach (var instruction in input)
            {
                var command = instruction.Split(" ")[0];
                var value = int.Parse(instruction.Split(" ")[1]);

                switch (command)
                {
                    case "up":
                        aim -= value;
                        break;
                    case "down":
                        aim += value;
                        break;
                    case "forward":
                        horizontalPosition += value;
                        depth += aim * value;
                        break;
                }
            }

            return horizontalPosition * depth;
        }
    }
}