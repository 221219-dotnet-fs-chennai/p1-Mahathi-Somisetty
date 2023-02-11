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

        public TrainerD AddTraineeDetails(TrainerD trainer)
        {
            return Map.TrainerMap(repo.AddTraineeDetails(Map.TrainerMap(trainer)));
        }

        public SkillD AddSkillDetails(SkillD skill)
        {
            return Map.SkillMap(repo.AddSkillDetails(Map.SkillMap(skill)));
        }

        public EducationalD AddEducationalDetails(EducationalD educational)
        {
            return Map.EducationMap(repo.AddEducationalDetails(Map.EducationMap(educational)));
        }

        public CompanyD AddCompanyDetails(CompanyD company)
        {
            return Map.CompanyMap(repo.AddCompanyDetails(Map.CompanyMap(company)));
        }

        public TrainerD DeleteAllDetails(int Id)
        {
            var t = repo.DeleteAllDetails(Id);
            if (t != null)
            {
                return Map.TrainerMap(t);
            }
            else
            {
                return null;
            }
        }

        public TrainerD updatebyid(int id, TrainerD trainer)
        {
            var u = (from detail in repo.GetTraineeDetails()
                     where detail.TraineeId == id
                     select detail).FirstOrDefault();
            if(u!= null)
            {
                u.FullName = trainer.FullName;
                u.EmailId = trainer.EmailId;
                u.Age = Convert.ToInt32(trainer.Age);
                u.Gender = trainer.Gender;
                u.PhoneNumber = trainer.PhoneNumber;

                u = repo.updatebyid(u);
            }
            return Map.TrainerMap(u);
        }
    }
}