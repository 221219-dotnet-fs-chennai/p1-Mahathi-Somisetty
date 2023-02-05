using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SkillD
    {
        public SkillD()
        {

        }

        public int TraineeId
        {
            get; set;
        }
        public string? Skill_name
        {
            get; set;
        }
        public string? Skill_Type
        {
            get; set;
        }
        public string? Expertise
        {
            get; set;
        }
        public string SkillDetail()
        {
        return $@"{TraineeId},{Skill_name},{Skill_Type},{Expertise}";

        }
    }
    
}
