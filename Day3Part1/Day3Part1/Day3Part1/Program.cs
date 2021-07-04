using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Part1
{
    public class Program
    {
        public int part1(string fileInput)
        {
            string input = fileInput;
            const int columns = 1000, rows = 1000;

            int[,] santaArray = new int[rows, columns];
            int santaX = columns / 2;
            int santaY = rows / 2;

            int result = 1;

            santaArray[santaX, santaY] = 1;

            foreach (char c in input)
            {
                if (santaArray[santaX, santaY] != 1)
                {
                    santaArray[santaX, santaY] = 1;
                    result += 1;
                }
                switch (c)
                {
                    case '^':
                        santaY--;
                        break;
                    case 'v':
                        santaY++;
                        break;
                    case '>':
                        santaX++;
                        break;
                    case '<':
                        santaX--;
                        break;
                    default:
                        break;
                }
            }
            return result;
        }

        public static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt");
            Program p = new Program();
            Console.WriteLine("Part 1: " + p.part1(input));
        }
    }
}
