using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Final_Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                
                string[] comarr = command.Split(new char[] { ':', '|', ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (comarr[0] == "InsertSpace")
                {
                    message = message.Insert(int.Parse(comarr[1]), " ");
                    Console.WriteLine(message);
                }
                else if (comarr[0] == "Reverse")
                {
                    int checkindex = message.IndexOf(comarr[1]);
                    string cut = comarr[1];
                    if (checkindex == -1)
                    {
                        Console.WriteLine("error");
                    }
                    else { 
                    message = message.Remove(checkindex, cut.Length);
                    message = message + string.Join("", cut.Reverse());
                    Console.WriteLine(message);
                    }
                }
                else if (comarr[0] == "ChangeAll")
                {
                    string substring = comarr[1];
                    string toreplace = comarr[2];
                    message = message.Replace(substring, toreplace);
                    Console.WriteLine(message);   
                }
                
                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");

            //string input = Console.ReadLine();
            //string command = Console.ReadLine();


            //while (command != "Reveal")
            //{

            //    string [] commandarr = command.Split(new char[] { ':', '|', ':' }, StringSplitOptions.RemoveEmptyEntries)
            //        .ToArray();
            //    string commandtype = commandarr[0];
            //    //InsertSpace:|:{index}
            //    if (commandtype== "InsertSpace")
            //    {
            //        input = input.Insert(int.Parse(commandarr[1]), " ");
            //    }
            //    else if (commandtype == "Reverse")
            //    {
            //        string substring = commandarr[1];
            //        int wordindex = input.IndexOf(substring);
            //        input = input.Remove(wordindex,substring.Length);
            //        input = input + string.Join("", substring.Reverse());
            //    }
            //    else if (commandtype == "ChangeAll")
            //    {
            //        string substring = commandarr[1];
            //        string textoreplace = commandarr[2];
            //        input = input.Replace(substring, textoreplace);
            //    }
            //    Console.WriteLine(input);
            //    command = Console.ReadLine();

            //}
            //Console.WriteLine($"You have a new text message: {input}");
        }
    }
}
