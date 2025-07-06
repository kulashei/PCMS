using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class Contract
{
    public int ContractId { get; set; }

    public string ContractCode { get; set; }

    public string ContractTitle { get; set; }

    public string ContractDesc { get; set; }

    public bool Fixed { get; set; }

    public DateOnly BaseMonth { get; set; }

    public DateOnly AwardDate { get; set; }

    public DateOnly? SiteDate { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public DateOnly? RevisedDate { get; set; }

    public DateOnly? ActualDate { get; set; }

    public DateOnly? NoPafDate { get; set; }

    public double AdjAmount { get; set; }

    public string Currency { get; set; }

    public bool IsPacked { get; set; }

    public bool Archived { get; set; }

    public bool Approved { get; set; }

    public int? ApprovedBy { get; set; }

    public DateTime? ApprovedAt { get; set; }

    public int BidId { get; set; }

    public int ManagerFk { get; set; }

    public int ContractorId { get; set; }

    public int ContractStatusId { get; set; }

    public int ContractTypeFk { get; set; }

    public int UserId { get; set; }

    public int DeptId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual PortalUser ApprovedByNavigation { get; set; }

    public virtual Bid Bid { get; set; }

    public virtual ICollection<BidBase> BidBases { get; set; } = new List<BidBase>();

    public virtual ICollection<BidBillEx> BidBillExes { get; set; } = new List<BidBillEx>();

    public virtual ICollection<BidBill> BidBills { get; set; } = new List<BidBill>();

    public virtual ICollection<BidClause> BidClauses { get; set; } = new List<BidClause>();

    public virtual ICollection<BidWeitEx> BidWeitExes { get; set; } = new List<BidWeitEx>();

    public virtual ICollection<BidWeit> BidWeits { get; set; } = new List<BidWeit>();

    public virtual ICollection<BoqDamage> BoqDamages { get; set; } = new List<BoqDamage>();

    public virtual ICollection<BoqDrawing> BoqDrawings { get; set; } = new List<BoqDrawing>();

    public virtual BoqPafWeitEx BoqPafWeitEx { get; set; }

    public virtual ICollection<BoqPaf> BoqPafs { get; set; } = new List<BoqPaf>();

    public virtual ICollection<BoqProgress> BoqProgresses { get; set; } = new List<BoqProgress>();

    public virtual ICollection<Boq> Boqs { get; set; } = new List<Boq>();

    public virtual Closure Closure { get; set; }

    public virtual ICollection<ClosureDoc> ClosureDocs { get; set; } = new List<ClosureDoc>();

    public virtual ICollection<ContractAct> ContractActs { get; set; } = new List<ContractAct>();

    public virtual ICollection<ContractAdvDoc> ContractAdvDocs { get; set; } = new List<ContractAdvDoc>();

    public virtual ICollection<ContractAdv> ContractAdvs { get; set; } = new List<ContractAdv>();

    public virtual ICollection<ContractCost> ContractCosts { get; set; } = new List<ContractCost>();

    public virtual ICollection<ContractDaywork> ContractDayworks { get; set; } = new List<ContractDaywork>();

    public virtual ICollection<ContractDoc> ContractDocs { get; set; } = new List<ContractDoc>();

    public virtual ICollection<ContractInt> ContractInts { get; set; } = new List<ContractInt>();

    public virtual ICollection<ContractPlant> ContractPlants { get; set; } = new List<ContractPlant>();

    public virtual ICollection<ContractProgress> ContractProgresses { get; set; } = new List<ContractProgress>();

    public virtual ContractStatus ContractStatus { get; set; }

    public virtual ICollection<ContractSublet> ContractSublets { get; set; } = new List<ContractSublet>();

    public virtual ContractType ContractTypeFkNavigation { get; set; }

    public virtual Contractor Contractor { get; set; }

    public virtual ResDept Dept { get; set; }

    public virtual ICollection<IdpInt> IdpInts { get; set; } = new List<IdpInt>();

    public virtual ICollection<Idp> Idps { get; set; } = new List<Idp>();

    public virtual ICollection<IpcaddOmit> IpcaddOmits { get; set; } = new List<IpcaddOmit>();

    public virtual ICollection<Ipcback> Ipcbacks { get; set; } = new List<Ipcback>();

    public virtual PortalUser ManagerFkNavigation { get; set; }

    public virtual ICollection<Pv> Pvs { get; set; } = new List<Pv>();

    public virtual PortalUser User { get; set; }

    public virtual ICollection<VoBill> VoBills { get; set; } = new List<VoBill>();

    public virtual ICollection<Voext> Voexts { get; set; } = new List<Voext>();

    public virtual ICollection<Vo> Vos { get; set; } = new List<Vo>();
}
