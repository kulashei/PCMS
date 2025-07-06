using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class StandardActivity
{
    public int Id { get; set; }

    public int ActFk { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    public string Unit { get; set; }

    public int? ProgressFk { get; set; }

    public int? WeitFk { get; set; }

    public bool Active { get; set; }

    public string StandardProgress { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual StandardAct ActFkNavigation { get; set; }

    public virtual ICollection<BidAct> BidActs { get; set; } = new List<BidAct>();

    public virtual BoqPafExcept BoqPafExcept { get; set; }

    public virtual ICollection<ContractAct> ContractActs { get; set; } = new List<ContractAct>();

    public virtual ICollection<StandardActivityEx> StandardActivityExParentActNavigations { get; set; } = new List<StandardActivityEx>();

    public virtual ICollection<StandardActivityEx> StandardActivityExSubActNavigations { get; set; } = new List<StandardActivityEx>();

    public virtual ICollection<VoAct> VoActs { get; set; } = new List<VoAct>();
}
