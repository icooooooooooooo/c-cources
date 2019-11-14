using System;
using System.Linq;
using System.Collections.Generic;

namespace Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries).ToList(); //  { pokemonName} -> { evolutionType} -> { evolutionIndex}
            Dictionary<string, List<Evolution>> database = new Dictionary<string, List<Evolution>>();

            while (data[0].Trim() != "wubbalubbadubdub")
            {
                string name = data[0].Trim();              

                if (data.Count>1)
                {
                    string pokeType = data[1].Trim();
                    int evolution = int.Parse(data[2]);

                    Evolution pokemon = new Evolution();
                    pokemon.PokeType = pokeType;
                    pokemon.EvolutionPoints = evolution;
                    List<Evolution> pokelution = new List<Evolution>();
                    if (!database.ContainsKey(name))
                    {
                        pokelution.Add(pokemon);
                        database.Add(name, pokelution);
                    }
                    else
                    {
                        database[name].Add(pokemon);
                    }
                }
                else if(data.Count==1)
                {
                    foreach (var unit in database)
                    {
                        //Console.WriteLine(unit.Key.ToString()); testing 
                        if (unit.Key.Equals(name))
                        {
                            Console.WriteLine($"#{name}");
                            foreach (var evos in unit.Value)
                            {
                                Console.WriteLine($"{{{evos.PokeType}}} <-> {{{evos.EvolutionPoints}}}");
                            }
                        }
                    }
                }
                data = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries).ToList();
            }


            foreach (var item in database)
            {
                Console.WriteLine($"# {item.Key} ");
                foreach (var line in item.Value.OrderByDescending(x=>x.EvolutionPoints))
                {
                    Console.WriteLine($"{{{line.PokeType}}} <-> {{{line.EvolutionPoints}}}");                   
                }
            }

        }
    }

    class Evolution
    {
        //public string PokeName { get; set; } - this is the name of the Dict at the top and obsolete for now
        public string PokeType { get; set; }
        public int EvolutionPoints { get; set; }

    }
}
