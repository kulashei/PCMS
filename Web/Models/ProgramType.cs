using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class ProgramType
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Program> Programs { get; set; } = new List<Program>();
}
