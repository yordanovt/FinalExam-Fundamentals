using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Dictionary<int, int> result = new Dictionary<int, int>();
            foreach (int num in input)
            {
                if (result.ContainsKey(num))
                {
                    result[num]++;
                }
                else
                {
                    result.Add(num, 1);
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
