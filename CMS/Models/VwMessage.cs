using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwMessage
{
    public int Id { get; set; }

    public int ParentId { get; set; }

    public int Author { get; set; }

    public int Receiva { get; set; }

    public string Subj { get; set; }

    public string Content { get; set; }

    public bool Viewed { get; set; }

    public DateTime SentDate { get; set; }

    public DateTime? ViewedDate { get; set; }

    public int ReplyId { get; set; }

    public DateTime? ReplyDate { get; set; }

    public bool Emailed { get; set; }

    public short TrialCount { get; set; }

    public bool SmsSent { get; set; }

    public int SmsTry { get; set; }

    public int MsgCatId { get; set; }

    public string MsgCat { get; set; }

    public string Mode { get; set; }

    public string Brief { get; set; }

    public int AuthorId { get; set; }

    public string AuthorName { get; set; }

    public string AuthorLogin { get; set; }

    public bool? AuthorBlocked { get; set; }

    public string AuthorPhone { get; set; }

    public bool AuthorReceiveEmail { get; set; }

    public bool AuthorReceiveSms { get; set; }

    public string AuthorEmail { get; set; }

    public int ReceivaId { get; set; }

    public string ReceivaName { get; set; }

    public string ReceivaLogin { get; set; }

    public bool? ReceivaBlocked { get; set; }

    public string ReceivaEmail { get; set; }

    public string ReceivaPhone { get; set; }

    public bool ReceivaReceiveEmail { get; set; }

    public bool ReceivaReceiveSms { get; set; }
}
