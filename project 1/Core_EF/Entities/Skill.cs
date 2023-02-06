using System;
using System.Collections.Generic;

namespace Core_EF.Entities;

public partial class Skill
{
    public int TraineeId { get; set; }

    public string? Skill_name { get; set; }

    public string? Skill_Type { get; set; }

    public string? Expertise { get; set; }

    public virtual TraineeDetail Trainee { get; set; } = null!;
}
