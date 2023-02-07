using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Core_EF.Entities;

namespace BusinessLogic
{
    public class Validations
    {
        public static string ValidEmailId(string str)
        {


            string regex = @"^[\w\d+_.-]+@[\w\d.-]+$";

            if (Regex.IsMatch(str,regex))
            {
                return str;
            }
            else
            {
                
                throw new Exception("invalid EmailId");
            }
           
        }
        public static string ValidPassword(string str)
        {
            string regex = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{4,}$";
            if (Regex.IsMatch(str,regex))
            {
                return str;
            }
            else
            {
                
                throw new Exception("Password Pattern mismatch");
            }
        }

    }
}
