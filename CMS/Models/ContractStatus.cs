using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class ContractStatus
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Closure> Closures { get; set; } = new List<Closure>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();
}
