using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class ProgramDoc
{
    public int Id { get; set; }

    public int ProgramFk { get; set; }

    public string FlName { get; set; }

    public string FlPath { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool Baked { get; set; }

    public virtual Programme ProgramFkNavigation { get; set; }
}
