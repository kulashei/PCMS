using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class BidRead
{
    public int Id { get; set; }

    public int BidderFk { get; set; }

    public double BidAmount { get; set; }

    public bool Secured { get; set; }

    public bool Signed { get; set; }

    public bool Tax { get; set; }

    public bool Ssnit { get; set; }

    public bool Labour { get; set; }

    public bool Sealed { get; set; }

    public string Currency { get; set; }

    public string Remarks { get; set; }

    public int UserFk { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Bidder BidderFkNavigation { get; set; }

    public virtual PortalUser UserFkNavigation { get; set; }
}
