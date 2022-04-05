using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Final_Pirates__dictionary_
{
    internal class Program
    {
        public class City
        {
            public City (string name, int population, int gold)
            {
                this.Name = name;
                this.Population = population;
                this.Gold = gold;
            }
            public string Name { get; set; }
            public int Population { get; set; }
            public int Gold { get; set; }
        }
        static void Main(string[] args)
        {
            string firstcommand = Console.ReadLine();
            var Cities = new Dictionary<string, City>();

            while (firstcommand != "Sail")
            {
                string [] firstcommandArr = firstcommand.Split(new char[] {'|','|'}, StringSplitOptions.RemoveEmptyEntries);
                string city = firstcommandArr[0];
                int population = int.Parse(firstcommandArr[1]);
                int gold = int.Parse(firstcommandArr[2]);

                if (Cities.ContainsKey(city))
                {
                    Cities[city].Population += population;
                    Cities[city].Gold += gold;
                }
                else 
                {
                    var newcity = new City(city, population, gold);
                    Cities.Add(city, newcity);
                }
                firstcommand = Console.ReadLine();
            }
            string secondcommand = Console.ReadLine();
            while (secondcommand!="End")
            {
                string[] secondcommandArr = secondcommand.Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string scommandtype = secondcommandArr[0];
                
                if (scommandtype == "Plunder")
                {
                    string citytoplunder = secondcommandArr[1];
                    int people = int.Parse(secondcommandArr[2]);
                    int gold = int.Parse(secondcommandArr[3]);

                    Cities[citytoplunder].Population -= people;
                    Cities[citytoplunder].Gold -= gold;

                    Console.WriteLine($"{Cities[citytoplunder].Name} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (Cities[citytoplunder].Population <= 0 || Cities[citytoplunder].Gold <= 0)
                    {
                        Console.WriteLine($"{citytoplunder} has been wiped off the map!");
                        Cities.Remove(citytoplunder);

                    }
                    
                    
                }
                else
                {
                    string nameoftown = secondcommandArr[1];
                    int goldtoAdd = int.Parse(secondcommandArr[2]);

                    if (goldtoAdd < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        secondcommand = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        Cities[nameoftown].Gold += goldtoAdd;
                        Console.WriteLine($"{goldtoAdd} gold added to the city treasury. {nameoftown} now has {Cities[nameoftown].Gold} gold.");
                    }
                }
                

                secondcommand = Console.ReadLine();
            }
            if (Cities.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {Cities.Count} wealthy settlements to go to:");
                foreach (var item in Cities)
                {
                    Console.WriteLine($"{item.Value.Name} -> Population: {item.Value.Population} citizens, Gold: {item.Value.Gold} kg ");
                }
            }
        }
    }
}
