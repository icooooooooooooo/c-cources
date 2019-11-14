using System;
using System.Collections.Generic;
using System.Text;

namespace AdvertisementMessage
{
    class AdvertSlogan
    {
        public string[] Phrases { get; set; }  //{"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."}
        public string[] Events { get; set; }  //{"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"}
        public string[] Authors { get; set; }  //{"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"}
        public string[] Cities { get; set; }  //{"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}


        public void Randomizer(AdvertSlogan obj)
        {
            //AdvertSlogan obj = new AdvertSlogan();

            int ph = obj.Phrases.Length;
            int ev = obj.Events.Length;
            int au = obj.Authors.Length;
            int ci = obj.Cities.Length;

            Random random = new Random();

            Console.WriteLine("{0}, {1}, {2}, {3}",Phrases[random.Next(0, ph)], Events[random.Next(0, ev)], Authors[random.Next(0, au)], Cities[random.Next(0, ci)]);
        } 
    }
}

