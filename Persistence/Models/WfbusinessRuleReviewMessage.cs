using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class WfbusinessRuleReviewMessage
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

        public virtual WfbusinessRuleMessage BusinessRuleMessage { get; set; }
        public virtual User User { get; set; }
    }
}
