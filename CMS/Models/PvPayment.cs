using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class PvPayment
{
    public int PaymentId { get; set; }

    public int PvFk { get; set; }

    public DateTime PaymentDate { get; set; }

    public double AmountPaid { get; set; }

    public double Balance { get; set; }

    public bool Approved { get; set; }

    public string Remarks { get; set; }

    public bool IntEnabled { get; set; }

    public DateTime? IntStartDate { get; set; }

    public int UserId { get; set; }

    public int DeptId { get; set; }

    public string CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public string UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ResDept Dept { get; set; }

    public virtual IdpInt IdpInt { get; set; }

    public virtual ICollection<IdpIntItem> IdpIntItems { get; set; } = new List<IdpIntItem>();

    public virtual Pv PvFkNavigation { get; set; }

    public virtual PortalUser User { get; set; }
}
