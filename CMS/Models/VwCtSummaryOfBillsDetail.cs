using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwCtSummaryOfBillsDetail
{
    public int ContractId { get; set; }

    public string ContractCode { get; set; }

    public string ContractTitle { get; set; }

    public int BidBaseId { get; set; }

    public int Namba { get; set; }

    public string BaseNo { get; set; }

    public string BaseTitle { get; set; }

    public int BidBillId { get; set; }

    public string BillNoDesc { get; set; }

    public int StandardActivityId { get; set; }

    public string StandardActivity { get; set; }

    public int ContractProgressId { get; set; }

    public string ProgressCode { get; set; }

    public string ProgressName { get; set; }

    public int WeitId { get; set; }

    public string WeitCode { get; set; }

    public string WeitName { get; set; }

    public int ActId { get; set; }

    public string ActOrder { get; set; }

    public string ActCode { get; set; }

    public string ActName { get; set; }

    public string Unit { get; set; }

    public double Quantity { get; set; }

    public double Rate { get; set; }

    public double Amount { get; set; }

    public int ContractActivityId { get; set; }

    public string WorkCategory { get; set; }

    public string CategoryDesc { get; set; }

    public int SubActivityId { get; set; }

    public string ActivityCode { get; set; }

    public string ActivityDesc { get; set; }

    public string ProgressCode1 { get; set; }

    public string ProgressDesc { get; set; }
}
