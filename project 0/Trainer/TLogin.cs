using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainer
{
    internal class TLogin : IMenu
        {
        static string connection = $@"Server=LAPTOP-S7D0E4KP;Database=trainee;Trusted_Connection=True;";
            public void Display()
            {
                Console.WriteLine("Welcome to Trainer Login Page");
                Console.WriteLine("[1] Login");
                Console.WriteLine("[2] Exit");
            }
            public string Userchoice()
            {
                Console.WriteLine("Trainer Login Details");
                Console.WriteLine("Enter Your Choice:");
                string? userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //Console.WriteLine("[1] Proceed for Login");
                        TLogin log = new TLogin();
                        log.login();
                        Console.ReadLine();
                        return "Login";
                    case "2":
                        Console.WriteLine("[2] Proceed for Exit");
                        Console.ReadLine();
                        return "Menu";
                default:
                    Console.WriteLine("Wrong Choice!");
                    Console.WriteLine("Click Enter to Continue");
                    return "TLogin";
                }
                
            }
            public void login()
            {
                Console.WriteLine("Enter your EmailId:");
                string? username=Console.ReadLine();
                Console.WriteLine("Enter your Password:");
                Console.WriteLine("Password should be atleast 4");
                string? password=Console.ReadLine();
            Console.WriteLine("Successfully Logged in");
            }
        }
}
