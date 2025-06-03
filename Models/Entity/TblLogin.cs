using System;
using System.Collections.Generic;

namespace DynamicCv.Models.Entity;

public partial class TblLogin
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }
}
