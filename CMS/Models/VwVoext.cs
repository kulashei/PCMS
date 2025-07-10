using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwVoext
{
    public int Id { get; set; }

    public int ContractFk { get; set; }

    public string ContractCode { get; set; }

    public string ContractTitle { get; set; }

    public DateTime CompDate { get; set; }

    public DateTime ReqDate { get; set; }

    public int Dur { get; set; }

    public DateTime NewDate { get; set; }

    public int CoNam { get; set; }

    public DateTime? CoStart { get; set; }

    public int NoNam { get; set; }

    public DateTime? NoStart { get; set; }

    public string Reason { get; set; }

    public bool Archived { get; set; }

    public bool Approved { get; set; }

    public int? ApprovedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string ApproverName { get; set; }

    public string ApprovedState { get; set; }

    public string Remarks { get; set; }

    public int UserId { get; set; }

    public string UserInfo { get; set; }

    public string UserEmail { get; set; }

    public int DeptId { get; set; }

    public string DeptCode { get; set; }

    public string DeptDesc { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime AwardDate { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime? SiteDate { get; set; }

    public DateTime? RevisedDate { get; set; }

    public int ManagerFk { get; set; }

    public string Manager { get; set; }

    public int ContractorId { get; set; }

    public string ContractorName { get; set; }
}
