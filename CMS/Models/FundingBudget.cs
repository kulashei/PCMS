using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class FundingBudget
{
    public int FundingBudgetId { get; set; }

    public int FiscalYearFk { get; set; }

    public int SubSourceFk { get; set; }

    public double BudgetAmount { get; set; }

    public int BudgetYear { get; set; }

    public string BudgetRemarks { get; set; }

    public string CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual CoaAccountFiscalYear FiscalYearFkNavigation { get; set; }

    public virtual ICollection<FundingExpenditure> FundingExpenditures { get; set; } = new List<FundingExpenditure>();

    public virtual FundSubSource SubSourceFkNavigation { get; set; }
}
