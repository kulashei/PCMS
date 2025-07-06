using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class RmDistSum
{
    public double Id { get; set; }

    public string District { get; set; }

    public string Cpno { get; set; }

    public string RoadNo { get; set; }

    public double? Bestimate { get; set; }

    public double? Cestimate { get; set; }
}
