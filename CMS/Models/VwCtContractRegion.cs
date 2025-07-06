using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwCtContractRegion
{
    public int? ContractFk { get; set; }

    public int RegionId { get; set; }

    public string RegionCode { get; set; }

    public string RegionName { get; set; }

    public string District { get; set; }
}
