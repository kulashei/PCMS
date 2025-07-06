using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class ContractDaywork
{
    public int Id { get; set; }

    public int ContractFk { get; set; }

    public int BidbaseFk { get; set; }

    public int DayworkFk { get; set; }

    public string Unit { get; set; }

    public double Quantity { get; set; }

    public double Voqtty { get; set; }

    public double Rate { get; set; }

    public double Amount { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual BidBase BidbaseFkNavigation { get; set; }

    public virtual Contract ContractFkNavigation { get; set; }

    public virtual StandardDaywork DayworkFkNavigation { get; set; }
}
