using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwBdBid
{
    public int BidId { get; set; }

    public int CatId { get; set; }

    public string LotNo { get; set; }

    public string BidNo { get; set; }

    public string BidTitle { get; set; }

    public DateOnly AdvertDate { get; set; }

    public DateOnly ClosingDate { get; set; }

    public double Physical { get; set; }

    public double Price { get; set; }

    public int UserId { get; set; }

    public int DeptId { get; set; }

    public bool IsPacked { get; set; }

    public bool Approved { get; set; }

    public bool Archived { get; set; }

    public bool IsLocked { get; set; }

    public int ProjectId { get; set; }

    public string Notes { get; set; }

    public int BidTypeId { get; set; }

    public string BidTypeCode { get; set; }

    public string BidTypeName { get; set; }

    public int BidBatchId { get; set; }

    public string BatchNo { get; set; }

    public string BatchTitle { get; set; }

    public int UserId1 { get; set; }

    public string UserLogin { get; set; }

    public string UserFullName { get; set; }

    public string UserPhone { get; set; }

    public string UserEmail { get; set; }
}
