using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class BoqPaf
{
    public int PafId { get; set; }

    public int ContractFk { get; set; }

    public int BoqFk { get; set; }

    public DateOnly PafMonth { get; set; }

    public string Remarks { get; set; }

    public bool Active { get; set; }

    public int ExecBoqFk { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Boq BoqFkNavigation { get; set; }

    public virtual ICollection<BoqPafCalc> BoqPafCalcs { get; set; } = new List<BoqPafCalc>();

    public virtual Contract ContractFkNavigation { get; set; }

    public virtual Boq ExecBoqFkNavigation { get; set; }
}
