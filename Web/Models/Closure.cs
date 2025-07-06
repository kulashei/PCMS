using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class Closure
{
    public int Id { get; set; }

    public int ContractFk { get; set; }

    public int ApprovedBy { get; set; }

    public DateOnly ApprovedDate { get; set; }

    public DateOnly CompletedDate { get; set; }

    public string Reason { get; set; }

    public string Remarks { get; set; }

    public bool Approved { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int StatusFk { get; set; }

    public int UserId { get; set; }

    public int DeptId { get; set; }

    public virtual PortalUser ApprovedByNavigation { get; set; }

    public virtual ICollection<ClosureDoc> ClosureDocs { get; set; } = new List<ClosureDoc>();

    public virtual Contract ContractFkNavigation { get; set; }

    public virtual PortalUser CreatedByNavigation { get; set; }

    public virtual ResDept Dept { get; set; }

    public virtual ContractStatus StatusFkNavigation { get; set; }

    public virtual PortalUser User { get; set; }
}
