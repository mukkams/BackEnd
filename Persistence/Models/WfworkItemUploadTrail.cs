using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class WfworkItemUploadTrail
    {
        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid WorkItemId { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
        public string Comment { get; set; }
        public Guid DealId { get; set; }
        public bool? IsActive { get; set; }
        public Guid CreatedByUserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ActionBy { get; set; }
        public DateTime ActionOn { get; set; }

        public virtual User CreatedByUser { get; set; }
        public virtual WfworkItem WorkItem { get; set; }
    }
}
