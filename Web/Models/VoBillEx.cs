using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class VoBillEx
{
    public int VoBillExId { get; set; }

    public int VoFk { get; set; }

    public int? BidBillFk { get; set; }

    public int? VoBillFk { get; set; }

    public int? BidBillsExFk { get; set; }

    public int HeaderNo { get; set; }

    public string HeaderDesc { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual BidBill BidBillFkNavigation { get; set; }

    public virtual BidBillEx BidBillsExFkNavigation { get; set; }

    public virtual ICollection<VoAct> VoActs { get; set; } = new List<VoAct>();

    public virtual VoBill VoBillFkNavigation { get; set; }

    public virtual Vo VoFkNavigation { get; set; }
}
