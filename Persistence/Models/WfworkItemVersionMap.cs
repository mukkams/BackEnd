using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class WfworkItemVersionMap
    {
        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid WorkItemId { get; set; }
        public Guid VersionId { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual Version Version { get; set; }
        public virtual WfworkItem WorkItem { get; set; }
    }
}
