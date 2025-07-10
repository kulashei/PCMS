using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwVo
{
    public int ContractId { get; set; }

    public string ContractCode { get; set; }

    public string ContractTitle { get; set; }

    public int VoId { get; set; }

    public string VNo { get; set; }

    public DateTime RequestedDate { get; set; }

    public DateTime? NewCompletionDate { get; set; }

    public string RequestedReason { get; set; }

    public double AdditionSum { get; set; }

    public string AdditionDesc { get; set; }

    public double OmissionSum { get; set; }

    public string OmissionDesc { get; set; }

    public string Remarks { get; set; }

    public bool Archived { get; set; }

    public bool Approved { get; set; }

    public string ApprovedText { get; set; }

    public DateTime? ApprovedAt { get; set; }

    public int ApprovedBy { get; set; }

    public string ApprovedName { get; set; }

    public int UserId { get; set; }

    public int DeptId { get; set; }

    public string UserLogin { get; set; }

    public string UserFullName { get; set; }
}
