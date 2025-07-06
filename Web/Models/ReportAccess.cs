using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class ReportAccess
{
    public int Id { get; set; }

    public string ReportId { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    public string Cat { get; set; }

    public int ContractId { get; set; }

    public int BidId { get; set; }

    public int BoqId { get; set; }

    public int VoId { get; set; }

    public int PvId { get; set; }

    public int RegionId { get; set; }

    public int ContractTypeId { get; set; }

    public int ContractorId { get; set; }

    public int ActId { get; set; }

    public int ProjId { get; set; }

    public DateOnly? InitDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool Prev { get; set; }
}
