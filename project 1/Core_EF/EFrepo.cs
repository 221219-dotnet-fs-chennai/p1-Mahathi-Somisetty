using Core_EF.Entities;
using Model;
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
        public List<Alldetails> GetAllDetails()
        {
            var TrainerD = obj.TraineeDetails;
            var EducationalD = obj.EducationalDetails;
            var SkillD = obj.Skills;
            var CompanyD = obj.CompanyDetails;
            var AllD = (from Trainer in TrainerD 
                        join Education in EducationalD on Trainer.TraineeId equals Education.TraineeId
                        join Skil in SkillD on Trainer.TraineeId equals Skil.TraineeId
                        join Company in CompanyD on Trainer.TraineeId equals Company.TraineeId
                        select new Alldetails()
                        {
                            TraineeId = Trainer.TraineeId,
                            FullName = Trainer.FullName,
                            EmailId = Trainer.EmailId,
                            Age = Convert.ToString(Trainer.Age),
                            Gender = Trainer.Gender,
                            //Password = Trainer.Password,
                            PhoneNumber = Trainer.PhoneNumber,
                            HQualification = Education.Hqualification,
                            YearOfPassing = Education.YearOfPassing,
                            Stream = Education.Stream,
                            Percentage = Education.Percentage,
                            Skill_name = Skil.Skill_name,
                            Skill_Type = Skil.Skill_Type,
                            Expertise = Skil.Expertise,
                            Company_name = Company.Company_name,
                            ProjectName = Company.ProjectName,
                            Experience = Company.Experience,
                            Position = Company.Position,
                        });
            return AllD.ToList();

        }
        public TraineeDetail AddTraineeDetails(TraineeDetail trainee)
        {
            obj.Add(trainee);
            obj.SaveChanges();
            return trainee;
        }
        public Skill AddSkillDetails(Skill skill)
        {
            obj.Add(skill);
            obj.SaveChanges();
            return skill;
        }
        public EducationalDetail AddEducationalDetails(EducationalDetail educational)
        {
            obj.Add(educational);
            obj.SaveChanges();
            return educational;
        }
        public CompanyDetail AddCompanyDetails(CompanyDetail company)
        {
            obj.Add(company);
            obj.SaveChanges();
            return company;
        }
        
    }
}
