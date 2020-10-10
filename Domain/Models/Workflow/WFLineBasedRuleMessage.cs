using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFLineBasedRuleMessage
    {
        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid BusinessRuleId { get; set; }
        public string Comment { get; set; }
        public Guid UserId { get; set; }
        public Guid WorkItemId { get; set; }
        public Guid LineId { get; set; }
        public string TableName { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual WFBusinessRule BusinessRule { get; set; }
        
        public virtual WFWorkItem WorkItem { get; set; }
    }
}
