using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Part1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(File.ReadAllLines(@"input.txt")
            .Select(s => s.Split('x'))
            .Select(x => x.Select(Int32.Parse))
            .Select(w => w.OrderBy(x => x).ToArray())
            .Select(w => 3 * w[0] * w[1] + 2 * w[0] * w[2] + 2 * w[1] * w[2])
            .Sum());

        }
    }
}
