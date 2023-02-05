﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Validations
    {
        public static string ValidEmailId(string str)
        {


            string regex = @"^[\w\d+_.-]+@[\w\d.-]+$";
            string? EmailId = Console.ReadLine();

            if (Regex.IsMatch(EmailId, regex))
            {
                return EmailId;
            }
            else
            {
                
                throw new Exception("invalid EmailId");
            }
           
        }
        public static string ValidPassword(string str)
        {
            string regex = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{4,}$";
            string? Password = Console.ReadLine();
            if (Regex.IsMatch(Password, regex))
            {
                return Password;
            }
            else
            {
                
                throw new Exception("Password Pattern mismatch");
            }
        }

    }
}