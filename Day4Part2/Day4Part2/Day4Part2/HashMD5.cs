using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day4Part1
{
    class HashMD5
    {
        private bool doesMD5HashStartWithNZeros(MD5 md5Hash, string input, long quantity)
        {
            //array of bytes
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            if (quantity > data.Length)
                throw new ArgumentException();

            long half = quantity / 2;
            //  checking whole bytes
            for (int i = 0; i < half; i++)
                if (data[i] != 0)
                    return false;

            // getting rid of other half of byte
            if (quantity % 2 == 1)
            {
                if (data[half] > 0x0f)
                    return false;
            }
            return true;
        }

        public long FindLowestHashThatStartsWithNZeros(string key, long howMany)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                long counter = 0;
                string currentString = key + counter;

                while (!doesMD5HashStartWithNZeros(md5Hash, currentString, howMany))
                {
                    counter++;
                    currentString = key + counter;
                }
                return counter;
            }

        }
    }
}
