using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
                count++;

            }
            Console.WriteLine(input[3]);

            string word = "tonilom";
            string reversedword = string.Join("", word.Reverse());
            Console.WriteLine(word);
            Console.WriteLine(reversedword);
            Console.WriteLine(word.Length);
        }
    }
}
