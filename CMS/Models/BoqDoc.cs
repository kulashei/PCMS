using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class BoqDoc
{
    public int Id { get; set; }

    public int BoqFk { get; set; }

    public string Name { get; set; }

    public string FlPath { get; set; }

    public string Sourx { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool Baked { get; set; }

    public virtual Boq BoqFkNavigation { get; set; }
}
