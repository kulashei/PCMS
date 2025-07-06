using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class StandardDaywork
{
    public int Id { get; set; }

    public int CatFk { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    public string Unit { get; set; }

    public virtual ICollection<BidDaywork> BidDayworks { get; set; } = new List<BidDaywork>();

    public virtual StandardDayworkEx CatFkNavigation { get; set; }

    public virtual ICollection<ContractDaywork> ContractDayworks { get; set; } = new List<ContractDaywork>();
}
