using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DynamicCv.Models.Entity;

public partial class TblEducation
{
    public int Id { get; set; }

    [Required(ErrorMessage ="This area must be fill")]
    public string? Title { get; set; }

    public string? SubTitle { get; set; }

    public string? Description { get; set; }

    [StringLength(10,ErrorMessage ="Max 10 character")]
    public string? Gno { get; set; }

    public string? Date { get; set; }
}
