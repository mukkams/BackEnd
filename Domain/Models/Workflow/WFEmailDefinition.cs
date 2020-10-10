using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFEmailDefinition
    {
        public WFEmailDefinition()
        {
            WfemailEvent = new HashSet<WFEmailEvent>();
        }

        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid ClassId { get; set; }
        public string Description { get; set; }
        public string Subject { get; set; }
        public string HtmlBody { get; set; }
        public string TextBody { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual WFEmailClass Class { get; set; }
        public virtual ICollection<WFEmailEvent> WfemailEvent { get; set; }
    }
}
