using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class BidDaywork
{
    public int Id { get; set; }

    public int BidFk { get; set; }

    public int? BidbaseFk { get; set; }

    public int DayworkFk { get; set; }

    public string Unit { get; set; }

    public double Quantity { get; set; }

    public double Rate { get; set; }

    public double Amount { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Bid BidFkNavigation { get; set; }

    public virtual BidBase BidbaseFkNavigation { get; set; }

    public virtual StandardDaywork DayworkFkNavigation { get; set; }
}
