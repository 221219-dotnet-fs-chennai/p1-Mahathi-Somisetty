using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Trainer
{
    internal class TDelete : TSignup, IMenu
    {
        static string con = File.ReadAllText("../../../Connection.txt");
        IRepo repo = new Sqlrepo(con);
        public void Display()
        {
            Console.WriteLine("*****Welcome, You can made updates in this page*****");
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
            Console.WriteLine("[0] save: ");

        }
        public new string Userchoice()
        {
            Console.WriteLine("Trainer Details");
            Console.WriteLine("Enter your choice");
            string? userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Deleting FullName");
                    info.FullName = "Null";
                    repo.TDelete("TraineeDetails", "FullName" ,info.EmailId);
                    return "Profile";
                case "2":
                    Console.WriteLine("Deleting");
                    string regex = @"^[\w\d+_.-]+@[\w\d.-]+$";
                    string EmailId = Console.ReadLine();
                    if (Regex.IsMatch(EmailId, regex))
                    {
                        info.EmailId = EmailId;
                    }
                    else
                    {
                        Console.WriteLine("Check Your mail:");
                        Console.ReadLine();
                    }

                    return "Profile";
                case "3":
                    Console.WriteLine("Deleting Gender :  ");
                    info.Gender = "Null";
                    repo.TDelete("TraineeDetails", "Gender" ,info.EmailId);
                    return "Profile";
                case "4":
                    Console.WriteLine("Deleting Age :  ");
                    info.Age = 0;
                    repo.TDelete("TraineeDetails","Age", info.EmailId);
                    return "Profile";
                case "5":
                    Console.WriteLine("Deleting PhoneNumber :  ");
                    info.PhoneNumber = "Null";
                    repo.TDelete ("TraineeDetails","PhoneNumber", info.EmailId);
                    return "Profile";
                case "6":
                    Console.WriteLine(" Deleting Highest Qualification :  ");
                    info.HQualification = "Null";
                    repo.TDelete("EducationalDetails", "HQualification", info.EmailId);
                    return "Profile";
                case "7":
                    Console.WriteLine("Deleting Passing year :  ");
                    info.YearOfPassing = "Null";
                    repo.TDelete("EducationalDetails", "YearOfPassing", info.EmailId);
                    return "Profile";
                case "8":
                    Console.WriteLine("Deleting Percentage :  ");
                    info.Percentage = "Null";
                    repo.TDelete("EducationalDetails", "Percentage", info.EmailId);
                    return "Profile";
                case "9":
                    Console.WriteLine("Deleting Stream :  ");
                    info.Stream = "Null";
                    repo.TDelete("EducationalDetails", "Stream",info.EmailId);
                    return "Profile";

                case "10":
                    Console.WriteLine("Deleting Company Name:  ");
                    info.Company_name = "Null";
                    repo.TDelete("CompanyDetails", "CompanyName", info.EmailId);
                    return "Profile";
                case "11":
                    Console.WriteLine(" Deleting Project name :  ");
                    info.ProjectName = "Null";
                    repo.TDelete("CompanyDetails", "ProjectName", info.EmailId);
                    return "Profile";
                case "12":
                    Console.WriteLine("Deleting Position :  ");
                    info.Position = "Null";
                    repo.TDelete("CompanyDetails", "Position", info.EmailId);
                    return "Profile";
                case "13":
                    Console.WriteLine("Deleting Experience :  ");
                    info.Experience = "Null";
                    repo.TDelete("CompanyDetails", "Experience", info.EmailId);
                    return "Profile";
                case "14":
                    Console.WriteLine("Deleting SKillName :  ");
                    info.Skill_name = "Null";
                    repo.TDelete("Skills", "Skill_name", info.EmailId);
                    return "Profile";
                case "15":
                    Console.WriteLine(" Deleting SkillType :  ");
                    info.Skill_Type = "Null";
                    repo.TDelete("Skills", "Skill_Type", info.EmailId);
                    return "Profile";
                case "16":
                    Console.WriteLine(" Deleting Expertise :  ");
                    info.Expertise = "Null";
                    repo.TDelete("Skills", "Expertise", info.EmailId);
                    return "Profile";
                case "0":
                    Console.WriteLine("[0] Save");
                    return "Menu";
                default:
                    Console.WriteLine("Wrong choice");
                    Console.WriteLine("Click Enter to continue");
                    return "Profile";

            }
        }
    }
}
