using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFEvent
    {
        public WFEvent()
        {
            WFActivityEnterEvent = new HashSet<WFActivity>();
            WFActivityExitEvent = new HashSet<WFActivity>();
            WFActivityTransition = new HashSet<WFActivityTransition>();
            WfbusinessRuleEvent = new HashSet<WFBusinessRuleEvent>();
            WfemailEvent = new HashSet<WFEmailEvent>();
        }

        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual ICollection<WFActivity> WFActivityEnterEvent { get; set; }
        public virtual ICollection<WFActivity> WFActivityExitEvent { get; set; }
        public virtual ICollection<WFActivityTransition> WFActivityTransition { get; set; }
        public virtual ICollection<WFBusinessRuleEvent> WfbusinessRuleEvent { get; set; }
        public virtual ICollection<WFEmailEvent> WfemailEvent { get; set; }
    }
}
