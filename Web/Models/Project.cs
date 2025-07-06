using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class Project
{
    public int Id { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    public string Desc { get; set; }

    public int ProgramFk { get; set; }

    public int TypeFk { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int UserFk { get; set; }

    public bool Approved { get; set; }

    public virtual ICollection<BidBatch> BidBatches { get; set; } = new List<BidBatch>();

    public virtual Program ProgramFkNavigation { get; set; }

    public virtual ProjectType TypeFkNavigation { get; set; }

    public virtual PortalUser UserFkNavigation { get; set; }
}
