using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models.UserStore
{
    public class Address
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        [MaxLength(255)]
        public string Address1 { get; set; }

        [Required]
        [MaxLength(255)]
        public string Address2 { get; set; }

        public string Address3 { get; set; }

        public string Address4 { get; set; }

        public string Address5 { get; set; }

        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        [MaxLength(100)]
        public string State { get; set; }

        [Required]
        [MaxLength(25)]
        [Column(TypeName = "varchar(25)")]
        public string Postcode { get; set; }


    }
}
