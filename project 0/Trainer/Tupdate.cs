using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Trainer
{
    internal class Tupdate : TSignup, IMenu
    {
        static string con = File.ReadAllText("../../../Connection.txt");
        IRepo repo = new Sqlrepo(con);
        public void display()
        {
            Console.WriteLine("*****Welcome, You can made updates in this page*****");
            Console.WriteLine("[1] FullName:" + info.FullName);
            Console.WriteLine("[2] EmailId:" + info.EmailId);
            Console.WriteLine("[3] Gender:" + info.Gender);
            Console.WriteLine("[4] Age:" + info.Age);
            Console.WriteLine("[5] PhoneNumber:" + info.Phonenumber);
            Console.WriteLine("***********Educational Details***********");
            Console.WriteLine("[6] Highest Qualification:" + info.HighestQualification);
            Console.WriteLine("[7] Passing year:" + info.PassingYear);
            Console.WriteLine("[8] Percentage:" + info.Percentage);
            Console.WriteLine("[9] Stream:" + info.Stream);
            Console.WriteLine("***********Company Details***********");
            Console.WriteLine("[10] CompanyName:" + info.CompanyName);
            Console.WriteLine("[11] ProjectName:" + info.ProjectName);
            Console.WriteLine("[12] Position:" + info.Position);
            Console.WriteLine("[13] Experience:" + info.Experience);
            Console.WriteLine("***********Skill Details***********");
            Console.WriteLine("[14] SkillName:" + info.SkillName);
            Console.WriteLine("[15] SkillType:" + info.SkillType);
            Console.WriteLine("[16] Expertise :" + info.Expertise);
            Console.WriteLine("[0] save: ");
            Console.WriteLine("[00] Back");
        }
        public new string Userchoice()
        {
            Console.WriteLine("Trainer Details");
            Console.WriteLine("Enter your choice");
            string userInput = Console.ReadLine();
            Console.WriteLine("Please Enter  Your Email To Continue");
            info.EmailId = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Enter FullName:  ");
                    info.FullName = Console.ReadLine();
                    repo.Tupdate("TraineeDetails","FullName",info.FullName,info.EmailId);
                    return "Profile";
                case "2":
                    Console.WriteLine("Enter EmailID :  ");

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
                    Console.WriteLine("Enter Gender :  ");
                    info.FullName = Console.ReadLine();
                    repo.Tupdate("TraineeDetails", "Gender", info.Gender, info.EmailId);
                    info.Gender = Console.ReadLine();
                    return "Profile";
                case "4":
                    Console.WriteLine("Enter Age :  ");
                    info.FullName = Console.ReadLine();
                    repo.Tupdate("TraineeDetails", "Age", info.Age, info.EmailId);
                    info.Age = Convert.ToString(Console.ReadLine());
                    return "Profile";
                case "5":
                    Console.WriteLine("Enter PhoneNumber :  ");
                    info.FullName = Console.ReadLine();
                    repo.Tupdate("TraineeDetails", "PhoneNumber", info.Phonenumber, info.EmailId);
                    info.Phonenumber = Convert.ToString(Console.ReadLine());
                    return "Profile";
                case "6":
                    Console.WriteLine("Highest Qualification :  ");
                    info.FullName = Console.ReadLine();
                    
                    info.HighestQualification = Console.ReadLine();
                    repo.Tupdate("EducationalDetails", "HQualification", info.HighestQualification, info.EmailId);
                    return "Profile";
                case "7":
                    Console.WriteLine("Enter Passing year :  ");
                    
                    info.PassingYear = Console.ReadLine();
                    repo.Tupdate("EducationalDetails", "Passingyear", info.PassingYear, info.EmailId);
                    return "Profile";
                case "8":
                    Console.WriteLine("Percentage :  ");
                    
                    info.Percentage = Console.ReadLine();
                    repo.Tupdate("EducationalDetails", "Percentage", info.Percentage, info.EmailId);
                    return "Profile";
                case "9":
                    Console.WriteLine("Stream :  ");
                    
                    info.Stream = Console.ReadLine();
                    repo.Tupdate("EducationalDetails", "Stream", info.Stream, info.EmailId);
                    return "Profile";

                case "10":
                    Console.WriteLine("Company Name:  ");
                    
                    info.CompanyName = Console.ReadLine();
                    repo.Tupdate("ompanyDetails", "CompanyName", info.CompanyName, info.EmailId);
                    return "Profile";
                case "11":
                    Console.WriteLine(" Project name :  ");
                    
                    info.ProjectName = Console.ReadLine();
                    repo.Tupdate("CompanyDetails", "ProjectName", info.ProjectName, info.EmailId);
                    return "Profile";
                case "12":
                    Console.WriteLine("Position :  ");
                    
                    info.Position = Console.ReadLine();
                    repo.Tupdate("CompanyDetails", "Position", info.Position, info.EmailId);
                    return "Profile";
                case "13":
                    Console.WriteLine("Experience :  ");
                    
                    info.Experience = Console.ReadLine();
                    repo.Tupdate("CompanyDetails", "Experience", info.Experience, info.EmailId);
                    return "Profile";
                case "14":
                    Console.WriteLine("Enter SKillsName :  ");
                    
                    info.SkillName = Console.ReadLine();
                    repo.Tupdate("Skills", "SkillName", info.SkillName, info.EmailId);
                    return "Profile";
                case "15":
                    Console.WriteLine("SkillType :  ");
                    
                    info.SkillType = Console.ReadLine();
                    repo.Tupdate("Skills", "SkillType", info.SkillType, info.EmailId);
                    return "Profile";
                case "16":
                    Console.WriteLine("Expertise :  ");
                    
                    info.Expertise = Console.ReadLine();
                    repo.Tupdate("Skills", "Expertise", info.Expertise, info.EmailId);
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
