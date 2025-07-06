using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class CoaRevenue
{
    public int RevenueId { get; set; }

    public int AccountFk { get; set; }

    public double Amount { get; set; }

    public DateOnly RevDate { get; set; }

    public string RevRefNo { get; set; }

    public string RevDesc { get; set; }

    public string Remarks { get; set; }

    public string CreatedBy { get; set; }

    public DateOnly CreatedDate { get; set; }

    public string UpdatedBy { get; set; }

    public DateOnly? UpdatedDate { get; set; }

    public virtual CoaAccount AccountFkNavigation { get; set; }
}
