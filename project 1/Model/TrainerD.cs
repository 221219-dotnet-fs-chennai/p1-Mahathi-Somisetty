using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TrainerD
    {
        public TrainerD()
        {
        }
        public int TraineeId
        {
            get;
            set;
        }
            public string Password
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
        public int? Age
        {
            get; set;
        }
        public string? PhoneNumber
        {
            get; set;
        }
        public string TrainerDetails()
        {
            return $@"{TraineeId},{Password},{FullName},{EmailId},{Gender},{Age},{PhoneNumber}";
        }
    }
}

