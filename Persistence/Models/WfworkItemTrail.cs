using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class WfworkItemTrail
    {
        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid WorkItemId { get; set; }
        public Guid ActivityTransitionId { get; set; }
        public string Comment { get; set; }
        public bool? IsActive { get; set; }
        public string ActionBy { get; set; }
        public DateTime ActionOn { get; set; }

        public virtual WfactivityTransition ActivityTransition { get; set; }
        public virtual WfworkItem WorkItem { get; set; }
    }
}
