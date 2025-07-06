using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class ProjectType
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
