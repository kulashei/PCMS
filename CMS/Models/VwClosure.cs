using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwClosure
{
    public int Id { get; set; }

    public bool Approved { get; set; }

    public string ApprovedName { get; set; }

    public int ApprovedBy { get; set; }

    public string ApprovedByName { get; set; }

    public DateOnly ApprovedDate { get; set; }

    public DateOnly CompletedDate { get; set; }

    public string Reason { get; set; }

    public string Remarks { get; set; }

    public int UserId { get; set; }

    public int DeptId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string OwnaLogin { get; set; }

    public string OwnaFullName { get; set; }

    public string OwnaEmail { get; set; }

    public string OwnaPhone { get; set; }

    public int ContractId { get; set; }

    public string ContractTitle { get; set; }

    public int ContractStatusId { get; set; }

    public string ContractStatusName { get; set; }
}
