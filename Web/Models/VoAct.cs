using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class VoAct
{
    public int VoactId { get; set; }

    public int VoFk { get; set; }

    public int? ContractActivityFk { get; set; }

    public int? BidBillExFk { get; set; }

    public int ActivityFk { get; set; }

    public int? WeitFk { get; set; }

    public int StandardProgressFk { get; set; }

    public int? ContractProgressFk { get; set; }

    public int? VoBillExFk { get; set; }

    public string Unit { get; set; }

    public double PrevQtty { get; set; }

    public double? PrevVoqtty { get; set; }

    public double Quantity { get; set; }

    public double Rate { get; set; }

    public string Options { get; set; }

    public bool IsNew { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual StandardActivity ActivityFkNavigation { get; set; }

    public virtual BidBillEx BidBillExFkNavigation { get; set; }

    public virtual ContractAct ContractActivityFkNavigation { get; set; }

    public virtual ContractProgress ContractProgressFkNavigation { get; set; }

    public virtual StandardProgress StandardProgressFkNavigation { get; set; }

    public virtual VoBillEx VoBillExFkNavigation { get; set; }

    public virtual Vo VoFkNavigation { get; set; }

    public virtual StandardWeit WeitFkNavigation { get; set; }
}
