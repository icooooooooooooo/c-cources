using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            int entities = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> priceList = new Dictionary<string, decimal>();
            string beverage;
            decimal price;
            Shop shop = new Shop();


            for (int i = 0; i < entities; i++)
            {
                string[] input = Console.ReadLine().Split('-').ToArray();
                // shop.PriceList.Add(input[0], decimal.Parse(input[1]));

                beverage = input[0];
                price = decimal.Parse(input[1]);
                // if (shop.PriceList.ContainsKey(input[0]))
                // {
                // 
                // }
                if (priceList.ContainsKey(beverage))
                {
                    priceList[beverage] = price;
                }
                else
                {
                    priceList.Add(beverage,price);
                }

            }
            shop.PriceList = priceList;

            Customer customer = new Customer();
            List<Customer> helper = new List<Customer>(); 
            Dictionary<string, Dictionary<string, int>> purchasesPerName = new Dictionary<string, Dictionary<string, int>>();
            
            string command = Console.ReadLine();
            while (command != "end of clients")
            {
                string[] input = command.Split(new char[] { '-', ',' }).ToArray();
                string name = input[0];
                Dictionary<string,int> purchase = new Dictionary<string, int>();
                purchase.Add(input[1], int.Parse(input[2]));
                

                customer.Name = name;
                customer.Purchases.Add(input[1], int.Parse(input[2]));

                helper.Add(customer);

                if (purchasesPerName.Any(x => x.Key == name))
                {
                    if (purchasesPerName[name].Any(x=> x.Key == input[1]))
                    {
                        foreach (var person in purchasesPerName.Where(x => x.Key==input[1]))
                        {
                            person.Value.Add(input[1], int.Parse(input[2]));
                            person.Value.Any(x => x.Value(y => y.Value += purchase));


                            //here the issue I am experiencing is to address the proper part of the object with a lambda expression.
                        }
                        // purchase[name][input[1]].
                    }
                    else
                    {

                    }

                }
                else
                {

                }

                command = Console.ReadLine();
            }

        }
    }
    
    class Shop
    {
        public Dictionary<string,decimal> PriceList { get; set; }
    }

    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string,int> Purchases { get; set; }

        public void IncrementQuantity()
        {

        }
        //here I am trying to create a method,where the purchased items will increase with the new input valuee
        // public Dictionary<string, int> Bill
        // {
        //    set  
        //     {
        //         Shop pricelist = new Shop();
        //         foreach (var beverage in Purchases)
        //         {
        //             if (pricelist[beverage] )
        //             return beverage.Key * beverage.Value;
        //         }
        //     }
        // }    
    }
}
