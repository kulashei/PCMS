using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class District
{
    public int DistrictId { get; set; }

    public int RegionId { get; set; }

    public string DistrictCode { get; set; }

    public string DistrictName { get; set; }

    public string DistrictType { get; set; }

    public string DistCode { get; set; }

    public virtual ICollection<BidBase> BidBases { get; set; } = new List<BidBase>();

    public virtual Region Region { get; set; }

    public virtual ICollection<VoBase> VoBases { get; set; } = new List<VoBase>();
}
