using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFProcessType
    {
        public WFProcessType()
        {
            WFActivity = new HashSet<WFActivity>();
            WfprocessTypeAutoListedBrule = new HashSet<WFProcessTypeAutoListedBrule>();
            WfprocessTypePreprocessor = new HashSet<WFProcessTypePreprocessor>();
            WfworkItem = new HashSet<WFWorkItem>();
        }

        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public string ProcessTypeName { get; set; }
        public Guid ApplicationTypeId { get; set; }
        public string Description { get; set; }
        public Guid? StartActivityId { get; set; }
        public Guid? EndActivityId { get; set; }
        public bool? Islocked { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual WFApplicationType ApplicationType { get; set; }
        public virtual WFActivity EndActivity { get; set; }
        public virtual WFActivity StartActivity { get; set; }
        public virtual ICollection<WFActivity> WFActivity { get; set; }
        public virtual ICollection<WFProcessTypeAutoListedBrule> WfprocessTypeAutoListedBrule { get; set; }
        public virtual ICollection<WFProcessTypePreprocessor> WfprocessTypePreprocessor { get; set; }
        public virtual ICollection<WFWorkItem> WfworkItem { get; set; }
    }
}
