using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwContractorBank
{
    public int ContractorBankId { get; set; }

    public string AccountNumber { get; set; }

    public string AccountName { get; set; }

    public string AccountCurrency { get; set; }

    public bool AccountEditable { get; set; }

    public int ContractorId { get; set; }

    public string ContractorName { get; set; }

    public int BranchId { get; set; }

    public string BranchCode { get; set; }

    public string BranchName { get; set; }

    public int BankId { get; set; }

    public string BankCode { get; set; }

    public string BankName { get; set; }
}
