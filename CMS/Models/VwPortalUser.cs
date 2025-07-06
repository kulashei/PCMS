using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwPortalUser
{
    public int UserId { get; set; }

    public string UserLogin { get; set; }

    public string UserFullName { get; set; }

    public string UserPhone { get; set; }

    public string UserEmail { get; set; }

    public int StatusFk { get; set; }

    public int DeptFk { get; set; }

    public int? FailureCount { get; set; }

    public bool ReceiveEmail { get; set; }

    public bool ReceiveSms { get; set; }

    public bool? Blocked { get; set; }

    public bool Agreed { get; set; }

    public bool PwdExpires { get; set; }

    public string Userpwd { get; set; }

    public DateTime? LastPwdUpdate { get; set; }

    public DateTime? NextPwdUpdate { get; set; }

    public DateTime? FirstPwdChangedDate { get; set; }

    public int RoleId { get; set; }

    public string RoleName { get; set; }

    public int UserStatusId { get; set; }

    public string UserStatusName { get; set; }

    public bool UserStatusAccess { get; set; }

    public string UserStatusInfo { get; set; }

    public int DeptId { get; set; }

    public string DeptCode { get; set; }

    public string DeptDesc { get; set; }

    public bool IsDeputy { get; set; }

    public int? HodUserFk { get; set; }

    public int? DelegatedFk { get; set; }

    public int RegionFk { get; set; }

    public int RegionId { get; set; }

    public string RegionCode { get; set; }

    public string RegionName { get; set; }
}
