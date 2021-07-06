using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Part1
{
    class Program
    {
        public object PartOne(string input) =>
            input.Split('\n').Count(line => {
                var threeVowels = line.Count(ch => "aeiou".Contains(ch)) >= 3;
                var duplicate = Enumerable.Range(0, line.Length - 1).Any(i => line[i] == line[i + 1]);
                var reserved = "ab,cd,pq,xy".Split(',').Any(line.Contains);
                return threeVowels && duplicate && !reserved;
            });

        object part1(string input) =>
            //using split to get lines and use count on them
            input.Split('\n').Count(
                line =>
                {
                    //if string contains 3 or more, count it
                    var threeVowels = line.Count(c => "aeiou".Contains(c)) >= 3;
                    //if this line has any doubled letter, count it
                    var doubleLetter = Enumerable.Range(line.Length, line.Length + 1).Any(i => line[i] == line[i+1]);
                    //from 'ab,cd,pq,xy' if any string contains them, count in so we can exclude them in return
                    var forbiddenStrings = "ab,cd,pq,xy".Split(',').Any(line.Contains);
                    //nice string should containt three vowels and double letters
                    //and should not contain forbidden strings like 'ab,cd,pq,xy'
                    return threeVowels && doubleLetter && !forbiddenStrings;
                }
            );

        static void Main(string[] args)
        {
            var input = File.ReadAllText(@"input.txt");

            Program p = new Program();

            p.part1(input);
        }
    }
}
