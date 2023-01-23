using System.Runtime;
using Serilog;
using Trainer;
namespace Data
{
    class Program : TSignup
    {
        
        public static void Main(String[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.File(@"..\..\..\logs.txt", rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true).CreateLogger();
            Log.Logger.Information("Program start");
            bool repeat = true;
            IMenu menu = new Menu();
            while(repeat)
            {
                Details details = new Details();
                menu.Display();
                string ab = menu.Userchoice();
                switch (ab)
                {
                    case "Login":
                        Log.Logger.Information("Login Page");
                        menu = new TLogin();
                        break;
                    case "Signup":
                        menu = new TSignup();
                        break;
                    case "Menu":
                        menu = new Menu();
                        break;
                    case "Profile":
                        menu = new Profile(info);
                        break;
                    case "Tupdate":
                        menu = new Tupdate();
                        break;
                    case "TDelete":
                        menu = new TDelete();
                        break;
                  
                    case "Exit":
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Wrong choice!:");
                        Console.WriteLine("Click enter to continue!:");
                        break;

                }
            }

        }


    }
    
}

