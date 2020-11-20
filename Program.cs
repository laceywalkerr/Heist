using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("Add your new team members name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter skill level: ");
            int skillLevel = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter courage factor, pick between 0.0 - 2.0 : ");
            decimal courageFactor = int.Parse(Console.ReadLine());

            Console.WriteLine($"Team member info: {name} has a skill level of {skillLevel} and a courage factor of {courageFactor}");
        }

    }
}