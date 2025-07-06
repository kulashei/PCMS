using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class BidAct
{
    public int BidActivityId { get; set; }

    public int BidBillExFk { get; set; }

    public int ActivityFk { get; set; }

    public string Unit { get; set; }

    public double Quantity { get; set; }

    public double Rate { get; set; }

    public double Amount { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual StandardActivity ActivityFkNavigation { get; set; }

    public virtual BidBillEx BidBillExFkNavigation { get; set; }
}
