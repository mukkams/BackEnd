using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Persistence.Models
{
    public partial class EFDemoContext : DbContext
    {
        public EFDemoContext()
        {
        }

        public EFDemoContext(DbContextOptions<EFDemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Email> Email { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Version> Version { get; set; }
        public virtual DbSet<Wfactivity> Wfactivity { get; set; }
        public virtual DbSet<WfactivityPermission> WfactivityPermission { get; set; }
        public virtual DbSet<WfactivityScreenName> WfactivityScreenName { get; set; }
        public virtual DbSet<WfactivityTransition> WfactivityTransition { get; set; }
        public virtual DbSet<WfactivityTransitionEmail> WfactivityTransitionEmail { get; set; }
        public virtual DbSet<WfapplicationType> WfapplicationType { get; set; }
        public virtual DbSet<WfbusinessRule> WfbusinessRule { get; set; }
        public virtual DbSet<WfbusinessRuleClass> WfbusinessRuleClass { get; set; }
        public virtual DbSet<WfbusinessRuleEvent> WfbusinessRuleEvent { get; set; }
        public virtual DbSet<WfbusinessRuleMessage> WfbusinessRuleMessage { get; set; }
        public virtual DbSet<WfbusinessRuleReviewMessage> WfbusinessRuleReviewMessage { get; set; }
        public virtual DbSet<WfbusinessRuleSeverity> WfbusinessRuleSeverity { get; set; }
        public virtual DbSet<WfemailClass> WfemailClass { get; set; }
        public virtual DbSet<WfemailDefinition> WfemailDefinition { get; set; }
        public virtual DbSet<WfemailEvent> WfemailEvent { get; set; }
        public virtual DbSet<Wfevent> Wfevent { get; set; }
        public virtual DbSet<WflineBasedRuleMessage> WflineBasedRuleMessage { get; set; }
        public virtual DbSet<WfpreprocessorClass> WfpreprocessorClass { get; set; }
        public virtual DbSet<WfprocessType> WfprocessType { get; set; }
        public virtual DbSet<WfprocessTypeAutoListedBrule> WfprocessTypeAutoListedBrule { get; set; }
        public virtual DbSet<WfprocessTypePreprocessor> WfprocessTypePreprocessor { get; set; }
        public virtual DbSet<WfsendEmailNotification> WfsendEmailNotification { get; set; }
        public virtual DbSet<WfuploadAmendmentTemplates> WfuploadAmendmentTemplates { get; set; }
        public virtual DbSet<WfworkItem> WfworkItem { get; set; }
        public virtual DbSet<WfworkItemAttachDocRevMessage> WfworkItemAttachDocRevMessage { get; set; }
        public virtual DbSet<WfworkItemAttachedDocument> WfworkItemAttachedDocument { get; set; }
        public virtual DbSet<WfworkItemLockTrail> WfworkItemLockTrail { get; set; }
        public virtual DbSet<WfworkItemLog> WfworkItemLog { get; set; }
        public virtual DbSet<WfworkItemTrail> WfworkItemTrail { get; set; }
        public virtual DbSet<WfworkItemUploadTrail> WfworkItemUploadTrail { get; set; }
        public virtual DbSet<WfworkItemVersionMap> WfworkItemVersionMap { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MSLONDON-ITPC;Database=EFDemo;Trusted_Connection=True;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Postcode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Email)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FristName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Version>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ__Version__737584F6C0F00F7B")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK__Version__ParentI__4D2A7347");
            });

            modelBuilder.Entity<Wfactivity>(entity =>
            {
                entity.ToTable("WFActivity");

                entity.HasIndex(e => e.Name)
                    .HasName("UQ__WFActivi__737584F6BCFB3421")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.EditScreen)
                    .WithMany(p => p.WfactivityEditScreen)
                    .HasForeignKey(d => d.EditScreenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFActivit__EditS__12FDD1B2");

                entity.HasOne(d => d.EnterEvent)
                    .WithMany(p => p.WfactivityEnterEvent)
                    .HasForeignKey(d => d.EnterEventId)
                    .HasConstraintName("FK__WFActivit__Enter__13F1F5EB");

                entity.HasOne(d => d.ExitEvent)
                    .WithMany(p => p.WfactivityExitEvent)
                    .HasForeignKey(d => d.ExitEventId)
                    .HasConstraintName("FK__WFActivit__ExitE__14E61A24");

                entity.HasOne(d => d.ProcessType)
                    .WithMany(p => p.Wfactivity)
                    .HasForeignKey(d => d.ProcessTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFActivit__Proce__15DA3E5D");

                entity.HasOne(d => d.ViewScreen)
                    .WithMany(p => p.WfactivityViewScreen)
                    .HasForeignKey(d => d.ViewScreenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFActivit__ViewS__16CE6296");
            });

            modelBuilder.Entity<WfactivityPermission>(entity =>
            {
                entity.ToTable("WFActivityPermission");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.WfactivityPermission)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFActivit__Activ__17C286CF");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WfactivityPermission)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFActivit__UserI__19AACF41");
            });

            modelBuilder.Entity<WfactivityScreenName>(entity =>
            {
                entity.ToTable("WFActivityScreenName");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.ApplicationType)
                    .WithMany(p => p.WfactivityScreenName)
                    .HasForeignKey(d => d.ApplicationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFActivit__Appli__1A9EF37A");
            });

            modelBuilder.Entity<WfactivityTransition>(entity =>
            {
                entity.ToTable("WFActivityTransition");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.ActivityIdFromNavigation)
                    .WithMany(p => p.WfactivityTransitionActivityIdFromNavigation)
                    .HasForeignKey(d => d.ActivityIdFrom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFActivit__Activ__1B9317B3");

                entity.HasOne(d => d.ActivityIdToNavigation)
                    .WithMany(p => p.WfactivityTransitionActivityIdToNavigation)
                    .HasForeignKey(d => d.ActivityIdTo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFActivit__Activ__1C873BEC");

                entity.HasOne(d => d.TransitionEvent)
                    .WithMany(p => p.WfactivityTransition)
                    .HasForeignKey(d => d.TransitionEventId)
                    .HasConstraintName("FK__WFActivit__Trans__1E6F845E");
            });

            modelBuilder.Entity<WfactivityTransitionEmail>(entity =>
            {
                entity.ToTable("WFActivityTransitionEmail");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.EmailBody).IsRequired();

                entity.Property(e => e.EmailCc).HasColumnName("EmailCC");

                entity.Property(e => e.EmailTo).IsRequired();

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsHtmlbody).HasColumnName("IsHTMLBody");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<WfapplicationType>(entity =>
            {
                entity.ToTable("WFApplicationType");

                entity.HasIndex(e => e.Name)
                    .HasName("UQ__WFApplic__737584F60436E6B3")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<WfbusinessRule>(entity =>
            {
                entity.ToTable("WFBusinessRule");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MessageToReviewer).IsRequired();

                entity.Property(e => e.MessageToUser).IsRequired();

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.WfbusinessRule)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFBusines__Class__1F63A897");

                entity.HasOne(d => d.Severity)
                    .WithMany(p => p.WfbusinessRule)
                    .HasForeignKey(d => d.SeverityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFBusines__Sever__2057CCD0");
            });

            modelBuilder.Entity<WfbusinessRuleClass>(entity =>
            {
                entity.ToTable("WFBusinessRuleClass");

                entity.HasIndex(e => e.Name)
                    .HasName("UQ__WFBusine__737584F63BA48164")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<WfbusinessRuleEvent>(entity =>
            {
                entity.ToTable("WFBusinessRuleEvent");

                entity.HasIndex(e => new { e.BusinessRuleId, e.EventId })
                    .HasName("UQ__WFBusine__FBCB11A291E01700")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.BusinessRule)
                    .WithMany(p => p.WfbusinessRuleEvent)
                    .HasForeignKey(d => d.BusinessRuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFBusines__Busin__214BF109");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.WfbusinessRuleEvent)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFBusines__Event__22401542");
            });

            modelBuilder.Entity<WfbusinessRuleMessage>(entity =>
            {
                entity.ToTable("WFBusinessRuleMessage");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.BusinessRule)
                    .WithMany(p => p.WfbusinessRuleMessage)
                    .HasForeignKey(d => d.BusinessRuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFBusines__Busin__2334397B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WfbusinessRuleMessage)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFBusines__UserI__24285DB4");

                entity.HasOne(d => d.WorkItem)
                    .WithMany(p => p.WfbusinessRuleMessage)
                    .HasForeignKey(d => d.WorkItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFBusines__WorkI__251C81ED");
            });

            modelBuilder.Entity<WfbusinessRuleReviewMessage>(entity =>
            {
                entity.ToTable("WFBusinessRuleReviewMessage");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.BusinessRuleMessage)
                    .WithMany(p => p.WfbusinessRuleReviewMessage)
                    .HasForeignKey(d => d.BusinessRuleMessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFBusines__Busin__2610A626");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WfbusinessRuleReviewMessage)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFBusines__UserI__2704CA5F");
            });

            modelBuilder.Entity<WfbusinessRuleSeverity>(entity =>
            {
                entity.ToTable("WFBusinessRuleSeverity");

                entity.HasIndex(e => e.Severity)
                    .HasName("UQ__WFBusine__96F5CD14F43EA07D")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Severity)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<WfemailClass>(entity =>
            {
                entity.ToTable("WFEmailClass");

                entity.HasIndex(e => e.Name)
                    .HasName("UQ__WFEmailC__737584F615C0FF6D")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<WfemailDefinition>(entity =>
            {
                entity.ToTable("WFEmailDefinition");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.HtmlBody).IsRequired();

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Subject).IsRequired();

                entity.Property(e => e.TextBody).IsRequired();

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.WfemailDefinition)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFEmailDe__Class__27F8EE98");
            });

            modelBuilder.Entity<WfemailEvent>(entity =>
            {
                entity.ToTable("WFEmailEvent");

                entity.HasIndex(e => new { e.WfemailDefinitionId, e.EventId })
                    .HasName("UQ__WFEmailE__CFFD1B2AB4DCE9A3")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.WfemailDefinitionId).HasColumnName("WFEmailDefinitionId");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.WfemailEvent)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFEmailEv__Event__28ED12D1");

                entity.HasOne(d => d.WfemailDefinition)
                    .WithMany(p => p.WfemailEvent)
                    .HasForeignKey(d => d.WfemailDefinitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFEmailEv__WFEma__29E1370A");
            });

            modelBuilder.Entity<Wfevent>(entity =>
            {
                entity.ToTable("WFEvent");

                entity.HasIndex(e => e.Name)
                    .HasName("UQ__WFEvent__737584F6DD0F3168")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<WflineBasedRuleMessage>(entity =>
            {
                entity.ToTable("WFLineBasedRuleMessage");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.BusinessRule)
                    .WithMany(p => p.WflineBasedRuleMessage)
                    .HasForeignKey(d => d.BusinessRuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFLineBas__Busin__2AD55B43");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WflineBasedRuleMessage)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFLineBas__UserI__2BC97F7C");

                entity.HasOne(d => d.WorkItem)
                    .WithMany(p => p.WflineBasedRuleMessage)
                    .HasForeignKey(d => d.WorkItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFLineBas__WorkI__2CBDA3B5");
            });

            modelBuilder.Entity<WfpreprocessorClass>(entity =>
            {
                entity.ToTable("WFPreprocessorClass");

                entity.HasIndex(e => e.Name)
                    .HasName("UQ__WFPrepro__737584F683B2EC19")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<WfprocessType>(entity =>
            {
                entity.ToTable("WFProcessType");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProcessTypeName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.ApplicationType)
                    .WithMany(p => p.WfprocessType)
                    .HasForeignKey(d => d.ApplicationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFProcess__Appli__2DB1C7EE");

                entity.HasOne(d => d.EndActivity)
                    .WithMany(p => p.WfprocessTypeEndActivity)
                    .HasForeignKey(d => d.EndActivityId)
                    .HasConstraintName("FK__WFProcess__EndAc__2EA5EC27");

                entity.HasOne(d => d.StartActivity)
                    .WithMany(p => p.WfprocessTypeStartActivity)
                    .HasForeignKey(d => d.StartActivityId)
                    .HasConstraintName("FK__WFProcess__Start__2F9A1060");
            });

            modelBuilder.Entity<WfprocessTypeAutoListedBrule>(entity =>
            {
                entity.ToTable("WFProcessTypeAutoListedBRule");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.WfprocessTypeAutoListedBrule)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFProcess__Class__308E3499");

                entity.HasOne(d => d.ProcessType)
                    .WithMany(p => p.WfprocessTypeAutoListedBrule)
                    .HasForeignKey(d => d.ProcessTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFProcess__Proce__32767D0B");
            });

            modelBuilder.Entity<WfprocessTypePreprocessor>(entity =>
            {
                entity.ToTable("WFProcessTypePreprocessor");

                entity.HasIndex(e => new { e.ProcessTypeId, e.ClassId })
                    .HasName("UQ__WFProces__FC600799B08781E9")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.WfprocessTypePreprocessor)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFProcess__Class__336AA144");

                entity.HasOne(d => d.ProcessType)
                    .WithMany(p => p.WfprocessTypePreprocessor)
                    .HasForeignKey(d => d.ProcessTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFProcess__Proce__345EC57D");
            });

            modelBuilder.Entity<WfsendEmailNotification>(entity =>
            {
                entity.ToTable("WFSendEmailNotification");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.EmailBody).IsRequired();

                entity.Property(e => e.EmailCc).HasColumnName("EmailCC");

                entity.Property(e => e.EmailTo).IsRequired();

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsHtmlbody).HasColumnName("IsHTMLBody");

                entity.Property(e => e.StatusMessage)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.CreatedByUser)
                    .WithMany(p => p.WfsendEmailNotification)
                    .HasForeignKey(d => d.CreatedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFSendEma__Creat__3552E9B6");
            });

            modelBuilder.Entity<WfuploadAmendmentTemplates>(entity =>
            {
                entity.ToTable("WFUploadAmendmentTemplates");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.FileData).IsRequired();

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TemplateType)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<WfworkItem>(entity =>
            {
                entity.ToTable("WFWorkItem");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WorkItemDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WorkItemType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.WfworkItem)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFWorkIte__Activ__36470DEF");

                entity.HasOne(d => d.CreatedByUser)
                    .WithMany(p => p.WfworkItemCreatedByUser)
                    .HasForeignKey(d => d.CreatedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFWorkIte__Creat__373B3228");

                entity.HasOne(d => d.ProcessType)
                    .WithMany(p => p.WfworkItem)
                    .HasForeignKey(d => d.ProcessTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFWorkIte__Proce__39237A9A");

                entity.HasOne(d => d.ReuploadedByUser)
                    .WithMany(p => p.WfworkItemReuploadedByUser)
                    .HasForeignKey(d => d.ReuploadedByUserId)
                    .HasConstraintName("FK__WFWorkIte__Reupl__3A179ED3");
            });

            modelBuilder.Entity<WfworkItemAttachDocRevMessage>(entity =>
            {
                entity.ToTable("WFWorkItemAttachDocRevMessage");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WfworkItemAttachDocRevMessage)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFWorkIte__UserI__3B0BC30C");

                entity.HasOne(d => d.WorkItemAttachDocument)
                    .WithMany(p => p.WfworkItemAttachDocRevMessage)
                    .HasForeignKey(d => d.WorkItemAttachDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFWorkIte__WorkI__3BFFE745");
            });

            modelBuilder.Entity<WfworkItemAttachedDocument>(entity =>
            {
                entity.ToTable("WFWorkItemAttachedDocument");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.CreatedByUser)
                    .WithMany(p => p.WfworkItemAttachedDocument)
                    .HasForeignKey(d => d.CreatedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFWorkIte__Creat__3CF40B7E");

                entity.HasOne(d => d.WorkItem)
                    .WithMany(p => p.WfworkItemAttachedDocument)
                    .HasForeignKey(d => d.WorkItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFWorkIte__WorkI__3DE82FB7");
            });

            modelBuilder.Entity<WfworkItemLockTrail>(entity =>
            {
                entity.ToTable("WFWorkItemLockTrail");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActionBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.ActionOn).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.LockByUser)
                    .WithMany(p => p.WfworkItemLockTrail)
                    .HasForeignKey(d => d.LockByUserId)
                    .HasConstraintName("FK__WFWorkIte__LockB__3EDC53F0");

                entity.HasOne(d => d.WorkItem)
                    .WithMany(p => p.WfworkItemLockTrail)
                    .HasForeignKey(d => d.WorkItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFWorkIte__WorkI__3FD07829");
            });

            modelBuilder.Entity<WfworkItemLog>(entity =>
            {
                entity.ToTable("WFWorkItemLog");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WfworkItemLog)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFWorkIte__UserI__40C49C62");

                entity.HasOne(d => d.WorkItem)
                    .WithMany(p => p.WfworkItemLog)
                    .HasForeignKey(d => d.WorkItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFWorkIte__WorkI__41B8C09B");
            });

            modelBuilder.Entity<WfworkItemTrail>(entity =>
            {
                entity.ToTable("WFWorkItemTrail");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActionBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.ActionOn).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ActivityTransition)
                    .WithMany(p => p.WfworkItemTrail)
                    .HasForeignKey(d => d.ActivityTransitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFWorkIte__Activ__42ACE4D4");

                entity.HasOne(d => d.WorkItem)
                    .WithMany(p => p.WfworkItemTrail)
                    .HasForeignKey(d => d.WorkItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFWorkIte__WorkI__43A1090D");
            });

            modelBuilder.Entity<WfworkItemUploadTrail>(entity =>
            {
                entity.ToTable("WFWorkItemUploadTrail");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActionBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.ActionOn).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CreatedByUser)
                    .WithMany(p => p.WfworkItemUploadTrail)
                    .HasForeignKey(d => d.CreatedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFWorkIte__Creat__44952D46");

                entity.HasOne(d => d.WorkItem)
                    .WithMany(p => p.WfworkItemUploadTrail)
                    .HasForeignKey(d => d.WorkItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFWorkIte__WorkI__4589517F");
            });

            modelBuilder.Entity<WfworkItemVersionMap>(entity =>
            {
                entity.ToTable("WFWorkItemVersionMap");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AltExternalId).HasMaxLength(255);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.WfworkItemVersionMap)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFWorkIte__Versi__467D75B8");

                entity.HasOne(d => d.WorkItem)
                    .WithMany(p => p.WfworkItemVersionMap)
                    .HasForeignKey(d => d.WorkItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WFWorkIte__WorkI__477199F1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
