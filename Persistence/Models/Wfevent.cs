using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Wfevent
    {
        public Wfevent()
        {
            WfactivityEnterEvent = new HashSet<Wfactivity>();
            WfactivityExitEvent = new HashSet<Wfactivity>();
            WfactivityTransition = new HashSet<WfactivityTransition>();
            WfbusinessRuleEvent = new HashSet<WfbusinessRuleEvent>();
            WfemailEvent = new HashSet<WfemailEvent>();
        }

        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual ICollection<Wfactivity> WfactivityEnterEvent { get; set; }
        public virtual ICollection<Wfactivity> WfactivityExitEvent { get; set; }
        public virtual ICollection<WfactivityTransition> WfactivityTransition { get; set; }
        public virtual ICollection<WfbusinessRuleEvent> WfbusinessRuleEvent { get; set; }
        public virtual ICollection<WfemailEvent> WfemailEvent { get; set; }
    }
}
