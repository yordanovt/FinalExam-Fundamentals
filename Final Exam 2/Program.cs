using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Final_Exam_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"!([A-Z][a-z]{3,})!:(\[([A-Za-z]{8,})\])");
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (pattern.IsMatch(input))
                {
                    Match match= pattern.Match(input);
                    string command = match.Groups[1].Value;
                    string wordtotranslate = match.Groups[3].Value;

                    byte[] asciiBytes = Encoding.ASCII.GetBytes(wordtotranslate).ToArray();

                    Console.WriteLine(command + ": " + string.Join(" ", asciiBytes));
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }

            }
        }
    }
}
