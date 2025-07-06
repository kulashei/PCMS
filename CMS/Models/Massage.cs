using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class Massage
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

    public int MsgCatId { get; set; }

    public string MsgCat { get; set; }

    public bool SmsSent { get; set; }

    public int SmsTry { get; set; }

    public virtual PortalUser AuthorNavigation { get; set; }

    public virtual ICollection<MessageDoc> MessageDocs { get; set; } = new List<MessageDoc>();

    public virtual PortalUser ReceivaNavigation { get; set; }
}
