using System;
using System.Collections.Generic;

namespace DynamicCv.Models.Entity;

public partial class TblSocialMedia
{
    public int Id { get; set; }
    public string? AppName { get; set; }
    public string? Link { get; set; }
    public string? Icon { get; set; }
}
