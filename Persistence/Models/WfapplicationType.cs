using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class WfapplicationType
    {
        public WfapplicationType()
        {
            WfactivityScreenName = new HashSet<WfactivityScreenName>();
            WfprocessType = new HashSet<WfprocessType>();
        }

        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual ICollection<WfactivityScreenName> WfactivityScreenName { get; set; }
        public virtual ICollection<WfprocessType> WfprocessType { get; set; }
    }
}
