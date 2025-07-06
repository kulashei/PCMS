using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class Assembly
{
    public int AssemblyId { get; set; }

    public int RegionId { get; set; }

    public string AssemblyCode { get; set; }

    public string AssemblyName { get; set; }

    public string AssemblyType { get; set; }

    public string DistCode { get; set; }

    public virtual ICollection<BidBase> BidBases { get; set; } = new List<BidBase>();

    public virtual Region Region { get; set; }

    public virtual ICollection<VoBase> VoBases { get; set; } = new List<VoBase>();
}
