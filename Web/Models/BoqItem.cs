using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class BoqItem
{
    public int BoqItemId { get; set; }

    public int BoqId { get; set; }

    public int ContractActivityFk { get; set; }

    public double OriginalQtty { get; set; }

    public double Voqtty { get; set; }

    public double PrevQtty { get; set; }

    public double CurrQtty { get; set; }

    public double Rate { get; set; }

    public double Amount { get; set; }

    public bool Exceeded { get; set; }

    public string Remarks { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public double ExQtty { get; set; }

    public string ExRemarks { get; set; }

    public double RegQtty { get; set; }

    public virtual Boq Boq { get; set; }

    public virtual ContractAct ContractActivityFkNavigation { get; set; }
}
