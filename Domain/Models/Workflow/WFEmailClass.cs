using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFEmailClass
    {
        public WFEmailClass()
        {
            WfemailDefinition = new HashSet<WFEmailDefinition>();
        }

        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual ICollection<WFEmailDefinition> WfemailDefinition { get; set; }
    }
}
