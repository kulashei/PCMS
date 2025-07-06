using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class FundCategory
{
    public int FundCategoryId { get; set; }

    public string FundCategoryType { get; set; }

    public string FundTypeShort { get; set; }

    public virtual ICollection<ProgramCost> ProgramCosts { get; set; } = new List<ProgramCost>();
}
