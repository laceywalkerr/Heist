using System;
using System.Collections.Generic;
using System.Linq;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Plan Your Heist!");
            string name = null;
            //creating an empty list

            List<TeamMember> Teammates = new List<TeamMember>();
            // while loop runs through the team members
            while (name != "")
            {
                Console.WriteLine("Add your new team members name: ");
                //breaks code if user does not enter a name
                if (name == "")
                {
                    break;
                }
                name = Console.ReadLine();
                Console.WriteLine("Enter skill level: ");
                int skillLevel = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter courage factor, pick between 0.0 - 2.0 : ");
                decimal courageFactor = int.Parse(Console.ReadLine());
                //creating the team members
                TeamMember newTeammate = new TeamMember()
                {
                    _name = name,
                    _skillLevel = skillLevel,
                    _courageFactor = courageFactor
                };

                Teammates.Add(newTeammate);

                foreach (TeamMember Teammate in Teammates)
                {
                    Console.WriteLine($"Team member info: {name} has a skill level of {skillLevel} and a courage factor of {courageFactor}");
                }

            };

            // foreach (Teammate in Teammates)
            // {
            //     Console.WriteLine($"Team member info: {name} has a skill level of {skillLevel} and a courage factor of {courageFactor}");
            // }

        }
    }
}