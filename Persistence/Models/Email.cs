using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Email
    {
        public Guid Id { get; set; }
        public string EmailAddress { get; set; }
        public Guid? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
