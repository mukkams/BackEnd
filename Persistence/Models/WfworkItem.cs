using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class WfworkItem
    {
        public WfworkItem()
        {
            WfbusinessRuleMessage = new HashSet<WfbusinessRuleMessage>();
            WflineBasedRuleMessage = new HashSet<WflineBasedRuleMessage>();
            WfworkItemAttachedDocument = new HashSet<WfworkItemAttachedDocument>();
            WfworkItemLockTrail = new HashSet<WfworkItemLockTrail>();
            WfworkItemLog = new HashSet<WfworkItemLog>();
            WfworkItemTrail = new HashSet<WfworkItemTrail>();
            WfworkItemUploadTrail = new HashSet<WfworkItemUploadTrail>();
            WfworkItemVersionMap = new HashSet<WfworkItemVersionMap>();
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

        public virtual Wfactivity Activity { get; set; }
        public virtual User CreatedByUser { get; set; }
        public virtual WfprocessType ProcessType { get; set; }
        public virtual User ReuploadedByUser { get; set; }
        public virtual ICollection<WfbusinessRuleMessage> WfbusinessRuleMessage { get; set; }
        public virtual ICollection<WflineBasedRuleMessage> WflineBasedRuleMessage { get; set; }
        public virtual ICollection<WfworkItemAttachedDocument> WfworkItemAttachedDocument { get; set; }
        public virtual ICollection<WfworkItemLockTrail> WfworkItemLockTrail { get; set; }
        public virtual ICollection<WfworkItemLog> WfworkItemLog { get; set; }
        public virtual ICollection<WfworkItemTrail> WfworkItemTrail { get; set; }
        public virtual ICollection<WfworkItemUploadTrail> WfworkItemUploadTrail { get; set; }
        public virtual ICollection<WfworkItemVersionMap> WfworkItemVersionMap { get; set; }
    }
}
