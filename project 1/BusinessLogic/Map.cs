using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Cache;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Core_EF.Entities;

namespace BusinessLogic
{
    internal class Map
    {
        public static Model.TrainerD TrainerMap(Core_EF.Entities.TraineeDetail obj)
        {
            return new Model.TrainerD()
            {
                TraineeId = obj.TraineeId,
                EmailId = Validations.ValidEmailId(obj.EmailId),
                FullName = obj.FullName,
                Password = obj.Password,
                Gender = obj.Gender,
                Age = Convert.ToInt32(obj.Age),
                PhoneNumber = obj.PhoneNumber
            };
        }
        public static Core_EF.Entities.TraineeDetail TrainerMap(Model.TrainerD obj)
        {
            return new Core_EF.Entities.TraineeDetail()
            {
                TraineeId = obj.TraineeId,
                EmailId = Validations.ValidEmailId(obj.EmailId),
                FullName = obj.FullName,
                Password =obj.Password,
                Gender = obj.Gender,
                Age = Convert.ToInt32(obj.Age),
                PhoneNumber = obj.PhoneNumber

            };

        }
        public static Model.EducationalD EducationMap(Core_EF.Entities.EducationalDetail obj)
        {
            return new Model.EducationalD()
            {
                HQualification = obj.Hqualification,
                YearOfPassing = obj.YearOfPassing,
                Percentage = obj.Percentage,
                Stream = obj.Stream,

            };
        }
        public static Core_EF.Entities.EducationalDetail EducationMap(Model.EducationalD obj)
        {
            return new Core_EF.Entities.EducationalDetail()
            {
                Hqualification = obj.HQualification,
                YearOfPassing = obj.YearOfPassing,
                Percentage = obj.Percentage,
                Stream = obj.Stream,
            };
        }
        public static Model.CompanyD CompanyMap(Core_EF.Entities.CompanyDetail obj)
        {
            return new Model.CompanyD()
            {
                TraineeId = obj.TraineeId,
                Company_name = obj.Company_name,
                Project_Name = obj.ProjectName,
                Position = obj.Position,
                Experience = obj.Experience,
            };
        }
        public static Core_EF.Entities.CompanyDetail CompanyMap(Model.CompanyD obj)
        {
            return new Core_EF.Entities.CompanyDetail()
            {
                TraineeId = obj.TraineeId,
                Company_name = obj.Company_name,
                ProjectName = obj.Project_Name,
                Position = obj.Position,
                Experience = obj.Experience,
            };

        }
        public static Model.SkillD SkillMap(Core_EF.Entities.Skill obj)
        {
            return new Model.SkillD()
            {
                TraineeId = obj.TraineeId,
                Skill_name = obj.Skill_name,
                Skill_Type = obj.Skill_Type,
                Expertise = obj.Expertise,
            };
            
        }
        public static Core_EF.Entities.Skill SkillMap(Model.SkillD obj)
        {
            return new Core_EF.Entities.Skill()
            {
                TraineeId = obj.TraineeId,
                Skill_name = obj.Skill_name,
                Skill_Type = obj.Skill_Type,
                Expertise = obj.Expertise,
            };
        }

       

        /*public static Map.DetailsA detailsMap(Core_EF.Entities.Alldetails obj)
        {
            return new Map.DetailsA()
            {

            }
        }*/


        public static IEnumerable<Model.TrainerD> TrainerMap(IEnumerable<Core_EF.Entities.TraineeDetail> trainer)
        {
            return trainer.Select(TrainerMap);
        }
        public static IEnumerable<Model.CompanyD> CompanyMap(IEnumerable<Core_EF.Entities.CompanyDetail> trainer)
        {
            return trainer.Select(CompanyMap);
        }
        public static IEnumerable<Model.EducationalD> EducationMap(IEnumerable<Core_EF.Entities.EducationalDetail> trainer)
        {
            return trainer.Select(EducationMap);
        }
        public static IEnumerable<Model.SkillD> SkillMap(IEnumerable<Core_EF.Entities.Skill> trainer)
        {
            return trainer.Select(SkillMap);
        }
        //public static IEnumerable<Model.DetailsA>Map(IEnumerable<Core_EF.TraineeDetail> datas)
       
    }

}
