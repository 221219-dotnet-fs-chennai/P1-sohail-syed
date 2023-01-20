using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Menu : IMenu
    {
        public void Display()
        {
            /*Console.WriteLine("Welcome to UserDetails reviews!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[12] Getaddressdetails");
            Console.WriteLine("[11] Addaddressdetails");
            Console.WriteLine("[10] Geteducationdetails");
            Console.WriteLine("[9] Addeducationdetails");
            Console.WriteLine("[8] Getcompanydetails");
            Console.WriteLine("[7] Addcompanydetails");
            Console.WriteLine("[6] Get skills");
            Console.WriteLine("[5] Add skills");
            Console.WriteLine("[4] Get all logindetails");
            Console.WriteLine("[3] Add a new logindetails");
            Console.WriteLine("[2] Get all UserDetails");
            Console.WriteLine("[1] Add a new UserDetails");
            Console.WriteLine("[0] Exit");*/
            Console.WriteLine("[0] exit");
            Console.WriteLine("[1] signup");
            Console.WriteLine("[2] login");


        }

        public string UserChoice()
        {
            Console.Write("\nEnter your choice: ");
            string userInput = Console.ReadLine();

            //Switch cases are just useful if you are doing a bunch of comparison
            switch (userInput)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "Signup";
                case "2":
                    return "Check";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "Menu";
                //case "3":
                //    return "Addlogindetails";
                //case "4":
                //    return "Getlogindetails";
                //case "5":
                //    return "Addskills";
                //case "6":
                //    return "Getskills";
                //case "7":
                //    return "Addcompanydetails";
                //case "8":
                //    return "Getcompanydetails";
                //case "9":
                //    return "Addeducationdetails";
                //case "10":
                //    return "Geteducationdetails";
                //case "11":
                //    return "Addaddressdetails";
                //case "12":
                //    return "Getaddressdetails";
            }
        }


    }

}    
