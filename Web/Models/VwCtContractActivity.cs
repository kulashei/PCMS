using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class VwCtContractActivity
{
    public int ContractFk { get; set; }

    public int ContractActivityId { get; set; }

    public int BidBillId { get; set; }

    public string BillNo { get; set; }

    public string BillDesc { get; set; }

    public string BillNoDesc { get; set; }

    public int BidBillExId { get; set; }

    public int SubNo { get; set; }

    public string SubName { get; set; }

    public string SubDesc { get; set; }

    public int ActId { get; set; }

    public string ActCode { get; set; }

    public string ActName { get; set; }

    public string ActOrder { get; set; }

    public string Unit { get; set; }

    public double Quantity { get; set; }

    public double Voqtty { get; set; }

    public double Rate { get; set; }

    public double Amount { get; set; }

    public double TotalQtty { get; set; }

    public double TotalAmount { get; set; }

    public double BoqQtty { get; set; }

    public double BoqAmount { get; set; }

    public int WeitId { get; set; }

    public string WeitCode { get; set; }

    public string WeitName { get; set; }

    public int ContractProgressId { get; set; }

    public int ProgressId { get; set; }

    public string ProgressCode { get; set; }

    public string ProgressName { get; set; }

    public string ProgressCat { get; set; }

    public string ProgressUnit { get; set; }

    public int ProgressCatId { get; set; }

    public string ProgressCatName { get; set; }

    public double InitSchedule { get; set; }

    public double VoSchedule { get; set; }

    public double TotalSchedule { get; set; }

    public bool ProgressActive { get; set; }

    public int BidBaseId { get; set; }

    public int Namba { get; set; }

    public string BaseNo { get; set; }

    public string BaseTitle { get; set; }

    public int Culverts { get; set; }

    public double Distance { get; set; }

    public double DistStart { get; set; }

    public double DistEnd { get; set; }

    public string Notes { get; set; }
}
