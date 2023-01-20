using ClassLibrary1;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Addcompanydetails : IMenu
    {
        private static companydetails company = new companydetails();
        // reading connection String from a file
        static string conStr = File.ReadAllText("C:/Users/ASUS/Azurelink.txt");
        IRepo<companydetails> repo = new CompanyRepo(conStr);
        public void Display()
        {
            Console.WriteLine("Enter information");
            Console.WriteLine("[6] user_id - " + company.user_id);
            Console.WriteLine("[5] endyear - " + company.endyear);
            Console.WriteLine("[4] startyear - " + company.startyear);
            Console.WriteLine("[3] company_name - " + company.company_name);
            Console.WriteLine("[2] company_id - " + company.company_id);
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
                        Log.Information("Adding companydetails \n" + company);
                        repo.Add(company);
                        Log.Information("Successful at adding companyDetails!");
                    }
                    catch (System.Exception exc)
                    {
                        Log.Error($"Failed to add companydetails - {exc.Message}");
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                    }
                    return "Menu";
                case "2":
                    Console.WriteLine("Please enter an company_id!");
                   company.company_id = Convert.ToInt32(Console.ReadLine());
                    return "Addcompanydetails";
                case "3":
                    Console.WriteLine("Please enter a company_name!");
                    company.company_name = Console.ReadLine();
                    return "Addcompanydetails";
                case "4":
                    Console.WriteLine("Please enter the startyear!");
                    company.startyear = (Console.ReadLine());
                    return "Addcompanydetails";
                case "5":
                    Console.WriteLine("Please enter endyear");
                    company.endyear = (Console.ReadLine());
                    return "Addcompanydetails";
                case "6":
                    Console.WriteLine("Please enter the user_id");
                    company.user_id = Convert.ToInt32(Console.ReadLine());
                    return "Addcompanydetails";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "Addcompanydetails";
            }
        }
    }

}

