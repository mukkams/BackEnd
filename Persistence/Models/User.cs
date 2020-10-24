using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class User
    {
        public User()
        {
            Address = new HashSet<Address>();
            Email = new HashSet<Email>();
            WfactivityPermission = new HashSet<WfactivityPermission>();
            WfbusinessRuleMessage = new HashSet<WfbusinessRuleMessage>();
            WfbusinessRuleReviewMessage = new HashSet<WfbusinessRuleReviewMessage>();
            WflineBasedRuleMessage = new HashSet<WflineBasedRuleMessage>();
            WfsendEmailNotification = new HashSet<WfsendEmailNotification>();
            WfworkItemAttachDocRevMessage = new HashSet<WfworkItemAttachDocRevMessage>();
            WfworkItemAttachedDocument = new HashSet<WfworkItemAttachedDocument>();
            WfworkItemCreatedByUser = new HashSet<WfworkItem>();
            WfworkItemLockTrail = new HashSet<WfworkItemLockTrail>();
            WfworkItemLog = new HashSet<WfworkItemLog>();
            WfworkItemReuploadedByUser = new HashSet<WfworkItem>();
            WfworkItemUploadTrail = new HashSet<WfworkItemUploadTrail>();
        }

        public Guid Id { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<Email> Email { get; set; }
        public virtual ICollection<WfactivityPermission> WfactivityPermission { get; set; }
        public virtual ICollection<WfbusinessRuleMessage> WfbusinessRuleMessage { get; set; }
        public virtual ICollection<WfbusinessRuleReviewMessage> WfbusinessRuleReviewMessage { get; set; }
        public virtual ICollection<WflineBasedRuleMessage> WflineBasedRuleMessage { get; set; }
        public virtual ICollection<WfsendEmailNotification> WfsendEmailNotification { get; set; }
        public virtual ICollection<WfworkItemAttachDocRevMessage> WfworkItemAttachDocRevMessage { get; set; }
        public virtual ICollection<WfworkItemAttachedDocument> WfworkItemAttachedDocument { get; set; }
        public virtual ICollection<WfworkItem> WfworkItemCreatedByUser { get; set; }
        public virtual ICollection<WfworkItemLockTrail> WfworkItemLockTrail { get; set; }
        public virtual ICollection<WfworkItemLog> WfworkItemLog { get; set; }
        public virtual ICollection<WfworkItem> WfworkItemReuploadedByUser { get; set; }
        public virtual ICollection<WfworkItemUploadTrail> WfworkItemUploadTrail { get; set; }
    }
}
