using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CompanyD
    {
        public int TraineeId
        {
            get; set;
        }
        public string? Company_name
        {
            get; set;
        }
        public string? Project_Name
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
        public string CompanyDetails()
        {
            return $@"{TraineeId},{Company_name},{ProjectName},{Position},{Experience}";
        }
    }
}
