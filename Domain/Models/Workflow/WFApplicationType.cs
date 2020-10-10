using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFApplicationType
    {
        public WFApplicationType()
        {
            WFActivityScreenName = new HashSet<WFActivityScreenName>();
            WfprocessType = new HashSet<WFProcessType>();
        }

        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual ICollection<WFActivityScreenName> WFActivityScreenName { get; set; }
        public virtual ICollection<WFProcessType> WfprocessType { get; set; }
    }
}
