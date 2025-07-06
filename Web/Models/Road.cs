using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class Road
{
    public int RoadId { get; set; }

    public string RoadNumber { get; set; }

    public string RdId { get; set; }

    public string Region { get; set; }

    public string District { get; set; }

    public string ClassFk { get; set; }

    public string Fnode { get; set; }

    public string Tnode { get; set; }

    public double RdLength { get; set; }

    public string RoadName { get; set; }

    public string RoadDescription { get; set; }

    public virtual ICollection<BidBase> BidBases { get; set; } = new List<BidBase>();

    public virtual RdIrClass ClassFkNavigation { get; set; }

    public virtual ICollection<VoBase> VoBases { get; set; } = new List<VoBase>();
}
