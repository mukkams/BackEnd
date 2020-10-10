using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFActivityScreenName
    {
        public WFActivityScreenName()
        {
            WFActivityEditScreen = new HashSet<WFActivity>();
            WFActivityViewScreen = new HashSet<WFActivity>();
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

        public virtual WFApplicationType ApplicationType { get; set; }
        public virtual ICollection<WFActivity> WFActivityEditScreen { get; set; }
        public virtual ICollection<WFActivity> WFActivityViewScreen { get; set; }
    }
}
