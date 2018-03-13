using System;
class Program
{
    static void Main()
    {
		//Here we read the inputs that comes from the console
		//and parse them
        string name = Console.ReadLine();
        int current_health = int.Parse(Console.ReadLine());
        int maximum_health = int.Parse(Console.ReadLine());
        int current_energy = int.Parse(Console.ReadLine());
        int maxium_energy = int.Parse(Console.ReadLine());
         //and last we print name, health and energy to the console 
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Health: |{0}{1}|", new string('|', current_health), new string('.', maximum_health - current_health));
        Console.WriteLine("Energy: |{0}{1}|", new string('|', current_energy), new string('.', maxium_energy - current_energy));
    }
}