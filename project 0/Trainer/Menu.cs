using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainer
{
    internal class Menu : IMenu
    {

        public void Display()
        {
            Console.WriteLine("Welcome to Trainer");
            Console.WriteLine("[1] Signup");
            Console.WriteLine("[2] Login");
            Console.WriteLine("[3] Exit"); 
        }
        public string Userchoice()
        {
            string? UserChoice = Console.ReadLine();
            switch (UserChoice)
            {
                case "1":
                    return "Signup";
                case "2":
                    return "Login";
                case "3":
                    return "Exit";
                
                default:
                    Console.WriteLine("Wrong choice!");
                    Console.WriteLine("Click Enter to Continue");
                    Console.ReadLine();
                    return "Menu";

            }

        }
    }
}
