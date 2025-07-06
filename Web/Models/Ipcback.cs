using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class Ipcback
{
    public int CertificateId { get; set; }

    public int ContractFk { get; set; }

    public int BoqFk { get; set; }

    public double Paf { get; set; }

    public double AtotalIncrement { get; set; }

    public double AnetIncrement { get; set; }

    public double AnetTransfer { get; set; }

    public double BtotalIncrement { get; set; }

    public double BnetIncrement { get; set; }

    public double BnetTransfer { get; set; }

    public double CprevAdvances { get; set; }

    public double CadditionalAdvances { get; set; }

    public double CtotalAdvances { get; set; }

    public double DprevInterest { get; set; }

    public double DcurrInterest { get; set; }

    public double DtotalInterest { get; set; }

    public double EdirectPayment { get; set; }

    public double EcurrSubContPayment { get; set; }

    public double EprevDamages { get; set; }

    public double EcurrDamages { get; set; }

    public double EplantPrevRepay { get; set; }

    public double EplantCurrRepay { get; set; }

    public double EplantTotalRepay { get; set; }

    public double EmobPrevRepay { get; set; }

    public double EmobCurrRepay { get; set; }

    public double EmobTotalRepay { get; set; }

    public double EdeductionTransferred { get; set; }

    public double FfundsTransferred { get; set; }

    public double GfundsTransferred { get; set; }

    public double HplantAuthorized { get; set; }

    public double ImobAuthorized { get; set; }

    public double JadvMobDeductedToDate { get; set; }

    public double JoutStandingMobTobePaid { get; set; }

    public double KplantDeductedToDate { get; set; }

    public double KoutstandingPlantTobePaid { get; set; }

    public virtual Boq BoqFkNavigation { get; set; }

    public virtual Contract ContractFkNavigation { get; set; }

    public virtual ICollection<IpcaddOmit> IpcaddOmits { get; set; } = new List<IpcaddOmit>();
}
