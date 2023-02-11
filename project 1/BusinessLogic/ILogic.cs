using Core_EF;
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
        IEnumerable<TrainerD> GetTraineeDetails();
        IEnumerable<SkillD> GetSkillDetails();
        IEnumerable<Core_EF.Alldetails> GetAllDetails();
        TrainerD AddTraineeDetails(TrainerD trainer);
        
        SkillD AddSkillDetails(SkillD skill);

        EducationalD AddEducationalDetails(EducationalD educational);

        CompanyD AddCompanyDetails(CompanyD company);
    }
}
