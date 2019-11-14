using System;
using System.Linq;
using System.Collections.Generic;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string,Dictionary<string,int>> logs = new SortedDictionary<string, Dictionary<string, int>>();
            List<string> input = Console.ReadLine().Split(' ').ToList();

            string user;
            string message;
            string ip;
            //IP=192.23.30.40 message='Hello&derps.' user=destroyer
            while (!(input[0] == "end"))
            {
                string[] userInput = input[2].Split("=").ToArray();
                string[] ipInput = input[0].Split("=").ToArray();
                string[] messageInput = input[1].Split("=").ToArray();

                user = userInput[1];
                message = messageInput[1];
                ip = ipInput[1];


                if (!logs.ContainsKey(user))
                {
                    Dictionary<string, int> embedded = new Dictionary<string, int>();
                    embedded.Add(ip, 1);
                    logs.Add(user, embedded);
                }
                else
                {
                    if (!logs[user].ContainsKey(ip))
                    {
                        logs[user].Add(ip, 1);
                    }
                    else
                    {
                        logs[user][ip]++;
                    }
                }

                input = Console.ReadLine().Split(' ').ToList();
            }


            foreach (var username in logs)
            {
                Console.WriteLine($"{username.Key}:");
                List<string> assistant = new List<string>();

                foreach (var ipPair in username.Value)
                {
                    assistant.Add($"{ipPair.Key} => {ipPair.Value}");
                }
                Console.Write(string.Join(",", assistant));
                Console.Write(".");
                Console.WriteLine(" ");
            }
        }
    }
}
