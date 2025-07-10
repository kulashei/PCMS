using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class BoqPafCalc
{
    public int PafCalcId { get; set; }

    public int PafFk { get; set; }

    public int BidweitFk { get; set; }

    public double Llvalue { get; set; }

    public double Plvalue { get; set; }

    public double Fuvalue { get; set; }

    public double Bivalue { get; set; }

    public double Cevalue { get; set; }

    public double Rsvalue { get; set; }

    public double Tivalue { get; set; }

    public double Chvalue { get; set; }

    public double Pcvalue { get; set; }

    public double Rovalue { get; set; }

    public double Rlvalue { get; set; }

    public double Cbvalue { get; set; }

    public double Pgvalue { get; set; }

    public double Covalue { get; set; }

    public double TotalPaf { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual BidWeit BidweitFkNavigation { get; set; }

    public virtual BoqPaf PafFkNavigation { get; set; }
}
