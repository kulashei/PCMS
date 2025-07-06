using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class BidConPlc
{
    public int BidBaseId { get; set; }

    public int? BidFk { get; set; }

    public int? ContractFk { get; set; }

    public string Region { get; set; }

    public string AssemblyName { get; set; }
}
