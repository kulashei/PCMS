using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class IdpInt
{
    public int InterestId { get; set; }

    public int IdpFk { get; set; }

    public int BoqFk { get; set; }

    public int PvFk { get; set; }

    public int PaymentFk { get; set; }

    public int ContractFk { get; set; }

    public double CumInt { get; set; }

    public double IntOnly { get; set; }

    public string Remarks { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Boq BoqFkNavigation { get; set; }

    public virtual Contract ContractFkNavigation { get; set; }

    public virtual Idp IdpFkNavigation { get; set; }

    public virtual ICollection<IdpIntItem> IdpIntItems { get; set; } = new List<IdpIntItem>();

    public virtual PvPayment PaymentFkNavigation { get; set; }

    public virtual Pv PvFkNavigation { get; set; }
}
