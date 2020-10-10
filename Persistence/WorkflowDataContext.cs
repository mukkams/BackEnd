using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models.UserStore;
using Domain.Models.Workflow;

namespace Persistence
{
    public class WorkflowDataContext: DbContext
    {
        public WorkflowDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Email> Email { get; set; }
        public virtual DbSet<WFActivity> WFActivity { get; set; }
        public virtual DbSet<WFActivityPermission> WFActivityPermission { get; set; }
        public virtual DbSet<WFActivityScreenName> WFActivityScreenName { get; set; }
        public virtual DbSet<WFActivityTransition> WFActivityTransition { get; set; }
        public virtual DbSet<WFActivityTransitionEmail> WFActivityTransitionEmail { get; set; }
        public virtual DbSet<WFApplicationType> WfapplicationType { get; set; }
        public virtual DbSet<WFBusinessRule> WfbusinessRule { get; set; }
        public virtual DbSet<WFBusinessRuleClass> WfbusinessRuleClass { get; set; }
        public virtual DbSet<WFBusinessRuleEvent> WfbusinessRuleEvent { get; set; }
        public virtual DbSet<WFBusinessRuleMessage> WfbusinessRuleMessage { get; set; }
        public virtual DbSet<WFBusinessRuleReviewMessage> WfbusinessRuleReviewMessage { get; set; }
        public virtual DbSet<WFBusinessRuleSeverity> WfbusinessRuleSeverity { get; set; }
        public virtual DbSet<WFEmailClass> WfemailClass { get; set; }
        public virtual DbSet<WFEmailDefinition> WfemailDefinition { get; set; }
        public virtual DbSet<WFEmailEvent> WfemailEvent { get; set; }
        public virtual DbSet<WFEvent> Wfevent { get; set; }
        public virtual DbSet<WFLineBasedRuleMessage> WflineBasedRuleMessage { get; set; }
        public virtual DbSet<WFPreprocessorClass> WfpreprocessorClass { get; set; }
        public virtual DbSet<WFProcessType> WfprocessType { get; set; }
        public virtual DbSet<WFProcessTypeAutoListedBrule> WfprocessTypeAutoListedBrule { get; set; }
        public virtual DbSet<WFProcessTypePreprocessor> WfprocessTypePreprocessor { get; set; }
        public virtual DbSet<WFSendEmailNotification> WfsendEmailNotification { get; set; }
        public virtual DbSet<WFUploadAmendmentTemplates> WfuploadAmendmentTemplates { get; set; }
        public virtual DbSet<WFWorkItem> WfworkItem { get; set; }
        public virtual DbSet<WFWorkItemAttachDocRevMessage> WfworkItemAttachDocRevMessage { get; set; }
        public virtual DbSet<WFWorkItemAttachedDocument> WfworkItemAttachedDocument { get; set; }
        public virtual DbSet<WFWorkItemLockTrail> WfworkItemLockTrail { get; set; }
        public virtual DbSet<WFWorkItemLog> WfworkItemLog { get; set; }
        public virtual DbSet<WFWorkItemTrail> WfworkItemTrail { get; set; }
        public virtual DbSet<WFWorkItemUploadTrail> WfworkItemUploadTrail { get; set; }
        public virtual DbSet<WFWorkItemVersionMap> WfworkItemVersionMap { get; set; }
    }

}
