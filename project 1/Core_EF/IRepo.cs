using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core_EF.Entities;

namespace Core_EF
{
    public interface IRepo
    {
        List<Core_EF.Entities.TraineeDetail> GetTraineeDetails();
        List<Core_EF.Entities.Skill> GetSkillDetails();
        List<Core_EF.Alldetails> GetAllDetails();
        
        TraineeDetail AddTraineeDetails(TraineeDetail trineeDetail);
        Skill AddSkillDetails(Skill skill);
        EducationalDetail AddEducationalDetails(EducationalDetail educationalDetail);
        CompanyDetail AddCompanyDetails(CompanyDetail companyDetail);

        TraineeDetail DeleteAllDetails(int id);

        TraineeDetail updatebyid(TraineeDetail details);
          
    }
}
