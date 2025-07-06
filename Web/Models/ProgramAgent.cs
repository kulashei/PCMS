using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class ProgramAgent
{
    public int Id { get; set; }

    public int ProgramFk { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Program ProgramFkNavigation { get; set; }
}
