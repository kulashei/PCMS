using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class ContractorBank
{
    public int ContractorBankId { get; set; }

    public int ContractorFk { get; set; }

    public int BranchFk { get; set; }

    public string AccountNumber { get; set; }

    public string AccountName { get; set; }

    public string AccountCurrency { get; set; }

    public bool AccountEditable { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual BankBranch BranchFkNavigation { get; set; }

    public virtual Contractor ContractorFkNavigation { get; set; }

    public virtual ICollection<Pv> Pvs { get; set; } = new List<Pv>();
}
