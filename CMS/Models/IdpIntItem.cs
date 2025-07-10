using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class IdpIntItem
{
    public int Id { get; set; }

    public int InterestFk { get; set; }

    public int PaymentFk { get; set; }

    public int ItemNumber { get; set; }

    public double SubjectAmount { get; set; }

    public DateTime DelayFromDate { get; set; }

    public DateTime DelayToDate { get; set; }

    public DateTime ApplyMonth { get; set; }

    public double DelayAmount { get; set; }

    public double AnnualRate { get; set; }

    public double FactorAmount { get; set; }

    public double InterestAmount { get; set; }

    public double CummulativeAmountDue { get; set; }

    public double InterestDue { get; set; }

    public virtual IdpInt InterestFkNavigation { get; set; }

    public virtual PvPayment PaymentFkNavigation { get; set; }
}
