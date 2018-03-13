//CONFIRMED from milchoarnaudov
using System;
class Program
{
    static void Main()
    {
        //We recieve width and height floating point numbers on the console
        double widthChanged = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        //We calculate the rectangle’s area, based on its width and height and we print it
        Console.WriteLine("{0:f2}",widthChanged*height);
    }
}