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
                menu.Display();
                string? ab = menu.Userchoice();
                switch (ab)
                {
                    case "View":
                        menu = new ViewallTrainers();
                        break;
                    case "Login":
                        Log.Logger.Information("Login Page");
                        Details details = new Details();
                        menu = new TLogin();
                        break;
                    case "Signup":
                        Log.Logger.Information("Signup Page");
                        menu = new TSignup();
                        break;
                    case "Menu":
                        menu = new Menu();
                        break;
                    case "Profile":
                        Log.Logger.Information("Profile Page");
                        menu = new Profile(info);
                        break;
                    case "Tupdate":
                        Log.Logger.Information("Trainer Update Page");
                        menu = new Tupdate();
                        break;
                    case "TDelete":
                        Log.Logger.Information("Trainer Delete Page");
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

