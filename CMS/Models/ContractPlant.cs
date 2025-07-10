using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class ContractPlant
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

    public virtual BankBranch BranchFkNavigation { get; set; }

    public virtual Contract ContractFkNavigation { get; set; }

    public virtual ICollection<ContractPlantPmt> ContractPlantPmts { get; set; } = new List<ContractPlantPmt>();
}
