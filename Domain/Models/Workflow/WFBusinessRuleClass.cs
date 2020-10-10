using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFBusinessRuleClass
    {
        public WFBusinessRuleClass()
        {
            WfbusinessRule = new HashSet<WFBusinessRule>();
            WfprocessTypeAutoListedBrule = new HashSet<WFProcessTypeAutoListedBrule>();
        }

        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual ICollection<WFBusinessRule> WfbusinessRule { get; set; }
        public virtual ICollection<WFProcessTypeAutoListedBrule> WfprocessTypeAutoListedBrule { get; set; }
    }
}
