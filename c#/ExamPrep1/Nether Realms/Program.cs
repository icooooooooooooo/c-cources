using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            SortedDictionary<string, Character> heroes = new SortedDictionary<string, Character>();

            for (int i = 0; i < input.Length; i++)
            {
                Character hero = new Character();

                Regex rHealth = new Regex(@"([A-Za-z]*)");
                MatchCollection healthRunes = rHealth.Matches(input[i]);
                StringBuilder health = new StringBuilder();
                foreach (Match part in healthRunes)
                {
                    health.Append(part);
                }
                var healthCalc = health.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                int healthNum = 0;
                StringBuilder healthChar = new StringBuilder();
                for (int j = 0; j < healthCalc.Count; j++)
                {
                    healthChar.Append(healthCalc[j].ToCharArray());
                }

                for (int k = 0; k < healthChar.Length; k++)
                {
                    healthNum += healthChar[k];
                }
                hero.Health = (double)healthNum;


                Regex rDamage = new Regex(@"[+-\/*]{0,1}[0-9]*\.*[0-9]*");
                MatchCollection damageRunes = rDamage.Matches(input[i]);
                List<string> damage = new List<string>();

                foreach (Match rune in damageRunes)
                {
                    if (!rune.Value.Equals(string.Empty))
                    {
                        if (rDamage.IsMatch(rune.ToString()))
                        {
                            damage.Add(rune.ToString());
                        }
                    }
                }
                double heroDamage = 0;
                for (int l = 0; l < damage.Count; l++)
                {
                    if (!(damage[l].Equals("/")||damage[l].Equals("*")))
                    {
                        string character = damage[l];
                        double num = double.Parse(damage[l]);
                        heroDamage += num;
                    }
                    else if (damage[l].Equals("*"))
                    {
                        heroDamage *= 2;
                    }
                    else if (damage[l].Equals("/"))
                    {
                        heroDamage /= 2;
                    }
                }
                hero.Damage = heroDamage;

                heroes.Add(input[i], hero);
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine($"{hero.Key} - {hero.Value.Health:f2} health, {hero.Value.Damage:f2} damage");
            }

        }

        public class Character
        {
            public double Health { get; set; }
            public double Damage { get; set; }
        }
    }
}
