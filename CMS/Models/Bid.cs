using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class Bid
{
    public int BidId { get; set; }

    public int? BidBatchFk { get; set; }

    public string LotNo { get; set; }

    public string BidNo { get; set; }

    public string BidTitle { get; set; }

    public double Physical { get; set; }

    public double Price { get; set; }

    public bool IsPacked { get; set; }

    public bool Approved { get; set; }

    public bool Archived { get; set; }

    public string Notes { get; set; }

    public int UserId { get; set; }

    public int DeptId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<BidBase> BidBases { get; set; } = new List<BidBase>();

    public virtual BidBatch BidBatchFkNavigation { get; set; }

    public virtual ICollection<BidClause> BidClauses { get; set; } = new List<BidClause>();

    public virtual ICollection<BidDaywork> BidDayworks { get; set; } = new List<BidDaywork>();

    public virtual ICollection<BidSublet> BidSublets { get; set; } = new List<BidSublet>();

    public virtual BidWeitEx BidWeitEx { get; set; }

    public virtual ICollection<BidWeit> BidWeits { get; set; } = new List<BidWeit>();

    public virtual ICollection<Bidder> Bidders { get; set; } = new List<Bidder>();

    public virtual ContractInt ContractInt { get; set; }

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ResDept Dept { get; set; }

    public virtual PortalUser User { get; set; }
}
