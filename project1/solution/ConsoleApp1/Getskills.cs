﻿using ClassLibrary1;

using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Getskills : IMenu
    {
        static string conStr = File.ReadAllText("C:/Users/ASUS/Azurelink.txt");

        IRepo<skills> repo = new SkillRepo(conStr);
        public void Display()
        {
            Console.WriteLine("Please select an option to filter the UserDetails reviews database");
            Console.WriteLine("[1] All skills");
            Console.WriteLine("[0] Go back");

        }
        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "TrainerLogin";
                case "1":
                    //Logic to display the result
                    Log.Information("Getting all skills");
                    var listOfDetails = repo.GetAllDetails();
                    Log.Information($"Got list of {listOfDetails.Count} skills");
                    Log.Information("Reading skills about to start");
                    foreach (var r in listOfDetails)
                    {
                        Console.WriteLine("================");
                        Console.WriteLine(r.ToString());
                    }
                    Log.Information("Reading skills ends");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();

                    return "Menu";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "GetDetails";

            }
        }

    }
}
