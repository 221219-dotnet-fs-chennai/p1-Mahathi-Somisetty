using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainer
{
    internal class Profile : IMenu
    {
        
        public void Display()
        {
            Console.WriteLine("******Welcome to Profile Page******");
            Console.WriteLine("[L] Logout:");
            Console.WriteLine("[1] View All details: ");
            Console.WriteLine("[0] Exit");
        }
        public string Userchoice()
        {
            string? Input = Console.ReadLine();
            switch (Input)
            {
                case "L":
                    Console.WriteLine("Logout Successfully:");
                    return "Menu";
                case "1":
                    Console.WriteLine("Your Profile:");
                    return "Profile";
                case "0":
                    Console.WriteLine("Proceed to exit?:(Y/N)");
                    return "Menu";
                default:
                    Console.WriteLine("Wrong choice!");
                    Console.WriteLine("Click enter to Continue:");
                    Console.WriteLine("Taking You to the Home page");
                    return "Menu";
            }
        }
    }
}
