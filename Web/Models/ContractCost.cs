using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class ContractCost
{
    public int ContractCostId { get; set; }

    public int ContractId { get; set; }

    public double ActivityAmount { get; set; }

    public double PhysicalPercentage { get; set; }

    public double PhysicalContingency { get; set; }

    public double PricePercentage { get; set; }

    public double PriceContingency { get; set; }

    public double DayWorks { get; set; }

    public double ProvisionalSums { get; set; }

    public double ContractAmount { get; set; }

    public double Equipment { get; set; }

    public double Labour { get; set; }

    public double Material { get; set; }

    public string Currency { get; set; }

    public DateOnly ValueDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Contract Contract { get; set; }
}
