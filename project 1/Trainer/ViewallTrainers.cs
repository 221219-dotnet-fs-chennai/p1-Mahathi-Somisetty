using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainer
{
    public class ViewallTrainers : IMenu
    {
        static string con = File.ReadAllText("../../../Connection.txt");
        IRepo repo = new Sqlrepo(con);
        public void Display()
        {
            Console.WriteLine("[v] TO view All Details");
            Console.WriteLine("[0] To go Back");
        }

        public string Userchoice()
        {
            Console.WriteLine("Enter Your Choice:");
            string cho = Console.ReadLine();
            switch(cho)
            {
                case "0":
                    return "Signup";
                case "v":
                    var listof = repo.ViewAllTrainers();
                    foreach(var i in listof)
                    {
                        Console.WriteLine(i.TDetails());
                    }
                    return "Menu";
            }
            return "Menu";
        }

    }
}
