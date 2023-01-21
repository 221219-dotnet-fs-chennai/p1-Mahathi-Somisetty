using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Trainer
{
    
    internal class TSignup : IMenu
    {
        internal static Details details = new Details();

        static string constr = $@"server=LAPTOP-S7D0E4KP;Database=trainee;Trusted_Connection=True;";
        Sqlrepo repo = new Sqlrepo();
        public void Display()
        {
            Console.WriteLine("---Welcome to signup---");
            Console.WriteLine("[1] FullName:" + details.FullName);
            Console.WriteLine("[2] EmailId:" + details.EmailId);
            Console.WriteLine("[3] Gender:" + details.Gender);
            Console.WriteLine("[4] Age:" + details.Age);
            Console.WriteLine("[5] PhoneNumber:" + details.Phonenumber );
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
            Console.WriteLine("***********Skill Detaisl***********");
            Console.WriteLine("[14] SkillName:" + details.SkillName);
            Console.WriteLine("[15] SkillType:" + details.SkillType);
            Console.WriteLine("[16] Expertise :" + details.Expertise);
            Console.WriteLine("[0] Save");
            Console.WriteLine("[01] EXIT");
        }
        public string Userchoice()
        {
            Console.WriteLine("Trainer Details");
            Console.WriteLine("Enter your choice");
            string? userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    
                    repo.Add(details);
                    Console.WriteLine("saved successfully!");
                    return "Menu";
                case "1":
                    Console.WriteLine("Enter FullName:  ");
                    details.FullName = Console.ReadLine();
                    return "TSignup";
                case "2":
                    Console.WriteLine("Enter EmailID :  ");
                    details.EmailId = Console.ReadLine();
                    return "TSignup";
                case "3":
                    Console.WriteLine("Enter Gender :  ");
                    details.Gender = Console.ReadLine();
                    return "TSignup";
                case "4":
                    Console.WriteLine("Enter Age :  ");
                    details.Age = Convert.ToString(Console.ReadLine());
                    return "TSignup";
                case "5":
                    Console.WriteLine("Enter PhoneNumber :  ");
                    details.Phonenumber = Convert.ToString(Console.ReadLine());
                    return "TSignup";
                case "6":
                    Console.WriteLine("Highest Qualification :  ");
                    details.HighestQualification = Console.ReadLine();
                    return "TSignup";
                case "7":
                    Console.WriteLine("Enter Passing year :  ");
                    details.PassingYear = Console.ReadLine();
                    return "TSignup";
                case "8":
                    Console.WriteLine("Percentage :  ");
                    details.Percentage = Console.ReadLine();
                    return "TSignup";
                case "9":
                    Console.WriteLine("Stream :  ");
                    details.Stream = Console.ReadLine();
                    return "TSignup";
                
                case "10":
                    Console.WriteLine("Company Name:  ");
                    details.CompanyName = Console.ReadLine();
                    return "TSignUp";
                case "11":
                    Console.WriteLine(" Project name :  ");
                    details.ProjectName = Console.ReadLine();
                    return "TSignup";
                case "12":
                    Console.WriteLine("Position :  ");
                    details.Position = Console.ReadLine();
                    return "TSignup";
                case "13":
                    Console.WriteLine("Experience :  ");
                    details.Experience = Console.ReadLine();
                    return "TSignup";
                case "14":
                    Console.WriteLine("Enter SKillsName :  ");
                    details.SkillName = Console.ReadLine();
                    return "TSignup";
                case "15":
                    Console.WriteLine("SkillType :  ");
                    details.SkillType = Console.ReadLine();
                    return "TSignup";
                case "16":
                    Console.WriteLine("Expertise :  ");
                    details.Expertise = Console.ReadLine();
                    return "TSignup";
                
                case "01":
                    Console.WriteLine("EXIT");
                    return "Menu";
                
                default:
                    Console.WriteLine("Wrong Choice");
                    Console.WriteLine("Click enter to continue");
                    Console.ReadLine();
                    return "TSignup";



            }
        }
    }
}