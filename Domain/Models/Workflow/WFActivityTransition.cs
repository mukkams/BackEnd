using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFActivityTransition
    {
        public WFActivityTransition()
        {
            WfworkItemTrail = new HashSet<WFWorkItemTrail>();
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

        public virtual WFActivity ActivityIdFromNavigation { get; set; }
        public virtual WFActivity ActivityIdToNavigation { get; set; }
        public virtual WFEvent TransitionEvent { get; set; }
        public virtual ICollection<WFWorkItemTrail> WfworkItemTrail { get; set; }
    }
}
