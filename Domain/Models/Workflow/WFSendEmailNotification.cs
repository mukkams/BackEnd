using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFSendEmailNotification
    {
        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid ActivityTransitionEmailId { get; set; }
        public string EmailTo { get; set; }
        public string EmailCc { get; set; }
        public string Subject { get; set; }
        public string EmailBody { get; set; }
        public bool IsHtmlbody { get; set; }
        public int Status { get; set; }
        public string StatusMessage { get; set; }
        public int? RetryCount { get; set; }
        public Guid WorkItemId { get; set; }
        public bool? IsActive { get; set; }
        public Guid CreatedByUserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

    }
}
