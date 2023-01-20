using ClassLibrary1;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Addaddressdetails : IMenu
    {
        private static addressdetails address = new addressdetails();
        // reading connection String from a file
        static string conStr = File.ReadAllText("C:/Users/ASUS/Azurelink.txt");
        IRepo<addressdetails> repo = new AddressRepo(conStr);
        public void Display()
        {
            Console.WriteLine("Enter information");
            Console.WriteLine("[6] user_id - " + address.user_id);
            Console.WriteLine("[5] pincode - " + address.pincode);
            Console.WriteLine("[4] state - " + address.state);
            Console.WriteLine("[3] email - " + address.email);
            Console.WriteLine("[2] contact- " + address.contact);
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
                        Log.Information("Adding adressdetails \n" + address);
                        repo.Add(address);
                        Log.Information("Successful at adding addressdetails!");
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
                    Console.WriteLine("Please enter a contact!");
                    address.contact = (Console.ReadLine());
                    return "Addaddressdetails";
                case "3":
                    Console.WriteLine("Please enter a email");
                    address.email = Console.ReadLine();
                    return "Addaddressdetails";
                case "4":
                    Console.WriteLine("Please enter a state!");
                    address.state = (Console.ReadLine());
                    return "Addaddressdetails";
                case "5":
                    Console.WriteLine("Please enter pincode");
                    address.pincode = (Console.ReadLine());
                    return "Addaddressdetails";
                case "6":
                    Console.WriteLine("Please enter the user_id");
                    address.user_id = Convert.ToInt32(Console.ReadLine());
                    return "Addaddressdetails";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "Addaddressdetails";
            }
        }

    }
}
