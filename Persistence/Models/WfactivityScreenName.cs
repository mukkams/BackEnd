using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class WfactivityScreenName
    {
        public WfactivityScreenName()
        {
            WfactivityEditScreen = new HashSet<Wfactivity>();
            WfactivityViewScreen = new HashSet<Wfactivity>();
        }

        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public string ClassName { get; set; }
        public string Description { get; set; }
        public Guid ApplicationTypeId { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual WfapplicationType ApplicationType { get; set; }
        public virtual ICollection<Wfactivity> WfactivityEditScreen { get; set; }
        public virtual ICollection<Wfactivity> WfactivityViewScreen { get; set; }
    }
}
