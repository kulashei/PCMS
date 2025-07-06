using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwTicketSupportGroupUser
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public string GroupName { get; set; }

    public int UserId { get; set; }

    public string Username { get; set; }

    public string FullName { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public bool? Blocked { get; set; }

    public bool ReceiveEmail { get; set; }

    public bool ReceiveSms { get; set; }
}
