using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace ConsoleApp1
{
    public class AddDetails : IMenu
    {
        private static User newuser = new User();
        // reading connection String from a file
        static string conStr = File.ReadAllText("C:/Users/ASUS/Azurelink.txt");
        IRepo<User> repo = new SqlRepo(conStr);
        public void Display()
        {
            Console.WriteLine("Enter information");
            Console.WriteLine("[6] Gender - " + newuser.Gender);
            Console.WriteLine("[5] Age - " + newuser.Age);
            Console.WriteLine("[4] Last Name - " + newuser.Last_name);
            Console.WriteLine("[3] First Name - " + newuser.First_name);
            Console.WriteLine("[2] Id - " + newuser.user_id);
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
                        Log.Information("Adding UserDetails \n" + newuser);
                        repo.Add(newuser);
                        Log.Information("Successful at adding UserDetails!");
                    }
                    catch (System.Exception exc)
                    {
                        Log.Error($"Failed to add UserDetails - {exc.Message}");
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                    }
                    return "Menu";
                case "2":
                    Console.WriteLine("Please enter an Id!");
                    newuser.user_id= Convert.ToInt32(Console.ReadLine());
                    return "AddDetails";
                case "3":
                    Console.WriteLine("Please enter a first name!");
                    newuser.First_name = Console.ReadLine();
                    return "AddDetails";
                case "4":
                    Console.WriteLine("Please enter the last name!");
                    newuser.Last_name = Console.ReadLine();
                    return "AddDetails";
                case "5":
                    Console.WriteLine("Please enter age");
                    newuser.Age = Convert.ToInt32(Console.ReadLine());
                    return "AddDetails";
                case "6":
                    Console.WriteLine("Please enter the gender");
                    newuser.Gender = Console.ReadLine();
                    return "AddDetails";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddDetails";
            }
        }
    }
}
