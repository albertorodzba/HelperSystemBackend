﻿using System;
using System.Collections.Generic;

namespace HelperSystem.Domain.Models
{
    public partial class ApplicantDisability
    {
        public long IdApplicantDisability { get; set; }
        public long? FkIdApplicant { get; set; }
        public int? FkIdDisability { get; set; }

        public virtual Applicant? FkIdApplicantNavigation { get; set; }
        public virtual Disability? FkIdDisabilityNavigation { get; set; }
    }
}
