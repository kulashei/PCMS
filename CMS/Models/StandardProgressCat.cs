using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class StandardProgressCat
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Remarks { get; set; }

    public int Orda { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<StandardProgress> StandardProgresses { get; set; } = new List<StandardProgress>();
}
