using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Trainer
{
    public  class TLogin : IMenu
    {    
        static string con = File.ReadAllText("../../../Connection.txt");
        IRepo repo = new Sqlrepo(con);
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
                        Console.WriteLine("Enter your emailId: ");
                        string? EmailId= Console.ReadLine();
                        bool choice = repo.Login(EmailId);
                        if (choice)
                        {
                        TSignup tsignup= new TSignup(repo.Get(EmailId));

                        return "Profile";
                        }
                        else
                        {
                        return "Login";

                        }
                    case "2":

                        return "Profile";
                    
                    default:
                    Console.WriteLine("Wrong Choice!");
                    Console.WriteLine("Click Enter to Continue");
                    return "TLogin";
                }
                
            }
        
    }
}
