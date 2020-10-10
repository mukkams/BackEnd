using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFProcessTypePreprocessor
    {
        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid ProcessTypeId { get; set; }
        public Guid ClassId { get; set; }
        public string Description { get; set; }
        public bool RunBeforeFileLoad { get; set; }
        public int Order { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual WFPreprocessorClass Class { get; set; }
        public virtual WFProcessType ProcessType { get; set; }
    }
}
