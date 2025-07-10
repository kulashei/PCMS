using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class FundingExpenditure
{
    public int FundingExpendId { get; set; }

    public int FiscalPeriodFk { get; set; }

    public int FundingBudgetFk { get; set; }

    public double ExpendAmount { get; set; }

    public DateTime ExpendDate { get; set; }

    public string ExpendRemarks { get; set; }

    public string CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual CoaAccountPeriod FiscalPeriodFkNavigation { get; set; }

    public virtual FundingBudget FundingBudgetFkNavigation { get; set; }
}
