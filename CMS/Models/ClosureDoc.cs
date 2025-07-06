using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class ClosureDoc
{
    public int Id { get; set; }

    public int ContractFk { get; set; }

    public int ClosureFk { get; set; }

    public string Name { get; set; }

    public string FilePath { get; set; }

    public string Remarks { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool Baked { get; set; }

    public virtual Closure ClosureFkNavigation { get; set; }

    public virtual Contract ContractFkNavigation { get; set; }
}
