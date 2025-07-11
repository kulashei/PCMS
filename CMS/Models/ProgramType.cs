using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class ProgramType
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Programme> Programmes { get; set; } = new List<Programme>();
}
