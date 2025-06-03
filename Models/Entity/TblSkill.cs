using System;
using System.Collections.Generic;

namespace DynamicCv.Models.Entity;

public partial class TblSkill
{
    public int Id { get; set; }

    public string? Skill { get; set; }

    public byte? Progress { get; set; }
}
