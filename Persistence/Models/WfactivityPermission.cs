using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class WfactivityPermission
    {
        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid UserId { get; set; }
        public Guid ActivityId { get; set; }
        public Guid? DealId { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual Wfactivity Activity { get; set; }
        public virtual User User { get; set; }
    }
}
