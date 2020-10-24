using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class WfprocessType
    {
        public WfprocessType()
        {
            Wfactivity = new HashSet<Wfactivity>();
            WfprocessTypeAutoListedBrule = new HashSet<WfprocessTypeAutoListedBrule>();
            WfprocessTypePreprocessor = new HashSet<WfprocessTypePreprocessor>();
            WfworkItem = new HashSet<WfworkItem>();
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

        public virtual WfapplicationType ApplicationType { get; set; }
        public virtual Wfactivity EndActivity { get; set; }
        public virtual Wfactivity StartActivity { get; set; }
        public virtual ICollection<Wfactivity> Wfactivity { get; set; }
        public virtual ICollection<WfprocessTypeAutoListedBrule> WfprocessTypeAutoListedBrule { get; set; }
        public virtual ICollection<WfprocessTypePreprocessor> WfprocessTypePreprocessor { get; set; }
        public virtual ICollection<WfworkItem> WfworkItem { get; set; }
    }
}
