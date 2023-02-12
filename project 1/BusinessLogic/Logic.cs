using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Core_EF.Entities;
using Core_EF;
using Model;
using System.Security.Cryptography;

namespace BusinessLogic
{
    public class Logic : ILogic
    {
        IRepo repo;

        public Logic(IRepo rep)
        {
            this.repo = rep;
        }
        // get all trainer details
        public IEnumerable<TrainerD> GetTraineeDetails()
        {
            return Map.TrainerMap(repo.GetTraineeDetails());
        }
        //get all skills
        public IEnumerable<SkillD> GetSkillDetails()
        {
            return Map.SkillMap(repo.GetSkillDetails());
        }
        public IEnumerable<EducationalD> GetEducationalDetails()
        {
            return Map.EducationMap(repo.GetEducationalDetails());
        }
        public IEnumerable<CompanyD> GetCompanyDetails()
        {
            return Map.CompanyMap(repo.GetCompanyDetails());
        }
        public IEnumerable<Core_EF.Alldetails> GetAllDetails()
        {
            return repo.GetAllDetails();
        }
        // add trainer details
        public TrainerD AddTraineeDetails(TrainerD trainer)
        {
            return Map.TrainerMap(repo.AddTraineeDetails(Map.TrainerMap(trainer)));
        }
        //Add skill details

        public SkillD AddSkillDetails(SkillD skill)
        {
            return Map.SkillMap(repo.AddSkillDetails(Map.SkillMap(skill)));
        }
        //display add educational details
        public EducationalD AddEducationalDetails(EducationalD educational)
        {
            return Map.EducationMap(repo.AddEducationalDetails(Map.EducationMap(educational)));
        }
        //display add company details
        public CompanyD AddCompanyDetails(CompanyD company)
        {
            return Map.CompanyMap(repo.AddCompanyDetails(Map.CompanyMap(company)));
        }
        //delete trainer details
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
        // trainer details update
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

        public EducationalD Edupdatebyid(int id, EducationalD educational)
        {
            var e = (from detail in repo.GetEducationalDetails()
                     where detail.TraineeId == id
                     select detail).FirstOrDefault();
            if (e != null)
            {
                e.Hqualification = educational.HQualification;
                e.YearOfPassing = educational.YearOfPassing;
                e.Stream = educational.Stream;

                e = repo.Edupdatebyid(e);
            }
            return Map.EducationMap(e);
        }

        public SkillD Supdatebyid(int id, SkillD skill)
        {
            var s = (from detail in repo.GetSkillDetails()
                     where detail.TraineeId == id
                     select detail).FirstOrDefault();
            if (s != null)
            {
                s.Skill_name = skill.Skill_name;
                s.Skill_Type = skill.Skill_Type;
                s.Expertise = skill.Expertise;

                s = repo.updateSkillDetails(s);

            }
            return Map.SkillMap(s);
        }

        public CompanyD Cupdatebyid(int id, CompanyD company)
        {
            var c =(from detail in repo.GetCompanyDetails()
                    where detail.TraineeId == id
                    select detail).FirstOrDefault();
            if (c != null)
            {
                c.Company_name = company.Company_name;
                c.ProjectName = company.Project_Name;
                c.Position = company.Position;
                c.Experience = company.Experience;

                c=repo.Cupdatebyid(c);
            }
            return Map.CompanyMap(c);
        }
        public bool login(string EmailId,string Password) 
        {
            return repo.login(EmailId, Password);
        }
    }
}