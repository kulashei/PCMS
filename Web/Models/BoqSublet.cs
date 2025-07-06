using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class BoqSublet
{
    public int Id { get; set; }

    public int BoqFk { get; set; }

    public int SubletFk { get; set; }

    public double GrossValue { get; set; }

    public double Less5or10 { get; set; }

    public double Less5or10Amnt { get; set; }

    public double NetAmount { get; set; }

    public double LastCertAmnt { get; set; }

    public double AmntNowDue { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Boq BoqFkNavigation { get; set; }

    public virtual ContractSublet SubletFkNavigation { get; set; }
}
