using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFWorkItemAttachedDocument
    {
        public WFWorkItemAttachedDocument()
        {
            WfworkItemAttachDocRevMessage = new HashSet<WFWorkItemAttachDocRevMessage>();
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

        public virtual WFWorkItem WorkItem { get; set; }
        public virtual ICollection<WFWorkItemAttachDocRevMessage> WfworkItemAttachDocRevMessage { get; set; }
    }
}
