using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class BidBill
{
    public int BidBillId { get; set; }

    public int Number { get; set; }

    public string BillNo { get; set; }

    public string BillDesc { get; set; }

    public int? BidBaseFk { get; set; }

    public int? ContractFk { get; set; }

    public string Remarks { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual BidBase BidBaseFkNavigation { get; set; }

    public virtual ICollection<BidBillEx> BidBillExes { get; set; } = new List<BidBillEx>();

    public virtual Contract ContractFkNavigation { get; set; }

    public virtual ICollection<VoBillEx> VoBillExes { get; set; } = new List<VoBillEx>();

    public virtual ICollection<VoBill> VoBills { get; set; } = new List<VoBill>();
}
