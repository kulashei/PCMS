using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class StandardClause
{
    public int Id { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    public string Desc { get; set; }

    public double Value { get; set; }

    public virtual ICollection<BidClause> BidClauses { get; set; } = new List<BidClause>();
}
