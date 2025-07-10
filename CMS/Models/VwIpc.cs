using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwIpc
{
    public int ContractId { get; set; }

    public int BoqFk { get; set; }

    public string ContractCode { get; set; }

    public string ContractTitle { get; set; }

    public string Currency { get; set; }

    public string ContractorName { get; set; }

    public string Address { get; set; }

    public string Ipcnumber { get; set; }

    public string CertCode { get; set; }

    public string CertDesc { get; set; }

    public DateTime CertDate { get; set; }

    public DateTime Ipcdate { get; set; }

    public double ContractSum { get; set; }

    public double DittoContingency { get; set; }

    public double ContractSumLessContingency { get; set; }

    public double EstimatedOmissions { get; set; }

    public double EstimatedAdditions { get; set; }

    public double SubTotalLessEstOmissions { get; set; }

    public double EstTotalWorksCost { get; set; }

    public double WorksExFluctuation { get; set; }

    public double MaterialsOnSite { get; set; }

    public double SubTotalWorksMaterials { get; set; }

    public double NetFluctuationA { get; set; }

    public double TotalWorksCompleted { get; set; }

    public double LessMaxRetention { get; set; }

    public double SubTotalWorksLessRetention { get; set; }

    public double NetFluctuationB { get; set; }

    public double TotalNetWorksPayment { get; set; }

    public double PlantMobilisation { get; set; }

    public double NetWorksPayPlusPlantMob { get; set; }

    public double DelayedPayments { get; set; }

    public double SubTotalPlantMobPlusDelayPay { get; set; }

    public double TotalAllDeductions { get; set; }

    public double NetPayableAmountToContractor { get; set; }

    public double LessDittoPrevCert { get; set; }

    public double AmountNowPayableToContractor { get; set; }

    public double LessRetention5OnLastCert { get; set; }

    public double DraftRetentionHeld { get; set; }

    public double TotalWorksValueItem4N6 { get; set; }

    public double LessDittoItem4N6 { get; set; }

    public double GrossCertificateValue { get; set; }

    public double CertifyAmount { get; set; }

    public int CertificateId { get; set; }

    public int ContractFk { get; set; }

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

    public string AdvanceBank { get; set; }

    public string AdvanceBranch { get; set; }

    public double AdvanceAmount { get; set; }

    public DateTime? AdvanceExpiryDate { get; set; }

    public string PlantBank { get; set; }

    public string PlantBranch { get; set; }

    public double PlantAmount { get; set; }

    public DateTime? PlantExpiryDate { get; set; }
}
