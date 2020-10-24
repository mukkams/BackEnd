using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class WfbusinessRuleSeverity
    {
        public WfbusinessRuleSeverity()
        {
            WfbusinessRule = new HashSet<WfbusinessRule>();
        }

        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public string Severity { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual ICollection<WfbusinessRule> WfbusinessRule { get; set; }
    }
}
