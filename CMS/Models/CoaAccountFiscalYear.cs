using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class CoaAccountFiscalYear
{
    public int FiscalYearId { get; set; }

    public short FiscalYear { get; set; }

    public string YearCode { get; set; }

    public string YearName { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public bool IsOpen { get; set; }

    public string Remarks { get; set; }

    public string CreatedBy { get; set; }

    public DateOnly CreatedDate { get; set; }

    public string UpdatedBy { get; set; }

    public DateOnly? UpdatedDate { get; set; }

    public virtual ICollection<CoaAccountPeriod> CoaAccountPeriods { get; set; } = new List<CoaAccountPeriod>();

    public virtual ICollection<FundingBudget> FundingBudgets { get; set; } = new List<FundingBudget>();
}
