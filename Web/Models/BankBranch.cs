using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class BankBranch
{
    public int BranchId { get; set; }

    public int BankId { get; set; }

    public string BranchCode { get; set; }

    public string BranchName { get; set; }

    public virtual Bank Bank { get; set; }

    public virtual ICollection<ContractAdv> ContractAdvs { get; set; } = new List<ContractAdv>();

    public virtual ICollection<ContractPlant> ContractPlants { get; set; } = new List<ContractPlant>();

    public virtual ICollection<ContractorBank> ContractorBanks { get; set; } = new List<ContractorBank>();
}
