using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class ProgramCost
{
    public int Id { get; set; }

    public int ProgramFk { get; set; }

    public int CatFk { get; set; }

    public int SourceFk { get; set; }

    public double Amount { get; set; }

    public string Currency { get; set; }

    public DateOnly ValueDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual FundCategory CatFkNavigation { get; set; }

    public virtual Program ProgramFkNavigation { get; set; }

    public virtual FundSource SourceFkNavigation { get; set; }
}
