using System;
using System.Linq;
using System.Collections.Generic;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // number ofmessages to be generated

            AdvertSlogan advert = new AdvertSlogan();

            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events  = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities  = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            // setting the values of all the options of the class

            advert.Phrases = phrases;
            advert.Events  = events;
            advert.Authors = authors;
            advert.Cities  = cities;

            for (int i = 0; i < n; i++)
            {
                advert.Randomizer(advert);
            }
        }
    }
}
