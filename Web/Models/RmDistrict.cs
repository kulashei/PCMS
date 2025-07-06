using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class RmDistrict
{
    public int Id { get; set; }

    public string RegionName { get; set; }

    public string DistrictName { get; set; }

    public string RdNr { get; set; }
}
