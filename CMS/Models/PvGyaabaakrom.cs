using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class PvGyaabaakrom
{
    public int PvId { get; set; }

    public int ContractFk { get; set; }

    public int BoqFk { get; set; }

    public DateOnly Pvdate { get; set; }

    public string Pvnumber { get; set; }

    public double PvgrossAmount { get; set; }

    public double Pvretention { get; set; }

    public double PvretentionRecovered { get; set; }

    public double WithholdingTaxRatio { get; set; }

    public double WithholdingTax { get; set; }

    public double AdvancedPayment { get; set; }

    public double AdvancedPaymentRecovered { get; set; }

    public double Lad { get; set; }

    public string AssocCode { get; set; }

    public double AssocRate { get; set; }

    public double AssocAmount { get; set; }

    public double Others { get; set; }

    public double PvsubContractors { get; set; }

    public double PvnetAmount { get; set; }

    public string PaymentDesc { get; set; }

    public string Pvremarks { get; set; }

    public string GrossWords { get; set; }

    public string NetWords { get; set; }

    public int Preparer { get; set; }

    public bool Approved { get; set; }

    public bool IsPaid { get; set; }

    public int? BankFk { get; set; }

    public int StatusId { get; set; }

    public int DeptId { get; set; }

    public int UserId { get; set; }

    public string CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public string UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? ApprovedBy { get; set; }

    public DateOnly? ApprovedAt { get; set; }

    public bool Archived { get; set; }
}
