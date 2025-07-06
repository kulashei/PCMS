using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class Region
{
    public int RegionId { get; set; }

    public string RegionCode { get; set; }

    public string Descriptionreg { get; set; }

    public virtual ICollection<Assembly> Assemblies { get; set; } = new List<Assembly>();

    public virtual ICollection<ResDept> ResDepts { get; set; } = new List<ResDept>();
}
