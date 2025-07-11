using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwCtContract
{
    public int RegionId { get; set; }

    public string RegionCode { get; set; }

    public string RegionName { get; set; }

    public int BidId { get; set; }

    public int ContractId { get; set; }

    public string ContractName { get; set; }

    public string ContractCode { get; set; }

    public string ContractTitle { get; set; }

    public string ContractDesc { get; set; }

    public bool Fixed { get; set; }

    public DateOnly BaseMonth { get; set; }

    public DateOnly AwardDate { get; set; }

    public DateOnly? SiteDate { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public DateOnly? RevisedDate { get; set; }

    public DateOnly? NoPafDate { get; set; }

    public DateOnly? CompletionDate { get; set; }

    public double AdjustmentAllowance { get; set; }

    public bool IsPacked { get; set; }

    public bool Archived { get; set; }

    public int DeptId { get; set; }

    public int UserId { get; set; }

    public bool Approved { get; set; }

    public string ApprovedText { get; set; }

    public int ApprovedBy { get; set; }

    public DateTime? ApprovedAt { get; set; }

    public string ApprovedName { get; set; }

    public string UserLogin { get; set; }

    public string UserFullName { get; set; }

    public string UserEmail { get; set; }

    public string UserPhone { get; set; }

    public int ContractStatusId { get; set; }

    public string ContractStatusName { get; set; }

    public int ContractTypeId { get; set; }

    public string ContractTypeCode { get; set; }

    public string ContractTypeName { get; set; }

    public int ManagerId { get; set; }

    public string ManagerName { get; set; }

    public string ManagerEmail { get; set; }

    public string ManagerPhone { get; set; }

    public int ContractCostId { get; set; }

    public double ActivityAmount { get; set; }

    public double PhysicalPercentage { get; set; }

    public double PhysicalContingency { get; set; }

    public double PricePercentage { get; set; }

    public double PriceContingency { get; set; }

    public double DayWorks { get; set; }

    public double ProvisionalSums { get; set; }

    public double ContractAmount { get; set; }

    public double Equipment { get; set; }

    public double Labour { get; set; }

    public double Material { get; set; }

    public string Currency { get; set; }

    public DateOnly ValueDate { get; set; }

    public int InterestId { get; set; }

    public double IntDuration { get; set; }

    public string IntDelayIn { get; set; }

    public string InterestType { get; set; }

    public int ContractorId { get; set; }

    public string ContractorName { get; set; }

    public string ContractorTin { get; set; }

    public string ContractorAddress { get; set; }

    public string ContractorContact { get; set; }

    public string ContractorEmail { get; set; }

    public string ContractorPhone { get; set; }

    public string ContractorType { get; set; }

    public string ContractorClass { get; set; }

    public DateOnly? ContractorExpiryDate { get; set; }
}
