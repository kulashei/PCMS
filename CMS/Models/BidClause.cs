using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class BidClause
{
    public int Id { get; set; }

    public int BidFk { get; set; }

    public int? ContractFk { get; set; }

    public int ClauseFk { get; set; }

    public double Value { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Bid BidFkNavigation { get; set; }

    public virtual StandardClause ClauseFkNavigation { get; set; }

    public virtual Contract ContractFkNavigation { get; set; }
}
