using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class Voext
{
    public int Id { get; set; }

    public int ContractFk { get; set; }

    public DateTime CompDate { get; set; }

    public DateTime NewDate { get; set; }

    public DateTime ReqDate { get; set; }

    public string Reason { get; set; }

    public int Dur { get; set; }

    public int CoNam { get; set; }

    public DateTime? CoStart { get; set; }

    public int NoNam { get; set; }

    public DateTime? NoStart { get; set; }

    public bool Archived { get; set; }

    public bool Approved { get; set; }

    public int? ApprovedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public int UserId { get; set; }

    public int DeptId { get; set; }

    public string Remarks { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Contract ContractFkNavigation { get; set; }

    public virtual ResDept Dept { get; set; }

    public virtual PortalUser User { get; set; }

    public virtual ICollection<VoextCost> VoextCosts { get; set; } = new List<VoextCost>();

    public virtual ICollection<VoextDoc> VoextDocs { get; set; } = new List<VoextDoc>();
}
