using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwCtContractProgress
{
    public int ContractFk { get; set; }

    public int ContractProgressId { get; set; }

    public int ProgressCatId { get; set; }

    public string ProgressCatName { get; set; }

    public int ProgressId { get; set; }

    public string ProgressCode { get; set; }

    public string ProgressName { get; set; }

    public string ProgressCat { get; set; }

    public bool ProgressActive { get; set; }

    public string ProgressUnit { get; set; }

    public double InitSchedule { get; set; }

    public double VoSchedule { get; set; }

    public double TotalSchedule { get; set; }

    public double ProgressAmount { get; set; }

    public double BoqSchedule { get; set; }

    public int BidBaseId { get; set; }

    public int Namba { get; set; }

    public string BaseNo { get; set; }

    public string BaseTitle { get; set; }

    public int Culverts { get; set; }

    public double Distance { get; set; }

    public double DistStart { get; set; }

    public double DistEnd { get; set; }

    public string Notes { get; set; }

    public string Unit { get; set; }
}
