using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class VwTicket
{
    public int TicketId { get; set; }

    public string Code { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public bool Editable { get; set; }

    public string Subj { get; set; }

    public string Content { get; set; }

    public DateOnly ReceivedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CategoryId { get; set; }

    public string CategoryName { get; set; }

    public int PriorityId { get; set; }

    public string PriorityName { get; set; }

    public int SupportGroupId { get; set; }

    public string SupportGroupName { get; set; }

    public DateOnly? SupportGroupExpiryDate { get; set; }

    public int StatusId { get; set; }

    public string StatusName { get; set; }

    public string SmsMsg { get; set; }

    public string EmailMsg { get; set; }

    public int OwnerId { get; set; }

    public string OwnerName { get; set; }

    public string OwnerPhone { get; set; }

    public string OwnerEmail { get; set; }

    public bool? OwnerBlocked { get; set; }

    public bool OwnerReceiveEmail { get; set; }

    public bool OwnerReceiveSms { get; set; }

    public int CreatedBy { get; set; }

    public string CreaterName { get; set; }

    public string CreaterPhone { get; set; }

    public string CreaterEmail { get; set; }

    public bool? CreaterBlocked { get; set; }

    public bool CreaterReceiveEmail { get; set; }

    public bool CreaterReceiveSms { get; set; }
}
