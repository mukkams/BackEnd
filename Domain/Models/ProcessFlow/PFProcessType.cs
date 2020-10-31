using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models.ProcessFlow
{
    public class PFProcessType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public string ProcessTypeName { get; set; }
        public Guid ApplicationTypeId { get; set; }
        public string Description { get; set; }
        public Guid? StartActivityId { get; set; }
        public Guid? EndActivityId { get; set; }
        public bool? Islocked { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
