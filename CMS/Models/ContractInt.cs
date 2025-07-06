using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class ContractInt
{
    public int Id { get; set; }

    public int BidFk { get; set; }

    public int? ContractFk { get; set; }

    public double Duration { get; set; }

    public string DelayIn { get; set; }

    public string IntType { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Bid BidFkNavigation { get; set; }

    public virtual Contract ContractFkNavigation { get; set; }
}
