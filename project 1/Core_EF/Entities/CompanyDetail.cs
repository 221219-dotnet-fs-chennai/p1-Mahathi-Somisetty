using System;
using System.Collections.Generic;

namespace Core_EF.Entities;

public partial class CompanyDetail
{
    public int TraineeId { get; set; }

    public string? Company_name { get; set; }

    public string? ProjectName { get; set; }

    public string? Position { get; set; }

    public string? Experience { get; set; }

    public virtual TraineeDetail Trainee { get; set; } = null!;
    
}
