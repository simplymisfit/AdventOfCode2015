using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Part1
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashMD5 hashMD5 = new HashMD5();

            string key = "bgvyzdsv";
            DateTime start = DateTime.Now;

            long fiveZerosResult = hashMD5.FindLowestHashThatStartsWithNZeros(key, 5);
            Console.WriteLine("With 5 zeros: {0}", fiveZerosResult);


            long sixZerosResult = hashMD5.FindLowestHashThatStartsWithNZeros(key, 6);
            Console.WriteLine("With 6 zeros: {0}", sixZerosResult);

            if (sixZerosResult <= fiveZerosResult)
                throw new Exception("Error");

            double numMilliseconds = (DateTime.Now - start).TotalMilliseconds;

            Console.WriteLine("{0} iterations in {1} milliseconds", fiveZerosResult, numMilliseconds);
        }
    }
}
