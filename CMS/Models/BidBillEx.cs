using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class BidBillEx
{
    public int BidBillExId { get; set; }

    public int BidBillFk { get; set; }

    public int? ContractFk { get; set; }

    public int SubNo { get; set; }

    public string SubName { get; set; }

    public virtual ICollection<BidAct> BidActs { get; set; } = new List<BidAct>();

    public virtual BidBill BidBillFkNavigation { get; set; }

    public virtual ICollection<ContractAct> ContractActs { get; set; } = new List<ContractAct>();

    public virtual Contract ContractFkNavigation { get; set; }

    public virtual ICollection<VoAct> VoActs { get; set; } = new List<VoAct>();

    public virtual ICollection<VoBillEx> VoBillExes { get; set; } = new List<VoBillEx>();
}
