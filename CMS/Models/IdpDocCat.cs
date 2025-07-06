using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class IdpDocCat
{
    public int Id { get; set; }

    public string Name { get; set; }

    public bool Active { get; set; }

    public bool Rex { get; set; }

    public virtual ICollection<IdpDoc> IdpDocs { get; set; } = new List<IdpDoc>();
}
