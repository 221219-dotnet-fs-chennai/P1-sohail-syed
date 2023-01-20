using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TrainerProfile: IMenu
    {
        public void Display()
        {
            Console.WriteLine("[0] login");
            Console.WriteLine("[1] Getdetails");
            Console.WriteLine("[2] Getlogindetails");
            Console.WriteLine("[3] Getskills");
            Console.WriteLine("[4] Get companydetails");
            Console.WriteLine("[5] Get alldetails");
            Console.WriteLine("[6] Get all UserDetails");
        }

        public string UserChoice()
        {
            Console.Write("\nEnter your choice: ");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "Login";
                case "1":
                    return "GetDetails";
                case "2":
                    return "Getlogindetails";
                case "3":
                    return "Getskills";
                case "4":
                    return "Getcompanydetails";
                case "5":
                    return "Geteducationdetails";
                case "6":
                    return "Getaddressdetails";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "Profile";
            }
        }
    }

}
