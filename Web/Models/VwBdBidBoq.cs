using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class VwBdBidBoq
{
    public int? ContractId { get; set; }

    public int BidId { get; set; }

    public string LotNo { get; set; }

    public string BidNo { get; set; }

    public string BidTitle { get; set; }

    public DateOnly AdvertDate { get; set; }

    public DateOnly ClosingDate { get; set; }

    public string BidTypeName { get; set; }

    public int BidBaseId { get; set; }

    public int Namba { get; set; }

    public string BaseNo { get; set; }

    public string BaseTitle { get; set; }

    public int Culverts { get; set; }

    public double Distance { get; set; }

    public double DistStart { get; set; }

    public double DistEnd { get; set; }

    public string Notes { get; set; }

    public int BidBillId { get; set; }

    public string BillNo { get; set; }

    public string BillDesc { get; set; }

    public string BillNoDesc { get; set; }

    public int BidBillExId { get; set; }

    public int SubNo { get; set; }

    public string SubName { get; set; }

    public string SubDesc { get; set; }

    public int BidActivityId { get; set; }

    public int ActId { get; set; }

    public string ActCode { get; set; }

    public string ActName { get; set; }

    public string ActOrder { get; set; }

    public string Unit { get; set; }

    public double Quantity { get; set; }

    public double Rate { get; set; }

    public double Amount { get; set; }

    public double BillAmount { get; set; }

    public double VwQtty { get; set; }

    public double VwAmount { get; set; }
}
