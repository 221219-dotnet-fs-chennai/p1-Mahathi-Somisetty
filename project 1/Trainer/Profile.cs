using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Trainer
{
    class Profile : IMenu
    {

        Details info=new Details();
        static string constr = File.ReadAllText("../../../Connection.txt");
        IRepo repo = new Sqlrepo(constr);
        public Profile(Details det)
        {
            info = det;
        }

        public void Display()
        {
            Console.WriteLine("******Welcome to Profile Page******");
            Console.WriteLine("[L] Logout:");
            Console.WriteLine("[1] View Your details: ");
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
                    Console.ReadLine();
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
            Console.WriteLine("[1] FullName:" + info.FullName);
            Console.WriteLine("[2] EmailId:" + info.EmailId);
            Console.WriteLine("[3] Gender:" + info.Gender);
            Console.WriteLine("[4] Age:" + info.Age);
            Console.WriteLine("[5] PhoneNumber:" + info.PhoneNumber);
            Console.WriteLine("***********Educational Details***********");
            Console.WriteLine("[6] Highest Qualification:" + info.HQualification);
            Console.WriteLine("[7] Passing year:" + info.YearOfPassing);
            Console.WriteLine("[8] Percentage:" + info.Percentage);
            Console.WriteLine("[9] Stream:" + info.Stream);
            Console.WriteLine("***********Company Details***********");
            Console.WriteLine("[10] CompanyName:" + info.Company_name);
            Console.WriteLine("[11] ProjectName:" + info.ProjectName);
            Console.WriteLine("[12] Position:" + info.Position);
            Console.WriteLine("[13] Experience:" + info.Experience);
            Console.WriteLine("***********Skill Details***********");
            Console.WriteLine("[14] SkillName:" + info.Skill_name);
            Console.WriteLine("[15] SkillType:" + info.Skill_Type);
            Console.WriteLine("[16] Expertise :" + info.Expertise);
            Console.WriteLine("[17] Password :" + info.Password);
            
        }
    }
}
