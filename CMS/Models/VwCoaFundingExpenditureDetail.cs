using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwCoaFundingExpenditureDetail
{
    public int FundingExpendId { get; set; }

    public double ExpendAmount { get; set; }

    public DateOnly ExpendDate { get; set; }

    public string ExpendRemarks { get; set; }

    public int FundingBudgetId { get; set; }

    public double BudgetAmount { get; set; }

    public int BudgetYear { get; set; }

    public string BudgetRemarks { get; set; }

    public int SubSourceId { get; set; }

    public string SubSourceCode { get; set; }

    public string SubSourceDesc { get; set; }

    public int FundSourceId { get; set; }

    public string FundSourceCode { get; set; }

    public string FundSourceDesc { get; set; }

    public string FundSourceShort { get; set; }

    public int FiscalPeriodId { get; set; }

    public string PeriodCode { get; set; }

    public string PeriodName { get; set; }

    public DateOnly PeriodStartDate { get; set; }

    public DateOnly PeriodEndDate { get; set; }

    public string PeriodRemarks { get; set; }

    public int FiscalYearId { get; set; }

    public short FiscalYear { get; set; }

    public string YearCode { get; set; }

    public string YearName { get; set; }

    public DateOnly YearStartDate { get; set; }

    public DateOnly YearEndDate { get; set; }

    public bool IsOpen { get; set; }

    public string YearRemarks { get; set; }
}
