using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFPreprocessorClass
    {
        public WFPreprocessorClass()
        {
            WfprocessTypePreprocessor = new HashSet<WFProcessTypePreprocessor>();
        }

        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual ICollection<WFProcessTypePreprocessor> WfprocessTypePreprocessor { get; set; }
    }
}
