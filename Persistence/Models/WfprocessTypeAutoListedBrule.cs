using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class WfprocessTypeAutoListedBrule
    {
        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid ProcessTypeId { get; set; }
        public Guid DealId { get; set; }
        public Guid ClassId { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual WfbusinessRuleClass Class { get; set; }
        public virtual WfprocessType ProcessType { get; set; }
    }
}
