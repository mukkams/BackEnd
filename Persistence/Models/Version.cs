using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Version
    {
        public Version()
        {
            InverseParent = new HashSet<Version>();
            WfworkItemVersionMap = new HashSet<WfworkItemVersionMap>();
        }

        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid? ParentId { get; set; }
        public string Name { get; set; }
        public DateTime AsOfDate { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }
        public bool Islocked { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual Version Parent { get; set; }
        public virtual ICollection<Version> InverseParent { get; set; }
        public virtual ICollection<WfworkItemVersionMap> WfworkItemVersionMap { get; set; }
    }
}
