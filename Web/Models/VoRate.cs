using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class VoRate
{
    public int VoRateId { get; set; }

    public int VoFk { get; set; }

    public int? ContractActivityFk { get; set; }

    public double PrevQtty { get; set; }

    public double? PrevRate { get; set; }

    public double NewRate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ContractAct ContractActivityFkNavigation { get; set; }

    public virtual Vo VoFkNavigation { get; set; }
}
