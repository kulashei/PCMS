using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class BoqProgress
{
    public int BoqProgressId { get; set; }

    public int ContractFk { get; set; }

    public int BoqFk { get; set; }

    public int ContractProgressFk { get; set; }

    public double Previous { get; set; }

    public double Current { get; set; }

    public double Total { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Boq BoqFkNavigation { get; set; }

    public virtual Contract ContractFkNavigation { get; set; }

    public virtual ContractProgress ContractProgressFkNavigation { get; set; }
}
