using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class Ipcfront
{
    public int BoqFk { get; set; }

    public string Ipcnumber { get; set; }

    public string CertCode { get; set; }

    public string CertDesc { get; set; }

    public DateOnly CertDate { get; set; }

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

    public string Manager { get; set; }

    public string Note { get; set; }

    public virtual Boq BoqFkNavigation { get; set; }

    public virtual Pv Pv { get; set; }
}
