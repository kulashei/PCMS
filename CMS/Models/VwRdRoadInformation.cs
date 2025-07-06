using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwRdRoadInformation
{
    public int RoadId { get; set; }

    public string RoadNumber { get; set; }

    public string RoadName { get; set; }

    public string RoadDescription { get; set; }

    public double RdLength { get; set; }

    public string RdId { get; set; }

    public string Region { get; set; }

    public string District { get; set; }

    public string Fnode { get; set; }

    public string Tnode { get; set; }

    public string FncClass { get; set; }

    public string Fvilla { get; set; }

    public string Tvilla { get; set; }
}
