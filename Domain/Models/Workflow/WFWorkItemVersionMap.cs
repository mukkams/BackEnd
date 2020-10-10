﻿using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFWorkItemVersionMap
    {
        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string AltExternalId { get; set; }
        public Guid WorkItemId { get; set; }
        public Guid VersionId { get; set; }
        public bool? IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual WFWorkItem WorkItem { get; set; }
    }
}
