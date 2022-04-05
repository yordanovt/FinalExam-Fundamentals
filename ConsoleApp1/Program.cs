using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var dicsyn = new Dictionary<string, List<string>>();

            for (int i = 0; i < number; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!dicsyn.ContainsKey(word))
                {
                    
                    dicsyn.Add(word, new List<string>());
                    dicsyn[word].Add(synonym);
                }
                else
                {
                    dicsyn[word].Add(synonym);
                }
                
            }
            foreach (var item in dicsyn)
            {
                Console.WriteLine(item.Key + " - " + string.Join(", ", item.Value));
            }
           
        }
    }
}
