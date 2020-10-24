using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class WfuploadAmendmentTemplates
    {
        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public string Filename { get; set; }
        public string TemplateType { get; set; }
        public string Description { get; set; }
        public byte[] FileData { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
