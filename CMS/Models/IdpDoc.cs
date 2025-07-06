using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class IdpDoc
{
    public int Id { get; set; }

    public int CatFk { get; set; }

    public int IdpFk { get; set; }

    public bool Baked { get; set; }

    public string Name { get; set; }

    public string FlPath { get; set; }

    public string Remarks { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual IdpDocCat CatFkNavigation { get; set; }

    public virtual Idp IdpFkNavigation { get; set; }
}
