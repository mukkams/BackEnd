using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFBusinessRuleReviewMessage
    {
        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid BusinessRuleMessageId { get; set; }
        public string Comment { get; set; }
        public Guid UserId { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual WFBusinessRuleMessage BusinessRuleMessage { get; set; }
    }
}
