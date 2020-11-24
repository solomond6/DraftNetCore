using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DriverOnboarding.Models.DBModels
{
    public partial class gracelakemoovetestContext : DbContext
    {
        public gracelakemoovetestContext()
        {
        }

        public gracelakemoovetestContext(DbContextOptions<gracelakemoovetestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppApprovals> AppApprovals { get; set; }
        public virtual DbSet<AppApprovalsetup> AppApprovalsetup { get; set; }
        public virtual DbSet<AppAssemblies> AppAssemblies { get; set; }
        public virtual DbSet<AppBatchinfo> AppBatchinfo { get; set; }
        public virtual DbSet<AppBatchruninfo> AppBatchruninfo { get; set; }
        public virtual DbSet<AppBranch> AppBranch { get; set; }
        public virtual DbSet<AppCompanies> AppCompanies { get; set; }
        public virtual DbSet<AppCompanyInfo> AppCompanyInfo { get; set; }
        public virtual DbSet<AppDatabaselog> AppDatabaselog { get; set; }
        public virtual DbSet<AppDatabaselogsetup> AppDatabaselogsetup { get; set; }
        public virtual DbSet<AppDocumenthandling> AppDocumenthandling { get; set; }
        public virtual DbSet<AppDocumenthandlingdocuments> AppDocumenthandlingdocuments { get; set; }
        public virtual DbSet<AppEntitypermissions> AppEntitypermissions { get; set; }
        public virtual DbSet<AppFailedlogins> AppFailedlogins { get; set; }
        public virtual DbSet<AppFieldpermissions> AppFieldpermissions { get; set; }
        public virtual DbSet<AppFormcontrolpermissions> AppFormcontrolpermissions { get; set; }
        public virtual DbSet<AppLicense> AppLicense { get; set; }
        public virtual DbSet<AppNavigationpermissions> AppNavigationpermissions { get; set; }
        public virtual DbSet<AppNumbersequences> AppNumbersequences { get; set; }
        public virtual DbSet<AppOnlineusers> AppOnlineusers { get; set; }
        public virtual DbSet<AppPermissiongrouppermissions> AppPermissiongrouppermissions { get; set; }
        public virtual DbSet<AppPermissiongroups> AppPermissiongroups { get; set; }
        public virtual DbSet<AppPermissions> AppPermissions { get; set; }
        public virtual DbSet<AppPrintarchive> AppPrintarchive { get; set; }
        public virtual DbSet<AppPrintarchivedata> AppPrintarchivedata { get; set; }
        public virtual DbSet<AppQueries> AppQueries { get; set; }
        public virtual DbSet<AppRecordlevelsecuritypermissiongroupassignments> AppRecordlevelsecuritypermissiongroupassignments { get; set; }
        public virtual DbSet<AppReportredirection> AppReportredirection { get; set; }
        public virtual DbSet<AppRunnablepermissions> AppRunnablepermissions { get; set; }
        public virtual DbSet<AppSavedreports> AppSavedreports { get; set; }
        public virtual DbSet<AppSystemparameters> AppSystemparameters { get; set; }
        public virtual DbSet<AppUseralerts> AppUseralerts { get; set; }
        public virtual DbSet<AppUseralertsetup> AppUseralertsetup { get; set; }
        public virtual DbSet<AppUserbrowserfingerprinthashes> AppUserbrowserfingerprinthashes { get; set; }
        public virtual DbSet<AppUserlogintokens> AppUserlogintokens { get; set; }
        public virtual DbSet<AppUserpermissiongroups> AppUserpermissiongroups { get; set; }
        public virtual DbSet<AppUsers> AppUsers { get; set; }
        public virtual DbSet<AppUsersettings> AppUsersettings { get; set; }
        public virtual DbSet<AppWebservicepermissions> AppWebservicepermissions { get; set; }
        public virtual DbSet<Applicantfingerprintdata> Applicantfingerprintdata { get; set; }
        public virtual DbSet<Applicationpassports> Applicationpassports { get; set; }
        public virtual DbSet<Applicationresultremark> Applicationresultremark { get; set; }
        public virtual DbSet<Applications> Applications { get; set; }
        public virtual DbSet<Autoscheduleexam> Autoscheduleexam { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<Bankdetails> Bankdetails { get; set; }
        public virtual DbSet<Batches> Batches { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Dashboardreports> Dashboardreports { get; set; }
        public virtual DbSet<Dispatch> Dispatch { get; set; }
        public virtual DbSet<Dispatchoperationalarea> Dispatchoperationalarea { get; set; }
        public virtual DbSet<Dispatchschedule> Dispatchschedule { get; set; }
        public virtual DbSet<Dispatchscheduleparameters> Dispatchscheduleparameters { get; set; }
        public virtual DbSet<Driverapprovalhistory> Driverapprovalhistory { get; set; }
        public virtual DbSet<Driverdocuments> Driverdocuments { get; set; }
        public virtual DbSet<Driverdocumenttypes> Driverdocumenttypes { get; set; }
        public virtual DbSet<Driverparameter> Driverparameter { get; set; }
        public virtual DbSet<Driverschemes> Driverschemes { get; set; }
        public virtual DbSet<Examinationcategories> Examinationcategories { get; set; }
        public virtual DbSet<Examinationexaminationvenues> Examinationexaminationvenues { get; set; }
        public virtual DbSet<Examinationquestionoptions> Examinationquestionoptions { get; set; }
        public virtual DbSet<Examinationquestions> Examinationquestions { get; set; }
        public virtual DbSet<Examinations> Examinations { get; set; }
        public virtual DbSet<Examinationschedulecapturedimages> Examinationschedulecapturedimages { get; set; }
        public virtual DbSet<Examinationschedulecategories> Examinationschedulecategories { get; set; }
        public virtual DbSet<Examinationschedulequestionoptions> Examinationschedulequestionoptions { get; set; }
        public virtual DbSet<Examinationschedulequestions> Examinationschedulequestions { get; set; }
        public virtual DbSet<Examinationschedules> Examinationschedules { get; set; }
        public virtual DbSet<Examinationsubjects> Examinationsubjects { get; set; }
        public virtual DbSet<Examinationvenues> Examinationvenues { get; set; }
        public virtual DbSet<Guarantordetails> Guarantordetails { get; set; }
        public virtual DbSet<Guarantordocuments> Guarantordocuments { get; set; }
        public virtual DbSet<Guarantordocumenttypes> Guarantordocumenttypes { get; set; }
        public virtual DbSet<Guarantorverificationitem> Guarantorverificationitem { get; set; }
        public virtual DbSet<Lcda> Lcda { get; set; }
        public virtual DbSet<Localgovernments> Localgovernments { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<Tempdispatchschedule> Tempdispatchschedule { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<Testquestion> Testquestion { get; set; }
        public virtual DbSet<Testresult> Testresult { get; set; }
        public virtual DbSet<Testschedule> Testschedule { get; set; }
        public virtual DbSet<Verificationitem> Verificationitem { get; set; }
        public virtual DbSet<Verificationparameters> Verificationparameters { get; set; }
        public virtual DbSet<Verificationresult> Verificationresult { get; set; }
        public virtual DbSet<Verificationresultimages> Verificationresultimages { get; set; }
        public virtual DbSet<Verificationresultsapproval> Verificationresultsapproval { get; set; }
        public virtual DbSet<Verifiedbankaccounts> Verifiedbankaccounts { get; set; }
        public virtual DbSet<Verifiedbvns> Verifiedbvns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=localhost;Port=3305;User=root;Database=gracelakemoovetest");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppApprovals>(entity =>
            {
                entity.ToTable("app_approvals");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.ApprovalSetupDetailId, e.Company, e.Deleted })
                    .HasName("ApprovalSetupDetailID");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.EntityName, e.CreatedBy, e.CreatedDateTime, e.Company, e.Deleted })
                    .HasName("Approver");

                entity.HasIndex(e => new { e.EntityName, e.CreatedDateTime, e.CreatedBy, e.Company, e.Deleted })
                    .HasName("ApprovedDateTime");

                entity.HasIndex(e => new { e.EntityName, e.RecordId, e.ApprovalName, e.Company, e.Deleted })
                    .HasName("ApprovalName");

                entity.HasIndex(e => new { e.EntityName, e.RecordId, e.ApprovalSno, e.Company, e.Deleted })
                    .HasName("ApprovalSNo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovalName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ApprovalSetupDetailId)
                    .HasColumnName("ApprovalSetupDetailID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ApprovalSno)
                    .HasColumnName("ApprovalSNo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ApprovalStatus)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ApprovalStatusReason)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<AppApprovalsetup>(entity =>
            {
                entity.ToTable("app_approvalsetup");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.EntityName, e.ApprovalName, e.Company, e.Deleted })
                    .HasName("ApprovalName");

                entity.HasIndex(e => new { e.EntityName, e.ApprovalSno, e.Company, e.Deleted })
                    .HasName("ApprovalSNo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovalName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ApprovalSno)
                    .HasColumnName("ApprovalSNo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ApproverUsersQuery)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AutoApprovalReason)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.AutoApprovalStatus)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AutoApprove)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.EligigleRecordsQuery)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<AppAssemblies>(entity =>
            {
                entity.ToTable("app_assemblies");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.AssemblyName, e.MachineName, e.Deleted })
                    .HasName("AssemblyName")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssemblyName)
                    .IsRequired()
                    .HasColumnType("varchar(512)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.ReportFileLocation)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.ViewFileLocation)
                    .IsRequired()
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<AppBatchinfo>(entity =>
            {
                entity.ToTable("app_batchinfo");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.NextProposedRunDateTime, e.Company, e.Deleted })
                    .HasName("NextProposedRunDateTime");

                entity.HasIndex(e => new { e.ProposedStartDateTime, e.Company, e.Deleted })
                    .HasName("ProposedStartDateTime");

                entity.HasIndex(e => new { e.RunnableClassName, e.Company, e.Deleted })
                    .HasName("RunnableClassName");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Alerts)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.LastRunDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.MaxRecurrenceCount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.NextProposedRunDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.ProposedStartDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.RecurrenceCount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RecurrencePeriod)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecurrencePeriodGap)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RunnableCaption)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RunnableClassName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SerializedObject).IsRequired();
            });

            modelBuilder.Entity<AppBatchruninfo>(entity =>
            {
                entity.ToTable("app_batchruninfo");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.ActualStartDateTime, e.Deleted })
                    .HasName("ActualStartDateTime");

                entity.HasIndex(e => new { e.BatchInfoId, e.Deleted })
                    .HasName("BatchInfoID");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Pid, e.Deleted })
                    .HasName("PID");

                entity.HasIndex(e => new { e.ProposedStartDateTime, e.Deleted })
                    .HasName("ProposedStartDateTime");

                entity.HasIndex(e => new { e.RunnableClassName, e.Deleted })
                    .HasName("RunnableClassName");

                entity.HasIndex(e => new { e.Status, e.Deleted })
                    .HasName("Status");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualStartDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.BatchInfoId)
                    .HasColumnName("BatchInfoID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.EndDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.ExitCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.InfologData).IsRequired();

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Pid)
                    .HasColumnName("PID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PrintArchiveId)
                    .HasColumnName("PrintArchiveID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Progress)
                    .HasColumnType("decimal(64,30)")
                    .HasDefaultValueSql("'0.000000000000000000000000000000'");

                entity.Property(e => e.ProposedStartDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.RunnableCaption)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RunnableClassName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<AppBranch>(entity =>
            {
                entity.ToTable("app_branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.BranchId, e.Company, e.Deleted })
                    .HasName("BranchID")
                    .IsUnique();

                entity.HasIndex(e => new { e.Name, e.Company, e.Deleted })
                    .HasName("Name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("BranchID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<AppCompanies>(entity =>
            {
                entity.ToTable("app_companies");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.CompanyId, e.Deleted })
                    .HasName("CompanyID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<AppCompanyInfo>(entity =>
            {
                entity.ToTable("app_company_info");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.CompanyId, e.Deleted })
                    .HasName("CompanyID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.LogoPath)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.Smtphost)
                    .IsRequired()
                    .HasColumnName("SMTPHost")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SmtpoutgoingEmail)
                    .IsRequired()
                    .HasColumnName("SMTPOutgoingEmail")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SmtpoutgoingEmailName)
                    .IsRequired()
                    .HasColumnName("SMTPOutgoingEmailName")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Smtppassword)
                    .IsRequired()
                    .HasColumnName("SMTPPassword")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Smtpport)
                    .HasColumnName("SMTPPort")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Smtpusername)
                    .IsRequired()
                    .HasColumnName("SMTPUsername")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UseSslforSmtp)
                    .HasColumnName("UseSSLForSMTP")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<AppDatabaselog>(entity =>
            {
                entity.ToTable("app_databaselog");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.CreatedDateTime, e.Company, e.Deleted })
                    .HasName("CreatedDateTime");

                entity.HasIndex(e => new { e.EntityId, e.Company, e.Deleted })
                    .HasName("EntityID");

                entity.HasIndex(e => new { e.EntityName, e.EntityId, e.LogType, e.Company, e.Deleted })
                    .HasName("LogTypeIndex");

                entity.HasIndex(e => new { e.EntityName, e.EntityId, e.CreatedBy, e.CreatedDateTime, e.Company, e.Deleted })
                    .HasName("MainIndex");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.EntityId)
                    .HasColumnName("EntityID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LogType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<AppDatabaselogsetup>(entity =>
            {
                entity.ToTable("app_databaselogsetup");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.EntityName, e.LogType, e.Field, e.Deleted })
                    .HasName("Index")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Field)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LogType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<AppDocumenthandling>(entity =>
            {
                entity.ToTable("app_documenthandling");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.EntityName, e.EntityId, e.Company, e.Deleted })
                    .HasName("Entity");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.EntityId)
                    .HasColumnName("EntityID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<AppDocumenthandlingdocuments>(entity =>
            {
                entity.ToTable("app_documenthandlingdocuments");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.DocumentHandlingId, e.Company, e.Deleted })
                    .HasName("DocumentHandlingID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.DocumentBlob).IsRequired();

                entity.Property(e => e.DocumentHandlingId)
                    .HasColumnName("DocumentHandlingID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<AppEntitypermissions>(entity =>
            {
                entity.ToTable("app_entitypermissions");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.DefaultFormPermission, e.Deleted })
                    .HasName("DefaultFormPermission");

                entity.HasIndex(e => new { e.EntityName, e.Deleted })
                    .HasName("EntityName")
                    .IsUnique();

                entity.HasIndex(e => new { e.Permission, e.Deleted })
                    .HasName("Permission");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DefaultFormPermission)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<AppFailedlogins>(entity =>
            {
                entity.ToTable("app_failedlogins");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Server, e.Deleted })
                    .HasName("Server");

                entity.HasIndex(e => new { e.ServerName, e.Deleted })
                    .HasName("ServerName");

                entity.HasIndex(e => new { e.Username, e.Deleted })
                    .HasName("Username");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ClientIp)
                    .IsRequired()
                    .HasColumnName("ClientIP")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.LogOnDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.Server)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<AppFieldpermissions>(entity =>
            {
                entity.ToTable("app_fieldpermissions");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Permission, e.Deleted })
                    .HasName("Permission");

                entity.HasIndex(e => new { e.EntityName, e.FieldName, e.Deleted })
                    .HasName("EntityField")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<AppFormcontrolpermissions>(entity =>
            {
                entity.ToTable("app_formcontrolpermissions");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Permission, e.Deleted })
                    .HasName("Permission");

                entity.HasIndex(e => new { e.FormName, e.OperationControlId, e.OperationId, e.Deleted })
                    .HasName("FormControl")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.FormName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OperationControlId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OperationId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OperationTitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<AppLicense>(entity =>
            {
                entity.ToTable("app_license");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.AssemblyName, e.Deleted })
                    .HasName("AssemblyName")
                    .IsUnique();

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssemblyName)
                    .IsRequired()
                    .HasColumnType("varchar(512)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.LicenseData)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<AppNavigationpermissions>(entity =>
            {
                entity.ToTable("app_navigationpermissions");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.NavigationId, e.Company, e.Deleted })
                    .HasName("NavigationID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.NavigationCaption)
                    .IsRequired()
                    .HasColumnType("varchar(1024)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NavigationId)
                    .IsRequired()
                    .HasColumnName("NavigationID")
                    .HasColumnType("varchar(500)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<AppNumbersequences>(entity =>
            {
                entity.ToTable("app_numbersequences");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.SequenceId, e.Company, e.Deleted })
                    .HasName("SequenceId")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.CurrentNum)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FetchAheadNumber)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HoldDuringTransaction)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.SequenceId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<AppOnlineusers>(entity =>
            {
                entity.ToTable("app_onlineusers");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Server, e.Deleted })
                    .HasName("Server");

                entity.HasIndex(e => new { e.ServerName, e.Deleted })
                    .HasName("ServerName");

                entity.HasIndex(e => new { e.Username, e.Deleted })
                    .HasName("Username");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ClientIp)
                    .IsRequired()
                    .HasColumnName("ClientIP")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.LogOnDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.Server)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<AppPermissiongrouppermissions>(entity =>
            {
                entity.ToTable("app_permissiongrouppermissions");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.GroupName, e.Permission, e.Deleted })
                    .HasName("GroupPermission")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessLevel)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<AppPermissiongroups>(entity =>
            {
                entity.ToTable("app_permissiongroups");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.AutoCreated, e.Deleted })
                    .HasName("AutoCreated");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.GroupName, e.Deleted })
                    .HasName("GroupName")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AutoCreated)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OnePerTime)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<AppPermissions>(entity =>
            {
                entity.ToTable("app_permissions");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Permission, e.Deleted })
                    .HasName("Permission")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<AppPrintarchive>(entity =>
            {
                entity.ToTable("app_printarchive");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.CreatedBy, e.Company, e.Deleted })
                    .HasName("Username");

                entity.HasIndex(e => new { e.ReportName, e.Company, e.Deleted })
                    .HasName("ReportName");

                entity.HasIndex(e => new { e.ReportTitle, e.Company, e.Deleted })
                    .HasName("ReportTitle");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ReportTitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<AppPrintarchivedata>(entity =>
            {
                entity.ToTable("app_printarchivedata");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.PrintArchiveId, e.Company, e.Deleted })
                    .HasName("PrintArchiveID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PrintArchiveId)
                    .HasColumnName("PrintArchiveID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PrintFileFormat)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.ReportBlob).IsRequired();
            });

            modelBuilder.Entity<AppQueries>(entity =>
            {
                entity.ToTable("app_queries");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.EntityName, e.Deleted })
                    .HasName("EntityName");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("Name")
                    .IsUnique();

                entity.HasIndex(e => new { e.UserQuery, e.Public, e.CreatedBy, e.Deleted })
                    .HasName("UserQueryPublic");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllowMerge)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OwnerForm)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Public)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.QueryBlob).IsRequired();

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.UserQuery)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<AppRecordlevelsecuritypermissiongroupassignments>(entity =>
            {
                entity.ToTable("app_recordlevelsecuritypermissiongroupassignments");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.PermissionGroup, e.RecordLevelSecurityName, e.Deleted })
                    .HasName("PermissionGroup")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.CrossComp)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PermissionGroup)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordLevelSecurityName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<AppReportredirection>(entity =>
            {
                entity.ToTable("app_reportredirection");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.OriginalReportLocation, e.Company, e.Deleted })
                    .HasName("OriginalReportLocation")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OriginalReportLocation)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.RedirectedReportLocation)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<AppRunnablepermissions>(entity =>
            {
                entity.ToTable("app_runnablepermissions");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.FormName, e.Deleted })
                    .HasName("FormName")
                    .IsUnique();

                entity.HasIndex(e => new { e.Permission, e.Deleted })
                    .HasName("Permission");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.FormName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<AppSavedreports>(entity =>
            {
                entity.ToTable("app_savedreports");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.CreatedBy, e.ReportTitle, e.Company, e.Deleted })
                    .HasName("Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Public)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.ReportTitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SerializedObject).IsRequired();
            });

            modelBuilder.Entity<AppSystemparameters>(entity =>
            {
                entity.ToTable("app_systemparameters");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcceptablePasswordDescription)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.AcceptablePasswordRegex)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DefaultDataFormAccessLevel)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DefaultEntityAccessLevel)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DefaultFieldAccessLevel)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DefaultFormAccessLevel)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DefaultMenuAccessLevel)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DefaultOperationAccessLevel)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DefaultReportAccessLevel)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DefaultRunnableAccessLevel)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.HelpSiteUrl)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.MaxLoginAttempts)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.TwoFactorTokenExpiryMinutes)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UseTwoFactorAuthentication)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserBrowserFingerprintExpiryMinutes)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserMustChangePasswordOnFirstLogin)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<AppUseralerts>(entity =>
            {
                entity.ToTable("app_useralerts");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Username, e.CreatedDateTime, e.Read, e.Deleted })
                    .HasName("UserDateTime");

                entity.HasIndex(e => new { e.Username, e.EntityName, e.EntityId, e.Deleted })
                    .HasName("UserEntity");

                entity.HasIndex(e => new { e.Username, e.Read, e.CreatedDateTime, e.Deleted })
                    .HasName("UserUnread");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AlertId)
                    .HasColumnName("AlertID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AlertTitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ChangeType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.EntityId)
                    .HasColumnName("EntityID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Read)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<AppUseralertsetup>(entity =>
            {
                entity.ToTable("app_useralertsetup");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.EntityName, e.ChangeType, e.EntityId, e.Field, e.Deleted })
                    .HasName("Index2");

                entity.HasIndex(e => new { e.CreatedBy, e.EntityName, e.ChangeType, e.EntityId, e.Field, e.Deleted })
                    .HasName("Index");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AlertTitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ChangeType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Criteria)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.EntityId)
                    .HasColumnName("EntityID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Field)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ForAllSubordinates)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<AppUserbrowserfingerprinthashes>(entity =>
            {
                entity.ToTable("app_userbrowserfingerprinthashes");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.User, e.ExpiryDateTime, e.Company, e.Deleted })
                    .HasName("User");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ExpiryDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.FingerprintHash)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<AppUserlogintokens>(entity =>
            {
                entity.ToTable("app_userlogintokens");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.User, e.ExpiryDateTime, e.Deleted })
                    .HasName("User");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ExpiryDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Used)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<AppUserpermissiongroups>(entity =>
            {
                entity.ToTable("app_userpermissiongroups");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Username, e.Deleted })
                    .HasName("Username");

                entity.HasIndex(e => new { e.Username, e.UserGroup, e.Deleted })
                    .HasName("UserGroup")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.UserGroup)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<AppUsers>(entity =>
            {
                entity.ToTable("app_users");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.DefaultCompany, e.Deleted })
                    .HasName("DefaultCompany");

                entity.HasIndex(e => new { e.PreviousCompany, e.Deleted })
                    .HasName("PreviousCompany");

                entity.HasIndex(e => new { e.Supervisor, e.Deleted })
                    .HasName("Supervisor");

                entity.HasIndex(e => new { e.Username, e.Deleted })
                    .HasName("Username")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CanChangeCompany)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DefaultCompany)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.Enabled)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ForceChangePassword)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LoginFailCount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PreviousCompany)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<AppUsersettings>(entity =>
            {
                entity.ToTable("app_usersettings");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Username, e.ObjectName, e.ParentObject, e.Deleted })
                    .HasName("ObjectKey")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ObjectName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ParentObject)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<AppWebservicepermissions>(entity =>
            {
                entity.ToTable("app_webservicepermissions");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.WebServiceName, e.Company, e.Deleted })
                    .HasName("WebServiceName")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.WebServiceName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Applicantfingerprintdata>(entity =>
            {
                entity.ToTable("applicantfingerprintdata");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.RefNo, e.Company, e.Deleted })
                    .HasName("RefNo")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.FingerprintImageData).IsRequired();

                entity.Property(e => e.FingerprintMinutiaeData).IsRequired();

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Applicationpassports>(entity =>
            {
                entity.ToTable("applicationpassports");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.RefNo, e.Company, e.Deleted })
                    .HasName("RefNo")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ImageType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PassportData).IsRequired();

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Applicationresultremark>(entity =>
            {
                entity.ToTable("applicationresultremark");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.ApplicationResultRemarkId, e.Company, e.Deleted })
                    .HasName("ApplicationResultRemarkID")
                    .IsUnique();

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationResultRemarkId)
                    .IsRequired()
                    .HasColumnName("ApplicationResultRemarkID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Default)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Applications>(entity =>
            {
                entity.ToTable("applications");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.ApplicationStatus, e.Company, e.Deleted })
                    .HasName("ApplicationStatus");

                entity.HasIndex(e => new { e.ApprovedScheme, e.Company, e.Deleted })
                    .HasName("ApprovedScheme");

                entity.HasIndex(e => new { e.AssignedVehicle, e.Company, e.Deleted })
                    .HasName("AssignedVehicle");

                entity.HasIndex(e => new { e.AssignedVehicleRegNo, e.Company, e.Deleted })
                    .HasName("AssignedVehicleRegNo");

                entity.HasIndex(e => new { e.Batch, e.Company, e.Deleted })
                    .HasName("Batch");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Bvn, e.Company, e.Deleted })
                    .HasName("BVN");

                entity.HasIndex(e => new { e.Drn, e.Company, e.Deleted })
                    .HasName("RefNo")
                    .IsUnique();

                entity.HasIndex(e => new { e.Email, e.Company, e.Deleted })
                    .HasName("Email");

                entity.HasIndex(e => new { e.Mobile, e.Company, e.Deleted })
                    .HasName("Mobile");

                entity.HasIndex(e => new { e.UberId, e.Company, e.Deleted })
                    .HasName("UberID");

                entity.HasIndex(e => new { e.VehicleAssignmentDateTime, e.Company, e.Deleted })
                    .HasName("VehicleAssignmentDateTime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.AddressOfNextOfKin)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.ApplicationStatus)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Approved)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ApprovedScheme)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AssignedVehicle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AssignedVehicleDetails)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AssignedVehicleRegNo)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Batch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Blacklist)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Bvn)
                    .IsRequired()
                    .HasColumnName("BVN")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.DriverLicenseExpiryDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DriverLicenseNumber)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Drn)
                    .IsRequired()
                    .HasColumnName("DRN")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EducationalLevel)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FirstApprovalRejectionReason)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LcdaofResidence)
                    .IsRequired()
                    .HasColumnName("LCDAofResidence")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LgaofResidence)
                    .IsRequired()
                    .HasColumnName("LGAofResidence")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LocalGovernmentArea)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MaidenName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.NameTitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Nationality)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NextOfKinName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NextOfKinOccupation)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NextOfKinRelationship)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NextOfKinTelephoneNumber)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PostalAddress)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Religion)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RemarkReason)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Scheduled)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Score)
                    .HasColumnType("decimal(64,30)")
                    .HasDefaultValueSql("'0.000000000000000000000000000000'");

                entity.Property(e => e.SecondApprovalRejectionReason)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.StateOfOrigin)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SubmittedForApproval)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UberId)
                    .IsRequired()
                    .HasColumnName("UberID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UberName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UberScore)
                    .HasColumnType("decimal(64,30)")
                    .HasDefaultValueSql("'0.000000000000000000000000000000'");

                entity.Property(e => e.VehicleAssignmentDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");
            });

            modelBuilder.Entity<Autoscheduleexam>(entity =>
            {
                entity.ToTable("autoscheduleexam");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.ExaminationId, e.Company, e.Deleted })
                    .HasName("Key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ExaminationId)
                    .HasColumnName("ExaminationID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("bank");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.BankId, e.Company, e.Deleted })
                    .HasName("BankID")
                    .IsUnique();

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.FlutterwaveCode, e.Company, e.Deleted })
                    .HasName("FlutterwaveCode")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankId)
                    .IsRequired()
                    .HasColumnName("BankID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.FlutterwaveCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Bankdetails>(entity =>
            {
                entity.ToTable("bankdetails");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Drn, e.Bank, e.AccountNumber, e.Company, e.Deleted })
                    .HasName("DRNACCNum")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Bank)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.Drn)
                    .IsRequired()
                    .HasColumnName("DRN")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Batches>(entity =>
            {
                entity.ToTable("batches");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.BatchId, e.Company, e.Deleted })
                    .HasName("BatchID")
                    .IsUnique();

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasColumnName("BatchID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.ToTable("countries");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.CountryId, e.Deleted })
                    .HasName("Country")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CountryId)
                    .IsRequired()
                    .HasColumnName("CountryID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Nationality)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Dashboardreports>(entity =>
            {
                entity.ToTable("dashboardreports");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Username, e.SavedReportId, e.Company, e.Deleted })
                    .HasName("Unique")
                    .IsUnique();

                entity.HasIndex(e => new { e.Username, e.Sno, e.Company, e.Deleted })
                    .HasName("Unique2")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.SavedReportId)
                    .HasColumnName("SavedReportID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Sno)
                    .HasColumnName("SNo")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Dispatch>(entity =>
            {
                entity.ToTable("dispatch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.DispatchId, e.Company, e.Deleted })
                    .HasName("DispatchID")
                    .IsUnique();

                entity.HasIndex(e => new { e.Phone, e.Company, e.Deleted })
                    .HasName("Phone")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.DispatchId)
                    .IsRequired()
                    .HasColumnName("DispatchID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lcda)
                    .IsRequired()
                    .HasColumnName("LCDA")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lgv)
                    .IsRequired()
                    .HasColumnName("LGV")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Dispatchoperationalarea>(entity =>
            {
                entity.ToTable("dispatchoperationalarea");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.DispatchId, e.Lga, e.Company, e.Deleted })
                    .HasName("UniqueKey")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.DispatchId)
                    .IsRequired()
                    .HasColumnName("DispatchID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lcda)
                    .IsRequired()
                    .HasColumnName("LCDA")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lga)
                    .IsRequired()
                    .HasColumnName("LGA")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Rank)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Dispatchschedule>(entity =>
            {
                entity.ToTable("dispatchschedule");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.DispatchId, e.Company, e.Deleted })
                    .HasName("DispatchID");

                entity.HasIndex(e => new { e.Drn, e.Company, e.Deleted })
                    .HasName("Unique");

                entity.HasIndex(e => new { e.GuarantorId, e.Company, e.Deleted })
                    .HasName("GuarantorID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Completed)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.DispatchId)
                    .IsRequired()
                    .HasColumnName("DispatchID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Drn)
                    .IsRequired()
                    .HasColumnName("DRN")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GuarantorId)
                    .IsRequired()
                    .HasColumnName("GuarantorID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Dispatchscheduleparameters>(entity =>
            {
                entity.ToTable("dispatchscheduleparameters");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.DispatchScheduleMode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MaxSchedulePerDispatch)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Driverapprovalhistory>(entity =>
            {
                entity.ToTable("driverapprovalhistory");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Drn, e.GuarantorId, e.DispatchScheduleId, e.Company, e.Deleted })
                    .HasName("DRN")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.DispatchScheduleId)
                    .HasColumnName("DispatchScheduleID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Drn)
                    .IsRequired()
                    .HasColumnName("DRN")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FirstApprovalStatus)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FirstApprovalStatusReason)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GuarantorId)
                    .IsRequired()
                    .HasColumnName("GuarantorID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.SecondApprovalStatus)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SecondApprovalStatusReason)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Driverdocuments>(entity =>
            {
                entity.ToTable("driverdocuments");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Drn, e.DocumentType, e.Company, e.Deleted })
                    .HasName("Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.DocumentType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Drn)
                    .IsRequired()
                    .HasColumnName("DRN")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Driverdocumenttypes>(entity =>
            {
                entity.ToTable("driverdocumenttypes");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.DriverDocumentType, e.Company, e.Deleted })
                    .HasName("DriverDocumentType")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.DocumentStatus)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DriverDocumentType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Driverparameter>(entity =>
            {
                entity.ToTable("driverparameter");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.Driverscheme)
                    .IsRequired()
                    .HasColumnName("driverscheme")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GuarantorOptionalForApprovalSubmission)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GuarantorOptionalForVerfication)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Noofguarantor)
                    .HasColumnName("noofguarantor")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Driverschemes>(entity =>
            {
                entity.ToTable("driverschemes");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Level, e.Company, e.Deleted })
                    .HasName("Level");

                entity.HasIndex(e => new { e.LoanProductId, e.Company, e.Deleted })
                    .HasName("LoanProductId");

                entity.HasIndex(e => new { e.SchemeId, e.Drn, e.Company, e.Deleted })
                    .HasName("SchemeID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.Drn)
                    .IsRequired()
                    .HasColumnName("DRN")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Level)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LoanProductId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.MonthlyPayment)
                    .HasColumnType("decimal(64,30)")
                    .HasDefaultValueSql("'0.000000000000000000000000000000'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Principal)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.SchemeId)
                    .IsRequired()
                    .HasColumnName("SchemeID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Tenure)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Examinationcategories>(entity =>
            {
                entity.ToTable("examinationcategories");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.ExaminationId, e.Category, e.Company, e.Deleted })
                    .HasName("Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ExaminationId)
                    .HasColumnName("ExaminationID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.NumberOfQuestions)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Examinationexaminationvenues>(entity =>
            {
                entity.ToTable("examinationexaminationvenues");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.ExaminationId, e.Company, e.Deleted })
                    .HasName("ExaminationID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ExaminationId)
                    .HasColumnName("ExaminationID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FirstBatchStartTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.LastBatchEndTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.Venue)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Examinationquestionoptions>(entity =>
            {
                entity.ToTable("examinationquestionoptions");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.ExaminationQuestionId, e.Company, e.Deleted })
                    .HasName("ExaminationQuestionID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Answer)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ExaminationQuestionId)
                    .HasColumnName("ExaminationQuestionID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OptionHtml)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Examinationquestions>(entity =>
            {
                entity.ToTable("examinationquestions");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.ExaminationId, e.Company, e.Deleted })
                    .HasName("ExaminationID");

                entity.HasIndex(e => new { e.QuestionNumber, e.Company, e.Deleted })
                    .HasName("QuestionNumber");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ExaminationId)
                    .HasColumnName("ExaminationID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Marks)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.QuestionHtml)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.QuestionNumber)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Examinations>(entity =>
            {
                entity.ToTable("examinations");

                entity.HasIndex(e => e.Id)
                    .HasName("ExaminationID")
                    .IsUnique();

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Batch, e.Company, e.Deleted })
                    .HasName("Batch");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Subject, e.Company, e.Deleted })
                    .HasName("Subject")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Batch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.Duration)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ExamPaused)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Instructions)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.NumberOfQuestions)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PhysicalTest)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PracticeExam)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.QuestionSelectionMode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.QuestionsPerCategory)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RandomiseOptions)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.ShowScoreWhenFinished)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TimedQuestions)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UseOnlyGraceLakeCbtbrowser)
                    .HasColumnName("UseOnlyGraceLakeCBTBrowser")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UseOnlyPremierCbtbrowser)
                    .HasColumnName("UseOnlyPremierCBTBrowser")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Examinationschedulecapturedimages>(entity =>
            {
                entity.ToTable("examinationschedulecapturedimages");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.ExaminationScheduleId, e.Company, e.Deleted })
                    .HasName("ExaminationScheduleID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ExaminationScheduleId)
                    .HasColumnName("ExaminationScheduleID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ImageBlob).IsRequired();

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Examinationschedulecategories>(entity =>
            {
                entity.ToTable("examinationschedulecategories");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.ExaminationSceduleId, e.Category, e.Company, e.Deleted })
                    .HasName("Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ExaminationSceduleId)
                    .HasColumnName("ExaminationSceduleID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Examinationschedulequestionoptions>(entity =>
            {
                entity.ToTable("examinationschedulequestionoptions");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.ExaminationQuestionOptionId, e.Company, e.Deleted })
                    .HasName("ExaminationQuestionOptionID");

                entity.HasIndex(e => new { e.ExaminationScheduleId, e.ExaminationQuestionId, e.Company, e.Deleted })
                    .HasName("ExaminationScheduleQuestionID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ExaminationQuestionId)
                    .HasColumnName("ExaminationQuestionID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ExaminationQuestionOptionId)
                    .HasColumnName("ExaminationQuestionOptionID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ExaminationScheduleId)
                    .HasColumnName("ExaminationScheduleID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OptionNo)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.Selected)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Examinationschedulequestions>(entity =>
            {
                entity.ToTable("examinationschedulequestions");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.ExaminationQuestionId, e.Company, e.Deleted })
                    .HasName("ExaminationQuestionID");

                entity.HasIndex(e => new { e.ExaminationScheduleId, e.ExaminationQuestionId, e.Company, e.Deleted })
                    .HasName("ExaminationScheduleQuestionID");

                entity.HasIndex(e => new { e.ExaminationScheduleId, e.QuestionNo, e.Company, e.Deleted })
                    .HasName("ExaminationScheduleQuestionNo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Correct)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ExaminationQuestionId)
                    .HasColumnName("ExaminationQuestionID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ExaminationScheduleId)
                    .HasColumnName("ExaminationScheduleID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.QuestionNo)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Examinationschedules>(entity =>
            {
                entity.ToTable("examinationschedules");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.ExaminationId, e.Company, e.Deleted })
                    .HasName("ExaminationID");

                entity.HasIndex(e => new { e.RefNo, e.Company, e.Deleted })
                    .HasName("RefNo");

                entity.HasIndex(e => new { e.VenueId, e.Company, e.Deleted })
                    .HasName("VenueID");

                entity.HasIndex(e => new { e.RefNo, e.ExaminationId, e.Company, e.Deleted })
                    .HasName("Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualStartDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ExaminationId)
                    .HasColumnName("ExaminationID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PercentageScore)
                    .HasColumnType("decimal(64,30)")
                    .HasDefaultValueSql("'0.000000000000000000000000000000'");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Score)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StartDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VenueId)
                    .IsRequired()
                    .HasColumnName("VenueID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Examinationsubjects>(entity =>
            {
                entity.ToTable("examinationsubjects");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.SubjectId, e.Company, e.Deleted })
                    .HasName("Subject")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.SubjectId)
                    .IsRequired()
                    .HasColumnName("SubjectID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SubjectName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Examinationvenues>(entity =>
            {
                entity.ToTable("examinationvenues");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.VenueId, e.Company, e.Deleted })
                    .HasName("VenueID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Capacity)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.VenueId)
                    .IsRequired()
                    .HasColumnName("VenueID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VenueName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Guarantordetails>(entity =>
            {
                entity.ToTable("guarantordetails");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.GuarantorId, e.Company, e.Deleted })
                    .HasName("GuarantorID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Bvn)
                    .IsRequired()
                    .HasColumnName("BVN")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Drn)
                    .IsRequired()
                    .HasColumnName("DRN")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GuarantorId)
                    .IsRequired()
                    .HasColumnName("GuarantorID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lcda)
                    .IsRequired()
                    .HasColumnName("LCDA")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LocalGovernmentArea)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Occupation)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OfficeAddress)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PlaceofWork)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PositionHeld)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RemarkReason)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Scheduled)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SubmittedForApproval)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Guarantordocuments>(entity =>
            {
                entity.ToTable("guarantordocuments");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Drn, e.Company, e.Deleted })
                    .HasName("DRN");

                entity.HasIndex(e => new { e.GuarantorId, e.DocumentType, e.Company, e.Deleted })
                    .HasName("Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.DocumentType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Drn)
                    .IsRequired()
                    .HasColumnName("DRN")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GuarantorId)
                    .HasColumnName("GuarantorID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Guarantordocumenttypes>(entity =>
            {
                entity.ToTable("guarantordocumenttypes");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.GuarantorDocumentType, e.Company, e.Deleted })
                    .HasName("GuarantorDocumentType")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.DocumentStatus)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GuarantorDocumentType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsPassport)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Guarantorverificationitem>(entity =>
            {
                entity.ToTable("guarantorverificationitem");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.ItemId, e.Company, e.Deleted })
                    .HasName("ItemID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicableCategory)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasColumnName("ItemID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.RequireGpscoordinate)
                    .HasColumnName("RequireGPSCoordinate")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequireImage)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Lcda>(entity =>
            {
                entity.ToTable("lcda");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Lga, e.Lcdaid, e.Company, e.Deleted })
                    .HasName("LocalGovt")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.Lcdaid)
                    .IsRequired()
                    .HasColumnName("LCDAId")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lga)
                    .IsRequired()
                    .HasColumnName("LGA")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Localgovernments>(entity =>
            {
                entity.ToTable("localgovernments");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.StateId, e.LocalGovtId, e.Deleted })
                    .HasName("LocalGovt")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.LocalGovtId)
                    .IsRequired()
                    .HasColumnName("LocalGovtID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.StateId)
                    .IsRequired()
                    .HasColumnName("StateID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<States>(entity =>
            {
                entity.ToTable("states");

                entity.HasIndex(e => e.Deleted)
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("Name")
                    .IsUnique();

                entity.HasIndex(e => new { e.StateId, e.Deleted })
                    .HasName("State")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.StateId)
                    .IsRequired()
                    .HasColumnName("StateID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Tempdispatchschedule>(entity =>
            {
                entity.ToTable("tempdispatchschedule");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.DispatchId, e.Company, e.Deleted })
                    .HasName("DispatchID");

                entity.HasIndex(e => new { e.Drn, e.GuarantorId, e.Date, e.CreatedBy, e.Company, e.Deleted })
                    .HasName("Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.DispatchId)
                    .IsRequired()
                    .HasColumnName("DispatchID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DispatchOperationalArea)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Drn)
                    .IsRequired()
                    .HasColumnName("DRN")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GuarantorId)
                    .IsRequired()
                    .HasColumnName("GuarantorID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.VerificationLocation)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.ToTable("test");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.TestId, e.Company, e.Deleted })
                    .HasName("Tests")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.TestId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Testquestion>(entity =>
            {
                entity.ToTable("testquestion");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.TestQuestionId, e.Company, e.Deleted })
                    .HasName("TestQuestions")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Questions)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.TestId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TestQuestionId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Testresult>(entity =>
            {
                entity.ToTable("testresult");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.TestQuestionId, e.Company, e.Deleted })
                    .HasName("TestQuestionIdKey");

                entity.HasIndex(e => new { e.TestScheduleId, e.TestQuestionId, e.Company, e.Deleted })
                    .HasName("TestResult")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TestQuestionId)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TestScheduleId)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Testschedule>(entity =>
            {
                entity.ToTable("testschedule");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.ScheduleId, e.Company, e.Deleted })
                    .HasName("Schedule")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.Drn)
                    .IsRequired()
                    .HasColumnName("DRN")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.ScheduleId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TestId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Verificationitem>(entity =>
            {
                entity.ToTable("verificationitem");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.ItemId, e.Company, e.Deleted })
                    .HasName("ItemID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicableCategory)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasColumnName("ItemID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.RequireGpscoordinate)
                    .HasColumnName("RequireGPSCoordinate")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequireImage)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequireNote)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Verificationparameters>(entity =>
            {
                entity.ToTable("verificationparameters");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.DispatchScheduleMode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MaxSchedulePerDispatch)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Verificationresult>(entity =>
            {
                entity.ToTable("verificationresult");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.RefNo, e.Company, e.Deleted })
                    .HasName("RefNo");

                entity.HasIndex(e => new { e.DispatchScheduleId, e.RefNo, e.VerificationItem, e.Company, e.Deleted })
                    .HasName("UniqueKey")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.DispatchScheduleId)
                    .HasColumnName("DispatchScheduleID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Gps)
                    .IsRequired()
                    .HasColumnName("GPS")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.StatusReason)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VerificationItem)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Verificationresultimages>(entity =>
            {
                entity.ToTable("verificationresultimages");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.VerificatioResultId, e.Company, e.Deleted })
                    .HasName("VerificatioResultID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ImageData).IsRequired();

                entity.Property(e => e.ImageType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.VerificatioResultId)
                    .HasColumnName("VerificatioResultID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Verificationresultsapproval>(entity =>
            {
                entity.ToTable("verificationresultsapproval");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.GuarantorId, e.Company, e.Deleted })
                    .HasName("Key");

                entity.HasIndex(e => new { e.Drn, e.VerificationItem, e.Category, e.GuarantorId, e.Company, e.Deleted })
                    .HasName("UniqueKey")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.Drn)
                    .IsRequired()
                    .HasColumnName("DRN")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FirstApproval)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GuarantorId)
                    .IsRequired()
                    .HasColumnName("GuarantorID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.SecondApproval)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VerificationItem)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Verifiedbankaccounts>(entity =>
            {
                entity.ToTable("verifiedbankaccounts");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Bank, e.AccountNumber, e.Company, e.Deleted })
                    .HasName("Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Bank)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Verifiedbvns>(entity =>
            {
                entity.ToTable("verifiedbvns");

                entity.HasIndex(e => new { e.Company, e.Deleted })
                    .HasName("Company");

                entity.HasIndex(e => new { e.Deleted, e.Company })
                    .HasName("Deleted");

                entity.HasIndex(e => new { e.Branch, e.Company, e.Deleted })
                    .HasName("Branch");

                entity.HasIndex(e => new { e.Bvn, e.Company, e.Deleted })
                    .HasName("Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Bvn)
                    .IsRequired()
                    .HasColumnName("BVN")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DateofBirth)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Deleted).HasColumnType("bigint(20)");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Middlename)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecordVersion).HasColumnType("bigint(20)");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");
            });
        }
    }
}
