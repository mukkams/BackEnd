using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class WfpreprocessorClass
    {
        public WfpreprocessorClass()
        {
            WfprocessTypePreprocessor = new HashSet<WfprocessTypePreprocessor>();
        }

        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual ICollection<WfprocessTypePreprocessor> WfprocessTypePreprocessor { get; set; }
    }
}
