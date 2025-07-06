using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class FundSource
{
    public int FundSourceId { get; set; }

    public string FundSourceCode { get; set; }

    public string FundSourceDesc { get; set; }

    public string FundSourceShort { get; set; }

    public virtual ICollection<FundSubSource> FundSubSources { get; set; } = new List<FundSubSource>();

    public virtual ICollection<ProgramCost> ProgramCosts { get; set; } = new List<ProgramCost>();
}
