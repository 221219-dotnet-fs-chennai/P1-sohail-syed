using ClassLibrary1;

using Serilog;

//string path = "C:/Users/ASUS/Azurelink.txt";
//string cs = File.ReadAllText(path);
//IRepo newrepo = new SqlRepo(cs);
//List<User> newuser = new List<User>();
//newuser = (newrepo.GetAllDetails());
//foreach(var user in newuser)
//{
//    Console.WriteLine(user.ToString());
//}
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            IMenu menu = new Menu();
            while (repeat)
            {
                Console.Clear();
                menu.Display();
                string ans = menu.UserChoice();
                switch (ans)
                {
                    case "Signup":
                        menu = new TrainerSignup();
                        break;
                    case "Check":
                        menu = new Check();
                        break;
                    case "Login":
                        menu = new TrainerLogin();
                        break;
                    case "Profile":
                        menu = new TrainerProfile();
                        break;
                    case "Menu":
                        Log.Information("Displaying Main Menu to user");
                        menu = new Menu();
                        break;
                    case "AddDetails":
                        Log.Information("Displaying Add UserDetails menu to user");
                        menu = new AddDetails();
                        break;
                    case "Addlogindetails":
                        menu = new Addlogindetails();
                        break;
                    case "Addskills":
                        menu = new Addskills();
                        break;
                    case "Addcompanydetails":
                        menu = new Addcompanydetails();
                        break;
                    case "Addeducationdetails":
                        menu = new Addeducationdetails();
                        break;
                    case "Addaddressdetails":
                        menu = new Addaddressdetails();
                        break;
                    case "GetDetails":
                        menu = new GetDetails();
                        break;
                    case "Getlogindetails":
                        menu = new Getlogindetails();
                        break;
                    case "Getskills":
                        menu = new Getskills();
                        break;
                    case "Getcompanydetails":
                        menu = new Getcompanydetails();
                        break;
                    case "Geteducationdetails":
                        menu = new Geteducationdetails();
                        break;
                    case "Getaddressdetails":
                        menu = new Getaddressdetails();
                        break;
                    case "TrainerLogin":
                        menu = new TrainerLogin();
                        break;


                    case "Exit":
                        Log.Information("Exiting application");

                        Log.CloseAndFlush(); //To close our logger resource
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Page does not exist!");
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                        break;
                }
            }

        }
    }

}
