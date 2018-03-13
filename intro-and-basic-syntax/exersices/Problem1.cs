using System;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //We receive 4 integers on the console
            int firstInt = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            //We print them in 4-digit debit card format
            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}", firstInt,b,c,d);

        }
    }

}