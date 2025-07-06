using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class BoqDrawing
{
    public int Id { get; set; }

    public int ContractFk { get; set; }

    public int? BoqFk { get; set; }

    public bool Active { get; set; }

    public double RetValue { get; set; }

    public double RetPercent { get; set; }

    public double RetAmount { get; set; }

    public double PrevAmount { get; set; }

    public double CurrentSum { get; set; }

    public int CreatedBy { get; set; }

    public DateOnly CreatedAt { get; set; }

    public virtual Boq BoqFkNavigation { get; set; }

    public virtual Contract ContractFkNavigation { get; set; }
}
