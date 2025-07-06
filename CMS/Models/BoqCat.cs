using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class BoqCat
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Boq> Boqs { get; set; } = new List<Boq>();
}
