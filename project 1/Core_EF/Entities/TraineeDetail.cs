using System;
using System.Collections.Generic;

namespace Core_EF.Entities;

public partial class TraineeDetail
{
    public int TraineeId { get; set; }

    public string? FullName { get; set; }

    public string EmailId { get; set; } = null!;

    public string? Gender { get; set; }

    public int Age { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Password { get; set; }

    public virtual CompanyDetail? CompanyDetail { get; set; }
    
    public virtual EducationalDetail? EducationalDetail { get; set; }

    public virtual Skill? Skill { get; set; }
}
