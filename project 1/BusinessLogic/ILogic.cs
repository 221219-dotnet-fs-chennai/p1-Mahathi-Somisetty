using Core_EF;
using Core_EF.Entities;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface ILogic
    {
        // get trainer details
        IEnumerable<TrainerD> GetTraineeDetails();
        //get skill details
        IEnumerable<SkillD> GetSkillDetails();
        //get Alldetails
        IEnumerable<EducationalD> GetEducationalDetails();//Education details
        IEnumerable<CompanyD> GetCompanyDetails();//Company details
        IEnumerable<Core_EF.Alldetails> GetAllDetails();
        //Add trainer details
        TrainerD AddTraineeDetails(TrainerD trainer);
        //add skill details
        SkillD AddSkillDetails(SkillD skill);
        //add educational details
        EducationalD AddEducationalDetails(EducationalD educational);
        //add educational details
        CompanyD AddCompanyDetails(CompanyD company);
        //delete all details
       TrainerD DeleteAllDetails(string email);
        //update trainer details by id
       TrainerD updatebyid(int id, TrainerD trainer);
       EducationalD Edupdatebyid(int id, EducationalD educational);

        SkillD Supdatebyid(int id, SkillD skill);
        CompanyD Cupdatebyid(int id, CompanyD company);
        bool login(string Emailid,string Password);
        IEnumerable<SkillD> FindTrainerBySkill(string skill);
    }
}
