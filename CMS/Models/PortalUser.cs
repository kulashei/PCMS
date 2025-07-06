using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class PortalUser
{
    public int UserId { get; set; }

    public string UserName { get; set; }

    public string FullName { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public int StatusFk { get; set; }

    public int DeptFk { get; set; }

    public bool ReceiveSms { get; set; }

    public bool ReceiveEmail { get; set; }

    public bool PwdExpires { get; set; }

    public bool? Blocked { get; set; }

    public bool Agreed { get; set; }

    public int? FailureCount { get; set; }

    public string Userpwd { get; set; }

    public DateTime? LastPwdUpdate { get; set; }

    public DateTime? NextPwdUpdate { get; set; }

    public DateTime? FirstPwdChangedDate { get; set; }

    public virtual ICollection<BidBase> BidBases { get; set; } = new List<BidBase>();

    public virtual ICollection<BidRead> BidReads { get; set; } = new List<BidRead>();

    public virtual ICollection<Bid> Bids { get; set; } = new List<Bid>();

    public virtual ICollection<Boq> BoqIpcApprovedByNavigations { get; set; } = new List<Boq>();

    public virtual ICollection<Boq> BoqIpcPreparedByNavigations { get; set; } = new List<Boq>();

    public virtual ICollection<Boq> BoqUsers { get; set; } = new List<Boq>();

    public virtual ICollection<Closure> ClosureApprovedByNavigations { get; set; } = new List<Closure>();

    public virtual ICollection<Closure> ClosureCreatedByNavigations { get; set; } = new List<Closure>();

    public virtual ICollection<Closure> ClosureUsers { get; set; } = new List<Closure>();

    public virtual ICollection<Contract> ContractApprovedByNavigations { get; set; } = new List<Contract>();

    public virtual ICollection<Contract> ContractManagerFkNavigations { get; set; } = new List<Contract>();

    public virtual ICollection<Contract> ContractUsers { get; set; } = new List<Contract>();

    public virtual ResDept DeptFkNavigation { get; set; }

    public virtual ICollection<DocMove> DocMoves { get; set; } = new List<DocMove>();

    public virtual ICollection<DocPoss> DocPossDests { get; set; } = new List<DocPoss>();

    public virtual ICollection<DocPoss> DocPossInits { get; set; } = new List<DocPoss>();

    public virtual ICollection<DocumentFolderUser> DocumentFolderUsers { get; set; } = new List<DocumentFolderUser>();

    public virtual ICollection<DocumentUser> DocumentUsers { get; set; } = new List<DocumentUser>();

    public virtual ICollection<Idp> IdpApprovedByNavigations { get; set; } = new List<Idp>();

    public virtual ICollection<Idp> IdpUsers { get; set; } = new List<Idp>();

    public virtual ICollection<IntRate> IntRateApprovedByNavigations { get; set; } = new List<IntRate>();

    public virtual ICollection<IntRate> IntRateCreatedByNavigations { get; set; } = new List<IntRate>();

    public virtual ICollection<Massage> MassageAuthorNavigations { get; set; } = new List<Massage>();

    public virtual ICollection<Massage> MassageReceivaNavigations { get; set; } = new List<Massage>();

    public virtual ICollection<PortalAuthTab> PortalAuthTabs { get; set; } = new List<PortalAuthTab>();

    public virtual ICollection<PortalAuth> PortalAuths { get; set; } = new List<PortalAuth>();

    public virtual ICollection<PortalUserRole> PortalUserRoles { get; set; } = new List<PortalUserRole>();

    public virtual ICollection<Program> Programs { get; set; } = new List<Program>();

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    public virtual ICollection<PvPayment> PvPayments { get; set; } = new List<PvPayment>();

    public virtual ICollection<Pv> PvPreparerNavigations { get; set; } = new List<Pv>();

    public virtual ICollection<Pv> PvUsers { get; set; } = new List<Pv>();

    public virtual ICollection<ResDept> ResDeptDelegatedFkNavigations { get; set; } = new List<ResDept>();

    public virtual ICollection<ResDept> ResDeptHodUserFkNavigations { get; set; } = new List<ResDept>();

    public virtual PortalUserStatus StatusFkNavigation { get; set; }

    public virtual ICollection<TicketAProcess> TicketAProcessOwners { get; set; } = new List<TicketAProcess>();

    public virtual ICollection<TicketAProcess> TicketAProcessProcessedByNavigations { get; set; } = new List<TicketAProcess>();

    public virtual ICollection<TicketComment> TicketComments { get; set; } = new List<TicketComment>();

    public virtual ICollection<Ticket> TicketCreatedByNavigations { get; set; } = new List<Ticket>();

    public virtual ICollection<TicketDocument> TicketDocuments { get; set; } = new List<TicketDocument>();

    public virtual ICollection<TicketEscalated> TicketEscalatedCreatedByNavigations { get; set; } = new List<TicketEscalated>();

    public virtual ICollection<TicketEscalated> TicketEscalatedRecevas { get; set; } = new List<TicketEscalated>();

    public virtual ICollection<Ticket> TicketOwners { get; set; } = new List<Ticket>();

    public virtual ICollection<TicketReopen> TicketReopens { get; set; } = new List<TicketReopen>();

    public virtual ICollection<TicketResolved> TicketResolveds { get; set; } = new List<TicketResolved>();

    public virtual ICollection<TicketSupportGroupUser> TicketSupportGroupUsers { get; set; } = new List<TicketSupportGroupUser>();

    public virtual ICollection<VoBase> VoBases { get; set; } = new List<VoBase>();

    public virtual ICollection<Voext> Voexts { get; set; } = new List<Voext>();

    public virtual ICollection<Vo> Vos { get; set; } = new List<Vo>();
}
