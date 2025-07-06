using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class ContractType
{
    public int Id { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    public virtual ICollection<BidBase> BidBases { get; set; } = new List<BidBase>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ICollection<VoBase> VoBases { get; set; } = new List<VoBase>();
}
