using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class Idp
{
    public int Id { get; set; }

    public int ContractFk { get; set; }

    public int? CurrentBoqFk { get; set; }

    public int IdpNamb { get; set; }

    public string IdpDesc { get; set; }

    public DateOnly RequestedAt { get; set; }

    public bool Approved { get; set; }

    public int? ApprovedBy { get; set; }

    public DateOnly? ApprovedAt { get; set; }

    public string Remarks { get; set; }

    public int UserId { get; set; }

    public int DeptId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool Archived { get; set; }

    public virtual PortalUser ApprovedByNavigation { get; set; }

    public virtual Contract ContractFkNavigation { get; set; }

    public virtual Boq CurrentBoqFkNavigation { get; set; }

    public virtual ICollection<IdpDoc> IdpDocs { get; set; } = new List<IdpDoc>();

    public virtual ICollection<IdpInt> IdpInts { get; set; } = new List<IdpInt>();

    public virtual PortalUser User { get; set; }
}
