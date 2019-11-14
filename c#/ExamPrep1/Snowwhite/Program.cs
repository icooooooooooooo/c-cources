using System;
using System.Linq;
using System.Collections.Generic;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            List<Dwarf> crew = new List<Dwarf>();

            while(input!= "Once upon a time")
            {
                List<string> specs = input.Split(" <:> ").ToList();
                string name = specs[0];
                string hat = specs[1];
                int phisics = int.Parse(specs[2]);


                Dwarf dwarf = new Dwarf();
                dwarf.Name = specs[0];
                dwarf.Hat = specs[1];
                dwarf.Phisics = int.Parse(specs[2]);

                //•	If 2 dwarfs have the same name and the same color, store the one with the higher physics.
                crew.Add(dwarf);                                          
                              
                input = Console.ReadLine();
            }

            for (int i = 0; i < crew.Count; i++)
            {
                for (int j = 0; j < crew.Count; j++)
                {
                   
                    if ( crew[i].Name == crew[j].Name && crew[i].Hat == crew[j].Hat && crew[i].Phisics < crew[j].Phisics)
                    {
                        crew.RemoveAt(i);
                    }
                }
                
            }

            foreach (var member in crew.OrderByDescending(x=>x.Phisics).ThenBy(x=>x.Hat))
            {
                Console.WriteLine($"({member.Hat}) {member.Name} <-> {member.Phisics}");
            }
        }
    }
    class Dwarf
    {
        public string Hat { get; set; }
        public string Name { get; set; }
        public int Phisics { get; set; }
    }
}
