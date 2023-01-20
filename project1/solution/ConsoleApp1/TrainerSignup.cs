using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TrainerSignup : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Welcome to UserDetails reviews!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[6] Addaddressdetails");
            Console.WriteLine("[5] Addeducationdetails");
            Console.WriteLine("[4] Addcompanydetails");
            Console.WriteLine("[3] Add skills");
            Console.WriteLine("[2] Add a new logindetails");
            Console.WriteLine("[1] Add a new UserDetails");
            Console.WriteLine("[0] Back");
        


        }

        public string UserChoice()
        {
            Console.Write("\nEnter your choice: ");

            string userInput = Console.ReadLine();

            //Switch cases are just useful if you are doing a bunch of comparison
            switch (userInput)
            {
                case "0":
                    return "Menu";
                case "1":
                    return "AddDetails";
                case "2":
                    return "Addlogindetails";
                case "3":
                    return "Addskills";
                case "4":
                    return "Addcompanydetails";
                case "5":
                    return "Addeducationdetails";
                case "6":
                    return "Addaddressdetails";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "Profile";
            }
        }


    }

}    
    

