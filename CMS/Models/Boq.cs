using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class Boq
{
    public int BoqId { get; set; }

    public int ContractId { get; set; }

    public string BillNo { get; set; }

    public string BillDesc { get; set; }

    public bool IsLate { get; set; }

    public DateOnly BillDate { get; set; }

    public DateOnly? WorkStartDate { get; set; }

    public DateOnly? WorkEndDate { get; set; }

    public double ActivityAmount { get; set; }

    public double NonAdjustableSums { get; set; }

    public double LessNonAdjustableSums { get; set; }

    public double AmountLessProvSum { get; set; }

    public double ProductSubTotal { get; set; }

    public double BillsTotal { get; set; }

    public string Remarks { get; set; }

    public bool Approved { get; set; }

    public bool Archived { get; set; }

    public double IpcTotalAmount { get; set; }

    public double IpcPreviousAmount { get; set; }

    public int? IpcPreparedBy { get; set; }

    public int? IpcApprovedBy { get; set; }

    public int BoqCatFk { get; set; }

    public bool ApplyTerminationClause { get; set; }

    public int UserId { get; set; }

    public int DeptId { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateOnly? PafMonth { get; set; }

    public virtual BoqCat BoqCatFkNavigation { get; set; }

    public virtual ICollection<BoqDamage> BoqDamages { get; set; } = new List<BoqDamage>();

    public virtual ICollection<BoqDoc> BoqDocs { get; set; } = new List<BoqDoc>();

    public virtual ICollection<BoqDrawing> BoqDrawings { get; set; } = new List<BoqDrawing>();

    public virtual ICollection<BoqItemDel> BoqItemDels { get; set; } = new List<BoqItemDel>();

    public virtual ICollection<BoqItem> BoqItems { get; set; } = new List<BoqItem>();

    public virtual ICollection<BoqPaf> BoqPafBoqFkNavigations { get; set; } = new List<BoqPaf>();

    public virtual ICollection<BoqPaf> BoqPafExecBoqFkNavigations { get; set; } = new List<BoqPaf>();

    public virtual ICollection<BoqPafWeit> BoqPafWeits { get; set; } = new List<BoqPafWeit>();

    public virtual ICollection<BoqProgress> BoqProgresses { get; set; } = new List<BoqProgress>();

    public virtual ICollection<BoqSublet> BoqSublets { get; set; } = new List<BoqSublet>();

    public virtual Contract Contract { get; set; }

    public virtual ICollection<ContractAdvPmt> ContractAdvPmts { get; set; } = new List<ContractAdvPmt>();

    public virtual ICollection<ContractPlantPmt> ContractPlantPmts { get; set; } = new List<ContractPlantPmt>();

    public virtual ResDept Dept { get; set; }

    public virtual ICollection<IdpInt> IdpInts { get; set; } = new List<IdpInt>();

    public virtual ICollection<Idp> Idps { get; set; } = new List<Idp>();

    public virtual PortalUser IpcApprovedByNavigation { get; set; }

    public virtual PortalUser IpcPreparedByNavigation { get; set; }

    public virtual ICollection<IpcaddOmit> IpcaddOmits { get; set; } = new List<IpcaddOmit>();

    public virtual ICollection<Ipcback> Ipcbacks { get; set; } = new List<Ipcback>();

    public virtual Ipcfront Ipcfront { get; set; }

    public virtual Pv Pv { get; set; }

    public virtual PortalUser User { get; set; }
}
