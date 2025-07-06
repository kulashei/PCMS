using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class BidBatch
{
    public int BidBatchId { get; set; }

    public string BatchNo { get; set; }

    public string BatchTitle { get; set; }

    public DateOnly AdvertDate { get; set; }

    public DateOnly ClosingDate { get; set; }

    public int ProjectId { get; set; }

    public int BidTypeId { get; set; }

    public int CatId { get; set; }

    public bool IsLocked { get; set; }

    public string Notes { get; set; }

    public int UserId { get; set; }

    public int DeptId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual BidType BidType { get; set; }

    public virtual ICollection<Bid> Bids { get; set; } = new List<Bid>();

    public virtual Project Project { get; set; }
}
