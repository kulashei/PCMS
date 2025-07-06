using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class Program
{
    public int Id { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    public string Desc { get; set; }

    public string Obj { get; set; }

    public string Ben { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public int TypeFk { get; set; }

    /// <summary>
    /// Determines whether its regional etc. based on the code
    /// </summary>
    public int CoverageFk { get; set; }

    public int UserFk { get; set; }

    public bool Approved { get; set; }

    public virtual Coverage CoverageFkNavigation { get; set; }

    public virtual ICollection<ProgramAgent> ProgramAgents { get; set; } = new List<ProgramAgent>();

    public virtual ICollection<ProgramCost> ProgramCosts { get; set; } = new List<ProgramCost>();

    public virtual ICollection<ProgramDoc> ProgramDocs { get; set; } = new List<ProgramDoc>();

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    public virtual ProgramType TypeFkNavigation { get; set; }

    public virtual PortalUser UserFkNavigation { get; set; }
}
