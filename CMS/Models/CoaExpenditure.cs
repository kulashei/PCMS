using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class CoaExpenditure
{
    public int ExpenditureId { get; set; }

    public int AccountFk { get; set; }

    public double Amount { get; set; }

    public DateOnly ExpDate { get; set; }

    public string ExpRefNo { get; set; }

    public string ExpDesc { get; set; }

    public string Remarks { get; set; }

    public string CreatedBy { get; set; }

    public DateOnly CreatedDate { get; set; }

    public string UpdatedBy { get; set; }

    public DateOnly? UpdatedDate { get; set; }

    public virtual CoaAccount AccountFkNavigation { get; set; }
}
