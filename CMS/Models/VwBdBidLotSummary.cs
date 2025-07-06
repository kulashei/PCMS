using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwBdBidLotSummary
{
    public int BidId { get; set; }

    public int BidBaseId { get; set; }

    public int Namba { get; set; }

    public string BidNo { get; set; }

    public string BidTitle { get; set; }

    public string BaseNo { get; set; }

    public string BaseTitle { get; set; }

    public decimal Amount { get; set; }
}
