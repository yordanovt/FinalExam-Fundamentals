using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2_Final_Fancy_Barcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex("[0-9]");
            int barcnum = int.Parse(Console.ReadLine());
            for (int i = 0; i < barcnum; i++)
            {
                string barcode = Console.ReadLine();
                
                if (pattern.IsMatch(barcode))
                {
                    char[] result = barcode.Where(x => char.IsDigit(x)).ToArray();
                    Console.WriteLine(result);
                }
                
            }

            //string input = Console.ReadLine();
            //Regex pattern = new Regex("[toni]");
            //MatchCollection result = pattern.Matches(input);

            //foreach (Match item in result)
            //{
            //    Console.Write(item);

            //}
        }
    }
}
