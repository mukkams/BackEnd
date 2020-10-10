using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFBusinessRule
    {
        public WFBusinessRule()
        {
            WfbusinessRuleEvent = new HashSet<WFBusinessRuleEvent>();
            WfbusinessRuleMessage = new HashSet<WFBusinessRuleMessage>();
            WflineBasedRuleMessage = new HashSet<WFLineBasedRuleMessage>();
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

        public virtual WFBusinessRuleClass Class { get; set; }
        public virtual WFBusinessRuleSeverity Severity { get; set; }
        public virtual ICollection<WFBusinessRuleEvent> WfbusinessRuleEvent { get; set; }
        public virtual ICollection<WFBusinessRuleMessage> WfbusinessRuleMessage { get; set; }
        public virtual ICollection<WFLineBasedRuleMessage> WflineBasedRuleMessage { get; set; }
    }
}
