using Trainer;
namespace Data
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool repeat = true;
            IMenu menu = new Menu();
            while(repeat)
            {
                menu.Display();
                string ab = menu.Userchoice();
                switch (ab)
                {
                    case "Login":
                        menu = new TLogin();
                        break;
                    case "Signup":
                        menu = new TSignup();
                        break;
                    case "Menu":
                        menu = new Menu();
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

