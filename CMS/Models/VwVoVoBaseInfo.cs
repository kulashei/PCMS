﻿using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwVoVoBaseInfo
{
    public int ContractId { get; set; }

    public int? BidBaseId { get; set; }

    public int VoId { get; set; }

    public int VoBaseId { get; set; }

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
