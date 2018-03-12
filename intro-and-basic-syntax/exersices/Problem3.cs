using System;
class Program
{
    static void Main()
    {
		//we read the miles and parse them 
        double mile = double.Parse(Console.ReadLine());
		//and then print the to the console
        Console.WriteLine("{0:f2}", mile * 1.60934);
    }
}