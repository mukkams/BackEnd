using System;
using System.Collections.Generic;

namespace Domain.Models.Workflow
{
    public partial class WFActivity
    {
        public WFActivity()
        {
            WFActivityPermission = new HashSet<WFActivityPermission>();
            //WFActivityTransitionActivityIdFromNavigation = new HashSet<WFActivityTransition>();
            //WFActivityTransitionActivityIdToNavigation = new HashSet<WFActivityTransition>();
            //WfprocessTypeEndActivity = new HashSet<WFProcessType>();
            //WfprocessTypeStartActivity = new HashSet<WFProcessType>();
            WfworkItem = new HashSet<WFWorkItem>();
        }

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

        //public virtual WFActivityScreenName EditScreen { get; set; }
        //public virtual WFEvent EnterEvent { get; set; }
        //public virtual WFEvent ExitEvent { get; set; }
        //public virtual WFProcessType ProcessType { get; set; }
        //public virtual WFActivityScreenName ViewScreen { get; set; }
        public virtual ICollection<WFActivityPermission> WFActivityPermission { get; set; }
        //public virtual ICollection<WFActivityTransition> WFActivityTransitionActivityIdFromNavigation { get; set; }
        //public virtual ICollection<WFActivityTransition> WFActivityTransitionActivityIdToNavigation { get; set; }
        //public virtual ICollection<WFProcessType> WfprocessTypeEndActivity { get; set; }
        //public virtual ICollection<WFProcessType> WfprocessTypeStartActivity { get; set; }
        public virtual ICollection<WFWorkItem> WfworkItem { get; set; }
    }
}
