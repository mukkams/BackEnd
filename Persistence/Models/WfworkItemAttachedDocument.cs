using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class WfworkItemAttachedDocument
    {
        public WfworkItemAttachedDocument()
        {
            WfworkItemAttachDocRevMessage = new HashSet<WfworkItemAttachDocRevMessage>();
        }

        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid WorkItemId { get; set; }
        public string Comment { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
        public Guid CreatedByUserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual User CreatedByUser { get; set; }
        public virtual WfworkItem WorkItem { get; set; }
        public virtual ICollection<WfworkItemAttachDocRevMessage> WfworkItemAttachDocRevMessage { get; set; }
    }
}
