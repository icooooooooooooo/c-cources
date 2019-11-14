using System.Linq;
using System;
using System.Collections.Generic;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();

            List<string> input = Console.ReadLine().Split(new char[] {':',' ',','},StringSplitOptions.RemoveEmptyEntries).ToList();
            int sum=0;
            List<string> cards = new List<string>(); 
            string name="";



            while (input[0] != "JOKER")
            {
                name = input[0];
                cards = input.Skip(1).ToList();
                cards = cards.Distinct().ToList();

                if (!players.ContainsKey(name))
                {
                    players.Add(name, cards);
                }
                else
                {                    
                    players[name].AddRange(cards);
                    players[name]= players[name].Distinct().ToList();
                }

                input = Console.ReadLine().Split(new char[] { ':',' ',','},StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            int multiplier=0;
            int mainValue=0;

            foreach (var player in players)
            {
                foreach (var card in player.Value)
                {
                    switch (card[card.Length - 1])
                    {
                        case 'S':
                            multiplier = 4;
                            break;
                        case 'H':
                            multiplier = 3;
                            break;
                        case 'D':
                            multiplier = 2;
                            break;
                        case 'C':
                            multiplier = 1;
                            break;
                    }

                    /*
                     * The issue here is that I cannot remove the last character from the card, in order to read and parse it, as is.
                     */
                    string current = card.Remove(card.Length-1,1);

                    switch (current)
                    {
                        case "J":
                            mainValue = 11;
                            break;
                        case "Q":
                            mainValue = 12;
                            break;
                        case "K":
                            mainValue = 13;
                            break;
                        case "A":
                            mainValue = 14;
                            break;
                        default:
                            mainValue = int.Parse(current);
                            break;
                    }
                    sum += multiplier * mainValue;
                }
                Console.WriteLine("{0} -> {1}",player.Key,sum);
                sum = 0;
            }
        }
    }
}
