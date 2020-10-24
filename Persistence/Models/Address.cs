using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Address
    {
        public Guid Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Address5 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public Guid? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
