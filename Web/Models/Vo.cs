using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class Vo
{
    public int VoId { get; set; }

    public int ContractId { get; set; }

    public string VNo { get; set; }

    public DateOnly RequestedDate { get; set; }

    public string RequestedReason { get; set; }

    public double AdditionSum { get; set; }

    public string AdditionDesc { get; set; }

    public double OmissionSum { get; set; }

    public string OmissionDesc { get; set; }

    public string Remarks { get; set; }

    public int? ApprovedBy { get; set; }

    public DateOnly? ApprovedDate { get; set; }

    public DateOnly? NewCompletionDate { get; set; }

    public bool Approved { get; set; }

    public int UserId { get; set; }

    public int DeptId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool Archived { get; set; }

    public virtual Contract Contract { get; set; }

    public virtual ResDept Dept { get; set; }

    public virtual PortalUser User { get; set; }

    public virtual ICollection<VoAct> VoActs { get; set; } = new List<VoAct>();

    public virtual ICollection<VoBase> VoBases { get; set; } = new List<VoBase>();

    public virtual ICollection<VoBillEx> VoBillExes { get; set; } = new List<VoBillEx>();

    public virtual ICollection<VoBill> VoBills { get; set; } = new List<VoBill>();

    public virtual ICollection<VoDocument> VoDocuments { get; set; } = new List<VoDocument>();

    public virtual ICollection<VoProgress> VoProgresses { get; set; } = new List<VoProgress>();

    public virtual ICollection<VoRate> VoRates { get; set; } = new List<VoRate>();
}
