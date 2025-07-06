using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class ContractAct
{
    public int ContractActivityId { get; set; }

    public int ContractFk { get; set; }

    public int? BidBillExFk { get; set; }

    public int ActivityFk { get; set; }

    public int? BidweitFk { get; set; }

    public int? ContractProgressFk { get; set; }

    public string Unit { get; set; }

    public double Quantity { get; set; }

    public double Voqtty { get; set; }

    public double Rate { get; set; }

    public double Amount { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual StandardActivity ActivityFkNavigation { get; set; }

    public virtual BidBillEx BidBillExFkNavigation { get; set; }

    public virtual StandardWeit BidweitFkNavigation { get; set; }

    public virtual ICollection<BoqItemDel> BoqItemDels { get; set; } = new List<BoqItemDel>();

    public virtual ICollection<BoqItem> BoqItems { get; set; } = new List<BoqItem>();

    public virtual Contract ContractFkNavigation { get; set; }

    public virtual ContractProgress ContractProgressFkNavigation { get; set; }

    public virtual ICollection<VoAct> VoActs { get; set; } = new List<VoAct>();

    public virtual ICollection<VoRate> VoRates { get; set; } = new List<VoRate>();
}
