using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class WfemailDefinition
    {
        public WfemailDefinition()
        {
            WfemailEvent = new HashSet<WfemailEvent>();
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

        public virtual WfemailClass Class { get; set; }
        public virtual ICollection<WfemailEvent> WfemailEvent { get; set; }
    }
}
