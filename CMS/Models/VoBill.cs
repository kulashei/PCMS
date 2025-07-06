using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VoBill
{
    public int VoBillId { get; set; }

    public int Number { get; set; }

    public string BillNo { get; set; }

    public string BillDesc { get; set; }

    public string Remarks { get; set; }

    public int? BidBaseFk { get; set; }

    public int? BidBillFk { get; set; }

    public int ContractFk { get; set; }

    public int VoFk { get; set; }

    public int? VoBaseFk { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual BidBase BidBaseFkNavigation { get; set; }

    public virtual BidBill BidBillFkNavigation { get; set; }

    public virtual Contract ContractFkNavigation { get; set; }

    public virtual VoBase VoBaseFkNavigation { get; set; }

    public virtual ICollection<VoBillEx> VoBillExes { get; set; } = new List<VoBillEx>();

    public virtual Vo VoFkNavigation { get; set; }
}
