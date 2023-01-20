using ClassLibrary1;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Addeducationdetails : IMenu
    {
        private static educationdetails educationdetails = new educationdetails();
        // reading connection String from a file
        static string conStr = File.ReadAllText("C:/Users/ASUS/Azurelink.txt");
        IRepo<educationdetails> repo = new EducationRepo(conStr);
        public void Display()
        {
            Console.WriteLine("Enter information");

            Console.WriteLine("[5] grade - " + educationdetails.grade);
            Console.WriteLine("[4] passoutyear - " + educationdetails.passoutyear);
            Console.WriteLine("[3] university - " + educationdetails.university);
            Console.WriteLine("[2] user_id - " + educationdetails.user_id);

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
                        Log.Information("Adding educationdetails \n" + educationdetails);
                        repo.Add(educationdetails);
                        Log.Information("Successful at adding educationdetails!");
                    }
                    catch (System.Exception exc)
                    {
                        Log.Error($"Failed to add educationdetails - {exc.Message}");
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                    }
                    return "Menu";
                case "2":
                    Console.WriteLine("Please enter an user_id!");
                    educationdetails.user_id = Convert.ToInt32(Console.ReadLine());
                    return "Addeducationdetails";
                case "3":
                    Console.WriteLine("Please enter a university");
                    educationdetails.university = Console.ReadLine();
                    return "Addeducationdetails";
                case "4":
                    Console.WriteLine("Please enter a passoutyear");
                    educationdetails.passoutyear = (Console.ReadLine());
                    return "Addeducationdetails";
                case "5":
                    Console.WriteLine("please enter your grade");
                    educationdetails.grade = Console.ReadLine();
                    return "Addeducationdetails";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "Addeducationdetails";

            }
        }
    }
}
