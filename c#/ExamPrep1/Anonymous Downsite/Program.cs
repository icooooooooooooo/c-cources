using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Numerics;

namespace Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	On the first input line you will get N – the count of affected websites.
            //•	On the second input line you will the security key.
            //•	On the next N input lines you will get data about the websites.

            int affected = int.Parse(Console.ReadLine());
            int security = int.Parse(Console.ReadLine());

            List<Site> sites = new List<Site>();

            for (int i = 0; i < affected; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                Site site = new Site();
                site.Name = input[0];
                site.Visits = BigInteger.Parse(input[1]);
                site.Price = double.Parse(input[2]);
                sites.Add(site);
            }
            decimal loss = 0;

            
            foreach (Site site in sites)
            {
                Console.WriteLine(site.Name);

                loss += (decimal)site.Visits * (decimal)site.Price;

            }

            int securityToken = 1;
            for (int i = 0; i < affected; i++)
            {
                //I do not feel like casting
                securityToken *= security;
            }

            Console.WriteLine($"Total Loss: {loss:f20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }

    class Site
    {
        public string Name { get; set; }
        public BigInteger Visits { get; set; }
        public double Price { get; set; }
    }
}
