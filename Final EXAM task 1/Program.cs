using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_EXAM_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string message = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] comarr = command.Split(' ').ToArray();
                string comtype = comarr[0];

                if (comtype == "Translate")
                {
                    string substring = comarr[1];
                    string toreplace = comarr[2];
                    message = message.Replace(substring, toreplace);
                    Console.WriteLine(message);

                }
                else if (comtype == "Includes")
                {
                    bool result = message.Contains(comarr[1]);
                    Console.WriteLine(result);
                }
                else if (comtype == "Start")
                {
                    bool result = message.StartsWith(comarr[1]);
                    Console.WriteLine(result);
                }
                else if (comtype == "Lowercase")
                {
                    message = message.ToLower();
                    Console.WriteLine(message);
                }
                else if (comtype == "FindIndex")
                {
                    int result = message.LastIndexOf(comarr[1]);
                    Console.WriteLine(result);
                }
                else if (comtype == "Remove")
                {
                    message = message.Remove(int.Parse(comarr[1]), int.Parse(comarr[2]));
                    Console.WriteLine(message);
                }

                command = Console.ReadLine();
            }
            

        }
    }
}
