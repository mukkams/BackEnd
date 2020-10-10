using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFActivityPermission
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

        public virtual WFActivity Activity { get; set; }
    }
}
