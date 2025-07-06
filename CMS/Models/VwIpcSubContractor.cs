using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwIpcSubContractor
{
    public int ContractorId { get; set; }

    public int SubContractId { get; set; }

    public int? SubContractPaymentId { get; set; }

    public int ContractFk { get; set; }

    public int? BoqFk { get; set; }

    public string ContractorName { get; set; }

    public double TotalGrossValue { get; set; }

    public double Less5Or10Percent { get; set; }

    public double Less5Or10PercentValue { get; set; }

    public double TotalNetAmount { get; set; }

    public double LessLastCertAmount { get; set; }

    public double AmountNowDue { get; set; }
}
