using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Assembly> Assemblies { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<BankBranch> BankBranches { get; set; }

    public virtual DbSet<Bid> Bids { get; set; }

    public virtual DbSet<BidAct> BidActs { get; set; }

    public virtual DbSet<BidBase> BidBases { get; set; }

    public virtual DbSet<BidBatch> BidBatches { get; set; }

    public virtual DbSet<BidBill> BidBills { get; set; }

    public virtual DbSet<BidBillEx> BidBillExes { get; set; }

    public virtual DbSet<BidClause> BidClauses { get; set; }

    public virtual DbSet<BidClone> BidClones { get; set; }

    public virtual DbSet<BidConPlc> BidConPlcs { get; set; }

    public virtual DbSet<BidDaywork> BidDayworks { get; set; }

    public virtual DbSet<BidRead> BidReads { get; set; }

    public virtual DbSet<BidSublet> BidSublets { get; set; }

    public virtual DbSet<BidType> BidTypes { get; set; }

    public virtual DbSet<BidWeit> BidWeits { get; set; }

    public virtual DbSet<BidWeitEx> BidWeitExes { get; set; }

    public virtual DbSet<Bidder> Bidders { get; set; }

    public virtual DbSet<Boq> Boqs { get; set; }

    public virtual DbSet<BoqCat> BoqCats { get; set; }

    public virtual DbSet<BoqDamage> BoqDamages { get; set; }

    public virtual DbSet<BoqDoc> BoqDocs { get; set; }

    public virtual DbSet<BoqDrawing> BoqDrawings { get; set; }

    public virtual DbSet<BoqItem> BoqItems { get; set; }

    public virtual DbSet<BoqItemDel> BoqItemDels { get; set; }

    public virtual DbSet<BoqPaf> BoqPafs { get; set; }

    public virtual DbSet<BoqPafCalc> BoqPafCalcs { get; set; }

    public virtual DbSet<BoqPafExcept> BoqPafExcepts { get; set; }

    public virtual DbSet<BoqPafWeit> BoqPafWeits { get; set; }

    public virtual DbSet<BoqPafWeitEx> BoqPafWeitExes { get; set; }

    public virtual DbSet<BoqProgress> BoqProgresses { get; set; }

    public virtual DbSet<BoqSublet> BoqSublets { get; set; }

    public virtual DbSet<Closure> Closures { get; set; }

    public virtual DbSet<ClosureDoc> ClosureDocs { get; set; }

    public virtual DbSet<CoaAccount> CoaAccounts { get; set; }

    public virtual DbSet<CoaAccountBelow100> CoaAccountBelow100s { get; set; }

    public virtual DbSet<CoaAccountBelow20> CoaAccountBelow20s { get; set; }

    public virtual DbSet<CoaAccountFiscalYear> CoaAccountFiscalYears { get; set; }

    public virtual DbSet<CoaAccountJournal> CoaAccountJournals { get; set; }

    public virtual DbSet<CoaAccountJournalEntry> CoaAccountJournalEntries { get; set; }

    public virtual DbSet<CoaAccountJournalEntryItem> CoaAccountJournalEntryItems { get; set; }

    public virtual DbSet<CoaAccountJournalEntryItemReconcile> CoaAccountJournalEntryItemReconciles { get; set; }

    public virtual DbSet<CoaAccountPeriod> CoaAccountPeriods { get; set; }

    public virtual DbSet<CoaAsset> CoaAssets { get; set; }

    public virtual DbSet<CoaExpenditure> CoaExpenditures { get; set; }

    public virtual DbSet<CoaLiability> CoaLiabilities { get; set; }

    public virtual DbSet<CoaRevenue> CoaRevenues { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<ContractAct> ContractActs { get; set; }

    public virtual DbSet<ContractAdv> ContractAdvs { get; set; }

    public virtual DbSet<ContractAdvDoc> ContractAdvDocs { get; set; }

    public virtual DbSet<ContractAdvPmt> ContractAdvPmts { get; set; }

    public virtual DbSet<ContractCost> ContractCosts { get; set; }

    public virtual DbSet<ContractDaywork> ContractDayworks { get; set; }

    public virtual DbSet<ContractDoc> ContractDocs { get; set; }

    public virtual DbSet<ContractDocCat> ContractDocCats { get; set; }

    public virtual DbSet<ContractInt> ContractInts { get; set; }

    public virtual DbSet<ContractPlant> ContractPlants { get; set; }

    public virtual DbSet<ContractPlantPmt> ContractPlantPmts { get; set; }

    public virtual DbSet<ContractProgress> ContractProgresses { get; set; }

    public virtual DbSet<ContractStatus> ContractStatuses { get; set; }

    public virtual DbSet<ContractSublet> ContractSublets { get; set; }

    public virtual DbSet<ContractType> ContractTypes { get; set; }

    public virtual DbSet<Contractor> Contractors { get; set; }

    public virtual DbSet<ContractorAssoc> ContractorAssocs { get; set; }

    public virtual DbSet<ContractorBank> ContractorBanks { get; set; }

    public virtual DbSet<Coverage> Coverages { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<DocMove> DocMoves { get; set; }

    public virtual DbSet<DocPoss> DocPosses { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<DocumentFolder> DocumentFolders { get; set; }

    public virtual DbSet<DocumentFolderRole> DocumentFolderRoles { get; set; }

    public virtual DbSet<DocumentFolderUser> DocumentFolderUsers { get; set; }

    public virtual DbSet<DocumentRole> DocumentRoles { get; set; }

    public virtual DbSet<DocumentStatus> DocumentStatuses { get; set; }

    public virtual DbSet<DocumentUser> DocumentUsers { get; set; }

    public virtual DbSet<DocumentVersion> DocumentVersions { get; set; }

    public virtual DbSet<FundCategory> FundCategories { get; set; }

    public virtual DbSet<FundSource> FundSources { get; set; }

    public virtual DbSet<FundSubSource> FundSubSources { get; set; }

    public virtual DbSet<FundingBudget> FundingBudgets { get; set; }

    public virtual DbSet<FundingExpenditure> FundingExpenditures { get; set; }

    public virtual DbSet<HcmEmployee> HcmEmployees { get; set; }

    public virtual DbSet<Idp> Idps { get; set; }

    public virtual DbSet<IdpDoc> IdpDocs { get; set; }

    public virtual DbSet<IdpDocCat> IdpDocCats { get; set; }

    public virtual DbSet<IdpInt> IdpInts { get; set; }

    public virtual DbSet<IdpIntItem> IdpIntItems { get; set; }

    public virtual DbSet< Web.Models.Index> Indices { get; set; }

    public virtual DbSet<IndicesNew> IndicesNews { get; set; }

    public virtual DbSet<IntRate> IntRates { get; set; }

    public virtual DbSet<IpcaddOmit> IpcaddOmits { get; set; }

    public virtual DbSet<Ipcback> Ipcbacks { get; set; }

    public virtual DbSet<Ipcfront> Ipcfronts { get; set; }

    public virtual DbSet<Massage> Massages { get; set; }

    public virtual DbSet<MessageDoc> MessageDocs { get; set; }

    public virtual DbSet<MessageDocTemp> MessageDocTemps { get; set; }

    public virtual DbSet<Nationality> Nationalities { get; set; }

    public virtual DbSet<Photograph> Photographs { get; set; }

    public virtual DbSet<Portal> Portals { get; set; }

    public virtual DbSet<PortalAuth> PortalAuths { get; set; }

    public virtual DbSet<PortalAuthTab> PortalAuthTabs { get; set; }

    public virtual DbSet<PortalError> PortalErrors { get; set; }

    public virtual DbSet<PortalIcon> PortalIcons { get; set; }

    public virtual DbSet<PortalModule> PortalModules { get; set; }

    public virtual DbSet<PortalPageCate> PortalPageCates { get; set; }

    public virtual DbSet<PortalRole> PortalRoles { get; set; }

    public virtual DbSet<PortalSetting> PortalSettings { get; set; }

    public virtual DbSet<Web.Models.PortalTab> PortalTabs { get; set; }

    public virtual DbSet<PortalTabGroup> PortalTabGroups { get; set; }

    public virtual DbSet<PortalTabRole> PortalTabRoles { get; set; }

    public virtual DbSet<PortalUser> PortalUsers { get; set; }

    public virtual DbSet<PortalUserFlow> PortalUserFlows { get; set; }

    public virtual DbSet<PortalUserRole> PortalUserRoles { get; set; }

    public virtual DbSet<PortalUserStatus> PortalUserStatuses { get; set; }

    public virtual DbSet<Web.Models.Program> Programs { get; set; }

    public virtual DbSet<ProgramAgent> ProgramAgents { get; set; }

    public virtual DbSet<ProgramCost> ProgramCosts { get; set; }

    public virtual DbSet<ProgramDoc> ProgramDocs { get; set; }

    public virtual DbSet<ProgramType> ProgramTypes { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ProjectType> ProjectTypes { get; set; }

    public virtual DbSet<Pv> Pvs { get; set; }

    public virtual DbSet<PvAudit> PvAudits { get; set; }

    public virtual DbSet<PvGyaabaakrom> PvGyaabaakroms { get; set; }

    public virtual DbSet<PvPayment> PvPayments { get; set; }

    public virtual DbSet<PvStatus> PvStatuses { get; set; }

    public virtual DbSet<PvStatusCat> PvStatusCats { get; set; }

    public virtual DbSet<RdDef> RdDefs { get; set; }

    public virtual DbSet<RdIrClass> RdIrClasses { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<ReportAccess> ReportAccesses { get; set; }

    public virtual DbSet<ReportCat> ReportCats { get; set; }

    public virtual DbSet<ReportRole> ReportRoles { get; set; }

    public virtual DbSet<ResDept> ResDepts { get; set; }

    public virtual DbSet<ResDeptFlow> ResDeptFlows { get; set; }

    public virtual DbSet<RmDistSum> RmDistSums { get; set; }

    public virtual DbSet<RmDistrict> RmDistricts { get; set; }

    public virtual DbSet<RmRegSummary> RmRegSummaries { get; set; }

    public virtual DbSet<RmRoadMaintenance> RmRoadMaintenances { get; set; }

    public virtual DbSet<RmUnitCost> RmUnitCosts { get; set; }

    public virtual DbSet<RmWork> RmWorks { get; set; }

    public virtual DbSet<RmWorksItem> RmWorksItems { get; set; }

    public virtual DbSet<Road> Roads { get; set; }

    public virtual DbSet<RoadNode> RoadNodes { get; set; }

    public virtual DbSet<StandardAct> StandardActs { get; set; }

    public virtual DbSet<StandardActivity> StandardActivities { get; set; }

    public virtual DbSet<StandardActivityEx> StandardActivityExes { get; set; }

    public virtual DbSet<StandardBill> StandardBills { get; set; }

    public virtual DbSet<StandardBillEx> StandardBillExes { get; set; }

    public virtual DbSet<StandardClause> StandardClauses { get; set; }

    public virtual DbSet<StandardDaywork> StandardDayworks { get; set; }

    public virtual DbSet<StandardDayworkEx> StandardDayworkExes { get; set; }

    public virtual DbSet<StandardDayworkRm> StandardDayworkRms { get; set; }

    public virtual DbSet<StandardProgress> StandardProgresses { get; set; }

    public virtual DbSet<StandardProgressCat> StandardProgressCats { get; set; }

    public virtual DbSet<StandardWeit> StandardWeits { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<TicketAProcess> TicketAProcesses { get; set; }

    public virtual DbSet<TicketCategory> TicketCategories { get; set; }

    public virtual DbSet<TicketComment> TicketComments { get; set; }

    public virtual DbSet<TicketConfig> TicketConfigs { get; set; }

    public virtual DbSet<TicketDocument> TicketDocuments { get; set; }

    public virtual DbSet<TicketEscalated> TicketEscalateds { get; set; }

    public virtual DbSet<TicketNote> TicketNotes { get; set; }

    public virtual DbSet<TicketPriority> TicketPriorities { get; set; }

    public virtual DbSet<TicketReopen> TicketReopens { get; set; }

    public virtual DbSet<TicketResolved> TicketResolveds { get; set; }

    public virtual DbSet<TicketStatus> TicketStatuses { get; set; }

    public virtual DbSet<TicketSupportGroup> TicketSupportGroups { get; set; }

    public virtual DbSet<TicketSupportGroupUser> TicketSupportGroupUsers { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<Vo> Vos { get; set; }

    public virtual DbSet<VoAct> VoActs { get; set; }

    public virtual DbSet<VoBase> VoBases { get; set; }

    public virtual DbSet<VoBill> VoBills { get; set; }

    public virtual DbSet<VoBillEx> VoBillExes { get; set; }

    public virtual DbSet<VoDocument> VoDocuments { get; set; }

    public virtual DbSet<VoProgress> VoProgresses { get; set; }

    public virtual DbSet<VoRate> VoRates { get; set; }

    public virtual DbSet<Voext> Voexts { get; set; }

    public virtual DbSet<VoextCost> VoextCosts { get; set; }

    public virtual DbSet<VoextDoc> VoextDocs { get; set; }

    public virtual DbSet<VwBdBid> VwBdBids { get; set; }

    public virtual DbSet<VwBdBidBoq> VwBdBidBoqs { get; set; }

    public virtual DbSet<VwBdBidLotSummary> VwBdBidLotSummaries { get; set; }

    public virtual DbSet<VwBdBidRegion> VwBdBidRegions { get; set; }

    public virtual DbSet<VwBidBaseInfo> VwBidBaseInfos { get; set; }

    public virtual DbSet<VwBoqAct> VwBoqActs { get; set; }

    public virtual DbSet<VwBoqPafMonthlyValue> VwBoqPafMonthlyValues { get; set; }

    public virtual DbSet<VwClosure> VwClosures { get; set; }

    public virtual DbSet<VwCoaFundingExpenditureDetail> VwCoaFundingExpenditureDetails { get; set; }

    public virtual DbSet<VwContractorBank> VwContractorBanks { get; set; }

    public virtual DbSet<VwCtContract> VwCtContracts { get; set; }

    public virtual DbSet<VwCtContractActivity> VwCtContractActivities { get; set; }

    public virtual DbSet<VwCtContractBaseInfo> VwCtContractBaseInfos { get; set; }

    public virtual DbSet<VwCtContractProgress> VwCtContractProgresses { get; set; }

    public virtual DbSet<VwCtContractRegion> VwCtContractRegions { get; set; }

    public virtual DbSet<VwCtSummaryOfBill> VwCtSummaryOfBills { get; set; }

    public virtual DbSet<VwCtSummaryOfBillsDetail> VwCtSummaryOfBillsDetails { get; set; }

    public virtual DbSet<VwDocument> VwDocuments { get; set; }

    public virtual DbSet<VwDocumentFolder> VwDocumentFolders { get; set; }

    public virtual DbSet<VwExecSummaryOfBill> VwExecSummaryOfBills { get; set; }

    public virtual DbSet<VwHcmEmployee> VwHcmEmployees { get; set; }

    public virtual DbSet<VwIdp> VwIdps { get; set; }

    public virtual DbSet<VwIpc> VwIpcs { get; set; }

    public virtual DbSet<VwIpcSubContractor> VwIpcSubContractors { get; set; }

    public virtual DbSet<VwMessage> VwMessages { get; set; }

    public virtual DbSet<VwPortalTab> VwPortalTabs { get; set; }

    public virtual DbSet<VwPortalTabGroup> VwPortalTabGroups { get; set; }

    public virtual DbSet<VwPortalUser> VwPortalUsers { get; set; }

    public virtual DbSet<VwProgram> VwPrograms { get; set; }

    public virtual DbSet<VwProject> VwProjects { get; set; }

    public virtual DbSet<VwPv> VwPvs { get; set; }

    public virtual DbSet<VwRdRoadInformation> VwRdRoadInformations { get; set; }

    public virtual DbSet<VwStandardActivity> VwStandardActivities { get; set; }

    public virtual DbSet<VwStandardActivityEx> VwStandardActivityExes { get; set; }

    public virtual DbSet<VwStandardProgress> VwStandardProgresses { get; set; }

    public virtual DbSet<VwStandarddaywork> VwStandarddayworks { get; set; }

    public virtual DbSet<VwTicket> VwTickets { get; set; }

    public virtual DbSet<VwTicketSupportGroupUser> VwTicketSupportGroupUsers { get; set; }

    public virtual DbSet<VwVo> VwVos { get; set; }

    public virtual DbSet<VwVoVoBaseInfo> VwVoVoBaseInfos { get; set; }

    public virtual DbSet<VwVoext> VwVoexts { get; set; }

    public virtual DbSet<WebLink> WebLinks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=SQL1004.site4now.net;Initial Catalog=db_ab3184_gha;User Id=db_ab3184_gha_admin;Password=Fas000502");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Assembly>(entity =>
        {
            entity.ToTable("Assembly");

            entity.Property(e => e.AssemblyId).HasColumnName("AssemblyID");
            entity.Property(e => e.AssemblyCode)
                .IsRequired()
                .HasMaxLength(10);
            entity.Property(e => e.AssemblyName)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.AssemblyType)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.DistCode).HasMaxLength(10);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");

            entity.HasOne(d => d.Region).WithMany(p => p.Assemblies)
                .HasForeignKey(d => d.RegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Assembly_Region");
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.HasKey(e => e.BankId).HasName("PK__Bank__AA08CB330CA5D9DE");

            entity.ToTable("Bank");

            entity.HasIndex(e => e.BankCode, "UQ__Bank__93AE04F7125EB334").IsUnique();

            entity.HasIndex(e => e.BankName, "UQ__Bank__DA9ADFAA0F824689").IsUnique();

            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankCode)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.BankName)
                .IsRequired()
                .HasMaxLength(120);
        });

        modelBuilder.Entity<BankBranch>(entity =>
        {
            entity.HasKey(e => e.BranchId).HasName("PK__BankBran__A1682FA5162F4418");

            entity.ToTable("BankBranch");

            entity.HasIndex(e => e.BranchCode, "UQ__BankBran__1C61B888190BB0C3").IsUnique();

            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BranchCode)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.BranchName)
                .IsRequired()
                .HasMaxLength(120);

            entity.HasOne(d => d.Bank).WithMany(p => p.BankBranches)
                .HasForeignKey(d => d.BankId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BankBranc__BankI__1AF3F935");
        });

        modelBuilder.Entity<Bid>(entity =>
        {
            entity.HasKey(e => e.BidId).HasName("PK__BidInfor__4A733DB2442B18F2");

            entity.ToTable("Bid");

            entity.HasIndex(e => e.BidNo, "UQ_Bid").IsUnique();

            entity.Property(e => e.BidId).HasColumnName("BidID");
            entity.Property(e => e.Approved).HasColumnName("approved");
            entity.Property(e => e.Archived).HasColumnName("archived");
            entity.Property(e => e.BidBatchFk).HasColumnName("BidBatch_FK");
            entity.Property(e => e.BidNo)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.BidTitle)
                .IsRequired()
                .HasMaxLength(500);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DeptId)
                .HasDefaultValue(5)
                .HasColumnName("Dept_ID");
            entity.Property(e => e.LotNo).HasMaxLength(10);
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("User_ID");

            entity.HasOne(d => d.BidBatchFkNavigation).WithMany(p => p.Bids)
                .HasForeignKey(d => d.BidBatchFk)
                .HasConstraintName("FK_Bid_BidBatch");

            entity.HasOne(d => d.Dept).WithMany(p => p.Bids)
                .HasForeignKey(d => d.DeptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BidInform__Dept");

            entity.HasOne(d => d.User).WithMany(p => p.Bids)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BidInform__CurrUser");
        });

        modelBuilder.Entity<BidAct>(entity =>
        {
            entity.HasKey(e => e.BidActivityId).HasName("PK_BidActivities");

            entity.ToTable("BidAct");

            entity.HasIndex(e => new { e.BidBillExFk, e.ActivityFk }, "UQ_BidActivities").IsUnique();

            entity.Property(e => e.BidActivityId).HasColumnName("BidActivityID");
            entity.Property(e => e.ActivityFk).HasColumnName("activity_fk");
            entity.Property(e => e.BidBillExFk).HasColumnName("BidBillEx_FK");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Unit).HasMaxLength(20);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.ActivityFkNavigation).WithMany(p => p.BidActs)
                .HasForeignKey(d => d.ActivityFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BidActivities_StandardSubActivity");

            entity.HasOne(d => d.BidBillExFkNavigation).WithMany(p => p.BidActs)
                .HasForeignKey(d => d.BidBillExFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BidBillsEx__BidActivity");
        });

        modelBuilder.Entity<BidBase>(entity =>
        {
            entity.HasKey(e => e.BidBaseId).HasName("PK__BidBase");

            entity.ToTable("BidBase");

            entity.Property(e => e.BidBaseId).HasColumnName("BidBaseID");
            entity.Property(e => e.AssemblyFk).HasColumnName("Assembly_FK");
            entity.Property(e => e.BaseNo)
                .IsRequired()
                .HasMaxLength(60)
                .HasComment("This represents the Road or Bridge or component number or ID");
            entity.Property(e => e.BaseTitle)
                .IsRequired()
                .HasMaxLength(180)
                .HasComment("This is the component tile of d road or river name");
            entity.Property(e => e.BidFk).HasColumnName("Bid_FK");
            entity.Property(e => e.CatFk)
                .HasDefaultValue(1)
                .HasColumnName("cat_fk");
            entity.Property(e => e.ContractFk).HasColumnName("Contract_FK");
            entity.Property(e => e.ContractTypeFk)
                .HasDefaultValue(1)
                .HasColumnName("contract_type_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DistEnd).HasComment("The is the end section of the Road but in Bridge it is the No. of Spans");
            entity.Property(e => e.DistStart).HasComment("The is the start section of the Road but will be zero 4 Bridge");
            entity.Property(e => e.Distance).HasComment("This is the Road Length(km) or Bridge Length (m)");
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.RoadFk).HasColumnName("Road_FK");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.AssemblyFkNavigation).WithMany(p => p.BidBases)
                .HasForeignKey(d => d.AssemblyFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BidBase__Assembly");

            entity.HasOne(d => d.BidFkNavigation).WithMany(p => p.BidBases)
                .HasForeignKey(d => d.BidFk)
                .HasConstraintName("FK__BidBase__Bid");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.BidBases)
                .HasForeignKey(d => d.ContractFk)
                .HasConstraintName("FK__BidBase__Contract");

            entity.HasOne(d => d.ContractTypeFkNavigation).WithMany(p => p.BidBases)
                .HasForeignKey(d => d.ContractTypeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BidBase_contract_type");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.BidBases)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BidBase__crdUser");

            entity.HasOne(d => d.RoadFkNavigation).WithMany(p => p.BidBases)
                .HasForeignKey(d => d.RoadFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BidBase_Road");
        });

        modelBuilder.Entity<BidBatch>(entity =>
        {
            entity.ToTable("BidBatch");

            entity.Property(e => e.BidBatchId).HasColumnName("BidBatchID");
            entity.Property(e => e.BatchNo)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.BatchTitle)
                .IsRequired()
                .HasMaxLength(350);
            entity.Property(e => e.BidTypeId).HasColumnName("BidTypeID");
            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DeptId).HasColumnName("Dept_ID");
            entity.Property(e => e.Notes).HasMaxLength(350);
            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("User_ID");

            entity.HasOne(d => d.BidType).WithMany(p => p.BidBatches)
                .HasForeignKey(d => d.BidTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BidBatch_BidType");

            entity.HasOne(d => d.Project).WithMany(p => p.BidBatches)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BidBatch_Project");
        });

        modelBuilder.Entity<BidBill>(entity =>
        {
            entity.HasKey(e => e.BidBillId).HasName("PK__BidBill");

            entity.ToTable("BidBill");

            entity.HasIndex(e => new { e.BidBaseFk, e.BillNo }, "UQ_BidBillNo").IsUnique();

            entity.HasIndex(e => new { e.BidBaseFk, e.Number }, "UQ__BidBillNum").IsUnique();

            entity.Property(e => e.BidBillId).HasColumnName("BidBillID");
            entity.Property(e => e.BidBaseFk).HasColumnName("BidBase_FK");
            entity.Property(e => e.BillDesc)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.BillNo)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.ContractFk).HasColumnName("Contract_FK");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Remarks).HasMaxLength(350);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.BidBaseFkNavigation).WithMany(p => p.BidBills)
                .HasForeignKey(d => d.BidBaseFk)
                .HasConstraintName("FK_BidBills_BidBase");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.BidBills)
                .HasForeignKey(d => d.ContractFk)
                .HasConstraintName("FK_BidBills_Contract");
        });

        modelBuilder.Entity<BidBillEx>(entity =>
        {
            entity.HasKey(e => e.BidBillExId).HasName("PK_BidBillsEx");

            entity.ToTable("BidBillEx");

            entity.Property(e => e.BidBillExId).HasColumnName("BidBillExID");
            entity.Property(e => e.BidBillFk).HasColumnName("BidBill_FK");
            entity.Property(e => e.ContractFk).HasColumnName("Contract_FK");
            entity.Property(e => e.SubName)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("sub_name");
            entity.Property(e => e.SubNo).HasColumnName("sub_no");

            entity.HasOne(d => d.BidBillFkNavigation).WithMany(p => p.BidBillExes)
                .HasForeignKey(d => d.BidBillFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BidBills__BidBillsEx");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.BidBillExes)
                .HasForeignKey(d => d.ContractFk)
                .HasConstraintName("FK__BidBillsEx__Contract");
        });

        modelBuilder.Entity<BidClause>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contract__0ED225EE41B8C09B");

            entity.ToTable("BidClause");

            entity.HasIndex(e => new { e.BidFk, e.ClauseFk }, "UQ__Contract__9F9D761A4925A390").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BidFk).HasColumnName("bid_fk");
            entity.Property(e => e.ClauseFk).HasColumnName("clause_fk");
            entity.Property(e => e.ContractFk).HasColumnName("contract_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.BidFkNavigation).WithMany(p => p.BidClauses)
                .HasForeignKey(d => d.BidFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContReq__BidInfo");

            entity.HasOne(d => d.ClauseFkNavigation).WithMany(p => p.BidClauses)
                .HasForeignKey(d => d.ClauseFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractC__Requi__2BE97B0D");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.BidClauses)
                .HasForeignKey(d => d.ContractFk)
                .HasConstraintName("FK__Contract__ContReq");
        });

        modelBuilder.Entity<BidClone>(entity =>
        {
            entity.HasKey(e => e.BidCloneId).HasName("PK__BidClone__D405D8CE2693CAA2");

            entity.ToTable("BidClone");

            entity.HasIndex(e => e.DestinationFk, "UQ__BidClone__29EB8794B40577AB").IsUnique();

            entity.Property(e => e.BidCloneId).HasColumnName("BidCloneID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DestinationFk).HasColumnName("Destination_FK");
            entity.Property(e => e.SourceFk).HasColumnName("Source_FK");

            entity.HasOne(d => d.DestinationFkNavigation).WithOne(p => p.BidCloneDestinationFkNavigation)
                .HasForeignKey<BidClone>(d => d.DestinationFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BidClone_DestinationBase");

            entity.HasOne(d => d.SourceFkNavigation).WithMany(p => p.BidCloneSourceFkNavigations)
                .HasForeignKey(d => d.SourceFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BidClone_SourceBase");
        });

        modelBuilder.Entity<BidConPlc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BidConPlc");

            entity.Property(e => e.AssemblyName)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.BidBaseId).HasColumnName("BidBaseID");
            entity.Property(e => e.BidFk).HasColumnName("Bid_FK");
            entity.Property(e => e.ContractFk).HasColumnName("Contract_FK");
            entity.Property(e => e.Region)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<BidDaywork>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BidDayWorks");

            entity.ToTable("BidDaywork");

            entity.HasIndex(e => new { e.BidbaseFk, e.DayworkFk }, "UQ__BidDayWorks").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.BidFk).HasColumnName("bid_fk");
            entity.Property(e => e.BidbaseFk).HasColumnName("bidbase_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DayworkFk).HasColumnName("daywork_fk");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.Unit)
                .HasMaxLength(20)
                .HasColumnName("unit");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.BidFkNavigation).WithMany(p => p.BidDayworks)
                .HasForeignKey(d => d.BidFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BidDayWor__BidInfo");

            entity.HasOne(d => d.BidbaseFkNavigation).WithMany(p => p.BidDayworks)
                .HasForeignKey(d => d.BidbaseFk)
                .HasConstraintName("FK_BidBase_BidDayWorks");

            entity.HasOne(d => d.DayworkFkNavigation).WithMany(p => p.BidDayworks)
                .HasForeignKey(d => d.DayworkFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BidDayWorks__DayWorks");
        });

        modelBuilder.Entity<BidRead>(entity =>
        {
            entity.ToTable("BidRead");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BidAmount).HasColumnName("bidAmount");
            entity.Property(e => e.BidderFk).HasColumnName("bidder_FK");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Currency)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("currency");
            entity.Property(e => e.Labour).HasColumnName("labour");
            entity.Property(e => e.Remarks)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Sealed)
                .HasDefaultValue(true)
                .HasColumnName("sealed");
            entity.Property(e => e.Secured).HasColumnName("secured");
            entity.Property(e => e.Signed).HasColumnName("signed");
            entity.Property(e => e.Ssnit).HasColumnName("ssnit");
            entity.Property(e => e.Tax).HasColumnName("tax");
            entity.Property(e => e.UserFk).HasColumnName("user_FK");

            entity.HasOne(d => d.BidderFkNavigation).WithMany(p => p.BidReads)
                .HasForeignKey(d => d.BidderFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BidRead_Bidders");

            entity.HasOne(d => d.UserFkNavigation).WithMany(p => p.BidReads)
                .HasForeignKey(d => d.UserFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BidRead_User");
        });

        modelBuilder.Entity<BidSublet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BidSuble__3213E83F593821C0");

            entity.ToTable("BidSublet");

            entity.HasIndex(e => new { e.BidFk, e.ContractorFk }, "UQ__BidSuble__127F4B72AFC1D806").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BidFk).HasColumnName("bid_fk");
            entity.Property(e => e.ContractorFk).HasColumnName("contractor_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.GrossAmount).HasColumnName("gross_amount");
            entity.Property(e => e.GrossRet).HasColumnName("gross_ret");
            entity.Property(e => e.NetAmount).HasColumnName("net_amount");

            entity.HasOne(d => d.BidFkNavigation).WithMany(p => p.BidSublets)
                .HasForeignKey(d => d.BidFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BidBublet_Bid");

            entity.HasOne(d => d.ContractorFkNavigation).WithMany(p => p.BidSublets)
                .HasForeignKey(d => d.ContractorFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BidSublet_Contractor");
        });

        modelBuilder.Entity<BidType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BidType__EF38F7574DB4832C");

            entity.ToTable("BidType");

            entity.HasIndex(e => e.Code, "UQ__BidType__AE5F7AF85090EFD7").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<BidWeit>(entity =>
        {
            entity.HasKey(e => e.BidWeitId).HasName("PK__BidWorkC__6106DAAC31783731");

            entity.ToTable("BidWeit");

            entity.HasIndex(e => new { e.BidFk, e.WeitFk }, "UQ__BidWorkC__B43198753454A3DC").IsUnique();

            entity.Property(e => e.BidWeitId).HasColumnName("BidWeitID");
            entity.Property(e => e.Bi).HasColumnName("BI");
            entity.Property(e => e.BidFk).HasColumnName("Bid_FK");
            entity.Property(e => e.Cb).HasColumnName("CB");
            entity.Property(e => e.Ce).HasColumnName("CE");
            entity.Property(e => e.Ch).HasColumnName("CH");
            entity.Property(e => e.Co).HasColumnName("CO");
            entity.Property(e => e.ContractFk).HasColumnName("Contract_FK");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Fu).HasColumnName("FU");
            entity.Property(e => e.Ll).HasColumnName("LL");
            entity.Property(e => e.Pc).HasColumnName("PC");
            entity.Property(e => e.Pg).HasColumnName("PG");
            entity.Property(e => e.Pl).HasColumnName("PL");
            entity.Property(e => e.Rl).HasColumnName("RL");
            entity.Property(e => e.Ro).HasColumnName("RO");
            entity.Property(e => e.Rs).HasColumnName("RS");
            entity.Property(e => e.Ti).HasColumnName("TI");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.WeitFk).HasColumnName("weit_fk");

            entity.HasOne(d => d.BidFkNavigation).WithMany(p => p.BidWeits)
                .HasForeignKey(d => d.BidFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BidWorkCategory__BidInfo");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.BidWeits)
                .HasForeignKey(d => d.ContractFk)
                .HasConstraintName("FK__BidWorkCat__Contract");

            entity.HasOne(d => d.WeitFkNavigation).WithMany(p => p.BidWeits)
                .HasForeignKey(d => d.WeitFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bidweit_standardweit");
        });

        modelBuilder.Entity<BidWeitEx>(entity =>
        {
            entity.HasKey(e => e.BidFk).HasName("PK__BidWorkC__584267FC543E63A0");

            entity.ToTable("BidWeitEx");

            entity.Property(e => e.BidFk)
                .ValueGeneratedNever()
                .HasColumnName("Bid_FK");
            entity.Property(e => e.Cochoice)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("COchoice");
            entity.Property(e => e.ContractFk).HasColumnName("Contract_FK");
            entity.Property(e => e.Plchoice)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("PLchoice");

            entity.HasOne(d => d.BidFkNavigation).WithOne(p => p.BidWeitEx)
                .HasForeignKey<BidWeitEx>(d => d.BidFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BidWorkCatEx__BidInfo");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.BidWeitExes)
                .HasForeignKey(d => d.ContractFk)
                .HasConstraintName("FK__BidWorkCatEx__Contract");
        });

        modelBuilder.Entity<Bidder>(entity =>
        {
            entity.HasIndex(e => new { e.BidId, e.ContractorId }, "UQ_Bidders");

            entity.Property(e => e.BidderId).HasColumnName("BidderID");
            entity.Property(e => e.BidDate).HasColumnType("datetime");
            entity.Property(e => e.BidId).HasColumnName("BidID");
            entity.Property(e => e.ContractorId).HasColumnName("ContractorID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Currency)
                .IsRequired()
                .HasMaxLength(10);
            entity.Property(e => e.Email).HasMaxLength(80);
            entity.Property(e => e.Mobile).HasMaxLength(35);
            entity.Property(e => e.SubmittedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.Bid).WithMany(p => p.Bidders)
                .HasForeignKey(d => d.BidId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bidders_BidInformation");

            entity.HasOne(d => d.Contractor).WithMany(p => p.Bidders)
                .HasForeignKey(d => d.ContractorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bidders_Contractor");
        });

        modelBuilder.Entity<Boq>(entity =>
        {
            entity.HasKey(e => e.BoqId).HasName("PK__BOQ__CD1D87B544D52468");

            entity.ToTable("Boq");

            entity.HasIndex(e => new { e.ContractId, e.BillNo }, "UQ__BOQ__48121C4947B19113").IsUnique();

            entity.Property(e => e.BoqId).HasColumnName("BoqID");
            entity.Property(e => e.ApplyTerminationClause).HasColumnName("apply_termination_clause");
            entity.Property(e => e.Archived).HasColumnName("archived");
            entity.Property(e => e.BillDesc)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.BillNo)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.BoqCatFk)
                .HasDefaultValue(1)
                .HasColumnName("boq_cat_fk");
            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("created_by");
            entity.Property(e => e.DeptId)
                .HasDefaultValue(5)
                .HasColumnName("Dept_ID");
            entity.Property(e => e.IpcApprovedBy).HasColumnName("ipcApprovedBy");
            entity.Property(e => e.IpcPreparedBy).HasColumnName("ipcPreparedBy");
            entity.Property(e => e.IpcPreviousAmount).HasColumnName("ipcPreviousAmount");
            entity.Property(e => e.IpcTotalAmount).HasColumnName("ipcTotalAmount");
            entity.Property(e => e.PafMonth).HasColumnName("paf_month");
            entity.Property(e => e.Remarks).HasMaxLength(250);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(80)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("User_ID");

            entity.HasOne(d => d.BoqCatFkNavigation).WithMany(p => p.Boqs)
                .HasForeignKey(d => d.BoqCatFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_boq_boq_cat");

            entity.HasOne(d => d.Contract).WithMany(p => p.Boqs)
                .HasForeignKey(d => d.ContractId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Boq__ContractID");

            entity.HasOne(d => d.Dept).WithMany(p => p.Boqs)
                .HasForeignKey(d => d.DeptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BOQ__Dept_ID__398E5A45");

            entity.HasOne(d => d.IpcApprovedByNavigation).WithMany(p => p.BoqIpcApprovedByNavigations)
                .HasForeignKey(d => d.IpcApprovedBy)
                .HasConstraintName("FK__BOQ__ipcApproved__605D434C");

            entity.HasOne(d => d.IpcPreparedByNavigation).WithMany(p => p.BoqIpcPreparedByNavigations)
                .HasForeignKey(d => d.IpcPreparedBy)
                .HasConstraintName("FK__BOQ__ipcPrepared__61516785");

            entity.HasOne(d => d.User).WithMany(p => p.BoqUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BOQ__CurrUser_FK__094A4A46");
        });

        modelBuilder.Entity<BoqCat>(entity =>
        {
            entity.ToTable("boq_cat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<BoqDamage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BOQDamag__50C3EF7610C46C0E");

            entity.HasIndex(e => new { e.BoqFk, e.RecoveredBoqId }, "UQ_BoqDamages").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BoqFk).HasColumnName("Boq_FK");
            entity.Property(e => e.Comment)
                .HasMaxLength(250)
                .HasColumnName("comment");
            entity.Property(e => e.ContractFk).HasColumnName("Contract_FK");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.ItemName)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.ItemNo)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.RecoveredBoqId).HasColumnName("recovered_boq_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.BoqFkNavigation).WithMany(p => p.BoqDamages)
                .HasForeignKey(d => d.BoqFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BOQDamage__BOQ_F__63649880");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.BoqDamages)
                .HasForeignKey(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BoqDamage__Contract");
        });

        modelBuilder.Entity<BoqDoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BOQDocum__6F0F989FF4D795D1");

            entity.ToTable("BoqDoc");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Baked).HasColumnName("baked");
            entity.Property(e => e.BoqFk).HasColumnName("boq_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.FlPath)
                .HasMaxLength(50)
                .HasColumnName("fl_path");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Sourx)
                .HasMaxLength(500)
                .HasColumnName("sourx");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.BoqFkNavigation).WithMany(p => p.BoqDocs)
                .HasForeignKey(d => d.BoqFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BoqDocume__BOQ_F__298CFCA6");
        });

        modelBuilder.Entity<BoqDrawing>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BoqBuiltDrawing");

            entity.ToTable("BoqDrawing");

            entity.HasIndex(e => new { e.ContractFk, e.BoqFk }, "UQ__BoqBuiltDrawing").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.BoqFk).HasColumnName("boq_fk");
            entity.Property(e => e.ContractFk).HasColumnName("contract_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CurrentSum).HasColumnName("current_sum");
            entity.Property(e => e.PrevAmount).HasColumnName("prev_amount");
            entity.Property(e => e.RetAmount).HasColumnName("ret_amount");
            entity.Property(e => e.RetPercent).HasColumnName("ret_percent");
            entity.Property(e => e.RetValue).HasColumnName("ret_value");

            entity.HasOne(d => d.BoqFkNavigation).WithMany(p => p.BoqDrawings)
                .HasForeignKey(d => d.BoqFk)
                .HasConstraintName("FK_BoqBuiltDrawing__Boq");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.BoqDrawings)
                .HasForeignKey(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BoqBuiltDrawing_Contract");
        });

        modelBuilder.Entity<BoqItem>(entity =>
        {
            entity.HasKey(e => e.BoqItemId).HasName("PK__BOQItem2__E72BA1DB7C255952");

            entity.ToTable("BoqItem");

            entity.Property(e => e.BoqItemId).HasColumnName("BoqItemID");
            entity.Property(e => e.BoqId).HasColumnName("BoqID");
            entity.Property(e => e.ContractActivityFk).HasColumnName("ContractActivity_FK");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.ExRemarks).HasMaxLength(350);
            entity.Property(e => e.Exceeded).HasColumnName("exceeded");
            entity.Property(e => e.Remarks).HasMaxLength(350);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.Voqtty).HasColumnName("VOQtty");

            entity.HasOne(d => d.Boq).WithMany(p => p.BoqItems)
                .HasForeignKey(d => d.BoqId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BoqItem__Boq");

            entity.HasOne(d => d.ContractActivityFkNavigation).WithMany(p => p.BoqItems)
                .HasForeignKey(d => d.ContractActivityFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BoqItem_ContractActivities");
        });

        modelBuilder.Entity<BoqItemDel>(entity =>
        {
            entity.HasKey(e => e.BoqItemId).HasName("PK__BoqItemDel");

            entity.ToTable("BoqItemDel");

            entity.Property(e => e.BoqItemId)
                .ValueGeneratedNever()
                .HasColumnName("BoqItemID");
            entity.Property(e => e.BoqFk).HasColumnName("Boq_FK");
            entity.Property(e => e.ContractActivityFk).HasColumnName("ContractActivity_FK");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DeptFk).HasColumnName("Dept_FK");
            entity.Property(e => e.ExRemarks).HasMaxLength(350);
            entity.Property(e => e.Exceeded).HasColumnName("exceeded");
            entity.Property(e => e.Remarks).HasMaxLength(350);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.Voqtty).HasColumnName("VOQtty");

            entity.HasOne(d => d.BoqFkNavigation).WithMany(p => p.BoqItemDels)
                .HasForeignKey(d => d.BoqFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BoqItemDel_Boq");

            entity.HasOne(d => d.ContractActivityFkNavigation).WithMany(p => p.BoqItemDels)
                .HasForeignKey(d => d.ContractActivityFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BoqItemDel_ContractActivities");

            entity.HasOne(d => d.DeptFkNavigation).WithMany(p => p.BoqItemDels)
                .HasForeignKey(d => d.DeptFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BoqItemDel_Dept");
        });

        modelBuilder.Entity<BoqPaf>(entity =>
        {
            entity.HasKey(e => e.PafId).HasName("PK__BOQPaf__EDA6DDBC54C1736E");

            entity.ToTable("BoqPaf");

            entity.HasIndex(e => new { e.BoqFk, e.PafMonth }, "UQ__BOQPaf__7EA14EDB579DE019").IsUnique();

            entity.Property(e => e.PafId).HasColumnName("PafID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.BoqFk).HasColumnName("Boq_FK");
            entity.Property(e => e.ContractFk).HasColumnName("Contract_FK");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.ExecBoqFk).HasColumnName("exec_boq_fk");
            entity.Property(e => e.Remarks).HasMaxLength(250);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.BoqFkNavigation).WithMany(p => p.BoqPafBoqFkNavigations)
                .HasForeignKey(d => d.BoqFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BoqPaf__Boq");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.BoqPafs)
                .HasForeignKey(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BoqPaf__Contract");

            entity.HasOne(d => d.ExecBoqFkNavigation).WithMany(p => p.BoqPafExecBoqFkNavigations)
                .HasForeignKey(d => d.ExecBoqFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_boqpaf_boq_exec_fk");
        });

        modelBuilder.Entity<BoqPafCalc>(entity =>
        {
            entity.HasKey(e => e.PafCalcId).HasName("PK__BOQPafCa__3F92E2F36BB4ABA1");

            entity.ToTable("BoqPafCalc");

            entity.Property(e => e.PafCalcId).HasColumnName("PafCalcID");
            entity.Property(e => e.BidweitFk).HasColumnName("bidweit_fk");
            entity.Property(e => e.Bivalue).HasColumnName("BIvalue");
            entity.Property(e => e.Cbvalue).HasColumnName("CBvalue");
            entity.Property(e => e.Cevalue).HasColumnName("CEvalue");
            entity.Property(e => e.Chvalue).HasColumnName("CHvalue");
            entity.Property(e => e.Covalue).HasColumnName("COvalue");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Fuvalue).HasColumnName("FUvalue");
            entity.Property(e => e.Llvalue).HasColumnName("LLvalue");
            entity.Property(e => e.PafFk).HasColumnName("Paf_FK");
            entity.Property(e => e.Pcvalue).HasColumnName("PCvalue");
            entity.Property(e => e.Pgvalue).HasColumnName("PGvalue");
            entity.Property(e => e.Plvalue).HasColumnName("PLvalue");
            entity.Property(e => e.Rlvalue).HasColumnName("RLvalue");
            entity.Property(e => e.Rovalue).HasColumnName("ROvalue");
            entity.Property(e => e.Rsvalue).HasColumnName("RSvalue");
            entity.Property(e => e.Tivalue).HasColumnName("TIvalue");
            entity.Property(e => e.TotalPaf).HasColumnName("TotalPAF");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.BidweitFkNavigation).WithMany(p => p.BoqPafCalcs)
                .HasForeignKey(d => d.BidweitFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_boqpafcalc_standardweit");

            entity.HasOne(d => d.PafFkNavigation).WithMany(p => p.BoqPafCalcs)
                .HasForeignKey(d => d.PafFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BoqPafCalc__BoqPaf");
        });

        modelBuilder.Entity<BoqPafExcept>(entity =>
        {
            entity.HasKey(e => e.ActivityFk);

            entity.ToTable("BoqPafExcept");

            entity.Property(e => e.ActivityFk)
                .ValueGeneratedNever()
                .HasColumnName("activity_fk");

            entity.HasOne(d => d.ActivityFkNavigation).WithOne(p => p.BoqPafExcept)
                .HasForeignKey<BoqPafExcept>(d => d.ActivityFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BoqPafExcept_StandardSubActivity");
        });

        modelBuilder.Entity<BoqPafWeit>(entity =>
        {
            entity.ToTable("BoqPafWeit");

            entity.HasIndex(e => new { e.BoqFk, e.BidweitFk }, "UQ_BoqPafWeit").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BidweitFk).HasColumnName("bidweit_fk");
            entity.Property(e => e.BoqFk).HasColumnName("boq_fk");
            entity.Property(e => e.ContractFk).HasColumnName("contract_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Paf).HasColumnName("paf");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.BidweitFkNavigation).WithMany(p => p.BoqPafWeits)
                .HasForeignKey(d => d.BidweitFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BoqPafWeit_BidWeit");

            entity.HasOne(d => d.BoqFkNavigation).WithMany(p => p.BoqPafWeits)
                .HasForeignKey(d => d.BoqFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BoqPafWeit_Boq");
        });

        modelBuilder.Entity<BoqPafWeitEx>(entity =>
        {
            entity.HasKey(e => e.ContractFk);

            entity.ToTable("BoqPafWeitEx");

            entity.Property(e => e.ContractFk)
                .ValueGeneratedNever()
                .HasColumnName("contract_fk");

            entity.HasOne(d => d.ContractFkNavigation).WithOne(p => p.BoqPafWeitEx)
                .HasForeignKey<BoqPafWeitEx>(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BoqPafWeitEx_Contract");
        });

        modelBuilder.Entity<BoqProgress>(entity =>
        {
            entity.HasKey(e => e.BoqProgressId).HasName("PK__BOQProgr__1094C23BC137D1ED");

            entity.ToTable("BoqProgress");

            entity.HasIndex(e => new { e.BoqFk, e.ContractProgressFk }, "UQ__BOQProgr__94BEFD509F9F965C").IsUnique();

            entity.Property(e => e.BoqProgressId).HasColumnName("BoqProgressID");
            entity.Property(e => e.BoqFk).HasColumnName("Boq_FK");
            entity.Property(e => e.ContractFk).HasColumnName("Contract_FK");
            entity.Property(e => e.ContractProgressFk).HasColumnName("ContractProgress_FK");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");

            entity.HasOne(d => d.BoqFkNavigation).WithMany(p => p.BoqProgresses)
                .HasForeignKey(d => d.BoqFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BoqProgress__Boq");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.BoqProgresses)
                .HasForeignKey(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BoqProgress__Contract");

            entity.HasOne(d => d.ContractProgressFkNavigation).WithMany(p => p.BoqProgresses)
                .HasForeignKey(d => d.ContractProgressFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BoqProgress__ContractProgress");
        });

        modelBuilder.Entity<BoqSublet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contract__98DBFC311CE72E9F");

            entity.ToTable("Boq_sublet");

            entity.HasIndex(e => new { e.BoqFk, e.SubletFk }, "UQ__Contract__7966388A1FC39B4A").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AmntNowDue).HasColumnName("amnt_now_due");
            entity.Property(e => e.BoqFk).HasColumnName("boq_FK");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.GrossValue).HasColumnName("gross_value");
            entity.Property(e => e.LastCertAmnt).HasColumnName("last_cert_amnt");
            entity.Property(e => e.Less5or10).HasColumnName("less_5or10");
            entity.Property(e => e.Less5or10Amnt).HasColumnName("less_5or10_amnt");
            entity.Property(e => e.NetAmount).HasColumnName("net_amount");
            entity.Property(e => e.SubletFk).HasColumnName("sublet_fk");

            entity.HasOne(d => d.BoqFkNavigation).WithMany(p => p.BoqSublets)
                .HasForeignKey(d => d.BoqFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractS__BOQ_F__2858E14B");

            entity.HasOne(d => d.SubletFkNavigation).WithMany(p => p.BoqSublets)
                .HasForeignKey(d => d.SubletFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractS__SubCo__294D0584");
        });

        modelBuilder.Entity<Closure>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Closure");

            entity.ToTable("closure");

            entity.HasIndex(e => e.ContractFk, "UQ_Closure").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approved).HasColumnName("approved");
            entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");
            entity.Property(e => e.ApprovedDate).HasColumnName("approved_date");
            entity.Property(e => e.CompletedDate).HasColumnName("completed_date");
            entity.Property(e => e.ContractFk).HasColumnName("contract_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DeptId).HasColumnName("dept_id");
            entity.Property(e => e.Reason)
                .HasMaxLength(350)
                .HasColumnName("reason");
            entity.Property(e => e.Remarks)
                .HasMaxLength(350)
                .HasColumnName("remarks");
            entity.Property(e => e.StatusFk).HasColumnName("status_fk");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.ApprovedByNavigation).WithMany(p => p.ClosureApprovedByNavigations)
                .HasForeignKey(d => d.ApprovedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Closure_User");

            entity.HasOne(d => d.ContractFkNavigation).WithOne(p => p.Closure)
                .HasForeignKey<Closure>(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Closure_Contract");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ClosureCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Dept).WithMany(p => p.Closures)
                .HasForeignKey(d => d.DeptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_closure_dept");

            entity.HasOne(d => d.StatusFkNavigation).WithMany(p => p.Closures)
                .HasForeignKey(d => d.StatusFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_closure_contract_status");

            entity.HasOne(d => d.User).WithMany(p => p.ClosureUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_closure_portal_user_id");
        });

        modelBuilder.Entity<ClosureDoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ClosureDocument");

            entity.ToTable("closure_doc");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Baked).HasColumnName("baked");
            entity.Property(e => e.ClosureFk).HasColumnName("closure_fk");
            entity.Property(e => e.ContractFk).HasColumnName("contract_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.FilePath)
                .HasMaxLength(50)
                .HasColumnName("file_path");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .HasColumnName("remarks");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.ClosureFkNavigation).WithMany(p => p.ClosureDocs)
                .HasForeignKey(d => d.ClosureFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Closure_ClosureDoc");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.ClosureDocs)
                .HasForeignKey(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClosureDoc_Contract");
        });

        modelBuilder.Entity<CoaAccount>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK__coaAccou__349DA586B4E31E2D");

            entity.ToTable("coaAccount");

            entity.HasIndex(e => e.AccountCode, "UQ__coaAccou__38D0C56A23417B59").IsUnique();

            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.AccountCode)
                .IsRequired()
                .HasMaxLength(10);
            entity.Property(e => e.AccountDesc)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.ParentAccountId).HasColumnName("ParentAccountID");

            entity.HasOne(d => d.ParentAccount).WithMany(p => p.InverseParentAccount)
                .HasForeignKey(d => d.ParentAccountId)
                .HasConstraintName("FK__coaAccoun__Paren__11007AA7");
        });

        modelBuilder.Entity<CoaAccountBelow100>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__coaAccou__3214EC273726EEE6");

            entity.ToTable("coaAccountBelow100");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Word)
                .IsRequired()
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CoaAccountBelow20>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__coaAccou__3214EC2733565E02");

            entity.ToTable("coaAccountBelow20");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Word)
                .IsRequired()
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CoaAccountFiscalYear>(entity =>
        {
            entity.HasKey(e => e.FiscalYearId).HasName("PK__coaAccou__A4E4808F0777DBC4");

            entity.ToTable("coaAccountFiscalYear");

            entity.HasIndex(e => e.FiscalYear, "UQ__coaAccou__359C71901B6CA0E2").IsUnique();

            entity.HasIndex(e => e.StartDate, "UQ__coaAccou__4E19FCF6BB53B06B").IsUnique();

            entity.HasIndex(e => e.EndDate, "UQ__coaAccou__5A26560E166D0499").IsUnique();

            entity.Property(e => e.FiscalYearId).HasColumnName("FiscalYearID");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(80);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Remarks).HasMaxLength(350);
            entity.Property(e => e.UpdatedBy).HasMaxLength(80);
            entity.Property(e => e.YearCode)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.YearName)
                .IsRequired()
                .HasMaxLength(120);
        });

        modelBuilder.Entity<CoaAccountJournal>(entity =>
        {
            entity.HasKey(e => e.JournalId).HasName("PK__coaAccou__2501038634D17A38");

            entity.ToTable("coaAccountJournal");

            entity.HasIndex(e => e.JournalCode, "UQ__coaAccou__9C16714285E9FE70").IsUnique();

            entity.Property(e => e.JournalId).HasColumnName("JournalID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreditAccountFk).HasColumnName("CreditAccount_FK");
            entity.Property(e => e.DebitAccountFk).HasColumnName("DebitAccount_FK");
            entity.Property(e => e.JournalCode)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.JournalDesc)
                .IsRequired()
                .HasMaxLength(250);

            entity.HasOne(d => d.CreditAccountFkNavigation).WithMany(p => p.CoaAccountJournalCreditAccountFkNavigations)
                .HasForeignKey(d => d.CreditAccountFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__coaAccoun__Credi__316D4A39");

            entity.HasOne(d => d.DebitAccountFkNavigation).WithMany(p => p.CoaAccountJournalDebitAccountFkNavigations)
                .HasForeignKey(d => d.DebitAccountFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__coaAccoun__Debit__32616E72");
        });

        modelBuilder.Entity<CoaAccountJournalEntry>(entity =>
        {
            entity.HasKey(e => e.EntryId).HasName("PK__coaAccou__F57BD2D74F3382A1");

            entity.ToTable("coaAccountJournalEntry");

            entity.Property(e => e.EntryId).HasColumnName("EntryID");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(80);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.EntryDesc)
                .IsRequired()
                .HasMaxLength(120);
            entity.Property(e => e.EntryState).HasMaxLength(60);
            entity.Property(e => e.FiscalPeriodFk).HasColumnName("FiscalPeriod_FK");
            entity.Property(e => e.JournalFk).HasColumnName("Journal_FK");
            entity.Property(e => e.RefNo).HasMaxLength(30);
            entity.Property(e => e.UpdatedBy).HasMaxLength(80);

            entity.HasOne(d => d.FiscalPeriodFkNavigation).WithMany(p => p.CoaAccountJournalEntries)
                .HasForeignKey(d => d.FiscalPeriodFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__coaAccoun__Fisca__1E5B411C");

            entity.HasOne(d => d.JournalFkNavigation).WithMany(p => p.CoaAccountJournalEntries)
                .HasForeignKey(d => d.JournalFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__coaAccoun__Journ__53041385");
        });

        modelBuilder.Entity<CoaAccountJournalEntryItem>(entity =>
        {
            entity.HasKey(e => e.EntryItemId).HasName("PK__coaAccou__3CC6E2C56522C3C0");

            entity.ToTable("coaAccountJournalEntryItem");

            entity.Property(e => e.EntryItemId).HasColumnName("EntryItemID");
            entity.Property(e => e.AccountFk).HasColumnName("Account_FK");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(80);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.EntryFk).HasColumnName("Entry_FK");
            entity.Property(e => e.EntryItemReconcileFk).HasColumnName("EntryItemReconcile_FK");
            entity.Property(e => e.ItemDesc)
                .IsRequired()
                .HasMaxLength(120);
            entity.Property(e => e.ItemRefNo).HasMaxLength(60);
            entity.Property(e => e.JournalFk).HasColumnName("Journal_FK");
            entity.Property(e => e.UpdatedBy).HasMaxLength(80);

            entity.HasOne(d => d.AccountFkNavigation).WithMany(p => p.CoaAccountJournalEntryItems)
                .HasForeignKey(d => d.AccountFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__coaAccoun__Accou__67FF306B");

            entity.HasOne(d => d.EntryFkNavigation).WithMany(p => p.CoaAccountJournalEntryItems)
                .HasForeignKey(d => d.EntryFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__coaAccoun__Entry__69E778DD");

            entity.HasOne(d => d.EntryItemReconcileFkNavigation).WithMany(p => p.CoaAccountJournalEntryItems)
                .HasForeignKey(d => d.EntryItemReconcileFk)
                .HasConstraintName("FK__coaAccoun__Entry__6ADB9D16");

            entity.HasOne(d => d.JournalFkNavigation).WithMany(p => p.CoaAccountJournalEntryItems)
                .HasForeignKey(d => d.JournalFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__coaAccoun__Journ__68F354A4");
        });

        modelBuilder.Entity<CoaAccountJournalEntryItemReconcile>(entity =>
        {
            entity.HasKey(e => e.EntryItemReconcileId).HasName("PK__coaAccou__BEDFFD145F69EA6A");

            entity.ToTable("coaAccountJournalEntryItemReconcile");

            entity.Property(e => e.EntryItemReconcileId).HasColumnName("EntryItemReconcileID");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(80);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.EntryType)
                .IsRequired()
                .HasMaxLength(80);
            entity.Property(e => e.RefName)
                .IsRequired()
                .HasMaxLength(80);
            entity.Property(e => e.UpdatedBy).HasMaxLength(80);
        });

        modelBuilder.Entity<CoaAccountPeriod>(entity =>
        {
            entity.HasKey(e => e.FiscalPeriodId).HasName("PK__coaAccou__9E68FFCB07C1312F");

            entity.ToTable("coaAccountPeriod");

            entity.Property(e => e.FiscalPeriodId).HasColumnName("FiscalPeriodID");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(80);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FiscalYearFk).HasColumnName("FiscalYear_FK");
            entity.Property(e => e.PeriodCode).HasMaxLength(20);
            entity.Property(e => e.PeriodName)
                .IsRequired()
                .HasMaxLength(120);
            entity.Property(e => e.Remarks).HasMaxLength(350);
            entity.Property(e => e.UpdatedBy).HasMaxLength(80);

            entity.HasOne(d => d.FiscalYearFkNavigation).WithMany(p => p.CoaAccountPeriods)
                .HasForeignKey(d => d.FiscalYearFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__coaAccoun__Fisca__0F18FD8C");
        });

        modelBuilder.Entity<CoaAsset>(entity =>
        {
            entity.HasKey(e => e.AssetId).HasName("PK__coaAsset__4349237204CB51C1");

            entity.ToTable("coaAsset");

            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AccountFk).HasColumnName("Account_FK");
            entity.Property(e => e.AssetDesc).HasMaxLength(120);
            entity.Property(e => e.AssetRefNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(80);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Remarks)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(80);

            entity.HasOne(d => d.AccountFkNavigation).WithMany(p => p.CoaAssets)
                .HasForeignKey(d => d.AccountFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__coaAsset__Accoun__2D9CB955");
        });

        modelBuilder.Entity<CoaExpenditure>(entity =>
        {
            entity.HasKey(e => e.ExpenditureId).HasName("PK__coaExpen__5C07CE9DBD834994");

            entity.ToTable("coaExpenditure");

            entity.Property(e => e.ExpenditureId).HasColumnName("ExpenditureID");
            entity.Property(e => e.AccountFk).HasColumnName("Account_FK");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(80);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ExpDesc).HasMaxLength(120);
            entity.Property(e => e.ExpRefNo).HasMaxLength(50);
            entity.Property(e => e.Remarks)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(80);

            entity.HasOne(d => d.AccountFkNavigation).WithMany(p => p.CoaExpenditures)
                .HasForeignKey(d => d.AccountFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__coaExpend__Accou__2CA8951C");
        });

        modelBuilder.Entity<CoaLiability>(entity =>
        {
            entity.HasKey(e => e.LiabilityId).HasName("PK__coaLiabi__A84A133232FFC57C");

            entity.ToTable("coaLiability");

            entity.Property(e => e.LiabilityId).HasColumnName("LiabilityID");
            entity.Property(e => e.AccountFk).HasColumnName("Account_FK");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(80);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RefDesc).HasMaxLength(120);
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.Remarks)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(80);

            entity.HasOne(d => d.AccountFkNavigation).WithMany(p => p.CoaLiabilities)
                .HasForeignKey(d => d.AccountFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__coaLiabil__Accou__2BB470E3");
        });

        modelBuilder.Entity<CoaRevenue>(entity =>
        {
            entity.HasKey(e => e.RevenueId).HasName("PK__coaReven__275F173D0E8576CD");

            entity.ToTable("coaRevenue");

            entity.Property(e => e.RevenueId).HasColumnName("RevenueID");
            entity.Property(e => e.AccountFk).HasColumnName("Account_FK");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(80);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Remarks)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.RevDesc).HasMaxLength(120);
            entity.Property(e => e.RevRefNo).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(80);

            entity.HasOne(d => d.AccountFkNavigation).WithMany(p => p.CoaRevenues)
                .HasForeignKey(d => d.AccountFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__coaRevenu__Accou__2AC04CAA");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.ToTable("Contract");

            entity.HasIndex(e => new { e.ContractCode, e.ContractTitle }, "IXContract");

            entity.HasIndex(e => e.ContractCode, "UQ_Contract").IsUnique();

            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.AdjAmount).HasComment("");
            entity.Property(e => e.Approved).HasColumnName("approved");
            entity.Property(e => e.ApprovedAt)
                .HasColumnType("datetime")
                .HasColumnName("approved_at");
            entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");
            entity.Property(e => e.Archived).HasColumnName("archived");
            entity.Property(e => e.BidId).HasColumnName("BidID");
            entity.Property(e => e.ContractCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ContractDesc).HasMaxLength(350);
            entity.Property(e => e.ContractStatusId)
                .HasDefaultValue(1)
                .HasColumnName("ContractStatusID");
            entity.Property(e => e.ContractTitle)
                .IsRequired()
                .HasMaxLength(350);
            entity.Property(e => e.ContractTypeFk).HasColumnName("ContractType_FK");
            entity.Property(e => e.ContractorId).HasColumnName("ContractorID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Currency)
                .HasMaxLength(15)
                .HasDefaultValue("GHS");
            entity.Property(e => e.DeptId)
                .HasDefaultValue(5)
                .HasColumnName("Dept_ID");
            entity.Property(e => e.Fixed).HasColumnName("fixed");
            entity.Property(e => e.ManagerFk).HasColumnName("Manager_FK");
            entity.Property(e => e.NoPafDate).HasColumnName("no_paf_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("User_ID");

            entity.HasOne(d => d.ApprovedByNavigation).WithMany(p => p.ContractApprovedByNavigations)
                .HasForeignKey(d => d.ApprovedBy)
                .HasConstraintName("FK_Contract_approved_by");

            entity.HasOne(d => d.Bid).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.BidId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contract_BidInformation");

            entity.HasOne(d => d.ContractStatus).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.ContractStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contract_ContractStatus");

            entity.HasOne(d => d.ContractTypeFkNavigation).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.ContractTypeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Contract__ContractType");

            entity.HasOne(d => d.Contractor).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.ContractorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contract_Contractor");

            entity.HasOne(d => d.Dept).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.DeptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Contract__Dept");

            entity.HasOne(d => d.ManagerFkNavigation).WithMany(p => p.ContractManagerFkNavigations)
                .HasForeignKey(d => d.ManagerFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Contract__Manager");

            entity.HasOne(d => d.User).WithMany(p => p.ContractUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Contract__CurrUserr");
        });

        modelBuilder.Entity<ContractAct>(entity =>
        {
            entity.HasKey(e => e.ContractActivityId).HasName("PK__Contract__3214EC276442E2C9");

            entity.ToTable("contract_act");

            entity.HasIndex(e => new { e.ContractFk, e.BidBillExFk, e.ActivityFk }, "UQ_ContractActivities").IsUnique();

            entity.Property(e => e.ContractActivityId).HasColumnName("ContractActivityID");
            entity.Property(e => e.ActivityFk).HasColumnName("activity_fk");
            entity.Property(e => e.BidBillExFk).HasColumnName("BidBillEx_FK");
            entity.Property(e => e.BidweitFk).HasColumnName("bidweit_fk");
            entity.Property(e => e.ContractFk).HasColumnName("Contract_FK");
            entity.Property(e => e.ContractProgressFk).HasColumnName("ContractProgress_FK");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Unit)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.Voqtty).HasColumnName("VOQtty");

            entity.HasOne(d => d.ActivityFkNavigation).WithMany(p => p.ContractActs)
                .HasForeignKey(d => d.ActivityFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractActivities_StandardSubActivity");

            entity.HasOne(d => d.BidBillExFkNavigation).WithMany(p => p.ContractActs)
                .HasForeignKey(d => d.BidBillExFk)
                .HasConstraintName("FK__BidBillsEx__ContractActivities");

            entity.HasOne(d => d.BidweitFkNavigation).WithMany(p => p.ContractActs)
                .HasForeignKey(d => d.BidweitFk)
                .HasConstraintName("FK_contractact_standardweit");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.ContractActs)
                .HasForeignKey(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractActivities_Contract");

            entity.HasOne(d => d.ContractProgressFkNavigation).WithMany(p => p.ContractActs)
                .HasForeignKey(d => d.ContractProgressFk)
                .HasConstraintName("FK_ContractActivities_ContractProgress");
        });

        modelBuilder.Entity<ContractAdv>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contract__5E2E5B27665613C4");

            entity.ToTable("contract_adv");

            entity.HasIndex(e => new { e.ContractFk, e.BranchFk }, "UQ_ContractMobilizationAdvance").IsUnique();

            entity.HasIndex(e => new { e.ContractFk, e.IsPlant }, "UQ_contract_adv").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdvAmount).HasColumnName("adv_amount");
            entity.Property(e => e.BoqFk).HasColumnName("boq_fk");
            entity.Property(e => e.BranchFk).HasColumnName("branch_fk");
            entity.Property(e => e.CalcAmount).HasColumnName("calc_amount");
            entity.Property(e => e.ContractFk).HasColumnName("contract_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.ExpiresAt).HasColumnName("expires_at");
            entity.Property(e => e.GuarantedAmount).HasColumnName("guaranted_amount");
            entity.Property(e => e.IsPlant).HasColumnName("is_plant");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.BranchFkNavigation).WithMany(p => p.ContractAdvs)
                .HasForeignKey(d => d.BranchFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractM__Branc__683E5C36");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.ContractAdvs)
                .HasForeignKey(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractMob__Contract");
        });

        modelBuilder.Entity<ContractAdvDoc>(entity =>
        {
            entity.HasKey(e => e.FileId).HasName("PK_ContractMobilizationDoc");

            entity.ToTable("contract_adv_doc");

            entity.HasIndex(e => new { e.ContractFk, e.FlPath }, "UQ_ContractMobilizationDoc").IsUnique();

            entity.Property(e => e.FileId).HasColumnName("fileID");
            entity.Property(e => e.Baked).HasColumnName("baked");
            entity.Property(e => e.Comment)
                .HasMaxLength(500)
                .HasColumnName("comment");
            entity.Property(e => e.ContractFk).HasColumnName("contract_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DocDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("doc_date");
            entity.Property(e => e.FlName)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("fl_name");
            entity.Property(e => e.FlPath)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("fl_path");
            entity.Property(e => e.IsPlant).HasColumnName("is_plant");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.ContractAdvDocs)
                .HasForeignKey(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractMobilizationDoc_Contract");
        });

        modelBuilder.Entity<ContractAdvPmt>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Contract__3F4440184C813328");

            entity.ToTable("contract_adv_pmt");

            entity.HasIndex(e => new { e.ContractAdvFk, e.BoqFk }, "UQ_contract_adv_pmt").IsUnique();

            entity.Property(e => e.PaymentId).HasColumnName("paymentID");
            entity.Property(e => e.BoqFk).HasColumnName("boq_fk");
            entity.Property(e => e.CertAmount).HasColumnName("cert_amount");
            entity.Property(e => e.ContractAdvFk).HasColumnName("contract_adv_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CurrentAmount).HasColumnName("current_amount");
            entity.Property(e => e.PrevAmount).HasColumnName("prev_amount");

            entity.HasOne(d => d.BoqFkNavigation).WithMany(p => p.ContractAdvPmts)
                .HasForeignKey(d => d.BoqFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractM__BOQ_F__5051C40C");

            entity.HasOne(d => d.ContractAdvFkNavigation).WithMany(p => p.ContractAdvPmts)
                .HasForeignKey(d => d.ContractAdvFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractM__Advan__4F5D9FD3");
        });

        modelBuilder.Entity<ContractCost>(entity =>
        {
            entity.HasKey(e => e.ContractCostId).HasName("PK__Contract__F636281645BE5BA9");

            entity.ToTable("contract_cost");

            entity.HasIndex(e => new { e.ContractId, e.Currency }, "UQ__Contract__83F17A20489AC854").IsUnique();

            entity.Property(e => e.ContractCostId).HasColumnName("ContractCostID");
            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.Contract).WithMany(p => p.ContractCosts)
                .HasForeignKey(d => d.ContractId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractCost__Contract");
        });

        modelBuilder.Entity<ContractDaywork>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contract__6288BBA87CCE7641");

            entity.ToTable("contract_daywork");

            entity.HasIndex(e => new { e.ContractFk, e.BidbaseFk, e.DayworkFk }, "UQ__Contract__39E83CFBF7E10718").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.BidbaseFk).HasColumnName("bidbase_fk");
            entity.Property(e => e.ContractFk).HasColumnName("contract_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DayworkFk).HasColumnName("daywork_fk");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.Unit)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("unit");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.Voqtty).HasColumnName("voqtty");

            entity.HasOne(d => d.BidbaseFkNavigation).WithMany(p => p.ContractDayworks)
                .HasForeignKey(d => d.BidbaseFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractDayWorks_BidBase");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.ContractDayworks)
                .HasForeignKey(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractDayWorks__Contract");

            entity.HasOne(d => d.DayworkFkNavigation).WithMany(p => p.ContractDayworks)
                .HasForeignKey(d => d.DayworkFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractDayWorks__DayWorks");
        });

        modelBuilder.Entity<ContractDoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contract__6F0F989F6BAD8EC1");

            entity.ToTable("contract_doc");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CatFk).HasColumnName("cat_fk");
            entity.Property(e => e.ContractFk).HasColumnName("contract_FK");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.FlPath)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("fl_path");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .HasColumnName("remarks");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.CatFkNavigation).WithMany(p => p.ContractDocs)
                .HasForeignKey(d => d.CatFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractD__DocCa__12E8C319");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.ContractDocs)
                .HasForeignKey(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractDoc__Contract");
        });

        modelBuilder.Entity<ContractDocCat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contract__C3125C6D5B9AFC68");

            entity.ToTable("contract_doc_cat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.Compulsory)
                .HasDefaultValue(true)
                .HasColumnName("compulsory");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("name");
        });

        modelBuilder.Entity<ContractInt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contract__E52FB1AB382F5661");

            entity.ToTable("contract_int");

            entity.HasIndex(e => e.BidFk, "UQ__Contract__5E2E5B263B0BC30C").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BidFk).HasColumnName("bid_fk");
            entity.Property(e => e.ContractFk).HasColumnName("contract_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DelayIn)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("delay_in");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.IntType)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("int_type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.BidFkNavigation).WithOne(p => p.ContractInt)
                .HasForeignKey<ContractInt>(d => d.BidFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BidInfo__ContractInterest");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.ContractInts)
                .HasForeignKey(d => d.ContractFk)
                .HasConstraintName("FK__ContractInterest__Contract");
        });

        modelBuilder.Entity<ContractPlant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contract__5E2E5B276C0EED1A");

            entity.ToTable("contract_plant");

            entity.HasIndex(e => new { e.ContractFk, e.BranchFk }, "UQ_ContractMobilizationPlant").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdvAmount).HasColumnName("adv_amount");
            entity.Property(e => e.BoqFk).HasColumnName("boq_fk");
            entity.Property(e => e.BranchFk).HasColumnName("branch_fk");
            entity.Property(e => e.ContractFk).HasColumnName("contract_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.ExpiresAt).HasColumnName("expires_at");
            entity.Property(e => e.GuarantedAmount).HasColumnName("guaranted_amount");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.BranchFkNavigation).WithMany(p => p.ContractPlants)
                .HasForeignKey(d => d.BranchFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractM__Branc__6DF7358C");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.ContractPlants)
                .HasForeignKey(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractPlant__Contract");
        });

        modelBuilder.Entity<ContractPlantPmt>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Contract__1F208DB5532E30B7");

            entity.ToTable("contract_plant_pmt");

            entity.Property(e => e.PaymentId).HasColumnName("paymentID");
            entity.Property(e => e.BoqFk).HasColumnName("boq_fk");
            entity.Property(e => e.CertAmount).HasColumnName("cert_amount");
            entity.Property(e => e.ContractPlantFk).HasColumnName("contract_plant_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CurrentAmount).HasColumnName("current_amount");
            entity.Property(e => e.PrevAmount).HasColumnName("prev_amount");

            entity.HasOne(d => d.BoqFkNavigation).WithMany(p => p.ContractPlantPmts)
                .HasForeignKey(d => d.BoqFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractM__BOQ_F__56FEC19B");

            entity.HasOne(d => d.ContractPlantFkNavigation).WithMany(p => p.ContractPlantPmts)
                .HasForeignKey(d => d.ContractPlantFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractM__Plant__560A9D62");
        });

        modelBuilder.Entity<ContractProgress>(entity =>
        {
            entity.HasKey(e => e.ContractProgressId).HasName("PK__Contract__5D9036C21C680BB2");

            entity.ToTable("contract_progress");

            entity.Property(e => e.ContractProgressId).HasColumnName("ContractProgressID");
            entity.Property(e => e.BidBaseFk).HasColumnName("BidBase_FK");
            entity.Property(e => e.ContractFk).HasColumnName("Contract_FK");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.PlannedSchedule).HasDefaultValue(1.0);
            entity.Property(e => e.StandardProgressFk).HasColumnName("StandardProgress_FK");
            entity.Property(e => e.Unit).HasMaxLength(20);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.VoSchedule).HasColumnName("voSchedule");

            entity.HasOne(d => d.BidBaseFkNavigation).WithMany(p => p.ContractProgresses)
                .HasForeignKey(d => d.BidBaseFk)
                .HasConstraintName("FK__ContractProgress__BidBase");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.ContractProgresses)
                .HasForeignKey(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractProgress__Contract");

            entity.HasOne(d => d.StandardProgressFkNavigation).WithMany(p => p.ContractProgresses)
                .HasForeignKey(d => d.StandardProgressFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractProgress__StandardProgress");
        });

        modelBuilder.Entity<ContractStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ContractStatus");

            entity.ToTable("contract_status");

            entity.HasIndex(e => e.Name, "UK_ContractStatus").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<ContractSublet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contract__D2AC5AB6840634C8");

            entity.ToTable("contract_sublet");

            entity.HasIndex(e => new { e.ContractFk, e.ContractorFk }, "UQ__Contract__48321024C4FDBA3A").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContractFk).HasColumnName("contract_fk");
            entity.Property(e => e.ContractorFk).HasColumnName("contractor_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.GrossAmount).HasColumnName("gross_amount");
            entity.Property(e => e.GrossRet).HasColumnName("gross_ret");
            entity.Property(e => e.NetAmount).HasColumnName("net_amount");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.ContractSublets)
                .HasForeignKey(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractSub__Contract");

            entity.HasOne(d => d.ContractorFkNavigation).WithMany(p => p.ContractSublets)
                .HasForeignKey(d => d.ContractorFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractS__Contr__1A0AC1F4");
        });

        modelBuilder.Entity<ContractType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contract__68A61545EED67347");

            entity.ToTable("contract_type");

            entity.HasIndex(e => e.Name, "UQ__Contract__6E0AC57C5F883435").IsUnique();

            entity.HasIndex(e => e.Code, "UQ__Contract__C17C05278DAC1292").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Contractor>(entity =>
        {
            entity.ToTable("Contractor");

            entity.HasIndex(e => e.TinNo, "UQ_Contractor").IsUnique();

            entity.Property(e => e.ContractorId).HasColumnName("ContractorID");
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.Classification).HasMaxLength(10);
            entity.Property(e => e.ContactPerson).HasMaxLength(50);
            entity.Property(e => e.ContractorName).HasMaxLength(120);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.TinNo)
                .HasMaxLength(50)
                .HasColumnName("TIN_No");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<ContractorAssoc>(entity =>
        {
            entity.HasKey(e => e.AssociationId).HasName("PK__Contract__B51A19CD751B7A8C");

            entity.ToTable("ContractorAssoc");

            entity.HasIndex(e => e.AssocCode, "UQ__Contract__E8A24A0CD59C92AA").IsUnique();

            entity.Property(e => e.AssociationId).HasColumnName("AssociationID");
            entity.Property(e => e.AssocCode)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.AssocDesc)
                .IsRequired()
                .HasMaxLength(20);
        });

        modelBuilder.Entity<ContractorBank>(entity =>
        {
            entity.HasKey(e => e.ContractorBankId).HasName("PK__Contract__FE61C99B1F054C92");

            entity.ToTable("ContractorBank");

            entity.HasIndex(e => new { e.ContractorFk, e.BranchFk }, "UQ__Contract__B0E858A821E1B93D").IsUnique();

            entity.Property(e => e.ContractorBankId).HasColumnName("ContractorBankID");
            entity.Property(e => e.AccountCurrency)
                .IsRequired()
                .HasMaxLength(5);
            entity.Property(e => e.AccountEditable).HasDefaultValue(true);
            entity.Property(e => e.AccountName)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.AccountNumber)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.BranchFk).HasColumnName("Branch_FK");
            entity.Property(e => e.ContractorFk).HasColumnName("Contractor_FK");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.BranchFkNavigation).WithMany(p => p.ContractorBanks)
                .HasForeignKey(d => d.BranchFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Contracto__Branc__25B24A21");

            entity.HasOne(d => d.ContractorFkNavigation).WithMany(p => p.ContractorBanks)
                .HasForeignKey(d => d.ContractorFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Contracto__Contr__26A66E5A");
        });

        modelBuilder.Entity<Coverage>(entity =>
        {
            entity.HasKey(e => e.CoverageId).HasName("PK_tblCoverage");

            entity.ToTable("Coverage");

            entity.Property(e => e.CoverageId).HasColumnName("CoverageID");
            entity.Property(e => e.Coverage1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Coverage");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Currency");

            entity.Property(e => e.Code).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<DocMove>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DocStatu__1C7E87B4B9DB75AA");

            entity.ToTable("doc_move");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cat)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("cat");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DocId).HasColumnName("doc_id");
            entity.Property(e => e.Remarks)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("remarks");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.DocMoves)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_doc_move_portal_user");
        });

        modelBuilder.Entity<DocPoss>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__doc_poss__3213E83F59904680");

            entity.ToTable("doc_poss");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cat)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cat");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DestId).HasColumnName("dest_id");
            entity.Property(e => e.DocId).HasColumnName("doc_id");
            entity.Property(e => e.InitId).HasColumnName("init_id");
            entity.Property(e => e.Remarks)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("remarks");

            entity.HasOne(d => d.Dest).WithMany(p => p.DocPossDests)
                .HasForeignKey(d => d.DestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_doc_poss_created_by_portal_user");

            entity.HasOne(d => d.Init).WithMany(p => p.DocPossInits)
                .HasForeignKey(d => d.InitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_doc_poss_init_portal_user");
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.ToTable("document");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Brief)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("brief");
            entity.Property(e => e.CheckedOut).HasColumnName("checked_out");
            entity.Property(e => e.CheckedOutBy).HasColumnName("checked_out_by");
            entity.Property(e => e.CheckedOutDate)
                .HasColumnType("datetime")
                .HasColumnName("checked_out_date");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.FolderId).HasColumnName("folder_id");
            entity.Property(e => e.LastAccessedAt)
                .HasColumnType("datetime")
                .HasColumnName("last_accessed_at");
            entity.Property(e => e.LastAccessedBy).HasColumnName("last_accessed_by");
            entity.Property(e => e.LastUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("last_updated_at");
            entity.Property(e => e.LastUpdatedBy).HasColumnName("last_updated_by");
            entity.Property(e => e.Ref)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(lower(newid()))")
                .HasColumnName("ref");
            entity.Property(e => e.StatusId)
                .HasDefaultValue(1)
                .HasColumnName("status_id");
            entity.Property(e => e.Subj)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("subj");
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.VersionId).HasColumnName("version_id");

            entity.HasOne(d => d.Folder).WithMany(p => p.Documents)
                .HasForeignKey(d => d.FolderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_document_document_folder");

            entity.HasOne(d => d.Status).WithMany(p => p.Documents)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_document_document_status");

            entity.HasOne(d => d.Version).WithMany(p => p.Documents)
                .HasForeignKey(d => d.VersionId)
                .HasConstraintName("FK_document_document_version");
        });

        modelBuilder.Entity<DocumentFolder>(entity =>
        {
            entity.ToTable("document_folder");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Desc)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("desc");
            entity.Property(e => e.FlPath)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("fl_path");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Owna).HasColumnName("owna");
            entity.Property(e => e.ParentId)
                .HasDefaultValue(1)
                .HasColumnName("parent_id");
            entity.Property(e => e.StatusId)
                .HasDefaultValue(1)
                .HasColumnName("status_id");

            entity.HasOne(d => d.Status).WithMany(p => p.DocumentFolders)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_document_folder_document_status");
        });

        modelBuilder.Entity<DocumentFolderRole>(entity =>
        {
            entity.ToTable("document_folder_role");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dilete).HasColumnName("dilete");
            entity.Property(e => e.FolderId).HasColumnName("folder_id");
            entity.Property(e => e.Modify).HasColumnName("modify");
            entity.Property(e => e.RoleId).HasColumnName("role_id");

            entity.HasOne(d => d.Folder).WithMany(p => p.DocumentFolderRoles)
                .HasForeignKey(d => d.FolderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_document_folder_document_folder_role");

            entity.HasOne(d => d.Role).WithMany(p => p.DocumentFolderRoles)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_document_folder_role_portal_role");
        });

        modelBuilder.Entity<DocumentFolderUser>(entity =>
        {
            entity.ToTable("document_folder_user");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dilete).HasColumnName("dilete");
            entity.Property(e => e.FolderId).HasColumnName("folder_id");
            entity.Property(e => e.Modify).HasColumnName("modify");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Folder).WithMany(p => p.DocumentFolderUsers)
                .HasForeignKey(d => d.FolderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_document_folder_user_document_folder");

            entity.HasOne(d => d.User).WithMany(p => p.DocumentFolderUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_document_folder_user_portal_user");
        });

        modelBuilder.Entity<DocumentRole>(entity =>
        {
            entity.ToTable("document_role");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dilete).HasColumnName("dilete");
            entity.Property(e => e.DocumentId).HasColumnName("document_id");
            entity.Property(e => e.Modify).HasColumnName("modify");
            entity.Property(e => e.RoleId).HasColumnName("role_id");

            entity.HasOne(d => d.Document).WithMany(p => p.DocumentRoles)
                .HasForeignKey(d => d.DocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_document_document_role");
        });

        modelBuilder.Entity<DocumentStatus>(entity =>
        {
            entity.ToTable("document_status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DocumentUser>(entity =>
        {
            entity.ToTable("document_user");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dilete).HasColumnName("dilete");
            entity.Property(e => e.DocumentId).HasColumnName("document_id");
            entity.Property(e => e.Modify).HasColumnName("modify");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Document).WithMany(p => p.DocumentUsers)
                .HasForeignKey(d => d.DocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_document_document_user");

            entity.HasOne(d => d.User).WithMany(p => p.DocumentUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_document_user_portal_user");
        });

        modelBuilder.Entity<DocumentVersion>(entity =>
        {
            entity.ToTable("document_version");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Comments)
                .IsRequired()
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comments");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasDefaultValue(1)
                .HasColumnName("created_by");
            entity.Property(e => e.DocumentId).HasColumnName("document_id");
            entity.Property(e => e.Size).HasColumnName("size");
            entity.Property(e => e.Vs).HasColumnName("vs");
            entity.Property(e => e.VsPath)
                .IsRequired()
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vs_path");
            entity.Property(e => e.VsSourceData)
                .HasColumnType("image")
                .HasColumnName("vs_source_data");

            entity.HasOne(d => d.Document).WithMany(p => p.DocumentVersions)
                .HasForeignKey(d => d.DocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_document_version_document");
        });

        modelBuilder.Entity<FundCategory>(entity =>
        {
            entity.HasKey(e => e.FundCategoryId).HasName("PK__FundCate__6568EB890CE36B0D");

            entity.ToTable("FundCategory");

            entity.HasIndex(e => e.FundCategoryType, "UQ__FundCate__1D1F5963C2D8DDAC").IsUnique();

            entity.Property(e => e.FundCategoryId).HasColumnName("FundCategoryID");
            entity.Property(e => e.FundCategoryType)
                .HasMaxLength(100)
                .HasColumnName("Fund_Category_Type");
            entity.Property(e => e.FundTypeShort).HasMaxLength(50);
        });

        modelBuilder.Entity<FundSource>(entity =>
        {
            entity.ToTable("FundSource");

            entity.HasIndex(e => e.FundSourceCode, "UK_FundSourceCode").IsUnique();

            entity.Property(e => e.FundSourceId).HasColumnName("FundSourceID");
            entity.Property(e => e.FundSourceCode)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("Fund_Source_Code");
            entity.Property(e => e.FundSourceDesc)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Fund_Source_Desc");
            entity.Property(e => e.FundSourceShort)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FundSubSource>(entity =>
        {
            entity.HasKey(e => e.SubSourceId).HasName("PK__FundSubS__6A0A55526AA692EC");

            entity.ToTable("FundSubSource");

            entity.Property(e => e.SubSourceId).HasColumnName("SubSourceID");
            entity.Property(e => e.FundSourceFk).HasColumnName("FundSource_FK");
            entity.Property(e => e.SubSourceCode)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.SubSourceDesc)
                .IsRequired()
                .HasMaxLength(150);

            entity.HasOne(d => d.FundSourceFkNavigation).WithMany(p => p.FundSubSources)
                .HasForeignKey(d => d.FundSourceFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FundSubSo__FundS__6C8EDB5E");
        });

        modelBuilder.Entity<FundingBudget>(entity =>
        {
            entity.HasKey(e => e.FundingBudgetId).HasName("PK__FundingB__C3F2E1174D60DCC4");

            entity.ToTable("FundingBudget");

            entity.HasIndex(e => new { e.FiscalYearFk, e.SubSourceFk }, "UQ__FundingB__F1D8F5C1B08EB540").IsUnique();

            entity.Property(e => e.FundingBudgetId).HasColumnName("FundingBudgetID");
            entity.Property(e => e.BudgetRemarks).HasMaxLength(350);
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(80);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FiscalYearFk).HasColumnName("FiscalYear_FK");
            entity.Property(e => e.SubSourceFk).HasColumnName("SubSource_FK");
            entity.Property(e => e.UpdatedBy).HasMaxLength(80);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.FiscalYearFkNavigation).WithMany(p => p.FundingBudgets)
                .HasForeignKey(d => d.FiscalYearFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FundingBu__Fisca__390E6C01");

            entity.HasOne(d => d.SubSourceFkNavigation).WithMany(p => p.FundingBudgets)
                .HasForeignKey(d => d.SubSourceFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FundingBu__SubSo__3A02903A");
        });

        modelBuilder.Entity<FundingExpenditure>(entity =>
        {
            entity.HasKey(e => e.FundingExpendId).HasName("PK__FundingE__7D8B46F71B246322");

            entity.ToTable("FundingExpenditure");

            entity.Property(e => e.FundingExpendId).HasColumnName("FundingExpendID");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(80);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExpendRemarks).HasMaxLength(350);
            entity.Property(e => e.FiscalPeriodFk).HasColumnName("FiscalPeriod_FK");
            entity.Property(e => e.FundingBudgetFk).HasColumnName("FundingBudget_FK");
            entity.Property(e => e.UpdatedBy).HasMaxLength(80);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.FiscalPeriodFkNavigation).WithMany(p => p.FundingExpenditures)
                .HasForeignKey(d => d.FiscalPeriodFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FundingEx__Fisca__3EC74557");

            entity.HasOne(d => d.FundingBudgetFkNavigation).WithMany(p => p.FundingExpenditures)
                .HasForeignKey(d => d.FundingBudgetFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FundingEx__Fundi__3FBB6990");
        });

        modelBuilder.Entity<HcmEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Employee");

            entity.ToTable("hcmEmployee");

            entity.HasIndex(e => e.Number, "UQ_Employee").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DeptFk).HasColumnName("Dept_FK");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Home).HasMaxLength(15);
            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.MaritalStatus).HasMaxLength(10);
            entity.Property(e => e.Mobile).HasMaxLength(15);
            entity.Property(e => e.Nationality).HasMaxLength(100);
            entity.Property(e => e.Number)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.Office).HasMaxLength(15);
            entity.Property(e => e.OtherNames).HasMaxLength(50);
            entity.Property(e => e.Sex)
                .IsRequired()
                .HasMaxLength(6);
            entity.Property(e => e.Title).HasMaxLength(20);

            entity.HasOne(d => d.DeptFkNavigation).WithMany(p => p.HcmEmployees)
                .HasForeignKey(d => d.DeptFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__hcmEmployee__Dept");
        });

        modelBuilder.Entity<Idp>(entity =>
        {
            entity.ToTable("idp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approved).HasColumnName("approved");
            entity.Property(e => e.ApprovedAt).HasColumnName("approved_at");
            entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");
            entity.Property(e => e.Archived).HasColumnName("archived");
            entity.Property(e => e.ContractFk).HasColumnName("contract_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CurrentBoqFk).HasColumnName("current_boq_fk");
            entity.Property(e => e.DeptId).HasColumnName("Dept_ID");
            entity.Property(e => e.IdpDesc)
                .HasMaxLength(250)
                .HasColumnName("idp_desc");
            entity.Property(e => e.IdpNamb).HasColumnName("idp_namb");
            entity.Property(e => e.Remarks)
                .HasMaxLength(450)
                .HasColumnName("remarks");
            entity.Property(e => e.RequestedAt).HasColumnName("requested_at");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("User_ID");

            entity.HasOne(d => d.ApprovedByNavigation).WithMany(p => p.IdpApprovedByNavigations)
                .HasForeignKey(d => d.ApprovedBy)
                .HasConstraintName("FK_idp_approved_by_portal_user");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.Idps)
                .HasForeignKey(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_idp_contract_fk_contract");

            entity.HasOne(d => d.CurrentBoqFkNavigation).WithMany(p => p.Idps)
                .HasForeignKey(d => d.CurrentBoqFk)
                .HasConstraintName("FK_idp_current_boq_fk_Boq");

            entity.HasOne(d => d.User).WithMany(p => p.IdpUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_idp_user_id_portal_user");
        });

        modelBuilder.Entity<IdpDoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pv_payment_doc");

            entity.ToTable("idp_doc");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Baked).HasColumnName("baked");
            entity.Property(e => e.CatFk).HasColumnName("cat_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.FlPath)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("fl_path");
            entity.Property(e => e.IdpFk).HasColumnName("idp_fk");
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Remarks)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.CatFkNavigation).WithMany(p => p.IdpDocs)
                .HasForeignKey(d => d.CatFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_idp_doc_cat");

            entity.HasOne(d => d.IdpFkNavigation).WithMany(p => p.IdpDocs)
                .HasForeignKey(d => d.IdpFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_idp_doc_idp");
        });

        modelBuilder.Entity<IdpDocCat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pv_payment_doc_cat");

            entity.ToTable("idp_doc_cat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Rex)
                .HasDefaultValue(true)
                .HasColumnName("rex");
        });

        modelBuilder.Entity<IdpInt>(entity =>
        {
            entity.HasKey(e => e.InterestId);

            entity.ToTable("idp_int");

            entity.HasIndex(e => e.PaymentFk, "UQ_idp_int").IsUnique();

            entity.Property(e => e.InterestId).HasColumnName("interestID");
            entity.Property(e => e.BoqFk).HasColumnName("boq_fk");
            entity.Property(e => e.ContractFk).HasColumnName("contract_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CumInt).HasColumnName("cum_int");
            entity.Property(e => e.IdpFk).HasColumnName("idp_fk");
            entity.Property(e => e.IntOnly).HasColumnName("int_only");
            entity.Property(e => e.PaymentFk).HasColumnName("payment_fk");
            entity.Property(e => e.PvFk).HasColumnName("pv_fk");
            entity.Property(e => e.Remarks)
                .HasMaxLength(250)
                .HasColumnName("remarks");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.BoqFkNavigation).WithMany(p => p.IdpInts)
                .HasForeignKey(d => d.BoqFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_idp_int_boq_fk_Boq");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.IdpInts)
                .HasForeignKey(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_idp_int_contract_fk_contract");

            entity.HasOne(d => d.IdpFkNavigation).WithMany(p => p.IdpInts)
                .HasForeignKey(d => d.IdpFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_idp_int_idp");

            entity.HasOne(d => d.PaymentFkNavigation).WithOne(p => p.IdpInt)
                .HasForeignKey<IdpInt>(d => d.PaymentFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_idp_int_pv_payment");

            entity.HasOne(d => d.PvFkNavigation).WithMany(p => p.IdpInts)
                .HasForeignKey(d => d.PvFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_idp_int_pv_fk_pv");
        });

        modelBuilder.Entity<IdpIntItem>(entity =>
        {
            entity.ToTable("idp_int_item");

            entity.HasIndex(e => new { e.PaymentFk, e.ApplyMonth }, "UQ_idp_int_item").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InterestFk).HasColumnName("interest_fk");
            entity.Property(e => e.PaymentFk).HasColumnName("payment_fk");

            entity.HasOne(d => d.InterestFkNavigation).WithMany(p => p.IdpIntItems)
                .HasForeignKey(d => d.InterestFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_idp_int_item_idp_int");

            entity.HasOne(d => d.PaymentFkNavigation).WithMany(p => p.IdpIntItems)
                .HasForeignKey(d => d.PaymentFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_idp_int_item_payment");
        });

        modelBuilder.Entity<Web.Models.Index>(entity =>
        {
            entity.HasKey(e => e.Date).HasName("PK__Indices__77387D065575A085");

            entity.Property(e => e.Cbnew).HasColumnName("CBNew");
            entity.Property(e => e.Ce).HasColumnName("CE");
            entity.Property(e => e.Ch).HasColumnName("CH");
            entity.Property(e => e.Co).HasColumnName("CO");
            entity.Property(e => e.Cogoods).HasColumnName("COgoods");
            entity.Property(e => e.Ep).HasColumnName("EP");
            entity.Property(e => e.Epnew).HasColumnName("EPNew");
            entity.Property(e => e.Fe).HasColumnName("FE");
            entity.Property(e => e.IndicesId)
                .ValueGeneratedOnAdd()
                .HasColumnName("IndicesID");
            entity.Property(e => e.Ll).HasColumnName("LL");
            entity.Property(e => e.Pc).HasColumnName("PC");
            entity.Property(e => e.Pgnew).HasColumnName("PGNew");
            entity.Property(e => e.Re).HasColumnName("RE");
            entity.Property(e => e.Rlnew).HasColumnName("RLNew");
            entity.Property(e => e.Ronew).HasColumnName("RONew");
            entity.Property(e => e.Tinew).HasColumnName("TINew");
        });

        modelBuilder.Entity<IndicesNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IndicesNew");

            entity.Property(e => e.Cbnew).HasColumnName("CBNew");
            entity.Property(e => e.Ce).HasColumnName("CE");
            entity.Property(e => e.Ch).HasColumnName("CH");
            entity.Property(e => e.Co).HasColumnName("CO");
            entity.Property(e => e.Cogoods).HasColumnName("COgoods");
            entity.Property(e => e.Ep).HasColumnName("EP");
            entity.Property(e => e.Epnew).HasColumnName("EPNew");
            entity.Property(e => e.Fe).HasColumnName("FE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ll).HasColumnName("LL");
            entity.Property(e => e.Pc).HasColumnName("PC");
            entity.Property(e => e.Pgnew).HasColumnName("PGNew");
            entity.Property(e => e.Re).HasColumnName("RE");
            entity.Property(e => e.Rlnew).HasColumnName("RLNew");
            entity.Property(e => e.Ronew).HasColumnName("RONew");
            entity.Property(e => e.Tinew).HasColumnName("TINew");
        });

        modelBuilder.Entity<IntRate>(entity =>
        {
            entity.ToTable("int_rate");

            entity.HasIndex(e => e.Daet, "UQ_int_rate").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approved).HasColumnName("approved");
            entity.Property(e => e.ApprovedAt)
                .HasColumnType("datetime")
                .HasColumnName("approved_at");
            entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");
            entity.Property(e => e.Comment)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("comment");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Daet).HasColumnName("daet");
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.Sours)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("sours");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.Used).HasColumnName("used");

            entity.HasOne(d => d.ApprovedByNavigation).WithMany(p => p.IntRateApprovedByNavigations)
                .HasForeignKey(d => d.ApprovedBy)
                .HasConstraintName("FK_int_rate_approved_portal_user");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.IntRateCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_int_rate_created_by_portal_user");
        });

        modelBuilder.Entity<IpcaddOmit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_IPC_AddOmit");

            entity.ToTable("IPCAddOmit");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddAmnt)
                .HasDefaultValueSql("('')")
                .HasColumnName("add_amnt");
            entity.Property(e => e.AddItem)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("add_item");
            entity.Property(e => e.BoqFk).HasColumnName("boq_fk");
            entity.Property(e => e.Cat)
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("cat");
            entity.Property(e => e.CertFk).HasColumnName("cert_fk");
            entity.Property(e => e.ContractFk).HasColumnName("contract_fk");
            entity.Property(e => e.OmiAmnt)
                .HasDefaultValueSql("('')")
                .HasColumnName("omi_amnt");
            entity.Property(e => e.OmiItem)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("omi_item");

            entity.HasOne(d => d.BoqFkNavigation).WithMany(p => p.IpcaddOmits)
                .HasForeignKey(d => d.BoqFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IPC_AddOmit_Boq");

            entity.HasOne(d => d.CertFkNavigation).WithMany(p => p.IpcaddOmits)
                .HasForeignKey(d => d.CertFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IPC_AddOmit_IPCBack");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.IpcaddOmits)
                .HasForeignKey(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IPC_AddOmit_Contract");
        });

        modelBuilder.Entity<Ipcback>(entity =>
        {
            entity.HasKey(e => e.CertificateId).HasName("PK__IPCBack__BBF8A7E15A103870");

            entity.ToTable("IPCBack");

            entity.HasIndex(e => new { e.ContractFk, e.BoqFk }, "UQ_IPCBack").IsUnique();

            entity.Property(e => e.CertificateId).HasColumnName("CertificateID");
            entity.Property(e => e.AnetIncrement).HasColumnName("ANetIncrement");
            entity.Property(e => e.AnetTransfer).HasColumnName("ANetTransfer");
            entity.Property(e => e.AtotalIncrement).HasColumnName("ATotalIncrement");
            entity.Property(e => e.BnetIncrement).HasColumnName("BNetIncrement");
            entity.Property(e => e.BnetTransfer).HasColumnName("BNetTransfer");
            entity.Property(e => e.BoqFk).HasColumnName("BOQ_FK");
            entity.Property(e => e.BtotalIncrement).HasColumnName("BTotalIncrement");
            entity.Property(e => e.CadditionalAdvances).HasColumnName("CAdditionalAdvances");
            entity.Property(e => e.ContractFk).HasColumnName("Contract_FK");
            entity.Property(e => e.CprevAdvances).HasColumnName("CPrevAdvances");
            entity.Property(e => e.CtotalAdvances).HasColumnName("CTotalAdvances");
            entity.Property(e => e.DcurrInterest).HasColumnName("DCurrInterest");
            entity.Property(e => e.DprevInterest).HasColumnName("DPrevInterest");
            entity.Property(e => e.DtotalInterest).HasColumnName("DTotalInterest");
            entity.Property(e => e.EcurrDamages).HasColumnName("ECurrDamages");
            entity.Property(e => e.EcurrSubContPayment).HasColumnName("ECurrSubContPayment");
            entity.Property(e => e.EdirectPayment).HasColumnName("EDirectPayment");
            entity.Property(e => e.EmobCurrRepay).HasColumnName("EMobCurrRepay");
            entity.Property(e => e.EmobPrevRepay).HasColumnName("EMobPrevRepay");
            entity.Property(e => e.EmobTotalRepay).HasColumnName("EMobTotalRepay");
            entity.Property(e => e.EplantCurrRepay).HasColumnName("EPlantCurrRepay");
            entity.Property(e => e.EplantPrevRepay).HasColumnName("EPlantPrevRepay");
            entity.Property(e => e.EplantTotalRepay).HasColumnName("EPlantTotalRepay");
            entity.Property(e => e.EprevDamages).HasColumnName("EPrevDamages");
            entity.Property(e => e.HplantAuthorized).HasColumnName("HPlantAuthorized");
            entity.Property(e => e.ImobAuthorized).HasColumnName("IMobAuthorized");
            entity.Property(e => e.JadvMobDeductedToDate).HasColumnName("JAdvMobDeductedToDate");
            entity.Property(e => e.JoutStandingMobTobePaid).HasColumnName("JOutStandingMobTobePaid");
            entity.Property(e => e.KoutstandingPlantTobePaid).HasColumnName("KOutstandingPlantTobePaid");
            entity.Property(e => e.KplantDeductedToDate).HasColumnName("KPlantDeductedToDate");
            entity.Property(e => e.Paf).HasColumnName("PAF");

            entity.HasOne(d => d.BoqFkNavigation).WithMany(p => p.Ipcbacks)
                .HasForeignKey(d => d.BoqFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IPCBack__BOQ_FK__5A9A4855");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.Ipcbacks)
                .HasForeignKey(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IPCBack__Contract");
        });

        modelBuilder.Entity<Ipcfront>(entity =>
        {
            entity.HasKey(e => e.BoqFk).HasName("PK__IPCFront__3AE7B58B7B712C3B");

            entity.ToTable("IPCFront");

            entity.Property(e => e.BoqFk)
                .ValueGeneratedNever()
                .HasColumnName("Boq_FK");
            entity.Property(e => e.CertCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.CertDesc)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Ipcdate)
                .HasColumnType("datetime")
                .HasColumnName("IPCDate");
            entity.Property(e => e.Ipcnumber)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("IPCnumber");
            entity.Property(e => e.Manager).HasMaxLength(80);
            entity.Property(e => e.Note)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("note");

            entity.HasOne(d => d.BoqFkNavigation).WithOne(p => p.Ipcfront)
                .HasForeignKey<Ipcfront>(d => d.BoqFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IPCFront__Certif__7D5974AD");
        });

        modelBuilder.Entity<Massage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mdlMessa__C87C037CFF88CF40");

            entity.ToTable("massage");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Author).HasColumnName("author");
            entity.Property(e => e.Content)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("content");
            entity.Property(e => e.Emailed).HasColumnName("emailed");
            entity.Property(e => e.MsgCat)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("msgCat");
            entity.Property(e => e.MsgCatId).HasColumnName("msgCatID");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.Receiva).HasColumnName("receiva");
            entity.Property(e => e.ReplyDate)
                .HasColumnType("datetime")
                .HasColumnName("reply_date");
            entity.Property(e => e.ReplyId).HasColumnName("reply_id");
            entity.Property(e => e.SentDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("sent_date");
            entity.Property(e => e.SmsSent).HasColumnName("sms_sent");
            entity.Property(e => e.SmsTry).HasColumnName("sms_try");
            entity.Property(e => e.Subj)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("subj");
            entity.Property(e => e.TrialCount).HasColumnName("trial_count");
            entity.Property(e => e.Viewed).HasColumnName("viewed");
            entity.Property(e => e.ViewedDate)
                .HasColumnType("datetime")
                .HasColumnName("viewed_date");

            entity.HasOne(d => d.AuthorNavigation).WithMany(p => p.MassageAuthorNavigations)
                .HasForeignKey(d => d.Author)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__mdlMessag__Autho__04659998");

            entity.HasOne(d => d.ReceivaNavigation).WithMany(p => p.MassageReceivaNavigations)
                .HasForeignKey(d => d.Receiva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__mdlMessag__Recei__0559BDD1");
        });

        modelBuilder.Entity<MessageDoc>(entity =>
        {
            entity.ToTable("message_doc");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Baked).HasColumnName("baked");
            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.MessageFk).HasColumnName("message_fk");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("name");

            entity.HasOne(d => d.MessageFkNavigation).WithMany(p => p.MessageDocs)
                .HasForeignKey(d => d.MessageFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_message_doc_message");
        });

        modelBuilder.Entity<MessageDocTemp>(entity =>
        {
            entity.ToTable("message_doc_temp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Grope)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("grope");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Pathe)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("pathe");
        });

        modelBuilder.Entity<Nationality>(entity =>
        {
            entity.ToTable("Nationality");

            entity.HasIndex(e => e.NationalityName, "IX_Nationality").IsUnique();

            entity.Property(e => e.NationalityId).HasColumnName("NationalityID");
            entity.Property(e => e.CountryName)
                .IsRequired()
                .HasMaxLength(200);
            entity.Property(e => e.NationalityName)
                .IsRequired()
                .HasMaxLength(200);
        });

        modelBuilder.Entity<Photograph>(entity =>
        {
            entity.HasKey(e => e.PhotographId).HasName("PK__Photogra__EF4A2019E0EC24B1");

            entity.ToTable("Photograph");

            entity.Property(e => e.PhotographId).HasColumnName("PhotographID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.ContractFk).HasColumnName("Contract_FK");
            entity.Property(e => e.PhotoData).HasColumnType("image");
            entity.Property(e => e.PhotoDesc).HasMaxLength(250);
            entity.Property(e => e.PhotoExt).HasMaxLength(50);
            entity.Property(e => e.PhotoMime).HasMaxLength(50);
            entity.Property(e => e.PhotoName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.PhotoTitle).HasMaxLength(50);
            entity.Property(e => e.PhotoUrl).HasMaxLength(250);
        });

        modelBuilder.Entity<Portal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Portals");

            entity.ToTable("portal");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Alias)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("alias");
            entity.Property(e => e.Disc)
                .IsRequired()
                .HasMaxLength(300)
                .HasColumnName("disc");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<PortalAuth>(entity =>
        {
            entity.ToTable("portal_auth");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Access)
                .HasColumnType("datetime")
                .HasColumnName("access");
            entity.Property(e => e.Comp)
                .HasMaxLength(120)
                .HasColumnName("comp");
            entity.Property(e => e.Ip)
                .HasMaxLength(30)
                .HasColumnName("ip");
            entity.Property(e => e.PortalFk).HasColumnName("portal_fk");
            entity.Property(e => e.SessionId)
                .IsRequired()
                .HasMaxLength(60)
                .HasDefaultValue("")
                .HasColumnName("session_id");
            entity.Property(e => e.Success).HasColumnName("success");
            entity.Property(e => e.UserFk).HasColumnName("user_fk");

            entity.HasOne(d => d.UserFkNavigation).WithMany(p => p.PortalAuths)
                .HasForeignKey(d => d.UserFk)
                .HasConstraintName("FK_portal_auth_portal_user");
        });

        modelBuilder.Entity<PortalAuthTab>(entity =>
        {
            entity.ToTable("portal_auth_tab");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CheckedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("checked_time");
            entity.Property(e => e.ParentFk).HasColumnName("parent_fk");
            entity.Property(e => e.RoleFk).HasColumnName("role_fk");
            entity.Property(e => e.SessionId)
                .HasMaxLength(75)
                .HasColumnName("session_id");
            entity.Property(e => e.TabFk).HasColumnName("tab_fk");
            entity.Property(e => e.UserFk).HasColumnName("user_fk");

            entity.HasOne(d => d.ParentFkNavigation).WithMany(p => p.PortalAuthTabParentFkNavigations)
                .HasForeignKey(d => d.ParentFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserCheckedTabs_TabItems1");

            entity.HasOne(d => d.RoleFkNavigation).WithMany(p => p.PortalAuthTabs)
                .HasForeignKey(d => d.RoleFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserCheckedTabs_Roles");

            entity.HasOne(d => d.TabFkNavigation).WithMany(p => p.PortalAuthTabTabFkNavigations)
                .HasForeignKey(d => d.TabFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserCheckedTabs_TabItems");

            entity.HasOne(d => d.UserFkNavigation).WithMany(p => p.PortalAuthTabs)
                .HasForeignKey(d => d.UserFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserCheckedTabs_Users");
        });

        modelBuilder.Entity<PortalError>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataLayerExceptions");

            entity.ToTable("portal_error");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ErrorMessage).HasMaxLength(4000);
            entity.Property(e => e.ErrorProcedure).HasMaxLength(128);
            entity.Property(e => e.ErrorTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MiscInfo).HasMaxLength(250);
        });

        modelBuilder.Entity<PortalIcon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TabIcon__F322D22F689361F1");

            entity.ToTable("portal_icon");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Altname)
                .HasMaxLength(300)
                .HasColumnName("altname");
            entity.Property(e => e.Disc)
                .HasMaxLength(300)
                .HasColumnName("disc");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("name");
            entity.Property(e => e.Url)
                .IsRequired()
                .HasMaxLength(300)
                .HasDefaultValue("")
                .HasColumnName("url");
        });

        modelBuilder.Entity<PortalModule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TabModule");

            entity.ToTable("portal_module");

            entity.HasIndex(e => e.Name, "UK_TabModuleName").IsUnique();

            entity.HasIndex(e => e.Url, "UK_TabModuleUrl").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Url)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("url");
        });

        modelBuilder.Entity<PortalPageCate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mdlTabPa__322CD17DF0233D14");

            entity.ToTable("portal_page_cate");

            entity.HasIndex(e => e.Name, "UQ__mdlTabPa__9C61AB260DAE3504").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");

            entity.HasMany(d => d.TabFks).WithMany(p => p.CatFks)
                .UsingEntity<Dictionary<string, object>>(
                    "PortalPageTab",
                    r => r.HasOne<Web.Models.PortalTab>().WithMany()
                        .HasForeignKey("TabFk")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__mdlTabPag__Tab_F__3BEAD8AC"),
                    l => l.HasOne<Web.Models.PortalPageCate>().WithMany()
                        .HasForeignKey("CatFk")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__mdlTabPag__PageC__3AF6B473"),
                    j =>
                    {
                        j.HasKey("CatFk", "TabFk").HasName("PK__mdlTabPa__9A0AE74BA945BEB7");
                        j.ToTable("portal_page_tab");
                        j.IndexerProperty<int>("CatFk").HasColumnName("cat_fk");
                        j.IndexerProperty<int>("TabFk").HasColumnName("tab_fk");
                        
                    });
        });

        modelBuilder.Entity<PortalRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Roles");

            entity.ToTable("portal_role");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("name");
        });

        modelBuilder.Entity<PortalSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_mdlGlobalSettings");

            entity.ToTable("portal_setting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Disc)
                .HasMaxLength(3000)
                .IsUnicode(false)
                .HasColumnName("disc");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("value");
        });

        modelBuilder.Entity<Web.Models.PortalTab>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TabItems");

            entity.ToTable("portal_tab");

            entity.HasIndex(e => new { e.ParentFk, e.Name }, "UK_TabItems").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Disc)
                .HasMaxLength(300)
                .HasColumnName("disc");
            entity.Property(e => e.GroupFk)
                .HasDefaultValue(1)
                .HasColumnName("group_fk");
            entity.Property(e => e.HoverFk).HasColumnName("hover_fk");
            entity.Property(e => e.MenuFk).HasColumnName("menu_fk");
            entity.Property(e => e.ModuleFk).HasColumnName("module_fk");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Ordar).HasColumnName("ordar");
            entity.Property(e => e.ParentFk).HasColumnName("parent_fk");
            entity.Property(e => e.PortalFk).HasColumnName("portal_fk");

            entity.HasOne(d => d.GroupFkNavigation).WithMany(p => p.PortalTabs)
                .HasForeignKey(d => d.GroupFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_portal_tab_group");

            entity.HasOne(d => d.HoverFkNavigation).WithMany(p => p.PortalTabHoverFkNavigations)
                .HasForeignKey(d => d.HoverFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TabItems_TabIconHover");

            entity.HasOne(d => d.MenuFkNavigation).WithMany(p => p.PortalTabMenuFkNavigations)
                .HasForeignKey(d => d.MenuFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TabItems_TabIconMenu");

            entity.HasOne(d => d.ModuleFkNavigation).WithMany(p => p.PortalTabs)
                .HasForeignKey(d => d.ModuleFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TabItems_TabModule");

            entity.HasOne(d => d.PortalFkNavigation).WithMany(p => p.PortalTabs)
                .HasForeignKey(d => d.PortalFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TabItems_Portals");
        });

        modelBuilder.Entity<PortalTabGroup>(entity =>
        {
            entity.ToTable("portal_tab_group");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.Disc)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("disc");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Ordar).HasColumnName("ordar");
        });

        modelBuilder.Entity<PortalTabRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TabItemRoles");

            entity.ToTable("portal_tab_role");

            entity.HasIndex(e => new { e.TabFk, e.RoleFk }, "UK_TabItemRoles").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created).HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.RoleFk).HasColumnName("role_fk");
            entity.Property(e => e.TabFk).HasColumnName("tab_fk");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Viewed).HasColumnName("viewed");

            entity.HasOne(d => d.RoleFkNavigation).WithMany(p => p.PortalTabRoles)
                .HasForeignKey(d => d.RoleFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TabItemRoles_Roles");

            entity.HasOne(d => d.TabFkNavigation).WithMany(p => p.PortalTabRoles)
                .HasForeignKey(d => d.TabFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TabItemRoles_TabItems");
        });

        modelBuilder.Entity<PortalUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_Users_1");

            entity.ToTable("portal_user");

            entity.HasIndex(e => e.UserName, "UQ_mdlUsers").IsUnique();

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.Agreed).HasColumnName("agreed");
            entity.Property(e => e.Blocked).HasColumnName("blocked");
            entity.Property(e => e.DeptFk).HasColumnName("dept_fk");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.FailureCount).HasColumnName("failure_count");
            entity.Property(e => e.FirstPwdChangedDate)
                .HasColumnType("datetime")
                .HasColumnName("first_pwd_changed_date");
            entity.Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(60);
            entity.Property(e => e.LastPwdUpdate)
                .HasColumnType("datetime")
                .HasColumnName("last_pwd_update");
            entity.Property(e => e.NextPwdUpdate)
                .HasColumnType("datetime")
                .HasColumnName("next_pwd_update");
            entity.Property(e => e.Phone)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("phone");
            entity.Property(e => e.PwdExpires)
                .HasDefaultValue(true)
                .HasColumnName("pwd_expires");
            entity.Property(e => e.ReceiveEmail)
                .HasDefaultValue(true)
                .HasColumnName("receive_email");
            entity.Property(e => e.ReceiveSms)
                .HasDefaultValue(true)
                .HasColumnName("receive_sms");
            entity.Property(e => e.StatusFk)
                .HasDefaultValue(1)
                .HasColumnName("status_fk");
            entity.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Userpwd)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("userpwd");

            entity.HasOne(d => d.DeptFkNavigation).WithMany(p => p.PortalUsers)
                .HasForeignKey(d => d.DeptFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__mdlUsers__Dept_F__092A4EB5");

            entity.HasOne(d => d.StatusFkNavigation).WithMany(p => p.PortalUsers)
                .HasForeignKey(d => d.StatusFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_UserStatus");
        });

        modelBuilder.Entity<PortalUserFlow>(entity =>
        {
            entity.ToTable("portal_user_flow");

            entity.HasIndex(e => new { e.Sourx, e.Dest }, "UQ_portal_user_flow").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.Dest).HasColumnName("dest");
            entity.Property(e => e.Reason)
                .IsRequired()
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Sourx).HasColumnName("sourx");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updated_date");
        });

        modelBuilder.Entity<PortalUserRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UserRoles");

            entity.ToTable("portal_user_role");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created).HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.RoleFk).HasColumnName("role_fk");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.UserFk).HasColumnName("user_fk");
            entity.Property(e => e.Viewed).HasColumnName("viewed");

            entity.HasOne(d => d.RoleFkNavigation).WithMany(p => p.PortalUserRoles)
                .HasForeignKey(d => d.RoleFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRoles_Roles");

            entity.HasOne(d => d.UserFkNavigation).WithMany(p => p.PortalUserRoles)
                .HasForeignKey(d => d.UserFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRoles_Users");
        });

        modelBuilder.Entity<PortalUserStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UserStatus");

            entity.ToTable("portal_user_status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Access).HasColumnName("access");
            entity.Property(e => e.Info)
                .HasMaxLength(500)
                .HasColumnName("info");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Web.Models.Program>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Project");

            entity.ToTable("program");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approved)
                .HasDefaultValue(true)
                .HasColumnName("approved");
            entity.Property(e => e.Ben)
                .HasMaxLength(500)
                .HasColumnName("ben");
            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.CoverageFk)
                .HasComment("Determines whether its regional etc. based on the code")
                .HasColumnName("coverage_fk");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Desc)
                .HasMaxLength(500)
                .HasColumnName("desc");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(400)
                .HasColumnName("name");
            entity.Property(e => e.Obj)
                .HasMaxLength(500)
                .HasColumnName("obj");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.TypeFk).HasColumnName("type_fk");
            entity.Property(e => e.UserFk).HasColumnName("user_fk");

            entity.HasOne(d => d.CoverageFkNavigation).WithMany(p => p.Programs)
                .HasForeignKey(d => d.CoverageFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Program_Coverage");

            entity.HasOne(d => d.TypeFkNavigation).WithMany(p => p.Programs)
                .HasForeignKey(d => d.TypeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Project_ProgramType");

            entity.HasOne(d => d.UserFkNavigation).WithMany(p => p.Programs)
                .HasForeignKey(d => d.UserFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Program__CurrUse__253C7D7E");
        });

        modelBuilder.Entity<ProgramAgent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProgramC__864EF6E6F05489D3");

            entity.ToTable("program_agent");

            entity.HasIndex(e => new { e.ProgramFk, e.Code }, "UQ__ProgramC__002F19BC357016B5").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("code");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Name)
                .HasMaxLength(450)
                .HasColumnName("name");
            entity.Property(e => e.ProgramFk).HasColumnName("program_fk");

            entity.HasOne(d => d.ProgramFkNavigation).WithMany(p => p.ProgramAgents)
                .HasForeignKey(d => d.ProgramFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProgramCollaboratives_Program");
        });

        modelBuilder.Entity<ProgramCost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EstimatedCost");

            entity.ToTable("program_cost");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CatFk).HasColumnName("cat_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Currency)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("currency");
            entity.Property(e => e.ProgramFk).HasColumnName("program_fk");
            entity.Property(e => e.SourceFk).HasColumnName("source_fk");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.ValueDate).HasColumnName("value_date");

            entity.HasOne(d => d.CatFkNavigation).WithMany(p => p.ProgramCosts)
                .HasForeignKey(d => d.CatFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectEstimatedCost_FundCategoryType");

            entity.HasOne(d => d.ProgramFkNavigation).WithMany(p => p.ProgramCosts)
                .HasForeignKey(d => d.ProgramFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Program__Program_Cost");

            entity.HasOne(d => d.SourceFkNavigation).WithMany(p => p.ProgramCosts)
                .HasForeignKey(d => d.SourceFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_program_cost_fundsource");
        });

        modelBuilder.Entity<ProgramDoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TblDocuments");

            entity.ToTable("program_doc");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Baked).HasColumnName("baked");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.FlName)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("fl_name");
            entity.Property(e => e.FlPath)
                .HasMaxLength(50)
                .HasColumnName("fl_path");
            entity.Property(e => e.ProgramFk).HasColumnName("program_fk");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.ProgramFkNavigation).WithMany(p => p.ProgramDocs)
                .HasForeignKey(d => d.ProgramFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProgramDocument_Program");
        });

        modelBuilder.Entity<ProgramType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ProjectType");

            entity.ToTable("program_type");

            entity.HasIndex(e => e.Name, "UK_ProjectType").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ProjectActivity");

            entity.ToTable("project");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approved)
                .HasDefaultValue(true)
                .HasColumnName("approved");
            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("code");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Desc)
                .IsRequired()
                .HasMaxLength(800)
                .HasColumnName("desc");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(400)
                .HasColumnName("name");
            entity.Property(e => e.ProgramFk).HasColumnName("program_fk");
            entity.Property(e => e.TypeFk).HasColumnName("type_fk");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.UserFk).HasColumnName("user_fk");

            entity.HasOne(d => d.ProgramFkNavigation).WithMany(p => p.Projects)
                .HasForeignKey(d => d.ProgramFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Program_Project");

            entity.HasOne(d => d.TypeFkNavigation).WithMany(p => p.Projects)
                .HasForeignKey(d => d.TypeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Project_ProjectType");

            entity.HasOne(d => d.UserFkNavigation).WithMany(p => p.Projects)
                .HasForeignKey(d => d.UserFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Project__CurrUser");
        });

        modelBuilder.Entity<ProjectType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ProjectType_1");

            entity.ToTable("project_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Pv>(entity =>
        {
            entity.HasKey(e => e.PvId).HasName("PK__PaymentV__B5AFD5D56C4EE43C");

            entity.ToTable("pv");

            entity.HasIndex(e => e.BoqFk, "UQ__PaymentV__AB4483FA6F2B50E7").IsUnique();

            entity.Property(e => e.PvId).HasColumnName("pv_id");
            entity.Property(e => e.Approved).HasColumnName("approved");
            entity.Property(e => e.ApprovedAt).HasColumnName("approved_at");
            entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");
            entity.Property(e => e.Archived).HasColumnName("archived");
            entity.Property(e => e.AssocCode).HasMaxLength(20);
            entity.Property(e => e.BankFk).HasColumnName("Bank_FK");
            entity.Property(e => e.BoqFk).HasColumnName("Boq_FK");
            entity.Property(e => e.ContractFk).HasColumnName("Contract_FK");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("created_by");
            entity.Property(e => e.DeptId)
                .HasDefaultValue(6)
                .HasColumnName("Dept_ID");
            entity.Property(e => e.GrossWords)
                .HasMaxLength(550)
                .IsUnicode(false);
            entity.Property(e => e.Lad).HasColumnName("LAD");
            entity.Property(e => e.NetWords)
                .HasMaxLength(550)
                .IsUnicode(false);
            entity.Property(e => e.PaymentDesc).HasMaxLength(300);
            entity.Property(e => e.Pvdate).HasColumnName("PVDate");
            entity.Property(e => e.PvgrossAmount).HasColumnName("PVGrossAmount");
            entity.Property(e => e.PvnetAmount).HasColumnName("PVNetAmount");
            entity.Property(e => e.Pvnumber)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("PVNumber");
            entity.Property(e => e.Pvremarks)
                .IsRequired()
                .HasMaxLength(120)
                .HasColumnName("PVRemarks");
            entity.Property(e => e.Pvretention).HasColumnName("PVRetention");
            entity.Property(e => e.PvretentionRecovered).HasColumnName("PVRetentionRecovered");
            entity.Property(e => e.PvsubContractors).HasColumnName("PVSubContractors");
            entity.Property(e => e.StatusId)
                .HasDefaultValue(1)
                .HasColumnName("Status_ID");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(80)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("User_ID");

            entity.HasOne(d => d.BankFkNavigation).WithMany(p => p.Pvs)
                .HasForeignKey(d => d.BankFk)
                .HasConstraintName("FK_IPCPV_ContractorBank");

            entity.HasOne(d => d.BoqFkNavigation).WithOne(p => p.Pv)
                .HasForeignKey<Pv>(d => d.BoqFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PaymentVo__BOQ_F__72FBE1CB");

            entity.HasOne(d => d.BoqFk1).WithOne(p => p.Pv)
                .HasForeignKey<Pv>(d => d.BoqFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PaymentVo__BOQ_F__7207BD92");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.Pvs)
                .HasForeignKey(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PaymentVo__Contract");

            entity.HasOne(d => d.Dept).WithMany(p => p.Pvs)
                .HasForeignKey(d => d.DeptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IPCPV__Dept_ID__3F47339B");

            entity.HasOne(d => d.PreparerNavigation).WithMany(p => p.PvPreparerNavigations)
                .HasForeignKey(d => d.Preparer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PV_Preparer");

            entity.HasOne(d => d.Status).WithMany(p => p.Pvs)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IPCPV__Status_ID__3E530F62");

            entity.HasOne(d => d.User).WithMany(p => p.PvUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IPCPV__User_ID__403B57D4");
        });

        modelBuilder.Entity<PvAudit>(entity =>
        {
            entity.HasKey(e => e.PvFk).HasName("PK__IPCPvAud__3133C5C130F91444");

            entity.ToTable("pv_audit");

            entity.Property(e => e.PvFk)
                .ValueGeneratedNever()
                .HasColumnName("pv_fk");
            entity.Property(e => e.AuditCode)
                .IsRequired()
                .HasMaxLength(80)
                .HasDefaultValue("");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DispatchDate).HasColumnType("datetime");
            entity.Property(e => e.Narration)
                .IsRequired()
                .HasMaxLength(350);
            entity.Property(e => e.Pvno)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("PVNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(350)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.Validations)
                .IsRequired()
                .HasMaxLength(350)
                .HasDefaultValue("");

            entity.HasOne(d => d.PvFkNavigation).WithOne(p => p.PvAudit)
                .HasForeignKey<PvAudit>(d => d.PvFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IPCPvAudi__Payme__33D580EF");
        });

        modelBuilder.Entity<PvGyaabaakrom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pv_gyaabaakrom");

            entity.Property(e => e.Approved).HasColumnName("approved");
            entity.Property(e => e.ApprovedAt).HasColumnName("approved_at");
            entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");
            entity.Property(e => e.Archived).HasColumnName("archived");
            entity.Property(e => e.AssocCode).HasMaxLength(20);
            entity.Property(e => e.BankFk).HasColumnName("Bank_FK");
            entity.Property(e => e.BoqFk).HasColumnName("Boq_FK");
            entity.Property(e => e.ContractFk).HasColumnName("Contract_FK");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("created_by");
            entity.Property(e => e.DeptId).HasColumnName("Dept_ID");
            entity.Property(e => e.GrossWords)
                .HasMaxLength(550)
                .IsUnicode(false);
            entity.Property(e => e.Lad).HasColumnName("LAD");
            entity.Property(e => e.NetWords)
                .HasMaxLength(550)
                .IsUnicode(false);
            entity.Property(e => e.PaymentDesc).HasMaxLength(300);
            entity.Property(e => e.PvId)
                .ValueGeneratedOnAdd()
                .HasColumnName("pv_id");
            entity.Property(e => e.Pvdate).HasColumnName("PVDate");
            entity.Property(e => e.PvgrossAmount).HasColumnName("PVGrossAmount");
            entity.Property(e => e.PvnetAmount).HasColumnName("PVNetAmount");
            entity.Property(e => e.Pvnumber)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("PVNumber");
            entity.Property(e => e.Pvremarks)
                .IsRequired()
                .HasMaxLength(120)
                .HasColumnName("PVRemarks");
            entity.Property(e => e.Pvretention).HasColumnName("PVRetention");
            entity.Property(e => e.PvretentionRecovered).HasColumnName("PVRetentionRecovered");
            entity.Property(e => e.PvsubContractors).HasColumnName("PVSubContractors");
            entity.Property(e => e.StatusId).HasColumnName("Status_ID");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(80)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("User_ID");
        });

        modelBuilder.Entity<PvPayment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__IPCPVPay__4C07F95B369CDF01");

            entity.ToTable("pv_payment");

            entity.HasIndex(e => new { e.PvFk, e.PaymentDate }, "UQ__IPCPVPay__3571BBF639794BAC").IsUnique();

            entity.Property(e => e.PaymentId).HasColumnName("paymentID");
            entity.Property(e => e.Approved)
                .HasDefaultValue(true)
                .HasColumnName("approved");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("created_by");
            entity.Property(e => e.DeptId).HasColumnName("dept_id");
            entity.Property(e => e.PvFk).HasColumnName("pv_fk");
            entity.Property(e => e.Remarks).HasMaxLength(250);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(80)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Dept).WithMany(p => p.PvPayments)
                .HasForeignKey(d => d.DeptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_pv_payment_res_dept");

            entity.HasOne(d => d.PvFkNavigation).WithMany(p => p.PvPayments)
                .HasForeignKey(d => d.PvFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IPCPVPaym__Payme__3E3E00C9");

            entity.HasOne(d => d.User).WithMany(p => p.PvPayments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_pv_payment_user_id_portal_user");
        });

        modelBuilder.Entity<PvStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StatusPV__C8EE2043B6CE47E8");

            entity.ToTable("pv_status");

            entity.HasIndex(e => new { e.CatFk, e.Name }, "UQ__StatusPV__CDEDC3CD8867DCAC").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.CatFk).HasColumnName("cat_fk");
            entity.Property(e => e.Desc)
                .HasMaxLength(250)
                .HasColumnName("desc");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");

            entity.HasOne(d => d.CatFkNavigation).WithMany(p => p.PvStatuses)
                .HasForeignKey(d => d.CatFk)
                .HasConstraintName("FK__StatusPV__Catego__29CC2871");
        });

        modelBuilder.Entity<PvStatusCat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StatusCa__19093A2B3ED1A57B");

            entity.ToTable("pv_status_cat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
        });

        modelBuilder.Entity<RdDef>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RD_DEF");

            entity.Property(e => e.AssemblyFk).HasColumnName("Assembly_FK");
            entity.Property(e => e.District).HasMaxLength(3);
            entity.Property(e => e.FncClass)
                .HasMaxLength(20)
                .HasColumnName("FNC_Class");
            entity.Property(e => e.Fnode).HasMaxLength(20);
            entity.Property(e => e.ObjectId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ObjectID");
            entity.Property(e => e.RdId)
                .HasMaxLength(20)
                .HasColumnName("RD_ID");
            entity.Property(e => e.RdNr)
                .HasMaxLength(20)
                .HasColumnName("RD_NR");
            entity.Property(e => e.Region).HasMaxLength(2);
            entity.Property(e => e.RegionFk).HasColumnName("Region_FK");
            entity.Property(e => e.Tnode).HasMaxLength(20);
        });

        modelBuilder.Entity<RdIrClass>(entity =>
        {
            entity.HasKey(e => e.ClassId).HasName("PK_RD_IR_CLASS");

            entity.ToTable("RD_IR_Class");

            entity.HasIndex(e => e.ClassCode, "UQ_RD_IR_CLASS").IsUnique();

            entity.Property(e => e.ClassId)
                .ValueGeneratedNever()
                .HasColumnName("ClassID");
            entity.Property(e => e.ClassCode)
                .IsRequired()
                .HasMaxLength(1);
            entity.Property(e => e.ClassDesc).HasMaxLength(15);
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.ToTable("Region");

            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.Descriptionreg)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.RegionCode)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("Region_Code");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Report__D5BD48E5322D2F9F");

            entity.ToTable("report");

            entity.HasIndex(e => new { e.CatFk, e.Name }, "UQ__Report__930D5CE735099C4A").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.CatFk).HasColumnName("cat_fk");
            entity.Property(e => e.Code)
                .HasMaxLength(45)
                .HasColumnName("code");
            entity.Property(e => e.Desc)
                .HasMaxLength(250)
                .HasColumnName("desc");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("name");
            entity.Property(e => e.Orda).HasColumnName("orda");
            entity.Property(e => e.Url)
                .IsRequired()
                .HasMaxLength(450)
                .HasColumnName("url");

            entity.HasOne(d => d.CatFkNavigation).WithMany(p => p.Reports)
                .HasForeignKey(d => d.CatFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Report__Category__3AC275A0");
        });

        modelBuilder.Entity<ReportAccess>(entity =>
        {
            entity.ToTable("report_access");

            entity.HasIndex(e => e.ReportId, "UQ_report_access").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActId).HasColumnName("act_id");
            entity.Property(e => e.BidId).HasColumnName("bid_id");
            entity.Property(e => e.BoqId).HasColumnName("boq_id");
            entity.Property(e => e.Cat)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("cat");
            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.ContractId).HasColumnName("contract_id");
            entity.Property(e => e.ContractTypeId).HasColumnName("contract_type_id");
            entity.Property(e => e.ContractorId).HasColumnName("contractor_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.InitDate).HasColumnName("init_date");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Prev).HasColumnName("prev");
            entity.Property(e => e.ProjId).HasColumnName("proj_id");
            entity.Property(e => e.PvId).HasColumnName("pv_id");
            entity.Property(e => e.RegionId).HasColumnName("region_id");
            entity.Property(e => e.ReportId)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("report_id");
            entity.Property(e => e.VoId).HasColumnName("vo_id");
        });

        modelBuilder.Entity<ReportCat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ReportCa__19093A2B2A8C0DD7");

            entity.ToTable("report_cat");

            entity.HasIndex(e => e.Name, "UQ__ReportCa__8517B2E02D687A82").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.Desc)
                .HasMaxLength(250)
                .HasColumnName("desc");
            entity.Property(e => e.ModuleFk).HasColumnName("module_fk");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("name");

            entity.HasOne(d => d.ModuleFkNavigation).WithMany(p => p.ReportCats)
                .HasForeignKey(d => d.ModuleFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ReportCategory_Module");
        });

        modelBuilder.Entity<ReportRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ReportRo__8529928162A85742");

            entity.ToTable("report_role");

            entity.HasIndex(e => new { e.RoleFk, e.ReportFk }, "UQ__ReportRo__0B052A63AFC05609").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ReportFk).HasColumnName("report_fk");
            entity.Property(e => e.RoleFk).HasColumnName("role_fk");

            entity.HasOne(d => d.ReportFkNavigation).WithMany(p => p.ReportRoles)
                .HasForeignKey(d => d.ReportFk)
                .HasConstraintName("FK__ReportRol__Repor__42639768");

            entity.HasOne(d => d.RoleFkNavigation).WithMany(p => p.ReportRoles)
                .HasForeignKey(d => d.RoleFk)
                .HasConstraintName("FK__ReportRol__Role___381A47C8");
        });

        modelBuilder.Entity<ResDept>(entity =>
        {
            entity.HasKey(e => e.DeptId).HasName("PK__msg_Dept__0148818E5A3B20F9");

            entity.ToTable("res_dept");

            entity.HasIndex(e => e.DeptDesc, "UQ__msg_Dept__94E4B351702A6218").IsUnique();

            entity.HasIndex(e => e.DeptCode, "UQ__msg_Dept__BB9B95507306CEC3").IsUnique();

            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.DelegatedFk).HasColumnName("Delegated_FK");
            entity.Property(e => e.DeptCode)
                .IsRequired()
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DeptDesc)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HodUserFk).HasColumnName("HodUser_FK");
            entity.Property(e => e.RegionFk).HasColumnName("Region_FK");

            entity.HasOne(d => d.DelegatedFkNavigation).WithMany(p => p.ResDeptDelegatedFkNavigations)
                .HasForeignKey(d => d.DelegatedFk)
                .HasConstraintName("FK__msg_Dept__Delega__5E0BB1DD");

            entity.HasOne(d => d.HodUserFkNavigation).WithMany(p => p.ResDeptHodUserFkNavigations)
                .HasForeignKey(d => d.HodUserFk)
                .HasConstraintName("FK__msg_Dept__HodUse__5D178DA4");

            entity.HasOne(d => d.RegionFkNavigation).WithMany(p => p.ResDepts)
                .HasForeignKey(d => d.RegionFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__mdlDept__Region___19CACAD2");
        });

        modelBuilder.Entity<ResDeptFlow>(entity =>
        {
            entity.HasKey(e => new { e.SourceId, e.DestinationId }).HasName("PK__mdlDeptT__CB55E7B31CB540F7");

            entity.ToTable("res_dept_flow");

            entity.Property(e => e.SourceId).HasColumnName("SourceID");
            entity.Property(e => e.DestinationId).HasColumnName("DestinationID");

            entity.HasOne(d => d.Source).WithMany(p => p.ResDeptFlows)
                .HasForeignKey(d => d.SourceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__mdlDeptTo__Sourc__7DD962F1");
        });

        modelBuilder.Entity<RmDistSum>(entity =>
        {
            entity.ToTable("rm_DistSum");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bestimate).HasColumnName("BEstimate");
            entity.Property(e => e.Cestimate).HasColumnName("CEstimate");
            entity.Property(e => e.Cpno)
                .HasMaxLength(50)
                .HasColumnName("CPNo");
            entity.Property(e => e.District).HasMaxLength(120);
            entity.Property(e => e.RoadNo)
                .HasMaxLength(50)
                .HasColumnName("Road_No");
        });

        modelBuilder.Entity<RmDistrict>(entity =>
        {
            entity.ToTable("rm_Districts");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DistrictName).HasMaxLength(100);
            entity.Property(e => e.RdNr)
                .HasMaxLength(50)
                .HasColumnName("RD_NR");
            entity.Property(e => e.RegionName).HasMaxLength(50);
        });

        modelBuilder.Entity<RmRegSummary>(entity =>
        {
            entity.ToTable("rm_RegSummary");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.BudgetEstGh).HasColumnName("Budget Est (GH ¢)");
            entity.Property(e => e.ContractEstGh).HasColumnName("Contract Est (GH ¢)");
            entity.Property(e => e.District).HasMaxLength(120);
            entity.Property(e => e.PackageNo)
                .HasMaxLength(50)
                .HasColumnName("Package No");
        });

        modelBuilder.Entity<RmRoadMaintenance>(entity =>
        {
            entity.ToTable("rm_RoadMaintenance");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.No).HasMaxLength(50);
            entity.Property(e => e.Unit).HasMaxLength(50);
        });

        modelBuilder.Entity<RmUnitCost>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("rm_UnitCost");

            entity.Property(e => e.Actno)
                .HasMaxLength(50)
                .HasColumnName("ACTNo");
            entity.Property(e => e.ArA).HasColumnName("AR-A");
            entity.Property(e => e.ArB).HasColumnName("AR-B");
            entity.Property(e => e.ArC).HasColumnName("AR-C");
            entity.Property(e => e.ArD).HasColumnName("AR-D");
            entity.Property(e => e.ArE).HasColumnName("AR-E");
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .HasColumnName("NOTE");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasColumnName("UNIT");
        });

        modelBuilder.Entity<RmWork>(entity =>
        {
            entity.HasKey(e => e.WorkId).HasName("PK__rmWorks__2DE6D2150A93743A");

            entity.ToTable("rmWorks");

            entity.HasIndex(e => e.WorkDesc, "UQ__rmWorks__25D4F30F0D6FE0E5").IsUnique();

            entity.Property(e => e.WorkId).HasColumnName("WorkID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.WorkDesc)
                .IsRequired()
                .HasMaxLength(120);
        });

        modelBuilder.Entity<RmWorksItem>(entity =>
        {
            entity.HasKey(e => e.WorksItemId).HasName("PK__rmWorksI__EC41E64516D061F3");

            entity.ToTable("rmWorksItems");

            entity.HasIndex(e => e.WorksItemCode, "UQ__rmWorksI__0965E1AEB9683DE1").IsUnique();

            entity.Property(e => e.WorksItemId).HasColumnName("WorksItemID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Unit).HasMaxLength(20);
            entity.Property(e => e.WorkFk).HasColumnName("Work_FK");
            entity.Property(e => e.WorksItemCode).HasMaxLength(10);
            entity.Property(e => e.WorksItemDesc).HasMaxLength(120);

            entity.HasOne(d => d.WorkFkNavigation).WithMany(p => p.RmWorksItems)
                .HasForeignKey(d => d.WorkFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__rmWorksIt__Work___17ED6F58");
        });

        modelBuilder.Entity<Road>(entity =>
        {
            entity.HasKey(e => e.RoadId).HasName("PK__Roads__C5D162CA5165187F");

            entity.HasIndex(e => e.RdId, "IX_Roads_RD_ID");

            entity.HasIndex(e => e.RoadNumber, "IX_Roads_RN");

            entity.HasIndex(e => e.RdId, "UQ__Roads__04CCDD2A5441852A").IsUnique();

            entity.Property(e => e.RoadId).HasColumnName("RoadID");
            entity.Property(e => e.ClassFk)
                .HasMaxLength(1)
                .HasColumnName("Class_FK");
            entity.Property(e => e.District).HasMaxLength(3);
            entity.Property(e => e.Fnode).HasMaxLength(20);
            entity.Property(e => e.RdId)
                .HasMaxLength(20)
                .HasColumnName("RD_ID");
            entity.Property(e => e.RdLength).HasColumnName("RD_Length");
            entity.Property(e => e.Region).HasMaxLength(2);
            entity.Property(e => e.RoadDescription).HasMaxLength(500);
            entity.Property(e => e.RoadName)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.RoadNumber)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.Tnode).HasMaxLength(20);

            entity.HasOne(d => d.ClassFkNavigation).WithMany(p => p.Roads)
                .HasPrincipalKey(p => p.ClassCode)
                .HasForeignKey(d => d.ClassFk)
                .HasConstraintName("FK__Road__Class");
        });

        modelBuilder.Entity<RoadNode>(entity =>
        {
            entity.HasKey(e => e.NodeId);

            entity.ToTable("Road_Nodes");

            entity.HasIndex(e => new { e.NodeId, e.Name }, "Indx_Road_Nodes");

            entity.Property(e => e.NodeId)
                .HasMaxLength(20)
                .HasColumnName("Node_ID");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(30);
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
        });

        modelBuilder.Entity<StandardAct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Standard__0092C76D2E06CDA9");

            entity.ToTable("StandardAct");

            entity.HasIndex(e => e.Code, "UQ_StandardActivity").IsUnique();

            entity.HasIndex(e => e.Name, "UQ__Standard__4EBBBAC930E33A54").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(10)
                .HasDefaultValue("")
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("name");
        });

        modelBuilder.Entity<StandardActivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Standard__ACC9114034B3CB38");

            entity.ToTable("StandardActivity");

            entity.HasIndex(e => e.Code, "UQ__Standard__9C7DC6B5D3CD94C7").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActFk).HasColumnName("act_fk");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("name");
            entity.Property(e => e.ProgressFk).HasColumnName("progress_fk");
            entity.Property(e => e.StandardProgress).HasMaxLength(50);
            entity.Property(e => e.Unit)
                .HasMaxLength(20)
                .HasColumnName("unit");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.WeitFk).HasColumnName("weit_fk");

            entity.HasOne(d => d.ActFkNavigation).WithMany(p => p.StandardActivities)
                .HasForeignKey(d => d.ActFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StandardSubActivity_StandardActivity");
        });

        modelBuilder.Entity<StandardActivityEx>(entity =>
        {
            entity.ToTable("StandardActivityEx");

            entity.HasIndex(e => new { e.ParentAct, e.SubAct }, "UQ_StandardActivityEx").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ParentAct).HasColumnName("parent_act");
            entity.Property(e => e.SubAct).HasColumnName("sub_act");

            entity.HasOne(d => d.ParentActNavigation).WithMany(p => p.StandardActivityExParentActNavigations)
                .HasForeignKey(d => d.ParentAct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StandardActivity_parent_act");

            entity.HasOne(d => d.SubActNavigation).WithMany(p => p.StandardActivityExSubActNavigations)
                .HasForeignKey(d => d.SubAct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StandardActivity_sub_act");
        });

        modelBuilder.Entity<StandardBill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Standard__3214EC2757933161");

            entity.ToTable("StandardBill");

            entity.HasIndex(e => e.Name, "UQ__Standard__A48D6E0F32E431CF").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("name");
        });

        modelBuilder.Entity<StandardBillEx>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Standard__3214EC279AB1BDFE");

            entity.ToTable("StandardBillEx");

            entity.HasIndex(e => e.Name, "UQ__Standard__A48D6E0FB79AF2C4").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("name");
        });

        modelBuilder.Entity<StandardClause>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contract__7DF11E7D17AD7836");

            entity.ToTable("StandardClause");

            entity.HasIndex(e => e.Code, "UQ__Contract__ED94CE631A89E4E1").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Desc)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("desc");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(75)
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<StandardDaywork>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DayWorks");

            entity.ToTable("StandardDaywork");

            entity.HasIndex(e => e.Code, "UQ__DayWorks__55443B2CDFB92990").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CatFk).HasColumnName("cat_fk");
            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("name");
            entity.Property(e => e.Unit)
                .HasMaxLength(20)
                .HasColumnName("unit");

            entity.HasOne(d => d.CatFkNavigation).WithMany(p => p.StandardDayworks)
                .HasForeignKey(d => d.CatFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DayWorks__DayWor__2042BE37");
        });

        modelBuilder.Entity<StandardDayworkEx>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DayWorkC__3D0F0EB2B6D584C5");

            entity.ToTable("StandardDayworkEx");

            entity.HasIndex(e => e.Name, "UQ__DayWorkC__3DBD83A2D74099AB").IsUnique();

            entity.HasIndex(e => e.Code, "UQ__DayWorkC__4FBA3CE4EF86EC32").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("name");
        });

        modelBuilder.Entity<StandardDayworkRm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__rmDayWor__BAE6A79F9CFB6E4A");

            entity.ToTable("StandardDayworkRm");

            entity.HasIndex(e => e.Code, "UQ__rmDayWor__55443B2CDCB21E4D").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CatFk).HasColumnName("cat_fk");
            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("name");
            entity.Property(e => e.Unit)
                .HasMaxLength(20)
                .HasColumnName("unit");

            entity.HasOne(d => d.CatFkNavigation).WithMany(p => p.StandardDayworkRms)
                .HasForeignKey(d => d.CatFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__rmDayWork__DayWo__25077354");
        });

        modelBuilder.Entity<StandardProgress>(entity =>
        {
            entity.ToTable("StandardProgress");

            entity.HasIndex(e => e.ProgressName, "UQ__Standard__70C9C2B741C3AD93").IsUnique();

            entity.HasIndex(e => e.ProgressCode, "UQ__Standard__C413CA3B44A01A3E").IsUnique();

            entity.Property(e => e.StandardProgressId).HasColumnName("StandardProgressID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CatFk).HasColumnName("cat_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Pfcode)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("PFCode");
            entity.Property(e => e.ProgressCode)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.ProgressDesc)
                .IsRequired()
                .HasMaxLength(350);
            entity.Property(e => e.ProgressName)
                .IsRequired()
                .HasMaxLength(150);
            entity.Property(e => e.Remarks)
                .IsRequired()
                .HasMaxLength(350);
            entity.Property(e => e.Unit)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.CatFkNavigation).WithMany(p => p.StandardProgresses)
                .HasForeignKey(d => d.CatFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_standard_progress_cat");
        });

        modelBuilder.Entity<StandardProgressCat>(entity =>
        {
            entity.ToTable("StandardProgressCat");

            entity.HasIndex(e => e.Name, "UQ_StandardProgressCat").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("name");
            entity.Property(e => e.Orda).HasColumnName("orda");
            entity.Property(e => e.Remarks)
                .HasMaxLength(350)
                .HasColumnName("remarks");
        });

        modelBuilder.Entity<StandardWeit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WorkCate__273A1087D6ACA0CA");

            entity.ToTable("StandardWeit");

            entity.HasIndex(e => e.Code, "UQ__WorkCate__371BA9554E6A571E").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bi).HasColumnName("BI");
            entity.Property(e => e.Cb).HasColumnName("CB");
            entity.Property(e => e.Ce).HasColumnName("CE");
            entity.Property(e => e.Ch).HasColumnName("CH");
            entity.Property(e => e.Co).HasColumnName("CO");
            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnName("code");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Fu).HasColumnName("FU");
            entity.Property(e => e.Ll).HasColumnName("LL");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("name");
            entity.Property(e => e.Pc).HasColumnName("PC");
            entity.Property(e => e.Pg).HasColumnName("PG");
            entity.Property(e => e.Pl).HasColumnName("PL");
            entity.Property(e => e.Rl).HasColumnName("RL");
            entity.Property(e => e.Ro).HasColumnName("RO");
            entity.Property(e => e.Rs).HasColumnName("RS");
            entity.Property(e => e.Ti).HasColumnName("TI");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tickets");

            entity.ToTable("ticket");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId)
                .HasDefaultValue(1)
                .HasColumnName("category_id");
            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Content)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("content");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Editable).HasColumnName("editable");
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.Phone)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.PriorityId)
                .HasDefaultValue(1)
                .HasColumnName("priority_id");
            entity.Property(e => e.ReceivedAt).HasColumnName("received_at");
            entity.Property(e => e.StatusId)
                .HasDefaultValue(1)
                .HasColumnName("status_id");
            entity.Property(e => e.Subj)
                .IsRequired()
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("subj");
            entity.Property(e => e.SupportGroupExpiryDate).HasColumnName("support_group_expiry_date");
            entity.Property(e => e.SupportGroupId)
                .HasDefaultValue(1)
                .HasColumnName("support_group_id");

            entity.HasOne(d => d.Category).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_ticket_category");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TicketCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_created_by_portal_user");

            entity.HasOne(d => d.Owner).WithMany(p => p.TicketOwners)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_owner_portal_user");

            entity.HasOne(d => d.Priority).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.PriorityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_ticket_priority");

            entity.HasOne(d => d.Status).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_ticket_status");

            entity.HasOne(d => d.SupportGroup).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.SupportGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_ticket_support_group");
        });

        modelBuilder.Entity<TicketAProcess>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PK_ticket_process");

            entity.ToTable("ticket_a_process");

            entity.Property(e => e.TicketId)
                .ValueGeneratedNever()
                .HasColumnName("ticket_id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.PriorityId).HasColumnName("priority_id");
            entity.Property(e => e.ProcessedBy).HasColumnName("processed_by");
            entity.Property(e => e.ProcessedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("processed_date");
            entity.Property(e => e.SupportGroupExpiryDate).HasColumnName("support_group_expiry_date");
            entity.Property(e => e.SupportGroupId).HasColumnName("support_group_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.Category).WithMany(p => p.TicketAProcesses)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_process_ticket_category");

            entity.HasOne(d => d.Owner).WithMany(p => p.TicketAProcessOwners)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_process_owner_portal_user");

            entity.HasOne(d => d.Priority).WithMany(p => p.TicketAProcesses)
                .HasForeignKey(d => d.PriorityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_process_ticket_priority");

            entity.HasOne(d => d.ProcessedByNavigation).WithMany(p => p.TicketAProcessProcessedByNavigations)
                .HasForeignKey(d => d.ProcessedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_processed_by_portal_user");

            entity.HasOne(d => d.SupportGroup).WithMany(p => p.TicketAProcesses)
                .HasForeignKey(d => d.SupportGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_process_support_group");

            entity.HasOne(d => d.Ticket).WithOne(p => p.TicketAProcess)
                .HasForeignKey<TicketAProcess>(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_ticket_process");
        });

        modelBuilder.Entity<TicketCategory>(entity =>
        {
            entity.ToTable("ticket_category");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<TicketComment>(entity =>
        {
            entity.ToTable("ticket_comment");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comments)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("comments");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.TicketId).HasColumnName("ticket_id");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TicketComments)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_comment_portal_user");

            entity.HasOne(d => d.Ticket).WithMany(p => p.TicketComments)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_ticket_comment");
        });

        modelBuilder.Entity<TicketConfig>(entity =>
        {
            entity.ToTable("ticket_config");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ContactNumber)
                .IsRequired()
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("contact_number");
            entity.Property(e => e.EmailMessage)
                .IsRequired()
                .HasMaxLength(450)
                .IsUnicode(false)
                .HasColumnName("email_message");
            entity.Property(e => e.EmailName)
                .IsRequired()
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("email_name");
            entity.Property(e => e.EmailPassword)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("email_password");
            entity.Property(e => e.EmailSubject)
                .IsRequired()
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("email_subject");
            entity.Property(e => e.EnableEmail).HasColumnName("enable_email");
            entity.Property(e => e.EnableSms).HasColumnName("enable_sms");
            entity.Property(e => e.MaxFailureCount).HasColumnName("max_failure_count");
            entity.Property(e => e.Prefix)
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("prefix");
            entity.Property(e => e.PriorityHighCount).HasColumnName("priority_high_count");
            entity.Property(e => e.PriorityLowCount).HasColumnName("priority_low_count");
            entity.Property(e => e.PriorityMedCount).HasColumnName("Priority_med_count");
            entity.Property(e => e.ShowFileUpload).HasColumnName("show_file_upload");
            entity.Property(e => e.SmsMessage)
                .IsRequired()
                .HasMaxLength(260)
                .IsUnicode(false)
                .HasColumnName("sms_message");
            entity.Property(e => e.TicketCount)
                .HasDefaultValue(1)
                .HasColumnName("ticket_count");
            entity.Property(e => e.TicketEmail)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ticket_email");
            entity.Property(e => e.WarningPeriod).HasColumnName("warning_period");
        });

        modelBuilder.Entity<TicketDocument>(entity =>
        {
            entity.ToTable("ticket_document");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Baked).HasColumnName("baked");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.FlName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fl_name");
            entity.Property(e => e.FlPath)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fl_path");
            entity.Property(e => e.TicketId).HasColumnName("ticket_id");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TicketDocuments)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_document_portal_user");

            entity.HasOne(d => d.Ticket).WithMany(p => p.TicketDocuments)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_ticket_document");
        });

        modelBuilder.Entity<TicketEscalated>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ticket_escalate");

            entity.ToTable("ticket_escalated");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Reason)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.RecevaId).HasColumnName("receva_id");
            entity.Property(e => e.TicketId).HasColumnName("ticket_id");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TicketEscalatedCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_escalated_created_by_portal_user");

            entity.HasOne(d => d.Receva).WithMany(p => p.TicketEscalatedRecevas)
                .HasForeignKey(d => d.RecevaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_escalated_receva_portal_user");

            entity.HasOne(d => d.Ticket).WithMany(p => p.TicketEscalateds)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_ticket_escalate");
        });

        modelBuilder.Entity<TicketNote>(entity =>
        {
            entity.ToTable("ticket_note");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Author)
                .IsRequired()
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("author");
            entity.Property(e => e.Cate)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("cate");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Msg)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("msg");
            entity.Property(e => e.Receiva)
                .IsRequired()
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("receiva");
            entity.Property(e => e.Status)
                .IsRequired()
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.TicketId).HasColumnName("ticket_id");

            entity.HasOne(d => d.Ticket).WithMany(p => p.TicketNotes)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_ticket_note");
        });

        modelBuilder.Entity<TicketPriority>(entity =>
        {
            entity.ToTable("ticket_priority");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<TicketReopen>(entity =>
        {
            entity.ToTable("ticket_reopen");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Reason)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.ReopenBy).HasColumnName("reopen_by");
            entity.Property(e => e.ReopenDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("reopen_date");
            entity.Property(e => e.ResolvedId).HasColumnName("resolved_id");

            entity.HasOne(d => d.ReopenByNavigation).WithMany(p => p.TicketReopens)
                .HasForeignKey(d => d.ReopenBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_resolved_reopen_by_user");

            entity.HasOne(d => d.Resolved).WithMany(p => p.TicketReopens)
                .HasForeignKey(d => d.ResolvedId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_reopen_ticket_resolved");
        });

        modelBuilder.Entity<TicketResolved>(entity =>
        {
            entity.ToTable("ticket_resolved");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Confirmed).HasColumnName("confirmed");
            entity.Property(e => e.ConfirmedDate)
                .HasColumnType("datetime")
                .HasColumnName("confirmed_date");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Reopened).HasColumnName("reopened");
            entity.Property(e => e.Resolution)
                .IsUnicode(false)
                .HasColumnName("resolution");
            entity.Property(e => e.ResolvedDate).HasColumnName("resolved_date");
            entity.Property(e => e.ResolverId).HasColumnName("resolver_id");
            entity.Property(e => e.TicketId).HasColumnName("ticket_id");
            entity.Property(e => e.UpatedAt)
                .HasColumnType("datetime")
                .HasColumnName("upated_at");
            entity.Property(e => e.UpatedBy).HasColumnName("upated_by");

            entity.HasOne(d => d.Resolver).WithMany(p => p.TicketResolveds)
                .HasForeignKey(d => d.ResolverId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_resolver_portal_user");

            entity.HasOne(d => d.Ticket).WithMany(p => p.TicketResolveds)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_ticket_resolved");
        });

        modelBuilder.Entity<TicketStatus>(entity =>
        {
            entity.ToTable("ticket_status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Desc)
                .IsRequired()
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("desc");
            entity.Property(e => e.EmailMsg)
                .IsRequired()
                .HasMaxLength(450)
                .IsUnicode(false)
                .HasColumnName("email_msg");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.SmsMsg)
                .IsRequired()
                .HasMaxLength(160)
                .IsUnicode(false)
                .HasColumnName("sms_msg");
        });

        modelBuilder.Entity<TicketSupportGroup>(entity =>
        {
            entity.ToTable("ticket_support_group");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.Desc)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("desc");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Number).HasColumnName("number");
        });

        modelBuilder.Entity<TicketSupportGroupUser>(entity =>
        {
            entity.ToTable("ticket_support_group_user");

            entity.HasIndex(e => new { e.GroupId, e.UserId }, "UQ_ticket_support_group_user").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Group).WithMany(p => p.TicketSupportGroupUsers)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_support_group_group");

            entity.HasOne(d => d.User).WithMany(p => p.TicketSupportGroupUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ticket_support_group_user");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.HasKey(e => e.UnitCode).HasName("PK__Unit__0665E6D807020F21");

            entity.ToTable("Unit");

            entity.Property(e => e.UnitCode).HasMaxLength(20);
            entity.Property(e => e.UnitDesc)
                .IsRequired()
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.UnitId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UnitID");
        });

        modelBuilder.Entity<Vo>(entity =>
        {
            entity.ToTable("vo");

            entity.Property(e => e.VoId).HasColumnName("vo_id");
            entity.Property(e => e.AdditionDesc).HasMaxLength(250);
            entity.Property(e => e.Archived).HasColumnName("archived");
            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DeptId)
                .HasDefaultValue(5)
                .HasColumnName("Dept_ID");
            entity.Property(e => e.OmissionDesc).HasMaxLength(250);
            entity.Property(e => e.Remarks).HasMaxLength(350);
            entity.Property(e => e.RequestedReason)
                .IsRequired()
                .HasMaxLength(350);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("User_ID");
            entity.Property(e => e.VNo)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("v_no");

            entity.HasOne(d => d.Contract).WithMany(p => p.Vos)
                .HasForeignKey(d => d.ContractId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractVO__Contract");

            entity.HasOne(d => d.Dept).WithMany(p => p.Vos)
                .HasForeignKey(d => d.DeptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractVO__Dept");

            entity.HasOne(d => d.User).WithMany(p => p.Vos)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BOQVO__CurrUser");
        });

        modelBuilder.Entity<VoAct>(entity =>
        {
            entity.HasKey(e => e.VoactId).HasName("PK__ContractVO");

            entity.ToTable("voAct");

            entity.HasIndex(e => new { e.VoFk, e.ContractActivityFk, e.BidBillExFk, e.ActivityFk, e.VoBillExFk }, "UQ__ContractVO").IsUnique();

            entity.Property(e => e.VoactId).HasColumnName("voactID");
            entity.Property(e => e.ActivityFk).HasColumnName("activity_fk");
            entity.Property(e => e.BidBillExFk).HasColumnName("BidBillEx_FK");
            entity.Property(e => e.ContractActivityFk).HasColumnName("ContractActivity_FK");
            entity.Property(e => e.ContractProgressFk).HasColumnName("ContractProgress_FK");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Options)
                .IsRequired()
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.PrevVoqtty).HasColumnName("PrevVOQtty");
            entity.Property(e => e.StandardProgressFk).HasColumnName("StandardProgress_FK");
            entity.Property(e => e.Unit).HasMaxLength(20);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.VoBillExFk).HasColumnName("voBillEx_FK");
            entity.Property(e => e.VoFk).HasColumnName("vo_fk");
            entity.Property(e => e.WeitFk).HasColumnName("weit_fk");

            entity.HasOne(d => d.ActivityFkNavigation).WithMany(p => p.VoActs)
                .HasForeignKey(d => d.ActivityFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VoItems__StandardSubActivity");

            entity.HasOne(d => d.BidBillExFkNavigation).WithMany(p => p.VoActs)
                .HasForeignKey(d => d.BidBillExFk)
                .HasConstraintName("FK__BidBillsEx__ContractVOItems");

            entity.HasOne(d => d.ContractActivityFkNavigation).WithMany(p => p.VoActs)
                .HasForeignKey(d => d.ContractActivityFk)
                .HasConstraintName("FK_VoItems_ContractActivities");

            entity.HasOne(d => d.ContractProgressFkNavigation).WithMany(p => p.VoActs)
                .HasForeignKey(d => d.ContractProgressFk)
                .HasConstraintName("FK__ContractProgress__ContractVoItems");

            entity.HasOne(d => d.StandardProgressFkNavigation).WithMany(p => p.VoActs)
                .HasForeignKey(d => d.StandardProgressFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractVOItems_StandardProgress");

            entity.HasOne(d => d.VoBillExFkNavigation).WithMany(p => p.VoActs)
                .HasForeignKey(d => d.VoBillExFk)
                .HasConstraintName("FK_ContractVOItems_voBillEx");

            entity.HasOne(d => d.VoFkNavigation).WithMany(p => p.VoActs)
                .HasForeignKey(d => d.VoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractVO__voItems");

            entity.HasOne(d => d.WeitFkNavigation).WithMany(p => p.VoActs)
                .HasForeignKey(d => d.WeitFk)
                .HasConstraintName("FK_voact_standardweit");
        });

        modelBuilder.Entity<VoBase>(entity =>
        {
            entity.HasKey(e => e.VoBaseId).HasName("PK__voBase");

            entity.ToTable("voBase");

            entity.Property(e => e.VoBaseId).HasColumnName("voBaseID");
            entity.Property(e => e.AssemblyFk).HasColumnName("Assembly_FK");
            entity.Property(e => e.BaseNo)
                .IsRequired()
                .HasMaxLength(60)
                .HasComment("This represents the Road or Bridge or component number or ID");
            entity.Property(e => e.BaseTitle)
                .IsRequired()
                .HasMaxLength(180)
                .HasComment("This is the component tile of d road or river name");
            entity.Property(e => e.BaseTypeFk)
                .HasDefaultValue(3)
                .HasColumnName("base_type_fk");
            entity.Property(e => e.BidBaseFk).HasColumnName("BidBase_FK");
            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DistEnd).HasComment("The is the end section of the Road but in Bridge it is the No. of Spans");
            entity.Property(e => e.DistStart).HasComment("The is the start section of the Road but will be zero 4 Bridge");
            entity.Property(e => e.Distance).HasComment("This is the Road Length(km) or Bridge Length (m)");
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.RoadFk).HasColumnName("Road_FK");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.VoFk).HasColumnName("vo_fk");

            entity.HasOne(d => d.AssemblyFkNavigation).WithMany(p => p.VoBases)
                .HasForeignKey(d => d.AssemblyFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__voBase__Assembly");

            entity.HasOne(d => d.BaseTypeFkNavigation).WithMany(p => p.VoBases)
                .HasForeignKey(d => d.BaseTypeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_voBase_contract_type");

            entity.HasOne(d => d.BidBaseFkNavigation).WithMany(p => p.VoBases)
                .HasForeignKey(d => d.BidBaseFk)
                .HasConstraintName("FK__voBase__BidBase");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.VoBases)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__voBase__crdUser");

            entity.HasOne(d => d.RoadFkNavigation).WithMany(p => p.VoBases)
                .HasForeignKey(d => d.RoadFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__voBill__Road");

            entity.HasOne(d => d.VoFkNavigation).WithMany(p => p.VoBases)
                .HasForeignKey(d => d.VoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__voBase__ContractVO");
        });

        modelBuilder.Entity<VoBill>(entity =>
        {
            entity.HasKey(e => e.VoBillId).HasName("PK_VoBill");

            entity.ToTable("voBill");

            entity.Property(e => e.VoBillId).HasColumnName("voBillID");
            entity.Property(e => e.BidBaseFk).HasColumnName("BidBase_FK");
            entity.Property(e => e.BidBillFk).HasColumnName("BidBill_FK");
            entity.Property(e => e.BillDesc)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.BillNo)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.ContractFk).HasColumnName("Contract_FK");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Remarks).HasMaxLength(350);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.VoBaseFk).HasColumnName("voBase_FK");
            entity.Property(e => e.VoFk).HasColumnName("vo_fk");

            entity.HasOne(d => d.BidBaseFkNavigation).WithMany(p => p.VoBills)
                .HasForeignKey(d => d.BidBaseFk)
                .HasConstraintName("FK_voBill_BidBase");

            entity.HasOne(d => d.BidBillFkNavigation).WithMany(p => p.VoBills)
                .HasForeignKey(d => d.BidBillFk)
                .HasConstraintName("FK_VoBill_BidBills");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.VoBills)
                .HasForeignKey(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoBill_Contract");

            entity.HasOne(d => d.VoBaseFkNavigation).WithMany(p => p.VoBills)
                .HasForeignKey(d => d.VoBaseFk)
                .HasConstraintName("FK_voBill_voBase");

            entity.HasOne(d => d.VoFkNavigation).WithMany(p => p.VoBills)
                .HasForeignKey(d => d.VoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_voBill_ContractVO");
        });

        modelBuilder.Entity<VoBillEx>(entity =>
        {
            entity.ToTable("voBillEx");

            entity.Property(e => e.VoBillExId).HasColumnName("voBillExID");
            entity.Property(e => e.BidBillFk).HasColumnName("BidBill_FK");
            entity.Property(e => e.BidBillsExFk).HasColumnName("BidBillsEx_FK");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.HeaderDesc)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.VoBillFk).HasColumnName("VoBill_FK");
            entity.Property(e => e.VoFk).HasColumnName("vo_fk");

            entity.HasOne(d => d.BidBillFkNavigation).WithMany(p => p.VoBillExes)
                .HasForeignKey(d => d.BidBillFk)
                .HasConstraintName("FK_voBillEx_BidBills");

            entity.HasOne(d => d.BidBillsExFkNavigation).WithMany(p => p.VoBillExes)
                .HasForeignKey(d => d.BidBillsExFk)
                .HasConstraintName("FK_voBillEx_BidBillsEx");

            entity.HasOne(d => d.VoBillFkNavigation).WithMany(p => p.VoBillExes)
                .HasForeignKey(d => d.VoBillFk)
                .HasConstraintName("FK_voBillEx_VoBill");

            entity.HasOne(d => d.VoFkNavigation).WithMany(p => p.VoBillExes)
                .HasForeignKey(d => d.VoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_voBillEx_ContractVo");
        });

        modelBuilder.Entity<VoDocument>(entity =>
        {
            entity.HasKey(e => e.FileId).HasName("PK__Contract__6F0F989F3D4BA915");

            entity.ToTable("voDocument");

            entity.Property(e => e.FileId).HasColumnName("FileID");
            entity.Property(e => e.Afta).HasColumnName("afta");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DocName)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.FilePath).HasMaxLength(50);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.VoFk).HasColumnName("vo_fk");

            entity.HasOne(d => d.VoFkNavigation).WithMany(p => p.VoDocuments)
                .HasForeignKey(d => d.VoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContractVo__voDocument");
        });

        modelBuilder.Entity<VoProgress>(entity =>
        {
            entity.HasKey(e => e.VoProgressId).HasName("PK_ContractVOProgress");

            entity.ToTable("voProgress");

            entity.Property(e => e.VoProgressId).HasColumnName("VoProgressID");
            entity.Property(e => e.BidBaseFk).HasColumnName("BidBase_FK");
            entity.Property(e => e.ContractProgressFk).HasColumnName("ContractProgress_FK");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.StandardProgressFk).HasColumnName("StandardProgress_FK");
            entity.Property(e => e.Unit)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.VoBaseFk).HasColumnName("voBase_FK");
            entity.Property(e => e.VoFk).HasColumnName("vo_fk");

            entity.HasOne(d => d.BidBaseFkNavigation).WithMany(p => p.VoProgresses)
                .HasForeignKey(d => d.BidBaseFk)
                .HasConstraintName("FK_voProgress_BidBase");

            entity.HasOne(d => d.ContractProgressFkNavigation).WithMany(p => p.VoProgresses)
                .HasForeignKey(d => d.ContractProgressFk)
                .HasConstraintName("FK_ContractVO_ContractProgress");

            entity.HasOne(d => d.StandardProgressFkNavigation).WithMany(p => p.VoProgresses)
                .HasForeignKey(d => d.StandardProgressFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractVO_StandardProgress");

            entity.HasOne(d => d.VoBaseFkNavigation).WithMany(p => p.VoProgresses)
                .HasForeignKey(d => d.VoBaseFk)
                .HasConstraintName("FK_voProgress_voBase");

            entity.HasOne(d => d.VoFkNavigation).WithMany(p => p.VoProgresses)
                .HasForeignKey(d => d.VoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractVO_Progress");
        });

        modelBuilder.Entity<VoRate>(entity =>
        {
            entity.HasKey(e => e.VoRateId).HasName("PK__Contract__D64E0B7F841A5FBB");

            entity.ToTable("voRate");

            entity.HasIndex(e => new { e.VoFk, e.ContractActivityFk }, "UQ__voRate").IsUnique();

            entity.Property(e => e.VoRateId).HasColumnName("voRateID");
            entity.Property(e => e.ContractActivityFk).HasColumnName("ContractActivity_FK");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.VoFk).HasColumnName("vo_fk");

            entity.HasOne(d => d.ContractActivityFkNavigation).WithMany(p => p.VoRates)
                .HasForeignKey(d => d.ContractActivityFk)
                .HasConstraintName("FK__voRate__ContractActivity");

            entity.HasOne(d => d.VoFkNavigation).WithMany(p => p.VoRates)
                .HasForeignKey(d => d.VoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__voRate__ContractVO");
        });

        modelBuilder.Entity<Voext>(entity =>
        {
            entity.ToTable("voext");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approved).HasColumnName("approved");
            entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");
            entity.Property(e => e.ApprovedDate).HasColumnName("approved_date");
            entity.Property(e => e.Archived).HasColumnName("archived");
            entity.Property(e => e.CoNam).HasColumnName("co_nam");
            entity.Property(e => e.CoStart).HasColumnName("co_start");
            entity.Property(e => e.CompDate).HasColumnName("comp_date");
            entity.Property(e => e.ContractFk).HasColumnName("contract_fk");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DeptId)
                .HasDefaultValue(5)
                .HasColumnName("dept_id");
            entity.Property(e => e.Dur).HasColumnName("dur");
            entity.Property(e => e.NewDate).HasColumnName("new_date");
            entity.Property(e => e.NoNam).HasColumnName("no_nam");
            entity.Property(e => e.NoStart).HasColumnName("no_start");
            entity.Property(e => e.Reason)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("reason");
            entity.Property(e => e.Remarks)
                .HasMaxLength(350)
                .HasColumnName("remarks");
            entity.Property(e => e.ReqDate).HasColumnName("req_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.ContractFkNavigation).WithMany(p => p.Voexts)
                .HasForeignKey(d => d.ContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_voext_contract");

            entity.HasOne(d => d.Dept).WithMany(p => p.Voexts)
                .HasForeignKey(d => d.DeptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_voext_Dept");

            entity.HasOne(d => d.User).WithMany(p => p.Voexts)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_voext_user");
        });

        modelBuilder.Entity<VoextCost>(entity =>
        {
            entity.ToTable("voext_cost");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ExtDate).HasColumnName("ext_date");
            entity.Property(e => e.ExtFk).HasColumnName("ext_fk");

            entity.HasOne(d => d.ExtFkNavigation).WithMany(p => p.VoextCosts)
                .HasForeignKey(d => d.ExtFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_voext_cost");
        });

        modelBuilder.Entity<VoextDoc>(entity =>
        {
            entity.ToTable("voext_doc");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Baked).HasColumnName("baked");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.ExtFk).HasColumnName("ext_fk");
            entity.Property(e => e.FlPath)
                .HasMaxLength(50)
                .HasColumnName("fl_path");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("name");

            entity.HasOne(d => d.ExtFkNavigation).WithMany(p => p.VoextDocs)
                .HasForeignKey(d => d.ExtFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_voext_doc_voext");
        });

        modelBuilder.Entity<VwBdBid>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Bd_Bid");

            entity.Property(e => e.Approved).HasColumnName("approved");
            entity.Property(e => e.Archived).HasColumnName("archived");
            entity.Property(e => e.BatchNo)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.BatchTitle)
                .IsRequired()
                .HasMaxLength(350);
            entity.Property(e => e.BidBatchId).HasColumnName("BidBatchID");
            entity.Property(e => e.BidId).HasColumnName("BidID");
            entity.Property(e => e.BidNo)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.BidTitle)
                .IsRequired()
                .HasMaxLength(500);
            entity.Property(e => e.BidTypeCode)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("bid_type_code");
            entity.Property(e => e.BidTypeId).HasColumnName("bid_type_id");
            entity.Property(e => e.BidTypeName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("bid_type_name");
            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.DeptId).HasColumnName("Dept_ID");
            entity.Property(e => e.LotNo).HasMaxLength(10);
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(50)
                .HasColumnName("user_email");
            entity.Property(e => e.UserFullName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("user_full_name");
            entity.Property(e => e.UserId).HasColumnName("User_ID");
            entity.Property(e => e.UserId1).HasColumnName("userID");
            entity.Property(e => e.UserLogin)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("user_login");
            entity.Property(e => e.UserPhone)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("user_phone");
        });

        modelBuilder.Entity<VwBdBidBoq>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Bd_BidBoq");

            entity.Property(e => e.ActCode)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("act_code");
            entity.Property(e => e.ActId).HasColumnName("act_id");
            entity.Property(e => e.ActName)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("act_name");
            entity.Property(e => e.ActOrder)
                .HasMaxLength(4000)
                .HasColumnName("act_order");
            entity.Property(e => e.BaseNo)
                .IsRequired()
                .HasMaxLength(60);
            entity.Property(e => e.BaseTitle)
                .IsRequired()
                .HasMaxLength(180);
            entity.Property(e => e.BidActivityId).HasColumnName("BidActivityID");
            entity.Property(e => e.BidBaseId).HasColumnName("BidBaseID");
            entity.Property(e => e.BidBillExId).HasColumnName("BidBillExID");
            entity.Property(e => e.BidBillId).HasColumnName("BidBillID");
            entity.Property(e => e.BidId).HasColumnName("BidID");
            entity.Property(e => e.BidNo)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.BidTitle)
                .IsRequired()
                .HasMaxLength(500);
            entity.Property(e => e.BidTypeName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("bid_type_name");
            entity.Property(e => e.BillDesc)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.BillNo)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.BillNoDesc)
                .IsRequired()
                .HasMaxLength(272);
            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.LotNo).HasMaxLength(10);
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.SubDesc)
                .HasMaxLength(282)
                .HasColumnName("sub_desc");
            entity.Property(e => e.SubName)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("sub_name");
            entity.Property(e => e.SubNo).HasColumnName("sub_no");
            entity.Property(e => e.Unit).HasMaxLength(20);
            entity.Property(e => e.VwAmount).HasColumnName("vwAmount");
            entity.Property(e => e.VwQtty).HasColumnName("vwQtty");
        });

        modelBuilder.Entity<VwBdBidLotSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Bd_BidLotSummary");

            entity.Property(e => e.Amount).HasColumnType("numeric(1, 1)");
            entity.Property(e => e.BaseNo)
                .IsRequired()
                .HasMaxLength(60);
            entity.Property(e => e.BaseTitle)
                .IsRequired()
                .HasMaxLength(180);
            entity.Property(e => e.BidBaseId).HasColumnName("BidBaseID");
            entity.Property(e => e.BidId).HasColumnName("BidID");
            entity.Property(e => e.BidNo)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.BidTitle)
                .IsRequired()
                .HasMaxLength(500);
        });

        modelBuilder.Entity<VwBdBidRegion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Bd_BidRegion");

            entity.Property(e => e.BidId).HasColumnName("BidID");
            entity.Property(e => e.BidNo)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.BidTitle)
                .IsRequired()
                .HasMaxLength(500);
            entity.Property(e => e.LotNo).HasMaxLength(10);
            entity.Property(e => e.RegionCode)
                .IsRequired()
                .HasMaxLength(10);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.RegionName)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<VwBidBaseInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Bid_Base_info");

            entity.Property(e => e.AssemblyId).HasColumnName("AssemblyID");
            entity.Property(e => e.AssemblyName)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.BaseDesc)
                .IsRequired()
                .HasMaxLength(243);
            entity.Property(e => e.BaseNo)
                .IsRequired()
                .HasMaxLength(60);
            entity.Property(e => e.BaseTitle)
                .IsRequired()
                .HasMaxLength(180);
            entity.Property(e => e.BidBaseId).HasColumnName("BidBaseID");
            entity.Property(e => e.BidId).HasColumnName("BidID");
            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.CatName)
                .IsRequired()
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.ContractTypeId).HasColumnName("contract_type_id");
            entity.Property(e => e.ContractTypeName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("contract_type_name");
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.RegionName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.RoadId).HasColumnName("RoadID");
            entity.Property(e => e.RoadName)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.RoadNumber)
                .IsRequired()
                .HasMaxLength(20);
        });

        modelBuilder.Entity<VwBoqAct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_boq_act");

            entity.Property(e => e.ActCode)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("act_code");
            entity.Property(e => e.ActId).HasColumnName("act_id");
            entity.Property(e => e.ActName)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("act_name");
            entity.Property(e => e.ActOrder)
                .HasMaxLength(4000)
                .HasColumnName("act_order");
            entity.Property(e => e.BaseNo)
                .IsRequired()
                .HasMaxLength(60);
            entity.Property(e => e.BaseTitle)
                .IsRequired()
                .HasMaxLength(180);
            entity.Property(e => e.BidBaseId).HasColumnName("BidBaseID");
            entity.Property(e => e.BidBillExId).HasColumnName("BidBillExID");
            entity.Property(e => e.BidBillId).HasColumnName("BidBillID");
            entity.Property(e => e.BillDesc)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.BillNo)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.BillNoDesc)
                .IsRequired()
                .HasMaxLength(272);
            entity.Property(e => e.BoqId).HasColumnName("BoqID");
            entity.Property(e => e.BoqItemId).HasColumnName("BoqItemID");
            entity.Property(e => e.ContractActivityId).HasColumnName("ContractActivityID");
            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.ExRemarks).HasMaxLength(350);
            entity.Property(e => e.ExceedEx)
                .IsRequired()
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.Remarks).HasMaxLength(350);
            entity.Property(e => e.SubDesc)
                .HasMaxLength(282)
                .HasColumnName("sub_desc");
            entity.Property(e => e.SubName)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("sub_name");
            entity.Property(e => e.SubNo).HasColumnName("sub_no");
            entity.Property(e => e.Unit)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.Voqtty).HasColumnName("VOQtty");
            entity.Property(e => e.WeitCode)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnName("weit_code");
            entity.Property(e => e.WeitId).HasColumnName("weit_id");
            entity.Property(e => e.WeitName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("weit_name");
        });

        modelBuilder.Entity<VwBoqPafMonthlyValue>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_boq_paf_monthly_value");

            entity.Property(e => e.BidWeitId).HasColumnName("BidWeitID");
            entity.Property(e => e.BoqId).HasColumnName("BoqID");
            entity.Property(e => e.CategoryDesc)
                .IsRequired()
                .HasMaxLength(150);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.MonthlyPaf).HasColumnName("monthly_paf");
            entity.Property(e => e.PafCalcId).HasColumnName("PafCalcID");
            entity.Property(e => e.PafId).HasColumnName("PafID");
        });

        modelBuilder.Entity<VwClosure>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_closure");

            entity.Property(e => e.Approved).HasColumnName("approved");
            entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");
            entity.Property(e => e.ApprovedByName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("approved_by_name");
            entity.Property(e => e.ApprovedDate).HasColumnName("approved_date");
            entity.Property(e => e.ApprovedName)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("approved_name");
            entity.Property(e => e.CompletedDate).HasColumnName("completed_date");
            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.ContractStatusId).HasColumnName("contract_status_id");
            entity.Property(e => e.ContractStatusName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("contract_status_name");
            entity.Property(e => e.ContractTitle)
                .IsRequired()
                .HasMaxLength(350);
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DeptId).HasColumnName("dept_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OwnaEmail)
                .HasMaxLength(50)
                .HasColumnName("owna_email");
            entity.Property(e => e.OwnaFullName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("owna_full_name");
            entity.Property(e => e.OwnaLogin)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("owna_login");
            entity.Property(e => e.OwnaPhone)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("owna_phone");
            entity.Property(e => e.Reason)
                .HasMaxLength(350)
                .HasColumnName("reason");
            entity.Property(e => e.Remarks)
                .HasMaxLength(350)
                .HasColumnName("remarks");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<VwCoaFundingExpenditureDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_coa_FundingExpenditureDetails");

            entity.Property(e => e.BudgetRemarks).HasMaxLength(350);
            entity.Property(e => e.ExpendRemarks).HasMaxLength(350);
            entity.Property(e => e.FiscalPeriodId).HasColumnName("FiscalPeriodID");
            entity.Property(e => e.FiscalYearId).HasColumnName("FiscalYearID");
            entity.Property(e => e.FundSourceCode)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("Fund_Source_Code");
            entity.Property(e => e.FundSourceDesc)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Fund_Source_Desc");
            entity.Property(e => e.FundSourceId).HasColumnName("FundSourceID");
            entity.Property(e => e.FundSourceShort)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FundingBudgetId).HasColumnName("FundingBudgetID");
            entity.Property(e => e.FundingExpendId).HasColumnName("FundingExpendID");
            entity.Property(e => e.PeriodCode).HasMaxLength(20);
            entity.Property(e => e.PeriodName)
                .IsRequired()
                .HasMaxLength(120);
            entity.Property(e => e.PeriodRemarks).HasMaxLength(350);
            entity.Property(e => e.SubSourceCode)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.SubSourceDesc)
                .IsRequired()
                .HasMaxLength(150);
            entity.Property(e => e.SubSourceId).HasColumnName("SubSourceID");
            entity.Property(e => e.YearCode)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.YearName)
                .IsRequired()
                .HasMaxLength(120);
            entity.Property(e => e.YearRemarks).HasMaxLength(350);
        });

        modelBuilder.Entity<VwContractorBank>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_contractor_bank");

            entity.Property(e => e.AccountCurrency)
                .IsRequired()
                .HasMaxLength(5);
            entity.Property(e => e.AccountName)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.AccountNumber)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.BankCode)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankName)
                .IsRequired()
                .HasMaxLength(120);
            entity.Property(e => e.BranchCode)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName)
                .IsRequired()
                .HasMaxLength(120);
            entity.Property(e => e.ContractorBankId).HasColumnName("ContractorBankID");
            entity.Property(e => e.ContractorId).HasColumnName("ContractorID");
            entity.Property(e => e.ContractorName).HasMaxLength(120);
        });

        modelBuilder.Entity<VwCtContract>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ct_contract");

            entity.Property(e => e.Approved).HasColumnName("approved");
            entity.Property(e => e.ApprovedAt)
                .HasColumnType("datetime")
                .HasColumnName("approved_at");
            entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");
            entity.Property(e => e.ApprovedName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("approved_name");
            entity.Property(e => e.ApprovedText)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("approved_text");
            entity.Property(e => e.Archived).HasColumnName("archived");
            entity.Property(e => e.BidId).HasColumnName("BidID");
            entity.Property(e => e.ContractCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ContractCostId).HasColumnName("ContractCostID");
            entity.Property(e => e.ContractDesc).HasMaxLength(350);
            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.ContractName)
                .IsRequired()
                .HasMaxLength(402);
            entity.Property(e => e.ContractStatusId).HasColumnName("contract_status_id");
            entity.Property(e => e.ContractStatusName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("contract_status_name");
            entity.Property(e => e.ContractTitle)
                .IsRequired()
                .HasMaxLength(350);
            entity.Property(e => e.ContractTypeCode)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("contract_type_code");
            entity.Property(e => e.ContractTypeId).HasColumnName("contract_type_id");
            entity.Property(e => e.ContractTypeName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("contract_type_name");
            entity.Property(e => e.ContractorAddress)
                .HasMaxLength(150)
                .HasColumnName("contractor_address");
            entity.Property(e => e.ContractorClass)
                .HasMaxLength(10)
                .HasColumnName("contractor_class");
            entity.Property(e => e.ContractorContact)
                .HasMaxLength(50)
                .HasColumnName("contractor_contact");
            entity.Property(e => e.ContractorEmail)
                .HasMaxLength(50)
                .HasColumnName("contractor_email");
            entity.Property(e => e.ContractorExpiryDate).HasColumnName("contractor_expiry_date");
            entity.Property(e => e.ContractorId).HasColumnName("contractor_id");
            entity.Property(e => e.ContractorName)
                .HasMaxLength(120)
                .HasColumnName("contractor_name");
            entity.Property(e => e.ContractorPhone)
                .HasMaxLength(50)
                .HasColumnName("contractor_phone");
            entity.Property(e => e.ContractorTin)
                .HasMaxLength(50)
                .HasColumnName("contractor_tin");
            entity.Property(e => e.ContractorType)
                .HasMaxLength(50)
                .HasColumnName("contractor_type");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.DeptId).HasColumnName("Dept_ID");
            entity.Property(e => e.Fixed).HasColumnName("fixed");
            entity.Property(e => e.IntDelayIn)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("int_delay_in");
            entity.Property(e => e.IntDuration).HasColumnName("int_duration");
            entity.Property(e => e.InterestId).HasColumnName("interest_id");
            entity.Property(e => e.InterestType)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("interest_type");
            entity.Property(e => e.ManagerEmail)
                .HasMaxLength(50)
                .HasColumnName("manager_email");
            entity.Property(e => e.ManagerId).HasColumnName("manager_id");
            entity.Property(e => e.ManagerName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("manager_name");
            entity.Property(e => e.ManagerPhone)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("manager_phone");
            entity.Property(e => e.NoPafDate).HasColumnName("no_paf_date");
            entity.Property(e => e.RegionCode)
                .IsRequired()
                .HasMaxLength(10);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.RegionName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.UserEmail)
                .HasMaxLength(50)
                .HasColumnName("user_email");
            entity.Property(e => e.UserFullName)
                .HasMaxLength(60)
                .HasColumnName("user_full_name");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UserLogin)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("user_login");
            entity.Property(e => e.UserPhone)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("user_phone");
        });

        modelBuilder.Entity<VwCtContractActivity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ct_contract_activity");

            entity.Property(e => e.ActCode)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("act_code");
            entity.Property(e => e.ActId).HasColumnName("act_id");
            entity.Property(e => e.ActName)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("act_name");
            entity.Property(e => e.ActOrder)
                .HasMaxLength(4000)
                .HasColumnName("act_order");
            entity.Property(e => e.BaseNo)
                .IsRequired()
                .HasMaxLength(60);
            entity.Property(e => e.BaseTitle)
                .IsRequired()
                .HasMaxLength(180);
            entity.Property(e => e.BidBaseId).HasColumnName("BidBaseID");
            entity.Property(e => e.BidBillExId).HasColumnName("BidBillExID");
            entity.Property(e => e.BidBillId).HasColumnName("BidBillID");
            entity.Property(e => e.BillDesc)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.BillNo)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.BillNoDesc)
                .IsRequired()
                .HasMaxLength(272);
            entity.Property(e => e.BoqAmount).HasColumnName("boq_amount");
            entity.Property(e => e.BoqQtty).HasColumnName("boq_qtty");
            entity.Property(e => e.ContractActivityId).HasColumnName("ContractActivityID");
            entity.Property(e => e.ContractFk).HasColumnName("contract_fk");
            entity.Property(e => e.ContractProgressId).HasColumnName("ContractProgressID");
            entity.Property(e => e.InitSchedule).HasColumnName("init_schedule");
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.ProgressActive).HasColumnName("progress_active");
            entity.Property(e => e.ProgressCat)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("progress_cat");
            entity.Property(e => e.ProgressCatId).HasColumnName("progress_cat_id");
            entity.Property(e => e.ProgressCatName)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("progress_cat_name");
            entity.Property(e => e.ProgressCode)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("progress_code");
            entity.Property(e => e.ProgressId).HasColumnName("progress_id");
            entity.Property(e => e.ProgressName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("progress_name");
            entity.Property(e => e.ProgressUnit)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("progress_unit");
            entity.Property(e => e.SubDesc)
                .HasMaxLength(282)
                .HasColumnName("sub_desc");
            entity.Property(e => e.SubName)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("sub_name");
            entity.Property(e => e.SubNo).HasColumnName("sub_no");
            entity.Property(e => e.TotalAmount).HasColumnName("total_amount");
            entity.Property(e => e.TotalQtty).HasColumnName("total_qtty");
            entity.Property(e => e.TotalSchedule).HasColumnName("total_schedule");
            entity.Property(e => e.Unit)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.VoSchedule).HasColumnName("vo_schedule");
            entity.Property(e => e.Voqtty).HasColumnName("VOQtty");
            entity.Property(e => e.WeitCode)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnName("weit_code");
            entity.Property(e => e.WeitId).HasColumnName("weit_id");
            entity.Property(e => e.WeitName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("weit_name");
        });

        modelBuilder.Entity<VwCtContractBaseInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ct_Contract_Base_Info");

            entity.Property(e => e.AssemblyId).HasColumnName("AssemblyID");
            entity.Property(e => e.AssemblyName)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.BaseDesc)
                .IsRequired()
                .HasMaxLength(243);
            entity.Property(e => e.BaseNo)
                .IsRequired()
                .HasMaxLength(60);
            entity.Property(e => e.BaseTitle)
                .IsRequired()
                .HasMaxLength(180);
            entity.Property(e => e.BidBaseId).HasColumnName("BidBaseID");
            entity.Property(e => e.BidId).HasColumnName("BidID");
            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.CatName)
                .IsRequired()
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.ContractTypeId).HasColumnName("contract_type_id");
            entity.Property(e => e.ContractTypeName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("contract_type_name");
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.RegionName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.RoadId).HasColumnName("RoadID");
            entity.Property(e => e.RoadName)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.RoadNumber)
                .IsRequired()
                .HasMaxLength(20);
        });

        modelBuilder.Entity<VwCtContractProgress>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ct_contract_progress");

            entity.Property(e => e.BaseNo)
                .IsRequired()
                .HasMaxLength(60);
            entity.Property(e => e.BaseTitle)
                .IsRequired()
                .HasMaxLength(180);
            entity.Property(e => e.BidBaseId).HasColumnName("BidBaseID");
            entity.Property(e => e.BoqSchedule).HasColumnName("boq_schedule");
            entity.Property(e => e.ContractFk).HasColumnName("contract_fk");
            entity.Property(e => e.ContractProgressId).HasColumnName("ContractProgressID");
            entity.Property(e => e.InitSchedule).HasColumnName("init_schedule");
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.ProgressActive).HasColumnName("progress_active");
            entity.Property(e => e.ProgressAmount).HasColumnName("progress_amount");
            entity.Property(e => e.ProgressCat)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("progress_cat");
            entity.Property(e => e.ProgressCatId).HasColumnName("progress_cat_id");
            entity.Property(e => e.ProgressCatName)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("progress_cat_name");
            entity.Property(e => e.ProgressCode)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("progress_code");
            entity.Property(e => e.ProgressId).HasColumnName("progress_id");
            entity.Property(e => e.ProgressName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("progress_name");
            entity.Property(e => e.ProgressUnit)
                .HasMaxLength(20)
                .HasColumnName("progress_unit");
            entity.Property(e => e.TotalSchedule).HasColumnName("total_schedule");
            entity.Property(e => e.Unit).HasMaxLength(20);
            entity.Property(e => e.VoSchedule).HasColumnName("vo_schedule");
        });

        modelBuilder.Entity<VwCtContractRegion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Ct_ContractRegion");

            entity.Property(e => e.ContractFk).HasColumnName("Contract_FK");
            entity.Property(e => e.District)
                .HasMaxLength(450)
                .IsUnicode(false);
            entity.Property(e => e.RegionCode)
                .IsRequired()
                .HasMaxLength(10);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.RegionName)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<VwCtSummaryOfBill>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Ct_SummaryOfBills");

            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AdjustmentAllowanceText)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Approved).HasColumnName("approved");
            entity.Property(e => e.BidBillId).HasColumnName("BidBillID");
            entity.Property(e => e.BillDesc)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.BillNo)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.BillNoDesc)
                .IsRequired()
                .HasMaxLength(272);
            entity.Property(e => e.Classification).HasMaxLength(10);
            entity.Property(e => e.ContractCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ContractDesc).HasMaxLength(350);
            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.ContractStatus)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Contract_Status");
            entity.Property(e => e.ContractStatusId).HasColumnName("ContractStatusID");
            entity.Property(e => e.ContractTitle)
                .IsRequired()
                .HasMaxLength(350);
            entity.Property(e => e.ContractorId).HasColumnName("ContractorID");
            entity.Property(e => e.ContractorName).HasMaxLength(120);
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.FADE).HasColumnName("F_A_D_E");
            entity.Property(e => e.TinNo)
                .HasMaxLength(50)
                .HasColumnName("TIN_No");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<VwCtSummaryOfBillsDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Ct_SummaryOfBillsDetails");

            entity.Property(e => e.ActCode)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("act_code");
            entity.Property(e => e.ActId).HasColumnName("act_id");
            entity.Property(e => e.ActName)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("act_name");
            entity.Property(e => e.ActOrder)
                .HasMaxLength(4000)
                .HasColumnName("act_order");
            entity.Property(e => e.ActivityCode)
                .IsRequired()
                .HasMaxLength(10);
            entity.Property(e => e.ActivityDesc)
                .IsRequired()
                .HasMaxLength(350);
            entity.Property(e => e.BaseNo)
                .IsRequired()
                .HasMaxLength(60);
            entity.Property(e => e.BaseTitle)
                .IsRequired()
                .HasMaxLength(180);
            entity.Property(e => e.BidBaseId).HasColumnName("BidBaseID");
            entity.Property(e => e.BidBillId).HasColumnName("BidBillID");
            entity.Property(e => e.BillNoDesc)
                .IsRequired()
                .HasMaxLength(272);
            entity.Property(e => e.CategoryDesc)
                .IsRequired()
                .HasMaxLength(150);
            entity.Property(e => e.ContractActivityId).HasColumnName("ContractActivityID");
            entity.Property(e => e.ContractCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.ContractProgressId).HasColumnName("ContractProgressID");
            entity.Property(e => e.ContractTitle)
                .IsRequired()
                .HasMaxLength(350);
            entity.Property(e => e.ProgressCode)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("progress_code");
            entity.Property(e => e.ProgressCode1)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("ProgressCode");
            entity.Property(e => e.ProgressDesc)
                .IsRequired()
                .HasMaxLength(150);
            entity.Property(e => e.ProgressName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("progress_name");
            entity.Property(e => e.StandardActivity)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.StandardActivityId).HasColumnName("StandardActivityID");
            entity.Property(e => e.SubActivityId).HasColumnName("SubActivityID");
            entity.Property(e => e.Unit)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.WeitCode)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnName("weit_code");
            entity.Property(e => e.WeitId).HasColumnName("weit_id");
            entity.Property(e => e.WeitName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("weit_name");
            entity.Property(e => e.WorkCategory)
                .IsRequired()
                .HasMaxLength(15);
        });

        modelBuilder.Entity<VwDocument>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_document");

            entity.Property(e => e.Brief)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("brief");
            entity.Property(e => e.CheckedOut).HasColumnName("checked_out");
            entity.Property(e => e.CheckedOutBy).HasColumnName("checked_out_by");
            entity.Property(e => e.CheckedOutDate)
                .HasColumnType("datetime")
                .HasColumnName("checked_out_date");
            entity.Property(e => e.CheckedOutName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("checked_out_name");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CreatedName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("created_name");
            entity.Property(e => e.DocumentId).HasColumnName("document_id");
            entity.Property(e => e.FolderDesc)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("folder_desc");
            entity.Property(e => e.FolderId).HasColumnName("folder_id");
            entity.Property(e => e.FolderName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("folder_name");
            entity.Property(e => e.FolderParentId).HasColumnName("folder_parent_id");
            entity.Property(e => e.FolderPath)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("folder_path");
            entity.Property(e => e.LastAccessedAt)
                .HasColumnType("datetime")
                .HasColumnName("last_accessed_at");
            entity.Property(e => e.LastAccessedBy).HasColumnName("last_accessed_by");
            entity.Property(e => e.LastAccessedName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("last_accessed_name");
            entity.Property(e => e.LastUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("last_updated_at");
            entity.Property(e => e.LastUpdatedBy).HasColumnName("last_updated_by");
            entity.Property(e => e.LastUpdatedName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("last_updated_name");
            entity.Property(e => e.Ref)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ref");
            entity.Property(e => e.StatusId).HasColumnName("status_id");
            entity.Property(e => e.StatusName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("status_name");
            entity.Property(e => e.Subj)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("subj");
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.VersionId).HasColumnName("version_id");
            entity.Property(e => e.VsNo).HasColumnName("vs_no");
            entity.Property(e => e.VsPath)
                .IsRequired()
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vs_path");
            entity.Property(e => e.VsSize).HasColumnName("vs_size");
        });

        modelBuilder.Entity<VwDocumentFolder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_document_folder");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CreatedName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("created_name");
            entity.Property(e => e.FileCount).HasColumnName("file_count");
            entity.Property(e => e.FileSize).HasColumnName("file_size");
            entity.Property(e => e.FolderDesc)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("folder_desc");
            entity.Property(e => e.FolderId).HasColumnName("folder_id");
            entity.Property(e => e.FolderName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("folder_name");
            entity.Property(e => e.FolderPath)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("folder_path");
            entity.Property(e => e.FolderPath2)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("folder_path2");
            entity.Property(e => e.Owna).HasColumnName("owna");
            entity.Property(e => e.OwnaName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("owna_name");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.ParentName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("parent_name");
            entity.Property(e => e.ParentStatusId).HasColumnName("parent_status_id");
            entity.Property(e => e.StatusId).HasColumnName("status_id");
            entity.Property(e => e.StatusName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("status_name");
            entity.Property(e => e.SubFolderCount).HasColumnName("sub_folder_count");
        });

        modelBuilder.Entity<VwExecSummaryOfBill>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Exec_SummaryOfBills");

            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AdjustmentAllowanceText).HasMaxLength(30);
            entity.Property(e => e.BidBillId).HasColumnName("BidBillID");
            entity.Property(e => e.BillDesc)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.BillNo)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.BillNoDesc)
                .IsRequired()
                .HasMaxLength(272);
            entity.Property(e => e.Classification).HasMaxLength(10);
            entity.Property(e => e.ContractCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ContractDesc).HasMaxLength(350);
            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.ContractStatus)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Contract_Status");
            entity.Property(e => e.ContractStatusId).HasColumnName("ContractStatusID");
            entity.Property(e => e.ContractTitle)
                .IsRequired()
                .HasMaxLength(350);
            entity.Property(e => e.ContractorId).HasColumnName("ContractorID");
            entity.Property(e => e.ContractorName).HasMaxLength(120);
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.TinNo)
                .HasMaxLength(50)
                .HasColumnName("TIN_No");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<VwHcmEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_hcm_employee");

            entity.Property(e => e.DeptCode)
                .IsRequired()
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DeptDesc)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.EmpName)
                .HasMaxLength(152)
                .HasColumnName("emp_name");
            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Home).HasMaxLength(15);
            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.MaritalStatus).HasMaxLength(10);
            entity.Property(e => e.Mobile).HasMaxLength(15);
            entity.Property(e => e.Nationality).HasMaxLength(100);
            entity.Property(e => e.Number)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.Office).HasMaxLength(15);
            entity.Property(e => e.OtherNames).HasMaxLength(50);
            entity.Property(e => e.RegionCode)
                .IsRequired()
                .HasMaxLength(10);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.RegionName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Sex)
                .IsRequired()
                .HasMaxLength(6);
            entity.Property(e => e.Title).HasMaxLength(20);
        });

        modelBuilder.Entity<VwIdp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_idp");

            entity.Property(e => e.Approved).HasColumnName("approved");
            entity.Property(e => e.ApprovedAt).HasColumnName("approved_at");
            entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");
            entity.Property(e => e.ApprovedStatus)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("approved_status");
            entity.Property(e => e.ApproverName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("approver_name");
            entity.Property(e => e.Archived).HasColumnName("archived");
            entity.Property(e => e.BillDesc)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.BillNo)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.BoqId).HasColumnName("BoqID");
            entity.Property(e => e.ContractCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.ContractTitle)
                .IsRequired()
                .HasMaxLength(350);
            entity.Property(e => e.ContractorAddress)
                .HasMaxLength(150)
                .HasColumnName("contractor_address");
            entity.Property(e => e.ContractorId).HasColumnName("contractor_id");
            entity.Property(e => e.ContractorName)
                .HasMaxLength(120)
                .HasColumnName("contractor_name");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CumInt).HasColumnName("cum_int");
            entity.Property(e => e.CurrentBoqFk).HasColumnName("current_boq_fk");
            entity.Property(e => e.DelayIn)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("delay_in");
            entity.Property(e => e.DeptId).HasColumnName("Dept_ID");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.IdpDesc)
                .HasMaxLength(250)
                .HasColumnName("idp_desc");
            entity.Property(e => e.IdpId).HasColumnName("idp_id");
            entity.Property(e => e.IdpNamb).HasColumnName("idp_namb");
            entity.Property(e => e.IntOnly).HasColumnName("int_only");
            entity.Property(e => e.IntType)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("int_type");
            entity.Property(e => e.RegionCode)
                .IsRequired()
                .HasMaxLength(10);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.RegionName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Remarks)
                .HasMaxLength(450)
                .HasColumnName("remarks");
            entity.Property(e => e.RequestedAt).HasColumnName("requested_at");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(50)
                .HasColumnName("user_email");
            entity.Property(e => e.UserFullName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("user_full_name");
            entity.Property(e => e.UserId).HasColumnName("User_ID");
            entity.Property(e => e.UserId1).HasColumnName("userID");
            entity.Property(e => e.UserLogin)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("user_login");
            entity.Property(e => e.UserPhone)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("user_phone");
        });

        modelBuilder.Entity<VwIpc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ipc");

            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AdvanceAmount).HasColumnName("advance_amount");
            entity.Property(e => e.AdvanceBank)
                .IsRequired()
                .HasMaxLength(120)
                .HasColumnName("advance_bank");
            entity.Property(e => e.AdvanceBranch)
                .IsRequired()
                .HasMaxLength(120)
                .HasColumnName("advance_branch");
            entity.Property(e => e.AdvanceExpiryDate).HasColumnName("advance_expiry_date");
            entity.Property(e => e.AnetIncrement).HasColumnName("ANetIncrement");
            entity.Property(e => e.AnetTransfer).HasColumnName("ANetTransfer");
            entity.Property(e => e.AtotalIncrement).HasColumnName("ATotalIncrement");
            entity.Property(e => e.BnetIncrement).HasColumnName("BNetIncrement");
            entity.Property(e => e.BnetTransfer).HasColumnName("BNetTransfer");
            entity.Property(e => e.BoqFk).HasColumnName("Boq_FK");
            entity.Property(e => e.BtotalIncrement).HasColumnName("BTotalIncrement");
            entity.Property(e => e.CadditionalAdvances).HasColumnName("CAdditionalAdvances");
            entity.Property(e => e.CertCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.CertDesc)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.CertificateId).HasColumnName("CertificateID");
            entity.Property(e => e.ContractCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ContractFk).HasColumnName("Contract_FK");
            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.ContractTitle)
                .IsRequired()
                .HasMaxLength(350);
            entity.Property(e => e.ContractorName).HasMaxLength(120);
            entity.Property(e => e.CprevAdvances).HasColumnName("CPrevAdvances");
            entity.Property(e => e.CtotalAdvances).HasColumnName("CTotalAdvances");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.DcurrInterest).HasColumnName("DCurrInterest");
            entity.Property(e => e.DprevInterest).HasColumnName("DPrevInterest");
            entity.Property(e => e.DtotalInterest).HasColumnName("DTotalInterest");
            entity.Property(e => e.EcurrDamages).HasColumnName("ECurrDamages");
            entity.Property(e => e.EcurrSubContPayment).HasColumnName("ECurrSubContPayment");
            entity.Property(e => e.EdirectPayment).HasColumnName("EDirectPayment");
            entity.Property(e => e.EmobCurrRepay).HasColumnName("EMobCurrRepay");
            entity.Property(e => e.EmobPrevRepay).HasColumnName("EMobPrevRepay");
            entity.Property(e => e.EmobTotalRepay).HasColumnName("EMobTotalRepay");
            entity.Property(e => e.EplantCurrRepay).HasColumnName("EPlantCurrRepay");
            entity.Property(e => e.EplantPrevRepay).HasColumnName("EPlantPrevRepay");
            entity.Property(e => e.EplantTotalRepay).HasColumnName("EPlantTotalRepay");
            entity.Property(e => e.EprevDamages).HasColumnName("EPrevDamages");
            entity.Property(e => e.HplantAuthorized).HasColumnName("HPlantAuthorized");
            entity.Property(e => e.ImobAuthorized).HasColumnName("IMobAuthorized");
            entity.Property(e => e.Ipcdate)
                .HasColumnType("datetime")
                .HasColumnName("IPCDate");
            entity.Property(e => e.Ipcnumber)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("IPCnumber");
            entity.Property(e => e.JadvMobDeductedToDate).HasColumnName("JAdvMobDeductedToDate");
            entity.Property(e => e.JoutStandingMobTobePaid).HasColumnName("JOutStandingMobTobePaid");
            entity.Property(e => e.KoutstandingPlantTobePaid).HasColumnName("KOutstandingPlantTobePaid");
            entity.Property(e => e.KplantDeductedToDate).HasColumnName("KPlantDeductedToDate");
            entity.Property(e => e.Paf).HasColumnName("PAF");
            entity.Property(e => e.PlantAmount).HasColumnName("plant_amount");
            entity.Property(e => e.PlantBank)
                .IsRequired()
                .HasMaxLength(120)
                .HasColumnName("plant_bank");
            entity.Property(e => e.PlantBranch)
                .IsRequired()
                .HasMaxLength(120)
                .HasColumnName("plant_branch");
            entity.Property(e => e.PlantExpiryDate).HasColumnName("plant_expiry_date");
        });

        modelBuilder.Entity<VwIpcSubContractor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_IPC_SubContractor");

            entity.Property(e => e.BoqFk).HasColumnName("boq_FK");
            entity.Property(e => e.ContractFk).HasColumnName("contract_fk");
            entity.Property(e => e.ContractorId).HasColumnName("ContractorID");
            entity.Property(e => e.ContractorName).HasMaxLength(120);
            entity.Property(e => e.SubContractId).HasColumnName("SubContractID");
            entity.Property(e => e.SubContractPaymentId).HasColumnName("SubContractPaymentID");
        });

        modelBuilder.Entity<VwMessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_message");

            entity.Property(e => e.Author).HasColumnName("author");
            entity.Property(e => e.AuthorBlocked).HasColumnName("author_blocked");
            entity.Property(e => e.AuthorEmail)
                .HasMaxLength(50)
                .HasColumnName("author_email");
            entity.Property(e => e.AuthorId).HasColumnName("author_id");
            entity.Property(e => e.AuthorLogin)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("author_login");
            entity.Property(e => e.AuthorName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("author_name");
            entity.Property(e => e.AuthorPhone)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("author_phone");
            entity.Property(e => e.AuthorReceiveEmail).HasColumnName("author_receive_email");
            entity.Property(e => e.AuthorReceiveSms).HasColumnName("author_receive_sms");
            entity.Property(e => e.Brief)
                .IsUnicode(false)
                .HasColumnName("brief");
            entity.Property(e => e.Content)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("content");
            entity.Property(e => e.Emailed).HasColumnName("emailed");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Mode)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("mode");
            entity.Property(e => e.MsgCat)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("msgCat");
            entity.Property(e => e.MsgCatId).HasColumnName("msgCatID");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.Receiva).HasColumnName("receiva");
            entity.Property(e => e.ReceivaBlocked).HasColumnName("receiva_blocked");
            entity.Property(e => e.ReceivaEmail)
                .HasMaxLength(50)
                .HasColumnName("receiva_email");
            entity.Property(e => e.ReceivaId).HasColumnName("receiva_id");
            entity.Property(e => e.ReceivaLogin)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("receiva_login");
            entity.Property(e => e.ReceivaName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("receiva_name");
            entity.Property(e => e.ReceivaPhone)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("receiva_phone");
            entity.Property(e => e.ReceivaReceiveEmail).HasColumnName("receiva_receive_email");
            entity.Property(e => e.ReceivaReceiveSms).HasColumnName("receiva_receive_sms");
            entity.Property(e => e.ReplyDate)
                .HasColumnType("datetime")
                .HasColumnName("reply_date");
            entity.Property(e => e.ReplyId).HasColumnName("reply_id");
            entity.Property(e => e.SentDate)
                .HasColumnType("datetime")
                .HasColumnName("sent_date");
            entity.Property(e => e.SmsSent).HasColumnName("sms_sent");
            entity.Property(e => e.SmsTry).HasColumnName("sms_try");
            entity.Property(e => e.Subj)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("subj");
            entity.Property(e => e.TrialCount).HasColumnName("trial_count");
            entity.Property(e => e.Viewed).HasColumnName("viewed");
            entity.Property(e => e.ViewedDate)
                .HasColumnType("datetime")
                .HasColumnName("viewed_date");
        });

        modelBuilder.Entity<VwPortalTab>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_portal_tab");

            entity.Property(e => e.GroupActive).HasColumnName("group_active");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.GroupName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("group_name");
            entity.Property(e => e.GroupOrdar).HasColumnName("group_ordar");
            entity.Property(e => e.Hierar)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("hierar");
            entity.Property(e => e.HovaAlt)
                .HasMaxLength(300)
                .HasColumnName("hova_alt");
            entity.Property(e => e.HovaId).HasColumnName("hova_id");
            entity.Property(e => e.HovaName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("hova_name");
            entity.Property(e => e.HovaUrl)
                .IsRequired()
                .HasMaxLength(300)
                .HasColumnName("hova_url");
            entity.Property(e => e.IconAlt)
                .HasMaxLength(300)
                .HasColumnName("icon_alt");
            entity.Property(e => e.IconId).HasColumnName("icon_id");
            entity.Property(e => e.IconName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("icon_name");
            entity.Property(e => e.IconUrl)
                .IsRequired()
                .HasMaxLength(300)
                .HasColumnName("icon_url");
            entity.Property(e => e.ModuleId).HasColumnName("module_id");
            entity.Property(e => e.ModuleName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("module_name");
            entity.Property(e => e.ModuleUrl)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("module_url");
            entity.Property(e => e.ParentActive).HasColumnName("parent_active");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.ParentName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("parent_name");
            entity.Property(e => e.ParentOrdar).HasColumnName("parent_ordar");
            entity.Property(e => e.PortalActive).HasColumnName("portal_active");
            entity.Property(e => e.PortalId).HasColumnName("portal_id");
            entity.Property(e => e.PortalName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("portal_name");
            entity.Property(e => e.TabActive).HasColumnName("tab_active");
            entity.Property(e => e.TabDisc)
                .HasMaxLength(300)
                .HasColumnName("tab_disc");
            entity.Property(e => e.TabId).HasColumnName("tab_id");
            entity.Property(e => e.TabName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("tab_name");
            entity.Property(e => e.TabOrdar).HasColumnName("tab_ordar");
        });

        modelBuilder.Entity<VwPortalTabGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_portal_tab_group");

            entity.Property(e => e.GroupActive).HasColumnName("group_active");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.GroupName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("group_name");
            entity.Property(e => e.GroupOrdar).HasColumnName("group_ordar");
            entity.Property(e => e.HovaAlt)
                .HasMaxLength(300)
                .HasColumnName("hova_alt");
            entity.Property(e => e.HovaId).HasColumnName("hova_id");
            entity.Property(e => e.HovaName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("hova_name");
            entity.Property(e => e.HovaUrl)
                .IsRequired()
                .HasMaxLength(300)
                .HasColumnName("hova_url");
            entity.Property(e => e.IconAlt)
                .HasMaxLength(300)
                .HasColumnName("icon_alt");
            entity.Property(e => e.IconId).HasColumnName("icon_id");
            entity.Property(e => e.IconName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("icon_name");
            entity.Property(e => e.IconUrl)
                .IsRequired()
                .HasMaxLength(300)
                .HasColumnName("icon_url");
            entity.Property(e => e.PortalActive).HasColumnName("portal_active");
            entity.Property(e => e.PortalId).HasColumnName("portal_id");
            entity.Property(e => e.PortalName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("portal_name");
            entity.Property(e => e.TabActive).HasColumnName("tab_active");
            entity.Property(e => e.TabDisc)
                .HasMaxLength(300)
                .HasColumnName("tab_disc");
            entity.Property(e => e.TabId).HasColumnName("tab_id");
            entity.Property(e => e.TabName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("tab_name");
            entity.Property(e => e.TabOrdar).HasColumnName("tab_ordar");
        });

        modelBuilder.Entity<VwPortalUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_portal_user");

            entity.Property(e => e.Agreed).HasColumnName("agreed");
            entity.Property(e => e.Blocked).HasColumnName("blocked");
            entity.Property(e => e.DelegatedFk).HasColumnName("Delegated_FK");
            entity.Property(e => e.DeptCode)
                .IsRequired()
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DeptDesc)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DeptFk).HasColumnName("dept_fk");
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.FailureCount).HasColumnName("failure_count");
            entity.Property(e => e.FirstPwdChangedDate)
                .HasColumnType("datetime")
                .HasColumnName("first_pwd_changed_date");
            entity.Property(e => e.HodUserFk).HasColumnName("HodUser_FK");
            entity.Property(e => e.LastPwdUpdate)
                .HasColumnType("datetime")
                .HasColumnName("last_pwd_update");
            entity.Property(e => e.NextPwdUpdate)
                .HasColumnType("datetime")
                .HasColumnName("next_pwd_update");
            entity.Property(e => e.PwdExpires).HasColumnName("pwd_expires");
            entity.Property(e => e.ReceiveEmail).HasColumnName("receive_email");
            entity.Property(e => e.ReceiveSms).HasColumnName("receive_sms");
            entity.Property(e => e.RegionCode)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("Region_code");
            entity.Property(e => e.RegionFk).HasColumnName("Region_FK");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.RegionName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Region_name");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.RoleName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("role_name");
            entity.Property(e => e.StatusFk).HasColumnName("status_fk");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(50)
                .HasColumnName("user_email");
            entity.Property(e => e.UserFullName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("user_full_name");
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.UserLogin)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("user_login");
            entity.Property(e => e.UserPhone)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("user_phone");
            entity.Property(e => e.UserStatusAccess).HasColumnName("user_status_access");
            entity.Property(e => e.UserStatusId).HasColumnName("user_status_id");
            entity.Property(e => e.UserStatusInfo)
                .HasMaxLength(500)
                .HasColumnName("user_status_info");
            entity.Property(e => e.UserStatusName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("user_status_name");
            entity.Property(e => e.Userpwd)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("userpwd");
        });

        modelBuilder.Entity<VwProgram>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_program");

            entity.Property(e => e.ProgramApproved).HasColumnName("program_approved");
            entity.Property(e => e.ProgramBen)
                .HasMaxLength(500)
                .HasColumnName("program_ben");
            entity.Property(e => e.ProgramCode)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("program_code");
            entity.Property(e => e.ProgramCoverageId).HasColumnName("program_coverage_id");
            entity.Property(e => e.ProgramCoverageName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("program_coverage_name");
            entity.Property(e => e.ProgramCreatedAt).HasColumnName("program_created_at");
            entity.Property(e => e.ProgramDesc)
                .HasMaxLength(500)
                .HasColumnName("program_desc");
            entity.Property(e => e.ProgramEndDate).HasColumnName("program_end_date");
            entity.Property(e => e.ProgramId).HasColumnName("program_id");
            entity.Property(e => e.ProgramName)
                .IsRequired()
                .HasMaxLength(400)
                .HasColumnName("program_name");
            entity.Property(e => e.ProgramObj)
                .HasMaxLength(500)
                .HasColumnName("program_obj");
            entity.Property(e => e.ProgramStartDate).HasColumnName("program_start_date");
            entity.Property(e => e.ProgramTypeId).HasColumnName("program_type_id");
            entity.Property(e => e.ProgramTypeName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("program_type_name");
            entity.Property(e => e.ProgramUserId).HasColumnName("program_user_id");
        });

        modelBuilder.Entity<VwProject>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_project");

            entity.Property(e => e.ProgramCode)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("program_code");
            entity.Property(e => e.ProgramId).HasColumnName("program_id");
            entity.Property(e => e.ProgramName)
                .IsRequired()
                .HasMaxLength(400)
                .HasColumnName("program_name");
            entity.Property(e => e.ProjectApproved).HasColumnName("project_approved");
            entity.Property(e => e.ProjectCode)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("project_code");
            entity.Property(e => e.ProjectDesc)
                .IsRequired()
                .HasMaxLength(800)
                .HasColumnName("project_desc");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.ProjectName)
                .IsRequired()
                .HasMaxLength(400)
                .HasColumnName("project_name");
            entity.Property(e => e.ProjectTypeId).HasColumnName("project_type_id");
            entity.Property(e => e.ProjectTypeName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("project_type_name");
            entity.Property(e => e.ProjectUserId).HasColumnName("project_user_id");
        });

        modelBuilder.Entity<VwPv>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_pv");

            entity.Property(e => e.AccountCurrency)
                .IsRequired()
                .HasMaxLength(5);
            entity.Property(e => e.AccountDesc)
                .IsRequired()
                .HasMaxLength(143);
            entity.Property(e => e.AccountName)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.AccountNumber)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.Approved).HasColumnName("approved");
            entity.Property(e => e.ApprovedAt).HasColumnName("approved_at");
            entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");
            entity.Property(e => e.ApprovedText)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("approved_text");
            entity.Property(e => e.Archived).HasColumnName("archived");
            entity.Property(e => e.AssocCode).HasMaxLength(20);
            entity.Property(e => e.BankName)
                .IsRequired()
                .HasMaxLength(120);
            entity.Property(e => e.BillDesc)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.BillNo)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.BoqId).HasColumnName("BoqID");
            entity.Property(e => e.BranchName)
                .IsRequired()
                .HasMaxLength(120);
            entity.Property(e => e.ContractCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.ContractTitle)
                .IsRequired()
                .HasMaxLength(350);
            entity.Property(e => e.ContractorBankId).HasColumnName("ContractorBankID");
            entity.Property(e => e.ContractorName).HasMaxLength(120);
            entity.Property(e => e.DeptId).HasColumnName("Dept_ID");
            entity.Property(e => e.DeptName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Dept_Name");
            entity.Property(e => e.GrossWords)
                .HasMaxLength(550)
                .IsUnicode(false);
            entity.Property(e => e.Ipcdate)
                .HasColumnType("datetime")
                .HasColumnName("IPCDate");
            entity.Property(e => e.Ipcnumber)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("IPCnumber");
            entity.Property(e => e.Lad).HasColumnName("LAD");
            entity.Property(e => e.NetWords)
                .HasMaxLength(550)
                .IsUnicode(false);
            entity.Property(e => e.PaymentDesc).HasMaxLength(300);
            entity.Property(e => e.PreparerId).HasColumnName("Preparer_id");
            entity.Property(e => e.PreparerName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("Preparer_name");
            entity.Property(e => e.PvId).HasColumnName("pv_id");
            entity.Property(e => e.Pvdate).HasColumnName("PVDate");
            entity.Property(e => e.PvgrossAmount).HasColumnName("PVGrossAmount");
            entity.Property(e => e.PvnetAmount).HasColumnName("PVNetAmount");
            entity.Property(e => e.Pvnumber)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("PVNumber");
            entity.Property(e => e.Pvremarks)
                .IsRequired()
                .HasMaxLength(120)
                .HasColumnName("PVRemarks");
            entity.Property(e => e.Pvretention).HasColumnName("PVRetention");
            entity.Property(e => e.PvretentionRecovered).HasColumnName("PVRetentionRecovered");
            entity.Property(e => e.PvsubContractors).HasColumnName("PVSubContractors");
            entity.Property(e => e.StatusId).HasColumnName("Status_ID");
            entity.Property(e => e.UserFullName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("user_full_name");
            entity.Property(e => e.UserId).HasColumnName("User_ID");
        });

        modelBuilder.Entity<VwRdRoadInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Rd_RoadInformation");

            entity.Property(e => e.District).HasMaxLength(3);
            entity.Property(e => e.FncClass)
                .IsRequired()
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FNC_Class");
            entity.Property(e => e.Fnode).HasMaxLength(20);
            entity.Property(e => e.Fvilla)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("FVilla");
            entity.Property(e => e.RdId)
                .HasMaxLength(20)
                .HasColumnName("RD_ID");
            entity.Property(e => e.RdLength).HasColumnName("RD_Length");
            entity.Property(e => e.Region).HasMaxLength(2);
            entity.Property(e => e.RoadDescription).HasMaxLength(500);
            entity.Property(e => e.RoadId).HasColumnName("RoadID");
            entity.Property(e => e.RoadName)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.RoadNumber)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.Tnode).HasMaxLength(20);
            entity.Property(e => e.Tvilla)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("TVilla");
        });

        modelBuilder.Entity<VwStandardActivity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_standard_activity");

            entity.Property(e => e.ActActive).HasColumnName("act_active");
            entity.Property(e => e.ActCode)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("act_code");
            entity.Property(e => e.ActId).HasColumnName("act_id");
            entity.Property(e => e.ActName)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("act_name");
            entity.Property(e => e.ActOrder)
                .HasMaxLength(4000)
                .HasColumnName("act_order");
            entity.Property(e => e.ActUnit)
                .HasMaxLength(20)
                .HasColumnName("act_unit");
            entity.Property(e => e.MajorActive).HasColumnName("major_active");
            entity.Property(e => e.MajorCode)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("major_code");
            entity.Property(e => e.MajorId).HasColumnName("major_id");
            entity.Property(e => e.MajorName)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("major_name");
            entity.Property(e => e.ProgressActive).HasColumnName("progress_active");
            entity.Property(e => e.ProgressCat)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("progress_cat");
            entity.Property(e => e.ProgressCode)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("progress_code");
            entity.Property(e => e.ProgressDesc)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("progress_desc");
            entity.Property(e => e.ProgressId).HasColumnName("progress_id");
            entity.Property(e => e.ProgressName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("progress_name");
            entity.Property(e => e.ProgressRemarks)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("progress_remarks");
            entity.Property(e => e.ProgressUnit)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("progress_unit");
            entity.Property(e => e.WeitCode)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnName("weit_code");
            entity.Property(e => e.WeitId).HasColumnName("weit_id");
            entity.Property(e => e.WeitName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("weit_name");
        });

        modelBuilder.Entity<VwStandardActivityEx>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_standard_activity_Ex");

            entity.Property(e => e.ActActive).HasColumnName("act_active");
            entity.Property(e => e.ActCode)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("act_code");
            entity.Property(e => e.ActId).HasColumnName("act_id");
            entity.Property(e => e.ActName)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("act_name");
            entity.Property(e => e.ActOrder)
                .HasMaxLength(4000)
                .HasColumnName("act_order");
            entity.Property(e => e.ActUnit)
                .HasMaxLength(20)
                .HasColumnName("act_unit");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ParentActive).HasColumnName("parent_active");
            entity.Property(e => e.ParentCode)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("parent_code");
            entity.Property(e => e.ParentDesc)
                .IsRequired()
                .HasMaxLength(362)
                .HasColumnName("parent_desc");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.ParentName)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("parent_name");
        });

        modelBuilder.Entity<VwStandardProgress>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_standard_progress");

            entity.Property(e => e.ProgressActive).HasColumnName("progress_active");
            entity.Property(e => e.ProgressCat)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("progress_cat");
            entity.Property(e => e.ProgressCatActive).HasColumnName("progress_cat_active");
            entity.Property(e => e.ProgressCatId).HasColumnName("progress_cat_id");
            entity.Property(e => e.ProgressCatName)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("progress_cat_name");
            entity.Property(e => e.ProgressCatOrda).HasColumnName("progress_cat_orda");
            entity.Property(e => e.ProgressCatRemarks)
                .HasMaxLength(350)
                .HasColumnName("progress_cat_remarks");
            entity.Property(e => e.ProgressCode)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("progress_code");
            entity.Property(e => e.ProgressDesc)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("progress_desc");
            entity.Property(e => e.ProgressId).HasColumnName("progress_id");
            entity.Property(e => e.ProgressName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("progress_name");
            entity.Property(e => e.ProgressRemarks)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("progress_remarks");
            entity.Property(e => e.ProgressUnit)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("progress_unit");
        });

        modelBuilder.Entity<VwStandarddaywork>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_standarddaywork");

            entity.Property(e => e.CatCode)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("cat_code");
            entity.Property(e => e.CatCodeName)
                .IsRequired()
                .HasMaxLength(362)
                .HasColumnName("cat_code_name");
            entity.Property(e => e.CatId).HasColumnName("cat_id");
            entity.Property(e => e.CatName)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("cat_name");
            entity.Property(e => e.DayWorkCode)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("day_work_code");
            entity.Property(e => e.DayWorkCodeName)
                .IsRequired()
                .HasMaxLength(362)
                .HasColumnName("day_work_code_name");
            entity.Property(e => e.DayWorkId).HasColumnName("day_work_id");
            entity.Property(e => e.DayWorkName)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("day_work_name");
            entity.Property(e => e.DayWorkUnit)
                .HasMaxLength(20)
                .HasColumnName("day_work_unit");
        });

        modelBuilder.Entity<VwTicket>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ticket");

            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.CategoryName)
                .IsRequired()
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("category_name");
            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Content)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("content");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CreaterBlocked).HasColumnName("creater_blocked");
            entity.Property(e => e.CreaterEmail)
                .HasMaxLength(50)
                .HasColumnName("creater_email");
            entity.Property(e => e.CreaterName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("creater_name");
            entity.Property(e => e.CreaterPhone)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("creater_phone");
            entity.Property(e => e.CreaterReceiveEmail).HasColumnName("creater_receive_email");
            entity.Property(e => e.CreaterReceiveSms).HasColumnName("creater_receive_sms");
            entity.Property(e => e.Editable).HasColumnName("editable");
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EmailMsg)
                .IsRequired()
                .HasMaxLength(450)
                .IsUnicode(false)
                .HasColumnName("email_msg");
            entity.Property(e => e.OwnerBlocked).HasColumnName("owner_blocked");
            entity.Property(e => e.OwnerEmail)
                .HasMaxLength(50)
                .HasColumnName("owner_email");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.OwnerName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("owner_name");
            entity.Property(e => e.OwnerPhone)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("owner_phone");
            entity.Property(e => e.OwnerReceiveEmail).HasColumnName("owner_receive_email");
            entity.Property(e => e.OwnerReceiveSms).HasColumnName("owner_receive_sms");
            entity.Property(e => e.Phone)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.PriorityId).HasColumnName("priority_id");
            entity.Property(e => e.PriorityName)
                .IsRequired()
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("priority_name");
            entity.Property(e => e.ReceivedAt).HasColumnName("received_at");
            entity.Property(e => e.SmsMsg)
                .IsRequired()
                .HasMaxLength(160)
                .IsUnicode(false)
                .HasColumnName("sms_msg");
            entity.Property(e => e.StatusId).HasColumnName("status_id");
            entity.Property(e => e.StatusName)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("status_name");
            entity.Property(e => e.Subj)
                .IsRequired()
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("subj");
            entity.Property(e => e.SupportGroupExpiryDate).HasColumnName("support_group_expiry_date");
            entity.Property(e => e.SupportGroupId).HasColumnName("support_group_id");
            entity.Property(e => e.SupportGroupName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("support_group_name");
            entity.Property(e => e.TicketId).HasColumnName("ticket_id");
        });

        modelBuilder.Entity<VwTicketSupportGroupUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ticket_support_group_user");

            entity.Property(e => e.Blocked).HasColumnName("blocked");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(60);
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.GroupName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("group_name");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Phone)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.ReceiveEmail).HasColumnName("receive_email");
            entity.Property(e => e.ReceiveSms).HasColumnName("receive_sms");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Username)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<VwVo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_vo");

            entity.Property(e => e.AdditionDesc).HasMaxLength(250);
            entity.Property(e => e.ApprovedName)
                .IsRequired()
                .HasMaxLength(60);
            entity.Property(e => e.ApprovedText)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Archived).HasColumnName("archived");
            entity.Property(e => e.ContractCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.ContractTitle)
                .IsRequired()
                .HasMaxLength(350);
            entity.Property(e => e.DeptId).HasColumnName("Dept_ID");
            entity.Property(e => e.OmissionDesc).HasMaxLength(250);
            entity.Property(e => e.Remarks).HasMaxLength(350);
            entity.Property(e => e.RequestedReason)
                .IsRequired()
                .HasMaxLength(350);
            entity.Property(e => e.UserFullName)
                .HasMaxLength(60)
                .HasColumnName("user_full_name");
            entity.Property(e => e.UserId).HasColumnName("User_ID");
            entity.Property(e => e.UserLogin)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("user_login");
            entity.Property(e => e.VNo)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("v_no");
            entity.Property(e => e.VoId).HasColumnName("vo_id");
        });

        modelBuilder.Entity<VwVoVoBaseInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_vo_voBase_info");

            entity.Property(e => e.AssemblyId).HasColumnName("AssemblyID");
            entity.Property(e => e.AssemblyName)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.BaseDesc)
                .IsRequired()
                .HasMaxLength(243);
            entity.Property(e => e.BaseNo)
                .IsRequired()
                .HasMaxLength(60);
            entity.Property(e => e.BaseTitle)
                .IsRequired()
                .HasMaxLength(180);
            entity.Property(e => e.BidBaseId).HasColumnName("BidBaseID");
            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.CatName)
                .IsRequired()
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.ContractTypeId).HasColumnName("contract_type_id");
            entity.Property(e => e.ContractTypeName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("contract_type_name");
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.RegionName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.RoadId).HasColumnName("RoadID");
            entity.Property(e => e.RoadName)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.RoadNumber)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.VoBaseId).HasColumnName("voBaseID");
            entity.Property(e => e.VoId).HasColumnName("vo_id");
        });

        modelBuilder.Entity<VwVoext>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_voext");

            entity.Property(e => e.Approved).HasColumnName("approved");
            entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");
            entity.Property(e => e.ApprovedDate).HasColumnName("approved_date");
            entity.Property(e => e.ApprovedState)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("approved_state");
            entity.Property(e => e.ApproverName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("approver_name");
            entity.Property(e => e.Archived).HasColumnName("archived");
            entity.Property(e => e.CoNam).HasColumnName("co_nam");
            entity.Property(e => e.CoStart).HasColumnName("co_start");
            entity.Property(e => e.CompDate).HasColumnName("comp_date");
            entity.Property(e => e.ContractCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ContractFk).HasColumnName("contract_fk");
            entity.Property(e => e.ContractTitle)
                .IsRequired()
                .HasMaxLength(350);
            entity.Property(e => e.ContractorId).HasColumnName("ContractorID");
            entity.Property(e => e.ContractorName).HasMaxLength(120);
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DeptCode)
                .IsRequired()
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DeptDesc)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DeptId).HasColumnName("dept_id");
            entity.Property(e => e.Dur).HasColumnName("dur");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Manager)
                .IsRequired()
                .HasMaxLength(60);
            entity.Property(e => e.ManagerFk).HasColumnName("Manager_FK");
            entity.Property(e => e.NewDate).HasColumnName("new_date");
            entity.Property(e => e.NoNam).HasColumnName("no_nam");
            entity.Property(e => e.NoStart).HasColumnName("no_start");
            entity.Property(e => e.Reason)
                .IsRequired()
                .HasMaxLength(350)
                .HasColumnName("reason");
            entity.Property(e => e.Remarks)
                .HasMaxLength(350)
                .HasColumnName("remarks");
            entity.Property(e => e.ReqDate).HasColumnName("req_date");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(50)
                .HasColumnName("user_email");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UserInfo)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("user_info");
        });

        modelBuilder.Entity<WebLink>(entity =>
        {
            entity.HasKey(e => e.LinkId);

            entity.Property(e => e.LinkId).HasColumnName("LinkID");
            entity.Property(e => e.LinkTitle)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.LinkUrl)
                .IsRequired()
                .HasMaxLength(350);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
