using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class ContractDocCat
{
    public int Id { get; set; }

    public string Name { get; set; }

    public bool Active { get; set; }

    public bool Compulsory { get; set; }

    public virtual ICollection<ContractDoc> ContractDocs { get; set; } = new List<ContractDoc>();
}
