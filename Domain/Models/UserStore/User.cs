using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace Domain.Models.UserStore
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }

        //public int Age { get; set; }
        
        //public List<Address> Addresses { get; set; } = new List<Address>();

        //public List<Email> EmailAddress { get; set; } = new List<Email>();


    }
}
