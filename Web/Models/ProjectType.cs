using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class ProjectType
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
