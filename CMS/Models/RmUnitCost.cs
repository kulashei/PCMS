using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class RmUnitCost
{
    public int? Id { get; set; }

    public string Category { get; set; }

    public string Actno { get; set; }

    public string Description { get; set; }

    public string Unit { get; set; }

    public double? ArA { get; set; }

    public double? ArB { get; set; }

    public double? ArC { get; set; }

    public double? ArD { get; set; }

    public double? ArE { get; set; }

    public string Note { get; set; }
}
