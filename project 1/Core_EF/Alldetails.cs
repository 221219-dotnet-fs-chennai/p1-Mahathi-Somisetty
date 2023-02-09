using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_EF
{
    public class Alldetails
    {
        public Alldetails()
        {

        }
        public int TraineeId
        {
            get;
            set;
        }
        public string? Password
        {
            get; set;
        }
        public string FullName
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
        public string PhoneNumber
        {
            get; set;
        }
        public string? HQualification
        {
            get; set;
        }
        public string YearOfPassing
        {
            get; set;
        }
        public string? Percentage
        {
            get;
            set;
        }
        public string? Stream
        {
            get; set;
        }
        public string? Company_name
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
        public string? Skill_name
        {
            get; set;
        }
        public string? Skill_Type
        {
            get; set;
        }
        public string? Expertise
        {
            get; set;
        }
        public string Alldetail()
        {
            return $@"{TraineeId},{Password},{FullName},{Age},{Gender},{EmailId},{PhoneNumber},{HQualification},{YearOfPassing},{Percentage},{Stream},{Company_name},{ProjectName},{Position}
                    {Experience},{Skill_name},{Skill_Type},{Expertise}";
        }
    }
}
