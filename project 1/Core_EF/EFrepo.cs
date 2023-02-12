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
        public List<Entities.EducationalDetail> GetEducationalDetails()
        {
            return obj.EducationalDetails.ToList();
        }
        public List<Entities.CompanyDetail> GetCompanyDetails() 
        {
            return obj.CompanyDetails.ToList();
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
        public Entities.TraineeDetail DeleteAllDetails (int id)
        {
            var t =obj.TraineeDetails.Where(x => x.TraineeId== id).FirstOrDefault();
            var e = obj.EducationalDetails.Where(x => x.TraineeId == id).FirstOrDefault();
            var c = obj.CompanyDetails.Where(x => x.TraineeId == id).FirstOrDefault();
            var s = obj.Skills.Where(x => x.TraineeId == id).FirstOrDefault();
            if (t != null)
            {
                obj.Skills.Remove(s);
                obj.CompanyDetails.Remove(c);
                obj.EducationalDetails.Remove(e);
                obj.TraineeDetails.Remove(t);
                obj.SaveChanges();
            }
            return t;

        }
        public TraineeDetail updatebyid(TraineeDetail detail)
        {
            obj.TraineeDetails.Update(detail);
            obj.SaveChanges();
            return detail;
        }
        public EducationalDetail Edupdatebyid(EducationalDetail detail)
        {
            obj.EducationalDetails.Update(detail);
            obj.SaveChanges();
            return detail;
        }
        public Skill updateSkillDetails(Skill skill)
        {
            obj.Skills.Update(skill);
            obj.SaveChanges();
            return skill;
        }


        public CompanyDetail Cupdatebyid(CompanyDetail companyDetail)
        {
            obj.CompanyDetails.Update(companyDetail);
            obj.SaveChanges();
            return companyDetail;
        }
        public bool login(string Emailid, string Password)
        {
            try
            {
                var l = (from detail in obj.TraineeDetails
                         where detail.EmailId == Emailid
                         select detail).FirstOrDefault();
                if (l != null)
                {

                    var log = (from detail in obj.TraineeDetails
                               where detail.Password == Password
                               select detail).FirstOrDefault();
                    if (log != null)
                    {
                        return true;

                    }
                    return false;
                }
                return false;
            }
            catch(Exception e) {
                throw new("Something went wrong try again!");
            }

        }
}
}
