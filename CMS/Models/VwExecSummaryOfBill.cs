﻿using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwExecSummaryOfBill
{
    public long? RowIndex { get; set; }

    public int BidBillId { get; set; }

    public string BillNo { get; set; }

    public string BillDesc { get; set; }

    public string BillNoDesc { get; set; }

    public double Amount { get; set; }

    public double TotalActivityAmount { get; set; }

    public double ProvisionalSums { get; set; }

    public double LessProvSums { get; set; }

    public double? DayWorks { get; set; }

    public double? AdjustmentAllowance { get; set; }

    public string AdjustmentAllowanceText { get; set; }

    public double ActAmountLessProvSum { get; set; }

    public double? Product { get; set; }

    public int ContractId { get; set; }

    public string ContractCode { get; set; }

    public string ContractTitle { get; set; }

    public string ContractDesc { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime AwardDate { get; set; }

    public DateTime? SiteDate { get; set; }

    public DateTime? RevisedDate { get; set; }

    public DateTime? CompletionDate { get; set; }

    public string Currency { get; set; }

    public int ContractStatusId { get; set; }

    public string ContractStatus { get; set; }

    public int ContractorId { get; set; }

    public string TinNo { get; set; }

    public string ContractorName { get; set; }

    public string Type { get; set; }

    public string Classification { get; set; }

    public string Address { get; set; }
}
