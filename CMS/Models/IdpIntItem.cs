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

    public DateOnly DelayFromDate { get; set; }

    public DateOnly DelayToDate { get; set; }

    public DateOnly ApplyMonth { get; set; }

    public double DelayAmount { get; set; }

    public double AnnualRate { get; set; }

    public double FactorAmount { get; set; }

    public double InterestAmount { get; set; }

    public double CummulativeAmountDue { get; set; }

    public double InterestDue { get; set; }

    public virtual IdpInt InterestFkNavigation { get; set; }

    public virtual PvPayment PaymentFkNavigation { get; set; }
}
