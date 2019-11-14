using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            ReceiptHeader();
            ReceiptBody();
            ReceiptFooter();
        }

        private static void ReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void ReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void ReceiptFooter()
        {
            Console.WriteLine("-----------------------------\n© SoftUni");
        }
    }
}
