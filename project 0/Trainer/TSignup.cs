using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Data;

namespace Trainer
{
    
    internal class TSignup : IMenu
    {
        internal static Details info = new Details();


        static string constr = File.ReadAllText("../../../Connection.txt");
        Sqlrepo repo = new Sqlrepo(constr);

        public TSignup()
        {

        }

        public TSignup(Details details)
        {
            info = details;
        }
        public void Display()
        {
            Console.WriteLine("---Welcome to signup---");
            Console.WriteLine("[1] FullName:" + info.FullName);
            Console.WriteLine("[2] EmailId:" + info.EmailId);
            Console.WriteLine("[3] Gender:" + info.Gender);
            Console.WriteLine("[4] Age:" + info.Age);
            Console.WriteLine("[5] PhoneNumber:" + info.PhoneNumber );
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
                    
                    repo.Add(info);
                    Console.WriteLine("saved successfully!");
                    return "Menu";
                case "1":
                    Console.WriteLine("Enter FullName:  ");
                    info.FullName = Console.ReadLine();
                    return "TSignup";
                case "2":
                    Console.WriteLine("Enter EmailID :  ");
                    string regex = @"^[\w\d+_.-]+@[\w\d.-]+$";
                    string? EmailId= Console.ReadLine();
                    if (Regex.IsMatch(EmailId,regex))
                    {
                        info.EmailId = EmailId;
                    }
                    else
                    {
                        Console.WriteLine("Check Your mail:");
                        Console.ReadLine();
                    }
                    
                    return "TSignup";
                case "3":
                    Console.WriteLine("Enter Gender :  ");
                    info.Gender = Console.ReadLine();
                    return "TSignup";
                case "4":
                    Console.WriteLine("Enter Age :  ");
                    info.Age = Convert.ToInt32(Console.ReadLine());
                    return "TSignup";
                case "5":
                    Console.WriteLine("Enter PhoneNumber :  ");
                    info.PhoneNumber = Convert.ToString(Console.ReadLine());
                    return "TSignup";
                case "6":
                    Console.WriteLine("Highest Qualification :  ");
                    info.HQualification = Console.ReadLine();
                    return "TSignup";
                case "7":
                    Console.WriteLine("Enter Passing year :  ");
                    info.YearOfPassing = Console.ReadLine();
                    return "TSignup";
                case "8":
                    Console.WriteLine("Percentage :  ");
                    info.Percentage = Console.ReadLine();
                    return "TSignup";
                case "9":
                    Console.WriteLine("Stream :  ");
                    info.Stream = Console.ReadLine();
                    return "TSignup";
                
                case "10":
                    Console.WriteLine("Company Name:  ");
                    info.Company_name = Console.ReadLine();
                    return "TSignUp";
                case "11":
                    Console.WriteLine(" Project name :  ");
                    info.ProjectName = Console.ReadLine();
                    return "TSignup";
                case "12":
                    Console.WriteLine("Position :  ");
                    info.Position = Console.ReadLine();
                    return "TSignup";
                case "13":
                    Console.WriteLine("Experience :  ");
                    info.Experience = Console.ReadLine();
                    return "TSignup";
                case "14":
                    Console.WriteLine("Enter SKillsName :  ");
                    info.Skill_name = Console.ReadLine();
                    return "TSignup";
                case "15":
                    Console.WriteLine("SkillType :  ");
                    info.Skill_Type = Console.ReadLine();
                    return "TSignup";
                case "16":
                    Console.WriteLine("Expertise :  ");
                    info.Expertise = Console.ReadLine();
                    return "TSignup";
                case "17":
                    Console.WriteLine("Password:");
                    Console.WriteLine("passWord Should Contain Minimum Four characters, at least one letter and one number:");
                    string regex1 = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{4,}$";
                    string? Password = Console.ReadLine();
                    if (Regex.IsMatch(Password, regex1))
                    {
                        info.Password = Password;
                    }
                    else
                    {
                        Console.WriteLine("Follow instructions for the password");
                        Console.ReadLine();
                    }
                    return "Tsignup";
                
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