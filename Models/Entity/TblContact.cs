using System;
using System.Collections.Generic;

namespace DynamicCv.Models.Entity;

public partial class TblContact
{
    public int Id { get; set; }

    public string? Namesurname { get; set; }

    public string? Email { get; set; }

    public string? Subject { get; set; }

    public string? Message { get; set; }

    public string? Date { get; set; }
}
