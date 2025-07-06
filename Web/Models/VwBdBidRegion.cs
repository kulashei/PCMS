using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class VwBdBidRegion
{
    public int BidId { get; set; }

    public string LotNo { get; set; }

    public string BidNo { get; set; }

    public string BidTitle { get; set; }

    public bool IsPacked { get; set; }

    public int RegionId { get; set; }

    public string RegionCode { get; set; }

    public string RegionName { get; set; }
}
