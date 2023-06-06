using System;
using System.Collections.Generic;

namespace HelperSystem.Domain.Models
{
    public partial class Activity
    {
        public Activity()
        {
            ActivityJobs = new HashSet<ActivityJob>();
            ActivityRequesteds = new HashSet<ActivityRequested>();
            ApplicantActivities = new HashSet<ApplicantActivity>();
        }

        public int IdActivity { get; set; }
        public string ActivityName { get; set; } = null!;

        public virtual ICollection<ActivityJob> ActivityJobs { get; set; }
        public virtual ICollection<ActivityRequested> ActivityRequesteds { get; set; }
        public virtual ICollection<ApplicantActivity> ApplicantActivities { get; set; }
    }
}
