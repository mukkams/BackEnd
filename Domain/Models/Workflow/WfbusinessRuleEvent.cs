using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFBusinessRuleEvent
    {
        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid BusinessRuleId { get; set; }
        public Guid EventId { get; set; }
        public int Order { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual WFBusinessRule BusinessRule { get; set; }
        public virtual WFEvent Event { get; set; }
    }
}
