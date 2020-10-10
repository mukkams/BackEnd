using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFBusinessRuleSeverity
    {
        public WFBusinessRuleSeverity()
        {
            WfbusinessRule = new HashSet<WFBusinessRule>();
        }

        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public string Severity { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual ICollection<WFBusinessRule> WfbusinessRule { get; set; }
    }
}
