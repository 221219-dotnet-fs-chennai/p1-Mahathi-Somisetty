using Core_EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_EF
{
    public class EFrepo:IRepo
    {
        private readonly TraineeContext obj;

        public EFrepo(TraineeContext context)
        {
            obj= context;
        }
         
        public List<Entities.TraineeDetail> GetTraineeDetails()
        {
            return obj.TraineeDetails.ToList();
        }
        public List<Entities.Skill> GetSkillDetails()
        {
            return obj.Skills.ToList();
        }

    }
}
