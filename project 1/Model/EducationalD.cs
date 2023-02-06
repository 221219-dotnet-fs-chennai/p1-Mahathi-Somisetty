using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EducationalD
    {
        public EducationalD() 
        { 
        }
        public int TraineeId
        {
            get;
            set;

        }
        public string? HQualification
        {
            get; set;
        }
        public string? YearOfPassing
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
        public string EducationalDetails()
        {
            return $@"{TraineeId},{HQualification},{YearOfPassing},{Percentage},{Stream}";
        }
    }
}
