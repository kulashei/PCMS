using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class VwBoqAct
{
    public int ContractId { get; set; }

    public int BoqId { get; set; }

    public int ContractActivityId { get; set; }

    public int BoqItemId { get; set; }

    public double OriginalQtty { get; set; }

    public double Voqtty { get; set; }

    public double ContTotal { get; set; }

    public double PrevQtty { get; set; }

    public double CurrQtty { get; set; }

    public double TotalQtty { get; set; }

    public double Rate { get; set; }

    public double Amount { get; set; }

    public bool Exceeded { get; set; }

    public string ExceedEx { get; set; }

    public string Remarks { get; set; }

    public double ExQtty { get; set; }

    public string ExRemarks { get; set; }

    public double RegQtty { get; set; }

    public int ActId { get; set; }

    public string ActCode { get; set; }

    public string ActName { get; set; }

    public string ActOrder { get; set; }

    public string Unit { get; set; }

    public int WeitId { get; set; }

    public string WeitCode { get; set; }

    public string WeitName { get; set; }

    public int BidBillExId { get; set; }

    public int SubNo { get; set; }

    public string SubName { get; set; }

    public string SubDesc { get; set; }

    public int BidBillId { get; set; }

    public string BillNo { get; set; }

    public string BillDesc { get; set; }

    public string BillNoDesc { get; set; }

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
