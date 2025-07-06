using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class VwBidBaseInfo
{
    public int BidBaseId { get; set; }

    public int? BidId { get; set; }

    public int? ContractId { get; set; }

    public int CatId { get; set; }

    public string CatName { get; set; }

    public string BaseDesc { get; set; }

    public int Namba { get; set; }

    public string BaseNo { get; set; }

    public string BaseTitle { get; set; }

    public int Culverts { get; set; }

    public double Distance { get; set; }

    public double DistStart { get; set; }

    public double DistEnd { get; set; }

    public string Notes { get; set; }

    public int ContractTypeId { get; set; }

    public string ContractTypeName { get; set; }

    public int RegionId { get; set; }

    public string RegionName { get; set; }

    public int AssemblyId { get; set; }

    public string AssemblyName { get; set; }

    public int RoadId { get; set; }

    public string RoadNumber { get; set; }

    public string RoadName { get; set; }
}
