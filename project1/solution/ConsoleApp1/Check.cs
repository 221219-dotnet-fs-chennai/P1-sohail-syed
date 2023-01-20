using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Check : IMenu


    {
        public void Display()
        {
            Console.WriteLine("-------Login Check-------");
            Console.WriteLine("[0] Go back");
            Console.WriteLine("[1] save");
            Console.WriteLine("[2] Enter Email Id");
            Console.WriteLine("[3] Enter Password");
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
                    
                    return "Login";
                case "2":
                    Console.WriteLine("Enter Email");
                    string str = Console.ReadLine();
                    return "Check";
                case "3":
                    Console.WriteLine("Enter Password");
                    string pswd = Console.ReadLine();
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


