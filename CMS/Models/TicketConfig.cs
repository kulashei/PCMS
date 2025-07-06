using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class TicketConfig
{
    public int Id { get; set; }

    public string Prefix { get; set; }

    public int TicketCount { get; set; }

    public int MaxFailureCount { get; set; }

    public bool ShowFileUpload { get; set; }

    public string ContactNumber { get; set; }

    public bool EnableSms { get; set; }

    public bool EnableEmail { get; set; }

    public string TicketEmail { get; set; }

    public string EmailName { get; set; }

    public string EmailSubject { get; set; }

    public string EmailPassword { get; set; }

    public int WarningPeriod { get; set; }

    public int PriorityLowCount { get; set; }

    public int PriorityMedCount { get; set; }

    public int PriorityHighCount { get; set; }

    public string SmsMessage { get; set; }

    public string EmailMessage { get; set; }
}
