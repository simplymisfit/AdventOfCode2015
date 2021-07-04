using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Part2
{
    class Program
    {

        public int part2(string fileInput)
        {
            string input = fileInput;
            const int columns = 1000, rows = 1000;

            int[,] santaArray = new int[rows, columns];
            int[,] roboSantaArray = new int[rows, columns];
            int santaX = columns / 2;
            int santaY = rows / 2;
            int roboSantaX = columns / 2;
            int roboSantaY = rows / 2;

            int turn = 0;
            int result = 1;

            santaArray[santaX, santaY] = 1;
            roboSantaArray[roboSantaX, roboSantaY] = 1;

            foreach (char c in input)
            {
                if (santaArray[santaX, santaY] != 1)
                {
                    santaArray[santaX, santaY] = 1;
                    roboSantaArray[santaX, santaY] = 1;

                    result += 1;
                }
                if (roboSantaArray[roboSantaX,roboSantaY] != 1)
                {
                    roboSantaArray[roboSantaX, roboSantaY] = 1;
                    santaArray[roboSantaX, roboSantaY] = 1;

                    result += 1;
                }

                switch (c)
                {
                    case '^':
                        if (turn % 2 == 0)
                            santaY--;
                        else
                            roboSantaY--;
                        break;
                    case 'v':
                        if (turn % 2 == 0)
                            santaY++;
                        else
                            roboSantaY++;
                        break;
                    case '>':
                        if (turn % 2 == 0)
                            santaX++;
                        else
                            roboSantaX++;
                        break;
                    case '<':
                        if (turn % 2 == 0)
                            santaX--;
                        else
                            roboSantaX--;
                        break;
                    default:
                        break;
                }
                turn += 1;
            }
            return result;
        }
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt");
            Program p = new Program();
            Console.WriteLine("Part 1: " + p.part2(input));
        }
    }
}
