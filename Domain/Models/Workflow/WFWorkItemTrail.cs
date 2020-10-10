using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFWorkItemTrail
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

        public virtual WFActivityTransition ActivityTransition { get; set; }
        public virtual WFWorkItem WorkItem { get; set; }
    }
}
