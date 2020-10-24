using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class WfemailEvent
    {
        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid WfemailDefinitionId { get; set; }
        public Guid EventId { get; set; }
        public int Order { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual Wfevent Event { get; set; }
        public virtual WfemailDefinition WfemailDefinition { get; set; }
    }
}
