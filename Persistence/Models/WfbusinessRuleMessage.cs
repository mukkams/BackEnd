using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class WfbusinessRuleMessage
    {
        public WfbusinessRuleMessage()
        {
            WfbusinessRuleReviewMessage = new HashSet<WfbusinessRuleReviewMessage>();
        }

        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid BusinessRuleId { get; set; }
        public string Comment { get; set; }
        public Guid UserId { get; set; }
        public Guid WorkItemId { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual WfbusinessRule BusinessRule { get; set; }
        public virtual User User { get; set; }
        public virtual WfworkItem WorkItem { get; set; }
        public virtual ICollection<WfbusinessRuleReviewMessage> WfbusinessRuleReviewMessage { get; set; }
    }
}
