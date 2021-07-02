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
        public static void Main(string[] args)
        {

            Console.WriteLine(  
                File.ReadAllText("input.txt")
                .Scan(new { x = 0, y = 0 }, (state, c) =>
                c == '>' ? new { x = state.x + 1, y = state.y } :
                c == '^' ? new { x = state.x, y = state.y + 1 } :
                c == '<' ? new { x = state.x - 1, y = state.y } :
                           new { x = state.x, y = state.y - 1 })
                .Select(p => String.Format("{0},{1}", p.x, p.y))
                .GroupBy(p => p)
                .Count()
             );


        }
    }
}
