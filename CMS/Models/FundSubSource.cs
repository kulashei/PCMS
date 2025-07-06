using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class FundSubSource
{
    public int SubSourceId { get; set; }

    public string SubSourceCode { get; set; }

    public string SubSourceDesc { get; set; }

    public int FundSourceFk { get; set; }

    public virtual FundSource FundSourceFkNavigation { get; set; }

    public virtual ICollection<FundingBudget> FundingBudgets { get; set; } = new List<FundingBudget>();
}
