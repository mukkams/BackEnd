using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace Domain.Models.UserStore
{
    public class Client
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string CompanyName { get; set; }

        [Required]
        [MaxLength(255)]
        public string WebSite { get; set; }

        public List<Address> Addresses { get; set; } = new List<Address>();

    }
}
