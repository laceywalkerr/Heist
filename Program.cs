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

            List<TeamMember> teammates = new List<TeamMember>();
            // while loop runs through the team members
            while (name != "")
            {
                Console.WriteLine("Add your new team members name, or press enter to close and see your team: ");
                //breaks code if user does not enter a name
                name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
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

                teammates.Add(newTeammate);

                // foreach (TeamMember teammate in teammates)
                // {
                //     Console.WriteLine($"Team member info: {teammate._name} has a skill level of {teammate._skillLevel} and a courage factor of {teammate._courageFactor}");
                // };
                // Console.WriteLine($"Number of Teammates: {teammates.Count}");

            };

            Console.WriteLine("Enter how many times you would like to try to rob the bank with your team: ");
            int heistAttempts = int.Parse(Console.ReadLine());
            for (int num = 0; num < heistAttempts; num++)
            {
                int difficultyLevel = 100;
                int luckyNum = new Random().Next(-10, 10);
                int luckAndDifficulty = luckyNum + difficultyLevel;

                int teamSkillLevel = teammates.Sum(teammate => teammate._skillLevel);
                if (teamSkillLevel >= luckAndDifficulty)
                {
                    Console.WriteLine("You win! You got all the monies!");
                }
                else
                {
                    Console.WriteLine("Sorry, you got busted. Try building a stronger team next time!");
                }

                Console.WriteLine($"Team Skill Level: {teamSkillLevel}");
                Console.WriteLine($"Bank Difficulty Level: {luckAndDifficulty}");
                Console.WriteLine($"Testing View Random Luck Level: {luckyNum}");
            }

        }
    }
}