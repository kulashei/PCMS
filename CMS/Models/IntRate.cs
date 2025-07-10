using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class IntRate
{
    public int Id { get; set; }

    public DateTime Daet { get; set; }

    public double Rate { get; set; }

    public bool Used { get; set; }

    public bool Approved { get; set; }

    public int? ApprovedBy { get; set; }

    public DateTime? ApprovedAt { get; set; }

    public string Sours { get; set; }

    public string Comment { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual PortalUser ApprovedByNavigation { get; set; }

    public virtual PortalUser CreatedByNavigation { get; set; }
}
