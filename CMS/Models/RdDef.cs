using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class RdDef
{
    public int ObjectId { get; set; }

    public string RdId { get; set; }

    public string RdNr { get; set; }

    public string Region { get; set; }

    public string District { get; set; }

    public string FncClass { get; set; }

    public string Fnode { get; set; }

    public string Tnode { get; set; }

    public double? Length { get; set; }

    public int? RegionFk { get; set; }

    public int? AssemblyFk { get; set; }
}
