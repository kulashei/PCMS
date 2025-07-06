using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class BoqPafWeit
{
    public int Id { get; set; }

    public int ContractFk { get; set; }

    public int BoqFk { get; set; }

    public int BidweitFk { get; set; }

    public double Paf { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual BidWeit BidweitFkNavigation { get; set; }

    public virtual Boq BoqFkNavigation { get; set; }
}
