using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class BidType
{
    public int Id { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    public virtual ICollection<BidBatch> BidBatches { get; set; } = new List<BidBatch>();
}
