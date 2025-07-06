using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class ResDept
{
    public int DeptId { get; set; }

    public string DeptCode { get; set; }

    public string DeptDesc { get; set; }

    public bool IsDeputy { get; set; }

    public int? HodUserFk { get; set; }

    public int? DelegatedFk { get; set; }

    public int RegionFk { get; set; }

    public virtual ICollection<Bid> Bids { get; set; } = new List<Bid>();

    public virtual ICollection<BoqItemDel> BoqItemDels { get; set; } = new List<BoqItemDel>();

    public virtual ICollection<Boq> Boqs { get; set; } = new List<Boq>();

    public virtual ICollection<Closure> Closures { get; set; } = new List<Closure>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual PortalUser DelegatedFkNavigation { get; set; }

    public virtual ICollection<HcmEmployee> HcmEmployees { get; set; } = new List<HcmEmployee>();

    public virtual PortalUser HodUserFkNavigation { get; set; }

    public virtual ICollection<PortalUser> PortalUsers { get; set; } = new List<PortalUser>();

    public virtual ICollection<PvPayment> PvPayments { get; set; } = new List<PvPayment>();

    public virtual ICollection<Pv> Pvs { get; set; } = new List<Pv>();

    public virtual Region RegionFkNavigation { get; set; }

    public virtual ICollection<ResDeptFlow> ResDeptFlows { get; set; } = new List<ResDeptFlow>();

    public virtual ICollection<Voext> Voexts { get; set; } = new List<Voext>();

    public virtual ICollection<Vo> Vos { get; set; } = new List<Vo>();
}
