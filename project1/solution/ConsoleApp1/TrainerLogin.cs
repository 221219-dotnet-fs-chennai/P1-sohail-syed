using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TrainerLogin : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Login Successful");
            Console.WriteLine("[0] Back");
            Console.WriteLine("[1] Show Address Details");
            Console.WriteLine("[2] Show Education Details");
            Console.WriteLine("[3] show Company Details");
            Console.WriteLine("[4] show User Details");
            Console.WriteLine("[5] show Skills Details");
        }

        public string UserChoice()
        {
            Console.Write("\nEnter your choice: ");

           int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 0:
                    return "Menu";
                case 1:
                    return "Getaddressdetails";
                case 2:
                    return "Geteducationdetails";
                case 3:
                    return "Getcompanydetails";
                case 4:
                    return "GetDetails";
                case 5:
                    return "Getskills";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "Menu";
            }

        }
    }
}
