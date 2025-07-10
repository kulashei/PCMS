using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class CoaLiability
{
    public int LiabilityId { get; set; }

    public int AccountFk { get; set; }

    public double Amount { get; set; }

    public DateTime RefDate { get; set; }

    public string RefNo { get; set; }

    public string RefDesc { get; set; }

    public string Remarks { get; set; }

    public string CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual CoaAccount AccountFkNavigation { get; set; }
}
