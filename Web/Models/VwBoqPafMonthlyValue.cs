﻿using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class VwBoqPafMonthlyValue
{
    public int ContractId { get; set; }

    public int BoqId { get; set; }

    public int PafId { get; set; }

    public DateOnly PafMonth { get; set; }

    public int PafCalcId { get; set; }

    public int CategoryId { get; set; }

    public string CategoryDesc { get; set; }

    public int BidWeitId { get; set; }

    public double MonthlyPaf { get; set; }
}
