using ClassLibrary1;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Addlogindetails : IMenu
    {
        private static logindetails Logindetails = new logindetails();
        // reading connection String from a file
        static string conStr = File.ReadAllText("C:/Users/ASUS/Azurelink.txt");
        IRepo<logindetails> repo = new LoginRepo(conStr);
        public void Display()
        {
            Console.WriteLine("Enter information");
            
            Console.WriteLine("[4] Email - " + Logindetails.Email);
            Console.WriteLine("[3] password - " + Logindetails.password);
            Console.WriteLine("[2] loginid - " + Logindetails.loginid);
           
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
                        Log.Information("Adding loginDetails \n" + Logindetails);
                        repo.Add(Logindetails);
                        Log.Information("Successful at adding loginDetails!");
                    }
                    catch (System.Exception exc)
                    {
                        Log.Error($"Failed to add loginDetails - {exc.Message}");
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                    }
                    return "Menu";
                case "2":
                    Console.WriteLine("Please enter an Id!");
                    Logindetails.loginid = Convert.ToInt32(Console.ReadLine());
                    return "Addlogindetails";
                case "3":
                    Console.WriteLine("Please enter a password");
                    Logindetails.password = Console.ReadLine();
                    return "Addlogindetails";
                case "4":
                    Console.WriteLine("Please enter a Email");
                    Logindetails.Email = Console.ReadLine();
                    return "Addlogindetails";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddDetails";

            }
        }
    }
}
