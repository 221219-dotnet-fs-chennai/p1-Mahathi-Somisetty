using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Details
    {
        public Details()
        {

        }
        public int TraineeId 
        {
            get; set;
        }
        public string Password 
        { 
            get; set;
        }
        public int SkillId 
        { 
            get; set;
        }
        public int EducationalId 
        { 
            get; set;
        }
        public int CompanyId 
        { 
            get; set;
        }

        public string? FullName
        {
            get; set;
        }
        public string? EmailId
        {
            get; set;
        }
        public string? Gender
        {
            get; set;
        }
        public string? Age
        {
            get; set;
        }
        public string? Phonenumber
        {
            get; set;
        }
        public string? HighestQualification
        {
            get; set;
        }
        public string? PassingYear
        {
            get; set;
        }
        public string? Percentage
        {
            get; set;
        }
        public string? Stream
        {
            get; set;
        }
        
        public string? CompanyName
        {
            get; set;
        }
        public string? ProjectName
        {
            get; set;
        }
        public string? Position
        {
            get; set;
        }
        public string? Experience
        {
            get; set;
        }
        public string? SkillName
        {
            get; set;
        }
        public string? SkillType
        {
            get; set;
        }
        public string? Expertise
        {
            get; set;
        }
        

        public string TrainerDetails()
        {
            return $@"{FullName},{EmailId}, {FullName}, {Gender}, {Age}, {Phonenumber}, {HighestQualification}, {PassingYear}, {Percentage}, {Stream}, {CompanyName}, {ProjectName}, {Position}, {Experience}, {SkillName}, {SkillType}, {Expertise} ";
           
        }
    }
}
