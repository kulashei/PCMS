using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class PortalUserStatus
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Info { get; set; }

    public bool Access { get; set; }

    public virtual ICollection<PortalUser> PortalUsers { get; set; } = new List<PortalUser>();
}
