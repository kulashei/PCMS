using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class PvAudit
{
    public int PvFk { get; set; }

    public int ReceivedBy { get; set; }

    public DateOnly? ReceivedDate { get; set; }

    public string AuditCode { get; set; }

    public string Validations { get; set; }

    public string Remarks { get; set; }

    public int? DispatchBy { get; set; }

    public DateTime? DispatchDate { get; set; }

    public int? DispatchReceiver { get; set; }

    public string Pvno { get; set; }

    public double GrossAmount { get; set; }

    public string Narration { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Pv PvFkNavigation { get; set; }
}
