using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class CoaAccountPeriod
{
    public int FiscalPeriodId { get; set; }

    public int FiscalYearFk { get; set; }

    public string PeriodCode { get; set; }

    public string PeriodName { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public bool Active { get; set; }

    public string Remarks { get; set; }

    public string CreatedBy { get; set; }

    public DateOnly CreatedDate { get; set; }

    public string UpdatedBy { get; set; }

    public DateOnly? UpdatedDate { get; set; }

    public virtual ICollection<CoaAccountJournalEntry> CoaAccountJournalEntries { get; set; } = new List<CoaAccountJournalEntry>();

    public virtual CoaAccountFiscalYear FiscalYearFkNavigation { get; set; }

    public virtual ICollection<FundingExpenditure> FundingExpenditures { get; set; } = new List<FundingExpenditure>();
}
