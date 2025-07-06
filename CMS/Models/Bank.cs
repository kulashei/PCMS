using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class Bank
{
    public int BankId { get; set; }

    public string BankCode { get; set; }

    public string BankName { get; set; }

    public virtual ICollection<BankBranch> BankBranches { get; set; } = new List<BankBranch>();
}
