using System;
using System.Collections.Generic;

namespace DynamicCv.Models.Entity;

public partial class TblAbout
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Photo { get; set; }

    public string? Description { get; set; }
}
