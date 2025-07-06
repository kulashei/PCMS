using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class VoextDoc
{
    public int Id { get; set; }

    public int ExtFk { get; set; }

    public string Name { get; set; }

    public string FlPath { get; set; }

    public bool Baked { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Voext ExtFkNavigation { get; set; }
}
