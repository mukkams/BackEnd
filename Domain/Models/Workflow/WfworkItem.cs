using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFWorkItem
    {
        public WFWorkItem()
        {
            WfbusinessRuleMessage = new HashSet<WFBusinessRuleMessage>();
            WflineBasedRuleMessage = new HashSet<WFLineBasedRuleMessage>();
            WfworkItemAttachedDocument = new HashSet<WFWorkItemAttachedDocument>();
            WfworkItemLockTrail = new HashSet<WFWorkItemLockTrail>();
            WfworkItemLog = new HashSet<WFWorkItemLog>();
            WfworkItemTrail = new HashSet<WFWorkItemTrail>();
            WfworkItemUploadTrail = new HashSet<WFWorkItemUploadTrail>();
            WfworkItemVersionMap = new HashSet<WFWorkItemVersionMap>();
        }

        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid ProcessTypeId { get; set; }
        public string Comment { get; set; }
        public Guid ActivityId { get; set; }
        public Guid? DealId { get; set; }
        public DateTime? AsOfDate { get; set; }
        public Guid? LockByUserId { get; set; }
        public bool? IsActive { get; set; }
        public Guid CreatedByUserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string WorkItemType { get; set; }
        public string WorkItemDescription { get; set; }
        public Guid? ReuploadedByUserId { get; set; }
        public DateTime? ReuploadedOn { get; set; }

        public virtual WFActivity Activity { get; set; }
        public virtual WFProcessType ProcessType { get; set; }
        public virtual ICollection<WFBusinessRuleMessage> WfbusinessRuleMessage { get; set; }
        public virtual ICollection<WFLineBasedRuleMessage> WflineBasedRuleMessage { get; set; }
        public virtual ICollection<WFWorkItemAttachedDocument> WfworkItemAttachedDocument { get; set; }
        public virtual ICollection<WFWorkItemLockTrail> WfworkItemLockTrail { get; set; }
        public virtual ICollection<WFWorkItemLog> WfworkItemLog { get; set; }
        public virtual ICollection<WFWorkItemTrail> WfworkItemTrail { get; set; }
        public virtual ICollection<WFWorkItemUploadTrail> WfworkItemUploadTrail { get; set; }
        public virtual ICollection<WFWorkItemVersionMap> WfworkItemVersionMap { get; set; }
    }
}
