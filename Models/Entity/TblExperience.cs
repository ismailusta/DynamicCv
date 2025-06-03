using System;
using System.Collections.Generic;

namespace DynamicCv.Models.Entity;

public partial class TblExperience
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? SubTitle { get; set; }

    public string? Description { get; set; }

    public string? Date { get; set; }
}
