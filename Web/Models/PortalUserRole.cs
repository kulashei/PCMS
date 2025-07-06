using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class PortalUserRole
{
    public int Id { get; set; }

    public int UserFk { get; set; }

    public int RoleFk { get; set; }

    public bool Created { get; set; }

    public bool Updated { get; set; }

    public bool Deleted { get; set; }

    public bool Viewed { get; set; }

    public int? CreatedBy { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateOnly? ModifiedDate { get; set; }

    public virtual PortalRole RoleFkNavigation { get; set; }

    public virtual PortalUser UserFkNavigation { get; set; }
}
