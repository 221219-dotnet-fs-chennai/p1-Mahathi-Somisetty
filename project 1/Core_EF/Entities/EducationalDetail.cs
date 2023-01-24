using System;
using System.Collections.Generic;

namespace Core_EF.Entities;

public partial class EducationalDetail
{
    public int TraineeId { get; set; }

    public string? Hqualification { get; set; }

    public string? YearOfPassing { get; set; }

    public string? Stream { get; set; }

    public string? Percentage { get; set; }

    public virtual TraineeDetail Trainee { get; set; } = null!;
}
