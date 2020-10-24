using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class WfworkItemLockTrail
    {
        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid WorkItemId { get; set; }
        public Guid? LockByUserId { get; set; }
        public bool? IsActive { get; set; }
        public string ActionBy { get; set; }
        public DateTime ActionOn { get; set; }

        public virtual User LockByUser { get; set; }
        public virtual WfworkItem WorkItem { get; set; }
    }
}
