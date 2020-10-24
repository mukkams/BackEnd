using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Wfactivity
    {
        public Wfactivity()
        {
            WfactivityPermission = new HashSet<WfactivityPermission>();
            WfactivityTransitionActivityIdFromNavigation = new HashSet<WfactivityTransition>();
            WfactivityTransitionActivityIdToNavigation = new HashSet<WfactivityTransition>();
            WfprocessTypeEndActivity = new HashSet<WfprocessType>();
            WfprocessTypeStartActivity = new HashSet<WfprocessType>();
            WfworkItem = new HashSet<WfworkItem>();
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

        public virtual WfactivityScreenName EditScreen { get; set; }
        public virtual Wfevent EnterEvent { get; set; }
        public virtual Wfevent ExitEvent { get; set; }
        public virtual WfprocessType ProcessType { get; set; }
        public virtual WfactivityScreenName ViewScreen { get; set; }
        public virtual ICollection<WfactivityPermission> WfactivityPermission { get; set; }
        public virtual ICollection<WfactivityTransition> WfactivityTransitionActivityIdFromNavigation { get; set; }
        public virtual ICollection<WfactivityTransition> WfactivityTransitionActivityIdToNavigation { get; set; }
        public virtual ICollection<WfprocessType> WfprocessTypeEndActivity { get; set; }
        public virtual ICollection<WfprocessType> WfprocessTypeStartActivity { get; set; }
        public virtual ICollection<WfworkItem> WfworkItem { get; set; }
    }
}
