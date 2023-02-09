using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Core_EF.Entities;
using Core_EF;
using Model;

namespace BusinessLogic
{
    public class Logic : ILogic
    {
        IRepo repo;

        public Logic(IRepo rep)
        {
            this.repo = rep;
        }

        public IEnumerable<TrainerD> GetTraineeDetails()
        {
            return Map.TrainerMap(repo.GetTraineeDetails());
        }
        public IEnumerable<SkillD> GetSkillDetails()
        {
            return Map.SkillMap(repo.GetSkillDetails());
        }
        public IEnumerable<Core_EF.Alldetails> GetAllDetails()
        {
            return repo.GetAllDetails();
        }
        public TrainerD Add(TraineeDetail trainee)
        {
            return Map.TrainerMap(repo.Add(Map.TrainerMap(TrainerD)))
        }
    }
}