using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFActivityTransitionEmail
    {
        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid ActivityTransitionId { get; set; }
        public string EmailTo { get; set; }
        public string EmailCc { get; set; }
        public string Subject { get; set; }
        public string EmailBody { get; set; }
        public bool IsHtmlbody { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
