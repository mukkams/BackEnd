using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class WfbusinessRule
    {
        public WfbusinessRule()
        {
            WfbusinessRuleEvent = new HashSet<WfbusinessRuleEvent>();
            WfbusinessRuleMessage = new HashSet<WfbusinessRuleMessage>();
            WflineBasedRuleMessage = new HashSet<WflineBasedRuleMessage>();
        }

        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid ClassId { get; set; }
        public string Description { get; set; }
        public string MessageToUser { get; set; }
        public string MessageToReviewer { get; set; }
        public Guid SeverityId { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual WfbusinessRuleClass Class { get; set; }
        public virtual WfbusinessRuleSeverity Severity { get; set; }
        public virtual ICollection<WfbusinessRuleEvent> WfbusinessRuleEvent { get; set; }
        public virtual ICollection<WfbusinessRuleMessage> WfbusinessRuleMessage { get; set; }
        public virtual ICollection<WflineBasedRuleMessage> WflineBasedRuleMessage { get; set; }
    }
}
