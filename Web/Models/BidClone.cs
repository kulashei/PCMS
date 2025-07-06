using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class BidClone
{
    public int BidCloneId { get; set; }

    public int SourceFk { get; set; }

    public int DestinationFk { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual BidBase DestinationFkNavigation { get; set; }

    public virtual BidBase SourceFkNavigation { get; set; }
}
