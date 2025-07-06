using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class DocumentRole
{
    public int Id { get; set; }

    public int DocumentId { get; set; }

    public int RoleId { get; set; }

    public bool Modify { get; set; }

    public bool Dilete { get; set; }

    public virtual Document Document { get; set; }
}
