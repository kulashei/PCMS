using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class PvStatus
{
    public int Id { get; set; }

    public int? CatFk { get; set; }

    public string Name { get; set; }

    public string Desc { get; set; }

    public bool Active { get; set; }

    public virtual PvStatusCat CatFkNavigation { get; set; }

    public virtual ICollection<Pv> Pvs { get; set; } = new List<Pv>();
}
