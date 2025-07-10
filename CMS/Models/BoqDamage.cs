using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class BoqDamage
{
    public int Id { get; set; }

    public int ContractFk { get; set; }

    public int BoqFk { get; set; }

    public int RecoveredBoqId { get; set; }

    public double ContractPrice { get; set; }

    public double DailyLad { get; set; }

    public double MaxLad { get; set; }

    public double MaxLadAmount { get; set; }

    public double PreviousAmount { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public short DelayDays { get; set; }

    public double DailyAmnt { get; set; }

    public double Amount { get; set; }

    public string ItemNo { get; set; }

    public string ItemName { get; set; }

    public string Comment { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Boq BoqFkNavigation { get; set; }

    public virtual Contract ContractFkNavigation { get; set; }
}
