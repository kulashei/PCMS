using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class ContractAdvPmt
{
    public int PaymentId { get; set; }

    public int ContractAdvFk { get; set; }

    public int BoqFk { get; set; }

    public double PrevAmount { get; set; }

    public double CurrentAmount { get; set; }

    public double CertAmount { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Boq BoqFkNavigation { get; set; }

    public virtual ContractAdv ContractAdvFkNavigation { get; set; }
}
