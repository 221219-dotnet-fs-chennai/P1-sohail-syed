using ClassLibrary1;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Addskills : IMenu
    {
        private static skills skill = new skills();
        // reading connection String from a file
        static string conStr = File.ReadAllText("C:/Users/ASUS/Azurelink.txt");
        IRepo<skills> repo = new SkillRepo(conStr);
        public void Display()
        {
            Console.WriteLine("Enter information");

            Console.WriteLine("[4] user_id - " + skill.user_id);
            Console.WriteLine("[3] skill_profficency - " + skill.skill_profficency);
            Console.WriteLine("[2] skill_name - " + skill.skill_name);

            Console.WriteLine("[1] Save");
            Console.WriteLine("[0] Go Back");

        }
        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "Menu";
                case "1":
                    //Exception handling to have a better user experience
                    try
                    {
                        Log.Information("Adding skills \n" + skill);
                        repo.Add(skill);
                        Log.Information("Successful at adding skills!");
                    }
                    catch (System.Exception exc)
                    {
                        Log.Error($"Failed to add skills - {exc.Message}");
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                    }
                    return "Menu";
                case "2":
                    Console.WriteLine("please enter skill_name");
                    skill.skill_name = Console.ReadLine();
                    return "Addskills";
                case "3":
                    Console.WriteLine("Please enter a skill_profficency");
                    skill.skill_profficency = Console.ReadLine();
                    return "Addskills";
                case "4":
                    Console.WriteLine("Please enter a user_id");
                    skill.user_id = Convert.ToInt32(Console.ReadLine());
                    return "Addskills";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "Addskills";

            }
        }
    }
}
