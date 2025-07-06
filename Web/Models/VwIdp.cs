using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class VwIdp
{
    public int IdpId { get; set; }

    public int IdpNamb { get; set; }

    public string IdpDesc { get; set; }

    public DateOnly RequestedAt { get; set; }

    public string Remarks { get; set; }

    public double CumInt { get; set; }

    public double IntOnly { get; set; }

    public bool Archived { get; set; }

    public bool Approved { get; set; }

    public DateOnly? ApprovedAt { get; set; }

    public int? ApprovedBy { get; set; }

    public string ApproverName { get; set; }

    public string ApprovedStatus { get; set; }

    public int UserId { get; set; }

    public int DeptId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public double Duration { get; set; }

    public string DelayIn { get; set; }

    public string IntType { get; set; }

    public int CurrentBoqFk { get; set; }

    public int BoqId { get; set; }

    public DateOnly? BillDate { get; set; }

    public string BillNo { get; set; }

    public string BillDesc { get; set; }

    public int ContractId { get; set; }

    public string ContractCode { get; set; }

    public string ContractTitle { get; set; }

    public int ContractorId { get; set; }

    public string ContractorName { get; set; }

    public string ContractorAddress { get; set; }

    public int RegionId { get; set; }

    public string RegionCode { get; set; }

    public string RegionName { get; set; }

    public int UserId1 { get; set; }

    public string UserLogin { get; set; }

    public string UserFullName { get; set; }

    public string UserPhone { get; set; }

    public string UserEmail { get; set; }
}
