using System;
using System.Collections.Generic;

namespace DynamicCv.Models.Entity;

public partial class TblCertificate
{
    public int Id { get; set; }

    public string? Certificate { get; set; }
    public string? Date {  get; set; }
}
