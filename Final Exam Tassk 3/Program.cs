using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_Tassk_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstline = Console.ReadLine();
            string teacherexam = Console.ReadLine();
            string command = Console.ReadLine();
            var dicsyn = new Dictionary<string, List<string>>();
            string[] firstarr = firstline.Split(new string[] { " | ", ": " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] teacherexamArr = teacherexam.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int num = firstarr.Length;
            for (int i = 0; i < num; i += 2)
            {
                string word = firstarr[i];
                string synonym = firstarr[i + 1];

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
            if (command == "Hand Over")
            {
                foreach (var item in dicsyn)
                {
                    Console.WriteLine(item.Key);
                }
            }
            if (command == "Test")
            {
                for (int i = 0; i < teacherexamArr.Length; i++)
                {
                    if (dicsyn.ContainsKey(teacherexamArr[i]))
                    {
                        var result = dicsyn[teacherexamArr[i]];
                        Console.WriteLine(teacherexamArr[i] + ": \n -" + String.Join("\n -", result));    
                    }
                    
                }
                
            }

        }
    }
}
