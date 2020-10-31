using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models.ProcessFlow
{
    public class PFActivity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid EditScreenId { get; set; }
        public Guid ViewScreenId { get; set; }
        public Guid ProcessTypeId { get; set; }
        public Guid? EnterEventId { get; set; }
        public Guid? ExitEventId { get; set; }
        public bool CanReloadWorkItem { get; set; }
        public int ByUserHierarchy { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
