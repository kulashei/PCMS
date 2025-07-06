using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class Bidder
{
    public int BidderId { get; set; }

    public int BidId { get; set; }

    public int ContractorId { get; set; }

    public double BidCost { get; set; }

    public string Currency { get; set; }

    public DateTime BidDate { get; set; }

    public string SubmittedBy { get; set; }

    public string Mobile { get; set; }

    public string Email { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Bid Bid { get; set; }

    public virtual ICollection<BidRead> BidReads { get; set; } = new List<BidRead>();

    public virtual Contractor Contractor { get; set; }
}
