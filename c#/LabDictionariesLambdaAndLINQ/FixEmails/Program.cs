using System;
using System.Linq;
using System.Collections.Generic;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mailBook = new Dictionary<string, string>();

            string name = Console.ReadLine();
            string email;

            while (name != "stop")
            {
                email = Console.ReadLine().ToLower();
                if (mailBook.ContainsKey(name))
                {
                    mailBook.Add(name, email);
                }
                else
                {
                    mailBook[name] = email;
                }

                name = Console.ReadLine();
            }

            foreach (var person in mailBook)
            {
                if (!person.Value.EndsWith(".uk") && !person.Value.EndsWith(".us"))
                {
                Console.WriteLine("{0} -> {1}",person.Key,person.Value);
                }
            }
        }
    }
}
