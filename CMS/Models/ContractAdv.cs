using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class ContractAdv
{
    public int Id { get; set; }

    public int ContractFk { get; set; }

    public int BoqFk { get; set; }

    public int BranchFk { get; set; }

    public double GuarantedAmount { get; set; }

    public double AdvAmount { get; set; }

    public DateTime? ExpiresAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool IsPlant { get; set; }

    public double CalcAmount { get; set; }

    public virtual BankBranch BranchFkNavigation { get; set; }

    public virtual ICollection<ContractAdvPmt> ContractAdvPmts { get; set; } = new List<ContractAdvPmt>();

    public virtual Contract ContractFkNavigation { get; set; }
}
