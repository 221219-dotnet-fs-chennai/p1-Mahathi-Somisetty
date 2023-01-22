using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Trainer
{
    internal class Profile : IMenu
    {

        Details details=new Details();
        static string constr = File.ReadAllText("../../../Connection.txt");
        IRepo repo = new Sqlrepo(constr);
        public Profile(Details det)
        {
            details = det;
        }

        public void Display()
        {
            Console.WriteLine("******Welcome to Profile Page******");
            Console.WriteLine("[L] Logout:");
            Console.WriteLine("[1] View All details: ");
            Console.WriteLine("[2] Update Your Details:");
            Console.WriteLine("[3] Delete Your Details:");
            Console.WriteLine("[0] Exit");
        }
        public string Userchoice()
        {
            string Input = Console.ReadLine();
            switch (Input)
            {
                case "L":
                    Console.WriteLine("Logout Successfully:");
                    return "Menu";
                case "1":
                    Console.WriteLine("Your Profile:");
                    Viewdetails();
                    return "Profile";
                case "2":
                    Console.WriteLine("Update Trainer Details:");
                    return "Tupdate";
                case "3":
                    Console.WriteLine("Delete your Details?");
                    return "TDelete";
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
        public void Viewdetails()
        {



            Console.WriteLine("---Welcome to signup---");
            Console.WriteLine("[1] FullName:" + details.FullName);
            Console.WriteLine("[2] EmailId:" + details.EmailId);
            Console.WriteLine("[3] Gender:" + details.Gender);
            Console.WriteLine("[4] Age:" + details.Age);
            Console.WriteLine("[5] PhoneNumber:" + details.Phonenumber);
            Console.WriteLine("***********Educational Details***********");
            Console.WriteLine("[6] Highest Qualification:" + details.HighestQualification);
            Console.WriteLine("[7] Passing year:" + details.PassingYear);
            Console.WriteLine("[8] Percentage:" + details.Percentage);
            Console.WriteLine("[9] Stream:" + details.Stream);
            Console.WriteLine("***********Company Details***********");
            Console.WriteLine("[10] CompanyName:" + details.CompanyName);
            Console.WriteLine("[11] ProjectName:" + details.ProjectName);
            Console.WriteLine("[12] Position:" + details.Position);
            Console.WriteLine("[13] Experience:" + details.Experience);
            Console.WriteLine("***********Skill Details***********");
            Console.WriteLine("[14] SkillName:" + details.SkillName);
            Console.WriteLine("[15] SkillType:" + details.SkillType);
            Console.WriteLine("[16] Expertise :" + details.Expertise);
            Console.WriteLine("[17] Password :" + details.Password);
            
        }
    }
}
