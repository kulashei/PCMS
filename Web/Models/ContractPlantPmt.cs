using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class ContractPlantPmt
{
    public int PaymentId { get; set; }

    public int ContractPlantFk { get; set; }

    public int BoqFk { get; set; }

    public double PrevAmount { get; set; }

    public double CurrentAmount { get; set; }

    public double CertAmount { get; set; }

    public int? CreatedBy { get; set; }

    public DateOnly CreatedAt { get; set; }

    public virtual Boq BoqFkNavigation { get; set; }

    public virtual ContractPlant ContractPlantFkNavigation { get; set; }
}
