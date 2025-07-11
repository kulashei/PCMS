using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwPv
{
    public int PvId { get; set; }

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

    public bool IsPaid { get; set; }

    public int StatusId { get; set; }

    public int UserId { get; set; }

    public string UserFullName { get; set; }

    public int DeptId { get; set; }

    public string DeptName { get; set; }

    public int PreparerId { get; set; }

    public string PreparerName { get; set; }

    public bool Archived { get; set; }

    public bool Approved { get; set; }

    public DateOnly? ApprovedAt { get; set; }

    public int? ApprovedBy { get; set; }

    public string ApprovedText { get; set; }

    public int BoqId { get; set; }

    public string BillNo { get; set; }

    public string BillDesc { get; set; }

    public string Ipcnumber { get; set; }

    public DateTime Ipcdate { get; set; }

    public int ContractId { get; set; }

    public string ContractCode { get; set; }

    public string ContractTitle { get; set; }

    public string ContractorName { get; set; }

    public int ContractorBankId { get; set; }

    public string AccountNumber { get; set; }

    public string AccountName { get; set; }

    public string AccountCurrency { get; set; }

    public string AccountDesc { get; set; }

    public string BankName { get; set; }

    public string BranchName { get; set; }
}
