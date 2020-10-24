using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class WfactivityTransition
    {
        public WfactivityTransition()
        {
            WfworkItemTrail = new HashSet<WfworkItemTrail>();
        }

        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid ActivityIdFrom { get; set; }
        public Guid ActivityIdTo { get; set; }
        public string Action { get; set; }
        public int Order { get; set; }
        public Guid? DealId { get; set; }
        public Guid? TransitionEventId { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual Wfactivity ActivityIdFromNavigation { get; set; }
        public virtual Wfactivity ActivityIdToNavigation { get; set; }
        public virtual Wfevent TransitionEvent { get; set; }
        public virtual ICollection<WfworkItemTrail> WfworkItemTrail { get; set; }
    }
}
