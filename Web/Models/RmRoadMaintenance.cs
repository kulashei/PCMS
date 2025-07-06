using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class RmRoadMaintenance
{
    public int Id { get; set; }

    public string Category { get; set; }

    public string No { get; set; }

    public string Description { get; set; }

    public string Unit { get; set; }

    public double? UnitCost { get; set; }

    public double? BudgetQuantity { get; set; }

    public double? BudgetCost { get; set; }

    public double? ContractQuantity { get; set; }

    public double? ContractCost { get; set; }
}
