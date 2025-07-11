using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class Region
{
    public int RegionId { get; set; }

    public string RegionCode { get; set; }

    public string Descriptionreg { get; set; }

    public virtual ICollection<District> Districts { get; set; } = new List<District>();

    public virtual ICollection<ResDept> ResDepts { get; set; } = new List<ResDept>();
}
