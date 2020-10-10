using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFEmailEvent
    {
        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid WfemailDefinitionId { get; set; }
        public Guid EventId { get; set; }
        public int Order { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual WFEvent Event { get; set; }
        public virtual WFEmailDefinition WfemailDefinition { get; set; }
    }
}
