using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class RmRegSummary
{
    public int Id { get; set; }

    public string District { get; set; }

    public string PackageNo { get; set; }

    public double? BudgetEstGh { get; set; }

    public double? ContractEstGh { get; set; }
}
